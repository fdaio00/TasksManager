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
    public partial class frmListTasks : Form
    {
        public frmListTasks()
        {
            InitializeComponent();
        }
        DataTable _dtTasks; 
        private async void frmListTasks_Load(object sender, EventArgs e)
        {
            _dtTasks = await clsTask.GetAllTasksAsync(); 
            if(_dtTasks.Rows.Count>0)
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
    }
}
