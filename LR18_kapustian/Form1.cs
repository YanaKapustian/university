namespace LR18_kapustian
{
    public partial class Form1 : Form
    {
        private int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Отримуємо введену користувачем кількість елементів у масиві
            int n = int.Parse(inputTextBox.Text);

            // Створюємо масив з n елементів
            double[] numbers = new double[n];

            // Заповнюємо масив числами, введеними користувачем
            for (int i = 0; i < n; i++)
            {
                string numberString = Microsoft.VisualBasic.Interaction.InputBox($"Введіть число #{i + 1}:", "Введення чисел");
                double number;
                while (!double.TryParse(numberString, out number))
                {
                    MessageBox.Show("Некоректне значення. Спробуйте ще раз.");
                    numberString = Microsoft.VisualBasic.Interaction.InputBox($"Введіть число #{i + 1}:", "Введення чисел");
                }
                numbers[i] = number;
            }

            // Отримуємо значення A та B від користувача
            double A = double.Parse(aTextBox.Text);
            double B = double.Parse(bTextBox.Text);

            // Розраховуємо кількість елементів у масиві, що лежать в діапазоні від А до B
            int count = 0;
            foreach (double number in numbers)
            {
                if (number >= A && number <= B)
                {
                    count++;
                }
            }

            // Розраховуємо суму елементів масиву, розташованих після максимального елемента
            double max = numbers.Max();
            int maxIndex = Array.IndexOf(numbers, max);
            double sum = 0;
            for (int i = maxIndex + 1; i < n; i++)
            {
                sum += numbers[i];
            }

            // Сортуємо елементи масиву за убуванням модулів
            Array.Sort(numbers, (a, b) => Math.Abs(b).CompareTo(Math.Abs(a)));

            // Виводимо результати на форму
            countLbl.Text = $"Кількість елементів масиву, що лежать в діапазоні від {A} до {B}: {count}";
            sumLbl.Text = $"Сума елементів масиву, розташованих після максимального елемента: {sum}";
            sortedNumbersListBox.DataSource = numbers;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintArray();
        }
        private void PrintArray()
        {
            string output = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    output += array[i, j] + " ";
                }
                output += Environment.NewLine;
            }
            arrayOutput.Text = output;
        }

        private void exchangeButton_Click(object sender, EventArgs e)
        {
            int temp = array[0, array.GetLength(1) - 1];
            array[0, array.GetLength(1) - 1] = array[array.GetLength(0) - 1, 0];
            array[array.GetLength(0) - 1, 0] = temp;

            temp = array[array.GetLength(0) - 1, array.GetLength(1) - 1];
            array[array.GetLength(0) - 1, array.GetLength(1) - 1] = array[0, 0];
            array[0, 0] = temp;

            PrintArray();
        }

        private void aTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (e.KeyChar != 1))
                return;

            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if ((aTextBox.Text.IndexOf(',') != -1) ||
                (aTextBox.Text.Length == 0))
                {
                    e.Handled = true;
                }

                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    bTextBox.Focus();
                }
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void bTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (e.KeyChar != 1))
                return;

            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if ((bTextBox.Text.IndexOf(',') != -1) ||
                (bTextBox.Text.Length == 0))
                {
                    e.Handled = true;
                }

                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    bTextBox.Focus();
                }
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
    }
}