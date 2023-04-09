namespace LR18_kapustian
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.countLbl = new System.Windows.Forms.Label();
            this.sumLbl = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.sortedNumbersListBox = new System.Windows.Forms.ListBox();
            this.sumLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.arrayOutput = new System.Windows.Forms.Label();
            this.exchangeButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.countLbl);
            this.tabPage1.Controls.Add(this.sumLbl);
            this.tabPage1.Controls.Add(this.calculateButton);
            this.tabPage1.Controls.Add(this.sortedNumbersListBox);
            this.tabPage1.Controls.Add(this.sumLabel);
            this.tabPage1.Controls.Add(this.countLabel);
            this.tabPage1.Controls.Add(this.bTextBox);
            this.tabPage1.Controls.Add(this.aTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.inputTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(42, 193);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(0, 20);
            this.countLbl.TabIndex = 13;
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Location = new System.Drawing.Point(43, 247);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(0, 20);
            this.sumLbl.TabIndex = 12;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(417, 134);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 29);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Обчислити";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // sortedNumbersListBox
            // 
            this.sortedNumbersListBox.FormattingEnabled = true;
            this.sortedNumbersListBox.ItemHeight = 20;
            this.sortedNumbersListBox.Location = new System.Drawing.Point(55, 286);
            this.sortedNumbersListBox.Name = "sortedNumbersListBox";
            this.sortedNumbersListBox.Size = new System.Drawing.Size(150, 104);
            this.sortedNumbersListBox.TabIndex = 10;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(586, 264);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(0, 20);
            this.sumLabel.TabIndex = 9;
            this.sumLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(586, 211);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 20);
            this.countLabel.TabIndex = 8;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(189, 135);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(125, 27);
            this.bTextBox.TabIndex = 5;
            this.bTextBox.TextChanged += new System.EventHandler(this.bTextBox_TextChanged);
            this.bTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bTextBox_KeyPress);
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(189, 93);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(125, 27);
            this.aTextBox.TabIndex = 4;
            this.aTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Значення B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Значення А";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(295, 28);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(125, 27);
            this.inputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість елементів масиву";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.arrayOutput);
            this.tabPage2.Controls.Add(this.exchangeButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // arrayOutput
            // 
            this.arrayOutput.AutoSize = true;
            this.arrayOutput.Location = new System.Drawing.Point(67, 26);
            this.arrayOutput.Name = "arrayOutput";
            this.arrayOutput.Size = new System.Drawing.Size(0, 20);
            this.arrayOutput.TabIndex = 1;
            // 
            // exchangeButton
            // 
            this.exchangeButton.Location = new System.Drawing.Point(67, 118);
            this.exchangeButton.Name = "exchangeButton";
            this.exchangeButton.Size = new System.Drawing.Size(94, 29);
            this.exchangeButton.TabIndex = 0;
            this.exchangeButton.Text = "Поміняти місцями";
            this.exchangeButton.UseVisualStyleBackColor = true;
            this.exchangeButton.Click += new System.EventHandler(this.exchangeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label sumLabel;
        private Label countLabel;
        private TextBox bTextBox;
        private TextBox aTextBox;
        private Label label3;
        private Label label2;
        private TextBox inputTextBox;
        private Label label1;
        private TabPage tabPage2;
        private Button calculateButton;
        private ListBox sortedNumbersListBox;
        private Label countLbl;
        private Label sumLbl;
        private Label arrayOutput;
        private Button exchangeButton;
    }
}