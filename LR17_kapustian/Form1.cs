using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR17_kapustian
{
    public partial class Form1 : Form
    {
        private Triad triad;
        public Form1()
        {
            InitializeComponent();
            triad = new Date(2023, 03, 30);
            UpdateDisplay();
        }

        private void buttonIncrementFirst_Click(object sender, EventArgs e)
        {
            triad.IncrementFirst();
            UpdateDisplay();
        }

        private void buttonIncrementSecond_Click(object sender, EventArgs e)
        {
            triad.IncrementSecond();
            UpdateDisplay();
        }

        private void buttonIncrementThird_Click(object sender, EventArgs e)
        {
            triad.IncrementThird();
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            labelFirst.Text = triad.GetFirst.ToString();
            labelSecond.Text = triad.GetSecond.ToString();
            labelThird.Text = triad.GetThird.ToString();
        }
    }
}
