namespace LR19_kapustian
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.alphabetButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(49, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 104);
            this.listBox1.TabIndex = 0;
            // 
            // alphabetButton
            // 
            this.alphabetButton.Location = new System.Drawing.Point(49, 157);
            this.alphabetButton.Name = "alphabetButton";
            this.alphabetButton.Size = new System.Drawing.Size(243, 40);
            this.alphabetButton.TabIndex = 1;
            this.alphabetButton.Text = "Перше слово за алфавітом";
            this.alphabetButton.UseVisualStyleBackColor = true;
            this.alphabetButton.Click += new System.EventHandler(this.alphabetButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(49, 219);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(318, 40);
            this.countButton.TabIndex = 2;
            this.countButton.Text = "Всі слова, що мають рівно дві букви \'d\'";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(289, 71);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.alphabetButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button alphabetButton;
        private Button countButton;
        private Label resultLabel;
    }
}