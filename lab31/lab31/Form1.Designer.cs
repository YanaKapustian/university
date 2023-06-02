namespace lab31
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exportButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.stopProcessToolStripMenuItem = new System.Windows.Forms.Button();
            this.viewProcessInfoToolStripMenuItem = new System.Windows.Forms.Button();
            this.processListView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(26, 257);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(324, 53);
            this.exportButton.TabIndex = 9;
            this.exportButton.Text = "exportButton";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(26, 205);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(324, 46);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.Text = "refreshButton";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // stopProcessToolStripMenuItem
            // 
            this.stopProcessToolStripMenuItem.Location = new System.Drawing.Point(26, 156);
            this.stopProcessToolStripMenuItem.Name = "stopProcessToolStripMenuItem";
            this.stopProcessToolStripMenuItem.Size = new System.Drawing.Size(324, 43);
            this.stopProcessToolStripMenuItem.TabIndex = 7;
            this.stopProcessToolStripMenuItem.Text = "stopProcessToolStripMenuItem";
            this.stopProcessToolStripMenuItem.UseVisualStyleBackColor = true;
            this.stopProcessToolStripMenuItem.Click += new System.EventHandler(this.stopProcessToolStripMenuItem_Click);
            // 
            // viewProcessInfoToolStripMenuItem
            // 
            this.viewProcessInfoToolStripMenuItem.Location = new System.Drawing.Point(26, 101);
            this.viewProcessInfoToolStripMenuItem.Name = "viewProcessInfoToolStripMenuItem";
            this.viewProcessInfoToolStripMenuItem.Size = new System.Drawing.Size(324, 49);
            this.viewProcessInfoToolStripMenuItem.TabIndex = 6;
            this.viewProcessInfoToolStripMenuItem.Text = "viewProcessInfoToolStripMenuItem";
            this.viewProcessInfoToolStripMenuItem.UseVisualStyleBackColor = true;
            this.viewProcessInfoToolStripMenuItem.Click += new System.EventHandler(this.viewProcessInfoToolStripMenuItem_Click);
            // 
            // processListView
            // 
            this.processListView.FormattingEnabled = true;
            this.processListView.ItemHeight = 16;
            this.processListView.Location = new System.Drawing.Point(412, 48);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(336, 356);
            this.processListView.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.stopProcessToolStripMenuItem);
            this.Controls.Add(this.viewProcessInfoToolStripMenuItem);
            this.Controls.Add(this.processListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button stopProcessToolStripMenuItem;
        private System.Windows.Forms.Button viewProcessInfoToolStripMenuItem;
        private System.Windows.Forms.ListBox processListView;
    }
}

