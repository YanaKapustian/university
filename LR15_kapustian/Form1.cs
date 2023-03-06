using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR15_kapustian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            if (x == 1)
            {
                txtResult.Text = "You can't divide by zero";
                return;
            }
            double y = Convert.ToDouble(textBox2.Text);
            double result = Math.Pow((x + 1) / (x - 1), x) + 18 * x * y * y;
            txtResult.Text = result.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (e.KeyChar != 1))
                return;
            
             if (e.KeyChar == '.') e.KeyChar = ',';
             if (e.KeyChar == ',')
             {
             if ((textBox1.Text.IndexOf(',') != -1) ||
             (textBox1.Text.Length == 0))
             {
             e.Handled = true;
             }
            
             return;
             }
            
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    textBox2.Focus();
                }
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if ((textBox1.Text.IndexOf(',') != -1) ||
                (textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }

                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btn.Focus();
                }
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtX2.Text);
            double a = 3 * x * x;
            double b = 4 * Math.Pow(x, 3);
            double result1 = -2 * x + a - b;
            double result2 = 1 + 2 * x + a + b;
            txtRes.Text = result1.ToString();
            txtRes2.Text = result2.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if ((textBox1.Text.IndexOf(',') != -1) ||
                (textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }

                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    textBox2.Focus();
                }
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string res = "false";
            lblRes3.Text = res;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox4.Text);
            int elevatorFloor = (int)Math.Ceiling((double)a / 3) * 2 - 1;
            lblRes4.Text = elevatorFloor.ToString();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            e.Handled = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox5.Text);
            if (n <= 2)
            {
                lblRes5.Text = "Invalid input. Please enter a positive integer greater than 2.";
            }
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    lblRes5.Text += i.ToString() + " ";
                }
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            e.Handled = true;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string input = textBox6.Text;
            string[] strNumbers = input.Split(',');
            int[] numbers = Array.ConvertAll(strNumbers, int.Parse);

            int smallestNumber = numbers[0];
            int smallestIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                    smallestIndex = i;
                }
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double mean = (double)sum / numbers.Length;
            int meanInt = (int)Math.Round(mean);

            bool replaced = false;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] == smallestNumber)
                {
                    numbers[i] = meanInt;
                    replaced = true;
                    break;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                lblRes6.Text += numbers[i].ToString() + ", ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox7.Text;

            string[] words = input.Split(' ');
            string lastWord = words[words.Length - 1];
            int count = 0;
            for (int i = 0; i < lastWord.Length; i++)
            {
                if (lastWord[i] == 'k')
                {
                    count++;
                }
            }
            lblRes7.Text = count.ToString();
        }
    }
}
