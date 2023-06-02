using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        Figure current;
        Figure next;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
                        
            loadCanvas();

            current = getRandomFigureInCenter();
            next = getNextFigure();

            timer.Tick += Timer_Tick;
            timer.Interval = 500;
            timer.Start();
            
            this.KeyDown += Form1_KeyDown;
        }
        
        Bitmap canvasBitmap;
        Graphics canvasGraphics;
        int canvasWidth = 10;
        int canvasHeight = 20;
        int[,] canvasDotArray;
        int dotSize = 20;
        private void loadCanvas()
        {
            // змінити розмір рамки зображення на основі розміру точки та розміру полотна
            pictureBox1.Width = canvasWidth * dotSize;
            pictureBox1.Height = canvasHeight * dotSize;

            // створити растрове зображення з розміром вікна
            canvasBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            canvasGraphics = Graphics.FromImage(canvasBitmap);

            canvasGraphics.FillRectangle(Brushes.Plum, 0, 0, canvasBitmap.Width, canvasBitmap.Height);

            // завантажити растрове зображення у вікно зображення
            pictureBox1.Image = canvasBitmap;

            // ініціалізувати масив точок полотна, за замовчуванням всі елементи дорівнюють нулю
            canvasDotArray = new int[canvasWidth, canvasHeight];
        }

        int currentX;
        int currentY;
        private Figure getRandomFigureInCenter()
        {
            var figure = FiguresHandler.GetRandomFigure();

            // обчислити значення x та y так, щоб фігура знаходилася в центрі
            currentX = canvasWidth / 2 - (figure.Width / 2);
            currentY = -figure.Height;

            return figure;
        }

        Bitmap workingBitmap;
        Graphics workingGraphics;
        private void Timer_Tick(object sender, EventArgs e)
        {
            var isMoveSuccess = moveFigureIfPossible(moveDown: 1);

            // якщо фігура досягла низу або торкнулася інших фігур
            if (!isMoveSuccess)
            {
                // скопіювати робоче зображення на зображення полотна
                canvasBitmap = new Bitmap(workingBitmap);

                updateCanvasDotArrayWithCurrentFigure();

                // отримати наступну фігуру
                current = next;
                next = getNextFigure();
                
                clearFilledRowsAndUpdateScore();
            }
        }
        //коли фігура досягла нижньої панелі або торкнулася інших фігур, заповнюємо комірки, де вона розташована
        private void updateCanvasDotArrayWithCurrentFigure()
        {
            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height; j++)
                {
                    if (current.Dots[j, i] == 1)
                    {
                        try
                        {
                            canvasDotArray[currentX + i, currentY + j] = 1;
                        } catch
                        {
                            //коли фігура вийшла за межі визначеного масиву, отримуємо помилку
                            GameOver();
                            
                        }
                    }
                }
            }
        }
        //якщо фігура виходить за межу полотна, гру закінчено
        private void GameOver()
        {
            timer.Stop();
            MessageBox.Show("Кінець гри");
            DialogResult result = MessageBox.Show("Почати нову гру?", "",
            MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                Application.Restart();
            }
        }

        // змінити положення фігури, якщо можливо
        private bool moveFigureIfPossible(int moveDown = 0, int moveSide = 0)
        {
            var newX = currentX + moveSide;
            var newY = currentY + moveDown;

            // перевірити, чи досягає фігура нижньої або бічної панелі
            if (newX < 0 || newX + current.Width > canvasWidth
                || newY + current.Height > canvasHeight)
                return false;

            // перевірити, чи не торкається фігура інших блоків
            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height; j++)
                {
                    if (newY + j > 0 && canvasDotArray[newX + i, newY + j] == 1 && current.Dots[j, i] == 1)
                        return false;
                }
            }

            currentX = newX;
            currentY = newY;

            drawFigure();

            return true;
        }

        private void drawFigure()
        {
            workingBitmap = new Bitmap(canvasBitmap);
            workingGraphics = Graphics.FromImage(workingBitmap);

            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height; j++)
                {
                    if (current.Dots[j, i] == 1)
                        workingGraphics.FillRectangle(Brushes.MidnightBlue, (currentX + i) * dotSize, (currentY + j) * dotSize, dotSize, dotSize);
                }
            }

            pictureBox1.Image = workingBitmap;
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var verticalMove = 0;
            var horizontalMove = 0;

            // обчислити значення вертикального та горизонтального переміщення на основі натиснутої клавіші
            switch (e.KeyCode)
            {
                // рух вліво
                case Keys.Left:
                    verticalMove--;
                    break;

                // рух вправо
                case Keys.Right:
                    verticalMove++;
                    break;

                // пришвидшити рух вниз
                case Keys.Down:
                    horizontalMove++;
                    break;

                // повернути фігуру на годинникової стрілкою
                case Keys.Up:
                    current.Turn();
                    break;
                default:
                    return;
            }

            var isMoveSuccess = moveFigureIfPossible(horizontalMove, verticalMove);

            // якщо поворот фігури є неможливим - відкотити фігуру назад
            if (!isMoveSuccess && e.KeyCode == Keys.Up)
                current.Rollback();
        }

        int score;
        // очистити заповнені рядки і збільшити рахунок
        public void clearFilledRowsAndUpdateScore()
        {
            // перевірити кожен рядок
            for (int i = 0; i < canvasHeight; i++)
            {
                int j;
                for (j = canvasWidth - 1; j >= 0; j--)
                {
                    if (canvasDotArray[j, i] == 0)
                        break;
                }

                if (j == -1)
                {
                    // оновити рахунок і вивести значення
                    score++;
                    label1.Text = "Рахунок: " + score;
                    // збільшити швидкість 
                    timer.Interval -= 10;

                    // оновити масив точок на основі перевірки
                    for (j = 0; j < canvasWidth; j++)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            canvasDotArray[j, k] = canvasDotArray[j, k - 1];
                        }

                        canvasDotArray[j, 0] = 0;
                    }
                }
            }

            // намалювати панель на основі оновлених значень масиву
            for (int i = 0; i < canvasWidth; i++)
            {
                for (int j = 0; j < canvasHeight; j++)
                {
                    canvasGraphics = Graphics.FromImage(canvasBitmap);
                    canvasGraphics.FillRectangle(
                        canvasDotArray[i, j] == 1 ? Brushes.MidnightBlue : Brushes.Plum,
                        i * dotSize, j * dotSize, dotSize, dotSize
                        );
                }
            }

            pictureBox1.Image = canvasBitmap;
        }

        Bitmap nextBitmap;
        Graphics nextGraphics;
        private Figure getNextFigure()
        {
            var figure = getRandomFigureInCenter();

            // бічна панель для відображення наступної фігури
            nextBitmap = new Bitmap(6 * dotSize, 6 * dotSize);
            nextGraphics = Graphics.FromImage(nextBitmap);

            nextGraphics.FillRectangle(Brushes.Plum, 0, 0, nextBitmap.Width, nextBitmap.Height);

            // знайти центральне положення для фігури
            var startX = (6 - figure.Width) / 2;
            var startY = (6 - figure.Height) / 2;

            for (int i = 0; i < figure.Height; i++)
            {
                for (int j = 0; j < figure.Width; j++)
                {
                    nextGraphics.FillRectangle(
                        figure.Dots[i, j] == 1 ? Brushes.MidnightBlue : Brushes.Plum,
                        (startX + j) * dotSize, (startY + i) * dotSize, dotSize, dotSize);
                }
            }

            pictureBox2.Size = nextBitmap.Size;
            pictureBox2.Image = nextBitmap;

            return figure;
        }
    }
}
