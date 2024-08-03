namespace TasksManager
{
    partial class frmAddUpdateTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaskDetails = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDueTime = new System.Windows.Forms.DateTimePicker();
            this.ckbNotes = new System.Windows.Forms.CheckBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTheory = new System.Windows.Forms.RadioButton();
            this.rbScientific = new System.Windows.Forms.RadioButton();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان المهمة";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(18, 36);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(582, 26);
            this.txtTaskTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "المادة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "المدرس";
            // 
            // txtTaskDetails
            // 
            this.txtTaskDetails.Location = new System.Drawing.Point(13, 165);
            this.txtTaskDetails.Multiline = true;
            this.txtTaskDetails.Name = "txtTaskDetails";
            this.txtTaskDetails.Size = new System.Drawing.Size(590, 111);
            this.txtTaskDetails.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "تفاصيل المهمة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "موعد التسليم";
            // 
            // dtpDueTime
            // 
            this.dtpDueTime.Location = new System.Drawing.Point(22, 317);
            this.dtpDueTime.Name = "dtpDueTime";
            this.dtpDueTime.Size = new System.Drawing.Size(258, 26);
            this.dtpDueTime.TabIndex = 9;
            // 
            // ckbNotes
            // 
            this.ckbNotes.AutoSize = true;
            this.ckbNotes.Location = new System.Drawing.Point(18, 361);
            this.ckbNotes.Name = "ckbNotes";
            this.ckbNotes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckbNotes.Size = new System.Drawing.Size(86, 22);
            this.ckbNotes.TabIndex = 10;
            this.ckbNotes.Text = "ملاحظات";
            this.ckbNotes.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(16, 390);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(590, 111);
            this.txtNotes.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(264, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 56);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(440, 513);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(169, 56);
            this.btnCancle.TabIndex = 14;
            this.btnCancle.Text = "الغاء";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rbScientific);
            this.groupBox1.Controls.Add(this.rbTheory);
            this.groupBox1.Location = new System.Drawing.Point(301, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 61);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rbTheory
            // 
            this.rbTheory.AutoSize = true;
            this.rbTheory.Location = new System.Drawing.Point(179, 25);
            this.rbTheory.Name = "rbTheory";
            this.rbTheory.Size = new System.Drawing.Size(63, 22);
            this.rbTheory.TabIndex = 16;
            this.rbTheory.TabStop = true;
            this.rbTheory.Text = "نظري";
            this.rbTheory.UseVisualStyleBackColor = true;
            // 
            // rbScientific
            // 
            this.rbScientific.AutoSize = true;
            this.rbScientific.Location = new System.Drawing.Point(39, 25);
            this.rbScientific.Name = "rbScientific";
            this.rbScientific.Size = new System.Drawing.Size(67, 22);
            this.rbScientific.TabIndex = 17;
            this.rbScientific.TabStop = true;
            this.rbScientific.Text = "علمي";
            this.rbScientific.UseVisualStyleBackColor = true;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(339, 102);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(261, 26);
            this.txtTeacher.TabIndex = 5;
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(22, 105);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(275, 26);
            this.cbSubject.TabIndex = 16;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // frmAddUpdateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 580);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.ckbNotes);
            this.Controls.Add(this.dtpDueTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTaskDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(647, 627);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(647, 627);
            this.Name = "frmAddUpdateTask";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مهمة";
            this.Load += new System.EventHandler(this.frmAddUpdateTask_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaskDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDueTime;
        private System.Windows.Forms.CheckBox ckbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbScientific;
        private System.Windows.Forms.RadioButton rbTheory;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.ComboBox cbSubject;
    }
}