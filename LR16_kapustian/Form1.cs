using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LR16_kapustian.StringArray;

namespace LR16_kapustian
{
    public partial class Form1 : Form
    {
        private StringArray array;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // новий масив з початковими значеннями
            string[] strings = { "hello", "world", "foo", "bar" };
            array = new StringArray(strings);

            DisplayArray();
        }
        //вивести масив на екран
        private void DisplayArray()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                string itemText = string.Format("{0} ({1})", array[i], array.Lengths[i]);
                listBox1.Items.Add(itemText);
            }
        }
        private void addButton_Click_1(object sender, EventArgs e)
        {
            string newText = addTextBox.Text;
            //додаємо новий елемент до масиву
            array = StringArray.Concatenate(array, new StringArray(new string[] { newText }));
            DisplayArray();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                StringArray newArray = new StringArray();
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != selectedIndex)
                    {
                        newArray = StringArray.Concatenate(newArray, new StringArray(new string[] { array[i] }));
                    }
                }
                array = newArray;
                DisplayArray();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            array = new StringArray();
            DisplayArray();
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            string[] strings = mergeTextBox.Text.Split(',');
            StringArray other = new StringArray(strings);

            // копіюємо значення без повторень
            array = StringArray.Merge(array, other);
            DisplayArray();
        }
    }
}
