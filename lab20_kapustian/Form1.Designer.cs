namespace lab20_kapustian
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
            this.numeratorTextBox = new System.Windows.Forms.TextBox();
            this.denominatorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.wholePartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numeratorTextBox
            // 
            this.numeratorTextBox.Location = new System.Drawing.Point(354, 46);
            this.numeratorTextBox.Name = "numeratorTextBox";
            this.numeratorTextBox.Size = new System.Drawing.Size(125, 27);
            this.numeratorTextBox.TabIndex = 0;
            // 
            // denominatorTextBox
            // 
            this.denominatorTextBox.Location = new System.Drawing.Point(354, 101);
            this.denominatorTextBox.Name = "denominatorTextBox";
            this.denominatorTextBox.Size = new System.Drawing.Size(125, 27);
            this.denominatorTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть чисельник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть знаменник";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(367, 192);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 29);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Обчислити";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Відповідь";
            // 
            // wholePartLabel
            // 
            this.wholePartLabel.AutoSize = true;
            this.wholePartLabel.Location = new System.Drawing.Point(235, 198);
            this.wholePartLabel.Name = "wholePartLabel";
            this.wholePartLabel.Size = new System.Drawing.Size(0, 20);
            this.wholePartLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wholePartLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.denominatorTextBox);
            this.Controls.Add(this.numeratorTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox numeratorTextBox;
        private TextBox denominatorTextBox;
        private Label label1;
        private Label label2;
        private Button calculateButton;
        private Label label3;
        private Label wholePartLabel;
    }
}