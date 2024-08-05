using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksManager
{
    public partial class frmAddUpdateTask : Form
    {
        DataTable _dtSubjects;
        clsSubject _Subject;
        clsTask _Task;
        int? _TaskID = null;

        enum enTaskType { Scientific = 1, Theory = 2 }
        enTaskType _TaskType;

        enum enMode { AddNew = 1, Update = 2 };
        enMode _Mode;
        public frmAddUpdateTask()
        {
            _Mode = enMode.AddNew;
            InitializeComponent();
        }
        public frmAddUpdateTask(int TaskID)
        {
            _Mode = enMode.Update;
            InitializeComponent();
            _TaskID = TaskID;
        }


        void _ResetDefaultValuse()
        {
            _FillSubjectsComboBox(); 
            if(_Mode==enMode.AddNew)
            {
                this.Text = "اضافة مهمة جديدة";
                _Task = new clsTask(); 

            }
            else
            {
                this.Text = "تعديل مهمة سابقة";

            }

            txtNotes.Clear();
            txtTaskDetails.Clear();
            txtTaskTitle.Clear();
            rbScientific.Checked = true; 
            

        }
       
      async  void _FillSubjectsComboBox()
        {
            _dtSubjects = await clsSubject.GetAllSubjectsAsync(); 
            if( _dtSubjects .Rows.Count>0 )
            {
                foreach(DataRow r in _dtSubjects.Rows)
                {
                    cbSubject.Items.Add(r["SubjectName"]);
                }
                cbSubject.SelectedIndex = 0;
                _Subject = clsSubject.FindSubjectBySubjectNameAsync(cbSubject.Text.Trim());
                if(_Subject!=null)
                txtTeacher.Text = _Subject.TeacherName;
            }
        }
        private void frmAddUpdateTask_Load(object sender, EventArgs e)
        {
            _ResetDefaultValuse();
            if (_Mode == enMode.Update)
                _LoadTaskInfo();
        }

        private void _LoadTaskInfo()
        {

            _Task = clsTask.FindTaskByTaskIDAsync(_TaskID??-1);
            if(_Task==null )
            {
                MessageBox.Show("لم يتم ايجاد المهمة هذه");
                return; 
            }

            txtTaskTitle.Text = _Task.TaskTitle; 
            txtNotes.Text = _Task.Notes; 
            txtTaskDetails.Text = _Task.TaskDetails;
            cbSubject.FindString(_Task.SubjectInfo.SubjectName);

            
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Subject = clsSubject.FindSubjectBySubjectNameAsync(cbSubject.Text.Trim());
            if (_Subject != null)
                txtTeacher.Text = _Subject.TeacherName;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            _Task.DueDate = dtpDueTime.Value;
            _Task.TaskDate = DateTime.Now;
            _Task.TaskDetails = txtTaskDetails.Text.Trim();
            _Task.Notes = txtNotes.Text.Trim();
            _Task.TaskTitle = txtTaskTitle.Text.Trim(); 
            _Task.SubjectID = _Subject.SubjectID; 
            if(rbScientific.Checked)
            {
                _TaskType = enTaskType.Scientific;

            }
            if (rbTheory.Checked)
            {
                _TaskType = enTaskType.Theory;
            }
                _Task.TaskType = Convert.ToInt32(_TaskType);

           if(await _Task.SaveAsync())
            {
                MessageBox.Show("تمت الاضاف بنجاح");
                this.Text = "تعديل مهمة سابقة";
                _Mode = enMode.Update;
                _TaskID = _Task.TaskID; 
            }
            else
            {
                MessageBox.Show(" لم تتم بنجاح");

            }
        }

        private void txtTeacher_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
