using System.Windows.Forms;

namespace LR19_kapustian
{
    public partial class Form1 : Form
    {
        private string[] stringArray = { "apple", "banana", "grandkids", "date", "dad" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintArray();
        }
        private void PrintArray()
        {
            listBox1.Items.Clear();

            // додати кожен елемент масиву до ListBox
            foreach (string word in stringArray)
            {
                listBox1.Items.Add(word);
            }
        }

        private void alphabetButton_Click(object sender, EventArgs e)
        {
            string firstWord = stringArray.OrderBy(s => s).First();
            resultLabel.Text = "Перше слово за алфавітом: " + firstWord;
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            var dWords = stringArray.Where(s => s.Count(c => c == 'd') == 2);
            resultLabel.Text = "Слова з 2 літерами d: " + string.Join(", ", dWords);
        }
    }
}