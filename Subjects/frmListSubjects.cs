using AccountingPR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksManager.Subjects
{
    public partial class frmListSubjects : Form
    {
        private DataTable _dtSubjects;
        private clsSubject _Subject;
        private int? _SubjectID;

        public frmListSubjects()
        {
            InitializeComponent();
        }

        async void _FillDataGridView()
        {
            _dtSubjects = await clsSubject.GetAllSubjectsAsync();
            if (_dtSubjects.Rows.Count > 0)
            {
                dgvSubjects.DataSource = _dtSubjects;

                dgvSubjects.Columns[0].Visible = false;
                dgvSubjects.Columns[1].HeaderText = "اسم المدرس";
                dgvSubjects.Columns[2].HeaderText = "المادة";
                //_Subject = clsSubject.FindSubjectBySubjectNameAsync(cbSubject.Text.Trim());
                //if (_Subject != null)
                //    txtTeacher.Text = _Subject.TeacherName;
            }
        }
        private async void frmListSubjects_Load(object sender, EventArgs e)
        {
            _FillDataGridView();
        }

        private void dgvSubjects_Click(object sender, EventArgs e)
        {
            _SubjectID = Convert.ToInt32(dgvSubjects.CurrentRow.Cells[0].Value);
            if (_SubjectID.HasValue)
            {
                _LoadTaskInfo();
            }
        }

        void _ResetDeafultValuse()
        {
            _ClearTextBoxes();
            _EnableDisable(false);
        }

        void _ClearTextBoxes()
        {
           
            txtSubject.Clear();
            txtTeacherName.Clear();
        }

        void _EnableDisable(bool IsEnabled)
        {
            txtSubject.Enabled = IsEnabled;
            txtTeacherName.Enabled = IsEnabled;
            btnSave.Enabled = IsEnabled;
            btnDelete.Enabled = IsEnabled;

        }
        private void _LoadTaskInfo()
        {

            _Subject = clsSubject.FindSubjectBySubjectID(_SubjectID??-1);

            if(_Subject == null )
            {
                myToast.ShowToast("لايوحد بيانات على هذا المادة");
                return; 
            }
            _EnableDisable(true);
            btnSave.Enabled = true;
            btnDelete.Enabled = true;   
            _SubjectID = _Subject.SubjectID; 
            txtSubject.Text = _Subject.SubjectName;
            txtTeacherName.Text = _Subject.TeacherName; 


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _EnableDisable(true);
            btnDelete.Enabled = false;
            txtTeacherName.Focus();
            _Subject = new clsSubject(); 

        }

        private void Validation(object sender, CancelEventArgs e)
        {
           

        }

        private void txtTeacherName_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (string.IsNullOrEmpty(temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError( temp, "هذا الحقل لا يمكن ان يكون فارغا");
            }
            else
            {
                errorProvider1.SetError(temp, null);

            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                return; 
            }

            _Subject.SubjectName = txtSubject.Text.Trim();
            _Subject.TeacherName = txtTeacherName.Text.Trim(); 

            if(await _Subject.SaveAsync())
            {
                myToast.ShowToast("تم الحفظ بنجاح", ToastTypeIcon.Success);
                btnDelete.Enabled = true;
                _SubjectID = _Subject.SubjectID; 
                _FillDataGridView();

            }
            else
                myToast.ShowToast("لم يتم الحفظ", ToastTypeIcon.Error);

        }

        private async  void btnDelete_Click(object sender, EventArgs e)
        {
            if (_SubjectID.HasValue)
            {
                if (MessageBox.Show("هل انت متاكد من حذف المهمة المحددة؟", "حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    if (await clsSubject.DeleteSubjectAsync(_SubjectID ?? -1))
                    {
                        myToast.ShowToast("تم الحذف بنجاح", ToastTypeIcon.Success);
                        _FillDataGridView();
                        dgvSubjects.ClearSelection();
                        btnDelete.Enabled = false;
                        btnSave.Enabled = false; 

                    }
                    else
                        myToast.ShowToast("فشلت المهمة", ToastTypeIcon.Error);

                }
            }
        }
    }
}
