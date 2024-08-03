namespace TasksManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ادارةالمهامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةمهمةجديدةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ادارةالمهامToolStripMenuItem,
            this.اضافةمهمةجديدةToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ادارةالمهامToolStripMenuItem
            // 
            this.ادارةالمهامToolStripMenuItem.Name = "ادارةالمهامToolStripMenuItem";
            this.ادارةالمهامToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.ادارةالمهامToolStripMenuItem.Text = "ادارة المهام";
            this.ادارةالمهامToolStripMenuItem.Click += new System.EventHandler(this.ادارةالمهامToolStripMenuItem_Click);
            // 
            // اضافةمهمةجديدةToolStripMenuItem
            // 
            this.اضافةمهمةجديدةToolStripMenuItem.Name = "اضافةمهمةجديدةToolStripMenuItem";
            this.اضافةمهمةجديدةToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.اضافةمهمةجديدةToolStripMenuItem.Text = "اضافة مهمة جديدة";
            this.اضافةمهمةجديدةToolStripMenuItem.Click += new System.EventHandler(this.اضافةمهمةجديدةToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محمد سامي المندوب";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ادارةالمهامToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةمهمةجديدةToolStripMenuItem;
    }
}

