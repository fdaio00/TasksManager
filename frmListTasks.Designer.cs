namespace TasksManager
{
    partial class frmListTasks
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
            this.dgvListTasks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListTasks
            // 
            this.dgvListTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTasks.Location = new System.Drawing.Point(12, 26);
            this.dgvListTasks.Name = "dgvListTasks";
            this.dgvListTasks.ReadOnly = true;
            this.dgvListTasks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListTasks.RowHeadersWidth = 51;
            this.dgvListTasks.RowTemplate.Height = 24;
            this.dgvListTasks.Size = new System.Drawing.Size(918, 453);
            this.dgvListTasks.TabIndex = 0;
            // 
            // frmListTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 504);
            this.Controls.Add(this.dgvListTasks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListTasks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المهام";
            this.Load += new System.EventHandler(this.frmListTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListTasks;
    }
}