namespace TasksManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.tcTasksManager = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnCurrentTasks = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.btnPreviousTasks = new System.Windows.Forms.RibbonButton();
            this.tcSubjectsManager = new System.Windows.Forms.RibbonTab();
            this.tbForms = new MdiTabControl.TabControl();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbText = "";
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButton1);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButton2);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Tahoma", 9F);
            this.ribbon1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbon1.Size = new System.Drawing.Size(1174, 124);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.tcTasksManager);
            this.ribbon1.Tabs.Add(this.tcSubjectsManager);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue_2010;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "سيبسي";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // tcTasksManager
            // 
            this.tcTasksManager.Name = "tcTasksManager";
            this.tcTasksManager.Panels.Add(this.ribbonPanel1);
            this.tcTasksManager.Panels.Add(this.ribbonPanel2);
            this.tcTasksManager.Text = "إدارة المهام";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.btnCurrentTasks);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
            // 
            // btnCurrentTasks
            // 
            this.btnCurrentTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrentTasks.Image")));
            this.btnCurrentTasks.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCurrentTasks.LargeImage")));
            this.btnCurrentTasks.MinimumSize = new System.Drawing.Size(120, 0);
            this.btnCurrentTasks.Name = "btnCurrentTasks";
            this.btnCurrentTasks.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCurrentTasks.SmallImage")));
            this.btnCurrentTasks.Text = "مهام حالية";
            this.btnCurrentTasks.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.btnCurrentTasks.Click += new System.EventHandler(this.btnCurrentTasks_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ButtonMoreEnabled = false;
            this.ribbonPanel2.ButtonMoreVisible = false;
            this.ribbonPanel2.Items.Add(this.btnPreviousTasks);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "";
            // 
            // btnPreviousTasks
            // 
            this.btnPreviousTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousTasks.Image")));
            this.btnPreviousTasks.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPreviousTasks.LargeImage")));
            this.btnPreviousTasks.MinimumSize = new System.Drawing.Size(120, 0);
            this.btnPreviousTasks.Name = "btnPreviousTasks";
            this.btnPreviousTasks.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPreviousTasks.SmallImage")));
            this.btnPreviousTasks.Text = "مهام فائتة";
            // 
            // tcSubjectsManager
            // 
            this.tcSubjectsManager.Name = "tcSubjectsManager";
            this.tcSubjectsManager.Text = "إدارة المواد";
            // 
            // tbForms
            // 
            this.tbForms.BackColor = System.Drawing.SystemColors.Window;
            this.tbForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbForms.Location = new System.Drawing.Point(0, 124);
            this.tbForms.MenuRenderer = null;
            this.tbForms.Name = "tbForms";
            this.tbForms.Size = new System.Drawing.Size(1174, 561);
            this.tbForms.TabCloseButtonImage = null;
            this.tbForms.TabCloseButtonImageDisabled = null;
            this.tbForms.TabCloseButtonImageHot = null;
            this.tbForms.TabIndex = 1;
            this.tbForms.TabsDirection = MdiTabControl.TabControl.FlowDirection.RightToLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 685);
            this.Controls.Add(this.tbForms);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منظم التكاليف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonTab tcTasksManager;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton btnCurrentTasks;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton btnPreviousTasks;
        private System.Windows.Forms.RibbonTab tcSubjectsManager;
        private MdiTabControl.TabControl tbForms;
    }
}