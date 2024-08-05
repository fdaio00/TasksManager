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
            this.ribbonItemGroup1 = new System.Windows.Forms.RibbonItemGroup();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDueTime = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbTheory = new System.Windows.Forms.RadioButton();
            this.rbScientific = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaskDetails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ckbNotes = new System.Windows.Forms.CheckBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbIncompelete = new System.Windows.Forms.RadioButton();
            this.rbCompelete = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTasks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListTasks
            // 
            this.dgvListTasks.AllowUserToAddRows = false;
            this.dgvListTasks.AllowUserToDeleteRows = false;
            this.dgvListTasks.AllowUserToOrderColumns = true;
            this.dgvListTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListTasks.Location = new System.Drawing.Point(3, 19);
            this.dgvListTasks.Name = "dgvListTasks";
            this.dgvListTasks.ReadOnly = true;
            this.dgvListTasks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListTasks.RowHeadersWidth = 51;
            this.dgvListTasks.RowTemplate.Height = 24;
            this.dgvListTasks.Size = new System.Drawing.Size(728, 195);
            this.dgvListTasks.TabIndex = 0;
            this.dgvListTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTasks_CellClick);
            this.dgvListTasks.Click += new System.EventHandler(this.dgvListTasks_Click);
            // 
            // ribbonItemGroup1
            // 
            this.ribbonItemGroup1.Name = "ribbonItemGroup1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSubject);
            this.groupBox1.Controls.Add(this.dtpDueTime);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.ckbNotes);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTaskTitle);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTeacher);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTaskDetails);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المهمة";
            // 
            // dtpDueTime
            // 
            this.dtpDueTime.Location = new System.Drawing.Point(295, 188);
            this.dtpDueTime.Name = "dtpDueTime";
            this.dtpDueTime.Size = new System.Drawing.Size(319, 23);
            this.dtpDueTime.TabIndex = 58;
            // 
            // txtNotes
            // 
            this.txtNotes.Enabled = false;
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNotes.Location = new System.Drawing.Point(15, 49);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(237, 223);
            this.txtNotes.TabIndex = 57;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbTheory);
            this.panel1.Controls.Add(this.rbScientific);
            this.panel1.Location = new System.Drawing.Point(296, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 28);
            this.panel1.TabIndex = 55;
            // 
            // rbTheory
            // 
            this.rbTheory.AutoSize = true;
            this.rbTheory.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rbTheory.Location = new System.Drawing.Point(96, 3);
            this.rbTheory.Name = "rbTheory";
            this.rbTheory.Size = new System.Drawing.Size(63, 22);
            this.rbTheory.TabIndex = 1;
            this.rbTheory.Text = "نظري";
            this.rbTheory.UseVisualStyleBackColor = true;
            // 
            // rbScientific
            // 
            this.rbScientific.AutoSize = true;
            this.rbScientific.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rbScientific.Location = new System.Drawing.Point(219, 2);
            this.rbScientific.Name = "rbScientific";
            this.rbScientific.Size = new System.Drawing.Size(67, 22);
            this.rbScientific.TabIndex = 0;
            this.rbScientific.Text = "عملي";
            this.rbScientific.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListTasks);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 217);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قائمة المهام";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::TasksManager.Properties.Resources.close;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(607, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 37);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::TasksManager.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(412, 530);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 37);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::TasksManager.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(218, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.Image = global::TasksManager.Properties.Resources.add;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(24, 533);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(79, 37);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "جديد";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label5.Location = new System.Drawing.Point(624, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "موعد التسليم:";
            // 
            // txtTaskDetails
            // 
            this.txtTaskDetails.Enabled = false;
            this.txtTaskDetails.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.txtTaskDetails.Location = new System.Drawing.Point(295, 109);
            this.txtTaskDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskDetails.Multiline = true;
            this.txtTaskDetails.Name = "txtTaskDetails";
            this.txtTaskDetails.Size = new System.Drawing.Size(319, 74);
            this.txtTaskDetails.TabIndex = 33;
            this.txtTaskDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label6.Location = new System.Drawing.Point(624, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "التافصيل:";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Enabled = false;
            this.txtTeacher.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.txtTeacher.Location = new System.Drawing.Point(295, 82);
            this.txtTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(319, 23);
            this.txtTeacher.TabIndex = 31;
            this.txtTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label9.Location = new System.Drawing.Point(626, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "المدرس:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label10.Location = new System.Drawing.Point(626, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "المادة:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label11.Location = new System.Drawing.Point(626, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "عنوان المهمة:";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Enabled = false;
            this.txtTaskTitle.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.txtTaskTitle.Location = new System.Drawing.Point(295, 19);
            this.txtTaskTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(319, 23);
            this.txtTaskTitle.TabIndex = 27;
            this.txtTaskTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label12.Location = new System.Drawing.Point(624, 219);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 16);
            this.label12.TabIndex = 54;
            this.label12.Text = "نوع المهمة:";
            // 
            // ckbNotes
            // 
            this.ckbNotes.AutoSize = true;
            this.ckbNotes.Checked = true;
            this.ckbNotes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNotes.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.ckbNotes.Location = new System.Drawing.Point(155, 22);
            this.ckbNotes.Name = "ckbNotes";
            this.ckbNotes.Size = new System.Drawing.Size(78, 20);
            this.ckbNotes.TabIndex = 53;
            this.ckbNotes.Text = "ملاحظات";
            this.ckbNotes.UseVisualStyleBackColor = true;
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(294, 53);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(319, 24);
            this.cbSubject.TabIndex = 59;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbAll);
            this.panel2.Controls.Add(this.rbIncompelete);
            this.panel2.Controls.Add(this.rbCompelete);
            this.panel2.Location = new System.Drawing.Point(296, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 28);
            this.panel2.TabIndex = 61;
            // 
            // rbIncompelete
            // 
            this.rbIncompelete.AutoSize = true;
            this.rbIncompelete.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rbIncompelete.Location = new System.Drawing.Point(217, 2);
            this.rbIncompelete.Name = "rbIncompelete";
            this.rbIncompelete.Size = new System.Drawing.Size(95, 22);
            this.rbIncompelete.TabIndex = 1;
            this.rbIncompelete.Text = "غير مكتمل";
            this.rbIncompelete.UseVisualStyleBackColor = true;
            this.rbIncompelete.CheckedChanged += new System.EventHandler(this.rbIncompelete_CheckedChanged);
            // 
            // rbCompelete
            // 
            this.rbCompelete.AutoSize = true;
            this.rbCompelete.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rbCompelete.Location = new System.Drawing.Point(141, 2);
            this.rbCompelete.Name = "rbCompelete";
            this.rbCompelete.Size = new System.Drawing.Size(70, 22);
            this.rbCompelete.TabIndex = 0;
            this.rbCompelete.Text = "مكتمل";
            this.rbCompelete.UseVisualStyleBackColor = true;
            this.rbCompelete.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label1.Location = new System.Drawing.Point(624, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "فتلرة المهام:";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rbAll.Location = new System.Drawing.Point(70, 2);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(56, 22);
            this.rbAll.TabIndex = 2;
            this.rbAll.Text = "الكل";
            this.rbAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // frmListTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 592);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListTasks;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDueTime;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbTheory;
        private System.Windows.Forms.RadioButton rbScientific;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.CheckBox ckbNotes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTaskDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbIncompelete;
        private System.Windows.Forms.RadioButton rbCompelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAll;
    }
}