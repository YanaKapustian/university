using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double xStep = 0.5;
            double yStep = 0.5;
            double xMin = -a * 3;
            double xMax = b * 3;
            double yMin = -a * 3;
            double yMax = b * 3;
            double xScale = (pictureBox1.Width * 0.8) / (xMax - xMin);
            double yScale = (pictureBox1.Height * 0.8) / (yMax - yMin);

            // створення об'єкта для відображення графіку
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // встановлення чорного кольору для ліній та тексту
                Pen pen = new Pen(Color.Black);
                SolidBrush brush = new SolidBrush(Color.Black);

                // обчислення меж області визначення функції
                double tMin = 0;
                double tMax = 2 * Math.PI;

                // обчислення кількості точок для побудови графіку
                int numPoints = (int)(pictureBox1.Width * 2);

                // створення масивів для зберігання координат точок графіку
                float[] xPoints = new float[numPoints];
                float[] yPoints = new float[numPoints];
                PointF[] points = new PointF[numPoints];

                // розрахунок координат точок
                for (int i = 0; i < numPoints; i++)
                {
                    double t = tMin + i * (tMax - tMin) / (numPoints - 1);

                    double x = a * Math.Cos(t) * (b + Math.Cos(t));
                    double y = Math.Sin(t) * (b + Math.Sin(t));

                    // перетворення координат до системи відліку PictureBox
                    float xPixel = (float)(pictureBox1.Width * 0.1 + (x - xMin) * xScale);
                    float yPixel = (float)(pictureBox1.Height * 0.9 - (y - yMin) * yScale);

                    points[i] = new PointF(xPixel, yPixel);
                }

                // відображення графіку
                g.DrawLines(pen, points);

                // відображення осей та написів на них
                g.DrawLine(pen, (float)(pictureBox1.Width * 0.1), (float)(pictureBox1.Height * 0.9), (float)(pictureBox1.Width * 0.9), (float)(pictureBox1.Height * 0.9));
                g.DrawLine(pen, (float)(pictureBox1.Width * 0.1), (float)(pictureBox1.Height * 0.9), (float)(pictureBox1.Width * 0.1), (float)(pictureBox1.Height * 0.1));

                Font font = new Font("Arial", 10);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                // написи на осі X
                for (double i = xMin; i <= xMax; i += xStep)
                {
                    float xPixel = (float)(pictureBox1.Width * 0.1 + (i - xMin) * xScale);
                    float yPixel = (float)(pictureBox1.Height * 0.9);

                    g.DrawLine(pen, xPixel, yPixel, xPixel, yPixel - 5);
                    g.DrawString(i.ToString(), font, brush, xPixel, yPixel + 5, format);
                }

                // написи на осі Y
                for (double i = yMin; i <= yMax; i += yStep)
                {
                    float xPixel = (float)(pictureBox1.Width * 0.1);
                    float yPixel = (float)(pictureBox1.Height * 0.9 - (i - yMin) * yScale);

                    g.DrawLine(pen, xPixel, yPixel, xPixel + 5, yPixel);
                    g.DrawString(i.ToString(), font, brush, xPixel - 5, yPixel, format);
                }
            }

            // відображення зображення на PictureBox
            pictureBox1.Image = bmp;
        }
    }
}
