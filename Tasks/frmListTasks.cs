using AccountingPR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksManager
{
    public partial class frmListTasks : Form
    {
        public frmListTasks()
        {
            InitializeComponent();
        }
        DataTable _dtTasks;
        StringBuilder _sbSummury = new StringBuilder();
        string st; 
        DataTable _dtSubjects;
        clsSubject _Subject;
        clsTask _Task;
        int? _TaskID = null;

        enum enTaskType { Scientific = 1, Theory = 2 }
        enTaskType _TaskType;

        enum enMode { AddNew = 1, Update = 2 };
        enMode _Mode;

        void _ResetDefaultValuse()
        {
            //if (_Mode == enMode.AddNew)
            //{
            //    this.Text = "اضافة مهمة جديدة";
            //    _Task = new clsTask();

            //}
            //else
            //{
            //    this.Text = "تعديل مهمة سابقة";

            //}

            txtNotes.Clear();
            txtTaskDetails.Clear();
            txtTaskTitle.Clear();
            rbScientific.Checked = true;
            dtpDueTime.Value = DateTime.Now;
            ckbNotes.Checked = false; 


        }
        private void _LoadTaskInfo()
        {

            _Task = clsTask.FindTaskByTaskIDAsync(_TaskID ?? -1);
            if (_Task == null)
            {
                myToast.ShowToast("لم يتم ايجاد المهمة هذه");
                return;
            }
            _Mode = enMode.Update; 
            txtTaskTitle.Text = _Task.TaskTitle;
            txtNotes.Text = _Task.Notes;
            txtTaskDetails.Text = _Task.TaskDetails;
            cbSubject.FindString(_Task.SubjectInfo.SubjectName);
            _EnableDisableTextBoxes(true);
            txtTaskDetails.Focus();
            btnSave.Enabled = true; 
            btnDelete.Enabled = true;
            dtpDueTime.Value = _Task.DueDate; 
            _TaskID = _Task.TaskID; 


        }

        void _GetSummury()
        {
            string IsEdit = "";
            if (_Mode == enMode.Update)
            {
                IsEdit = "*(تعديل)*";
            }
            string Note = "";
            if (ckbNotes.Checked)
            {
                Note += "*ملاحظة*\n";
                Note += $"{txtNotes.Text}";
                            
     
            }
            else
            {
                Note = "";
            }


            string Type = "";
            if (_TaskType == enTaskType.Theory)
            {
                Type = "نظري";
            }
            else
            {
                Type = "عملي";
            }


            //            st = "";
            //            st += $@"
            //                {IsEdit}

            //                {txtTaskTitle.Text}

            //                *المادة*
            //                {cbSubject.Text}

            //                *مدرس المادة*
            //                {txtTeacher.Text}

            //                *نوع التكليف*
            //                {Type}

            //                *نص التكليف*
            //                {txtTaskDetails.Text}

            //                *تاريخ التسليم*
            //                {dtpDueTime.Value.ToShortDateString()}

            //                {Note}






            //            //    ";
            //_sbAllInfo.AppendLine($"*{txtTaskTitle.Text}*");
            //_sbAllInfo.AppendLine();
            ////_sbAllInfo.AppendLine($"*Subject*: {cbSubject.Text}");
            //_sbAllInfo.AppendLine("*المادة*");
            //_sbAllInfo.AppendLine(cbSubject.Text);
            //_sbAllInfo.AppendLine();

            //_sbAllInfo.AppendLine($"*مدرس المادة*");

            //_sbAllInfo.AppendLine(txtTeacher.Text);
            //_sbAllInfo.AppendLine();

            //_sbAllInfo.AppendLine("*نص التكليف*");
            //_sbAllInfo.AppendLine(txtTaskDetails.Text);
            //_sbAllInfo.AppendLine();

            //_sbAllInfo.AppendLine("*موعد التسليم*");
            //_sbAllInfo.AppendLine(dtpDueTime.Value.ToString("yyyy-MM-dd"));
            //if(ckbNotes.Checked)
            //{
            //_sbAllInfo.AppendLine();
            //    _sbAllInfo.AppendLine("*ملاحظة: *");
            //    _sbAllInfo.AppendLine(txtNotes.Text);
            //}


            _sbSummury.Clear();
         if(!string.IsNullOrEmpty(IsEdit))
            {
                _sbSummury.AppendLine($"*!!!{IsEdit}!!!*");
                _sbSummury.AppendLine();
            }
            _sbSummury.AppendLine($"*{txtTaskTitle.Text}*");
            _sbSummury.AppendLine();
            //_sbAllInfo.AppendLine($"*Subject*: {cbSubject.Text}");
            _sbSummury.AppendLine("*المادة*");
            _sbSummury.AppendLine(cbSubject.Text);
            _sbSummury.AppendLine();

            _sbSummury.AppendLine($"*مدرس المادة*");

            _sbSummury.AppendLine(txtTeacher.Text);
            _sbSummury.AppendLine();
              _sbSummury.AppendLine($"*نوع التكليف*");

            _sbSummury.AppendLine(Type);
            _sbSummury.AppendLine();

            _sbSummury.AppendLine("*نص التكليف*");
            _sbSummury.AppendLine(txtTaskDetails.Text);
            _sbSummury.AppendLine();

            _sbSummury.AppendLine("*موعد التسليم*");
            _sbSummury.AppendLine(dtpDueTime.Value.ToString("yyyy-MM-dd"));
            if (!string.IsNullOrEmpty(Note))
            {
                _sbSummury.AppendLine(Note);
            }

        }

        async void _FillDataGridView()
        {
            _dtTasks = await clsTask.GetAllTasksAsync();
            if (_dtTasks.Rows.Count > 0)
            {
                dgvListTasks.DataSource = _dtTasks;

                dgvListTasks.Columns[0].Visible = false;
                //dgvListTasks.Columns[1].HeaderText = "عنوان المهمة";
                dgvListTasks.Columns[1].HeaderText = "التفاصيل";
                dgvListTasks.Columns[2].HeaderText = "تاريخ التسليم";
                dgvListTasks.Columns[3].HeaderText = "الايام المتبقية";
                dgvListTasks.Columns[4].HeaderText = "عملي/نظري";
                dgvListTasks.Columns[5].HeaderText = "المادة";

            }
        }
        async void _FillSubjectsComboBox()
        {
            _dtSubjects = await clsSubject.GetAllSubjectsAsync();
            if (_dtSubjects.Rows.Count > 0)
            {
                foreach (DataRow r in _dtSubjects.Rows)
                {
                    cbSubject.Items.Add(r["SubjectName"]);
                }
                cbSubject.SelectedIndex = 0;
                _Subject = clsSubject.FindSubjectBySubjectNameAsync(cbSubject.Text.Trim());
                if (_Subject != null)
                    txtTeacher.Text = _Subject.TeacherName;
            }
        }

        private  void frmListTasks_Load(object sender, EventArgs e)
        {
            _ResetDefaultValuse();
            _FillDataGridView();
            _FillSubjectsComboBox();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            _Task.DueDate = dtpDueTime.Value;
            _Task.TaskDate = DateTime.Now;
            _Task.TaskDetails = txtTaskDetails.Text.Trim();
            _Task.Notes = txtNotes.Text.Trim();
            _Task.TaskTitle = txtTaskTitle.Text.Trim();
            _Task.SubjectID = _Subject.SubjectID;
            if (rbScientific.Checked)
            {
                _TaskType = enTaskType.Scientific;

            }
            if (rbTheory.Checked)
            {
                _TaskType = enTaskType.Theory;
            }
            _Task.TaskType = Convert.ToInt32(_TaskType);

            if (await _Task.SaveAsync())
            {
                myToast.ShowToast("تمت الاضاف بنجاح",ToastTypeIcon.Success);
                //this.Text = "تعديل مهمة سابقة";
                //_Mode = enMode.Update;
                _TaskID = _Task.TaskID;
                _FillDataGridView();
                _GetSummury();
              //if(  MessageBox.Show("هل تريد طباعة الخلاصة؟","طباعة الخلاصة",MessageBoxButtons.OKCancel) ==DialogResult.OK)
              //  {
                frmSummury frm = new frmSummury(_sbSummury);
                frm.Show();
                _Mode = enMode.Update;

                
            }
            else
            {
                myToast.ShowToast(" لم تتم بنجاح",ToastTypeIcon.Error);

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _ResetDefaultValuse();
            _EnableDisableTextBoxes();
            btnSave.Enabled = true;
            txtTaskTitle.Focus();
            _Task = new clsTask();
            _Mode = enMode.AddNew; 

        }

        void _EnableDisableTextBoxes(bool IsEnable  = true)
        {
            txtNotes.Enabled = IsEnable; 
            txtTaskDetails.Enabled = IsEnable; 
            txtTaskTitle.Enabled = IsEnable; 
            dtpDueTime.Enabled = IsEnable;
            rbScientific.Enabled = IsEnable;
            rbTheory.Enabled = IsEnable;
            cbSubject.Enabled = IsEnable; 
        }

        private void dgvListTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Subject = clsSubject.FindSubjectBySubjectNameAsync(cbSubject.Text.Trim());
            if (_Subject != null)
                txtTeacher.Text = _Subject.TeacherName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListTasks_Click(object sender, EventArgs e)
        {
            _TaskID = Convert.ToInt32(dgvListTasks.CurrentRow.Cells[0].Value);
            if (_TaskID != null)
            {
                _LoadTaskInfo();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvListTasks.Rows.Count > 0)
            {
                _dtTasks.DefaultView.RowFilter = "";


                _dtTasks.DefaultView.RowFilter = "DaysLeft = 0 OR DaysLeft IS NULL";
            }
        }

        private void rbIncompelete_CheckedChanged(object sender, EventArgs e)
        {
            try
            {


                if (dgvListTasks.Rows.Count > 0)
                {
                    _dtTasks.DefaultView.RowFilter = "";


                    _dtTasks.DefaultView.RowFilter = "DaysLeft > 0 OR DaysLeft IS NULL";

                }
            }
            catch(Exception ex)
            {

            }
        }


        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            _dtTasks.DefaultView.RowFilter = "";

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if(_TaskID.HasValue)
            {
                if(MessageBox.Show("هل انت متاكد من حذف المهمة المحددة؟","حذف",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation)==DialogResult.OK)
                {
                    if(await clsTask.DeleteTaskAsync(_TaskID??-1))
                    {
                        myToast.ShowToast("تم الحذف بنجاح",ToastTypeIcon.Success);
                        _FillDataGridView();
                        _ResetDefaultValuse();
                        dgvListTasks.ClearSelection();
                        btnDelete.Enabled = false; 

                    }
                    else
                        myToast.ShowToast("فشلت المهمة", ToastTypeIcon.Error);

                }
            }
        }

        private void ckbNotes_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbNotes.Checked)
            {
                txtNotes.Enabled = true; 
            }
        }

        private void dgvListTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _GetSummury();
            frmSummury frm = new frmSummury(_sbSummury);
            frm.Show();
        }
    }
}
