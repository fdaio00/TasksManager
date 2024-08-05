using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TasksManager.Subjects;

namespace TasksManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        void _OpenForm(object sender)
        {
            Form frm = (Form)sender;
            frm.BackColor = Color.White;

            //string formTitle = frm.Text;

            //// Check if a tab with the same form is already open
            //foreach (TabPage tabPage in tbForms.TabPages)
            //{
            //    if (tabPage.Text == formTitle)
            //    {
            //        // If found, select the tab and return
            //        ribbon1.do.SelectedTab = tabPage;
            //        return;
            //    }
            //}
            tbForms.TabPages.Add(frm);
            frm.TopLevel = false; // Important to set this to false
            frm.FormBorderStyle = FormBorderStyle.None; // Remove border
            frm.Dock = DockStyle.None; // Ensure the form is not docked

            // Add the form to the TabPage and show it


            // Center the form within the TabPage

            frm.Left = (tbForms.ClientSize.Width - frm.Width) / 2;
            frm.Top = 15;
            frm.Show();



        }
        private void btnCurrentTasks_Click(object sender, EventArgs e)
        {
            frmListTasks frm = new frmListTasks();
            _OpenForm(frm);
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            frmListSubjects frm = new frmListSubjects();
            _OpenForm(frm);
        }
    }
}
