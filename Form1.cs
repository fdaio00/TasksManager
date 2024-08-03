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
    public partial class Form1 : Form
    {
        DataTable _dtSubjects;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //_dtSubjects = await  clsSubject.GetAllSubjectsAsync(); 
            //if(_dtSubjects.Rows.Count>0)
            //{
            //    dataGridView1.DataSource = _dtSubjects; 
            //}
        }

        private void ادارةالمهامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTasks frm = new frmListTasks();
            frm.ShowDialog(); 
        }

        private void اضافةمهمةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateTask frm = new frmAddUpdateTask();
            frm.ShowDialog(); 
        }
    }
}
