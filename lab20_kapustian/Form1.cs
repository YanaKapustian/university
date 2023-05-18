namespace lab20_kapustian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numerator = int.Parse(numeratorTextBox.Text);
                int denominator = int.Parse(denominatorTextBox.Text);

                int wholePart = CalculateWholePart(numerator, denominator);

                wholePartLabel.Text = "Ціла частина: " + wholePart.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Невірний формат введених даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка обробки.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private int CalculateWholePart(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Знаменник не може бути нулем.");
            }

            return numerator / denominator;
        }
    }
}