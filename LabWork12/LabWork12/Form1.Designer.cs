namespace l26
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.name1 = new System.Windows.Forms.TextBox();
            this.phone1 = new System.Windows.Forms.TextBox();
            this.txtTemplatePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.topic = new System.Windows.Forms.TextBox();
            this.fax1 = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fax2 = new System.Windows.Forms.TextBox();
            this.phone2 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(970, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Згенерувати довідку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGenerateCertificate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(970, 193);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Обрати шаблон довідки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSelectTemplate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(8, 23);
            this.name1.Margin = new System.Windows.Forms.Padding(4);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(407, 22);
            this.name1.TabIndex = 7;
            this.name1.Text = "to";
            // 
            // phone1
            // 
            this.phone1.Location = new System.Drawing.Point(8, 85);
            this.phone1.Margin = new System.Windows.Forms.Padding(4);
            this.phone1.Name = "phone1";
            this.phone1.Size = new System.Drawing.Size(407, 22);
            this.phone1.TabIndex = 10;
            this.phone1.Text = "phone";
            // 
            // txtTemplatePath
            // 
            this.txtTemplatePath.Location = new System.Drawing.Point(928, 87);
            this.txtTemplatePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtTemplatePath.Name = "txtTemplatePath";
            this.txtTemplatePath.Size = new System.Drawing.Size(235, 22);
            this.txtTemplatePath.TabIndex = 18;
            this.txtTemplatePath.Text = "Шлях для відкриття файлу";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1163, 53);
            this.label1.TabIndex = 29;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.topic);
            this.groupBox1.Controls.Add(this.fax1);
            this.groupBox1.Controls.Add(this.phone1);
            this.groupBox1.Controls.Add(this.name1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(415, 172);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "receıver";
            // 
            // topic
            // 
            this.topic.Location = new System.Drawing.Point(8, 117);
            this.topic.Margin = new System.Windows.Forms.Padding(4);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(407, 22);
            this.topic.TabIndex = 27;
            this.topic.Text = "topic";
            // 
            // fax1
            // 
            this.fax1.Location = new System.Drawing.Point(8, 53);
            this.fax1.Margin = new System.Windows.Forms.Padding(4);
            this.fax1.Name = "fax1";
            this.fax1.Size = new System.Drawing.Size(407, 22);
            this.fax1.TabIndex = 25;
            this.fax1.Text = "fax";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(177, 250);
            this.notes.Margin = new System.Windows.Forms.Padding(4);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(557, 22);
            this.notes.TabIndex = 29;
            this.notes.Text = "notes";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(928, 117);
            this.txtSave.Margin = new System.Windows.Forms.Padding(4);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(235, 22);
            this.txtSave.TabIndex = 32;
            this.txtSave.Text = "Шлях для збереження файлу";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(970, 230);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 42);
            this.button3.TabIndex = 33;
            this.button3.Text = "Обрати місце збереження";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fax2);
            this.groupBox2.Controls.Add(this.phone2);
            this.groupBox2.Controls.Add(this.name2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(463, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(415, 175);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "sender";
            // 
            // fax2
            // 
            this.fax2.Location = new System.Drawing.Point(8, 53);
            this.fax2.Margin = new System.Windows.Forms.Padding(4);
            this.fax2.Name = "fax2";
            this.fax2.Size = new System.Drawing.Size(407, 22);
            this.fax2.TabIndex = 25;
            this.fax2.Text = "fax";
            // 
            // phone2
            // 
            this.phone2.Location = new System.Drawing.Point(8, 85);
            this.phone2.Margin = new System.Windows.Forms.Padding(4);
            this.phone2.Name = "phone2";
            this.phone2.Size = new System.Drawing.Size(407, 22);
            this.phone2.TabIndex = 10;
            this.phone2.Text = "phone";
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(8, 23);
            this.name2.Margin = new System.Windows.Forms.Padding(4);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(407, 22);
            this.name2.TabIndex = 7;
            this.name2.Text = "from";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 115);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(407, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 587);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemplatePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "LR 26";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox phone1;
        private System.Windows.Forms.TextBox txtTemplatePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox fax1;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.TextBox topic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fax2;
        private System.Windows.Forms.TextBox phone2;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

