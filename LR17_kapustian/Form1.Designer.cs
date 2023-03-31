namespace LR17_kapustian
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelThird = new System.Windows.Forms.Label();
            this.buttonIncrementFirst = new System.Windows.Forms.Button();
            this.buttonIncrementSecond = new System.Windows.Forms.Button();
            this.buttonIncrementThird = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Location = new System.Drawing.Point(312, 29);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(0, 16);
            this.labelFirst.TabIndex = 0;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(312, 96);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(0, 16);
            this.labelSecond.TabIndex = 1;
            // 
            // labelThird
            // 
            this.labelThird.AutoSize = true;
            this.labelThird.Location = new System.Drawing.Point(312, 165);
            this.labelThird.Name = "labelThird";
            this.labelThird.Size = new System.Drawing.Size(0, 16);
            this.labelThird.TabIndex = 2;
            // 
            // buttonIncrementFirst
            // 
            this.buttonIncrementFirst.Location = new System.Drawing.Point(96, 21);
            this.buttonIncrementFirst.Name = "buttonIncrementFirst";
            this.buttonIncrementFirst.Size = new System.Drawing.Size(108, 45);
            this.buttonIncrementFirst.TabIndex = 3;
            this.buttonIncrementFirst.Text = "Increment";
            this.buttonIncrementFirst.UseVisualStyleBackColor = true;
            this.buttonIncrementFirst.Click += new System.EventHandler(this.buttonIncrementFirst_Click);
            // 
            // buttonIncrementSecond
            // 
            this.buttonIncrementSecond.Location = new System.Drawing.Point(96, 89);
            this.buttonIncrementSecond.Name = "buttonIncrementSecond";
            this.buttonIncrementSecond.Size = new System.Drawing.Size(108, 46);
            this.buttonIncrementSecond.TabIndex = 4;
            this.buttonIncrementSecond.Text = "Increment";
            this.buttonIncrementSecond.UseVisualStyleBackColor = true;
            this.buttonIncrementSecond.Click += new System.EventHandler(this.buttonIncrementSecond_Click);
            // 
            // buttonIncrementThird
            // 
            this.buttonIncrementThird.Location = new System.Drawing.Point(96, 158);
            this.buttonIncrementThird.Name = "buttonIncrementThird";
            this.buttonIncrementThird.Size = new System.Drawing.Size(108, 47);
            this.buttonIncrementThird.TabIndex = 5;
            this.buttonIncrementThird.Text = "Increment";
            this.buttonIncrementThird.UseVisualStyleBackColor = true;
            this.buttonIncrementThird.Click += new System.EventHandler(this.buttonIncrementThird_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIncrementThird);
            this.Controls.Add(this.buttonIncrementSecond);
            this.Controls.Add(this.buttonIncrementFirst);
            this.Controls.Add(this.labelThird);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelThird;
        private System.Windows.Forms.Button buttonIncrementFirst;
        private System.Windows.Forms.Button buttonIncrementSecond;
        private System.Windows.Forms.Button buttonIncrementThird;
    }
}

