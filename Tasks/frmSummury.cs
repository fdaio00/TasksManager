using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TasksManager
{
    public partial class frmSummury : Form
    {
        StringBuilder sb;
        string st = null; 
        public frmSummury(StringBuilder stringBuilder)
        {
            InitializeComponent();
            sb = stringBuilder;
        }
         public frmSummury(string st)
        {
            InitializeComponent();
            this.st = st;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSummury.Text);
            toolTip1.Show("تم نسخ النص بنجاح", txtSummury, 0, txtSummury.Height, 2000); // Display for 2 seconds
            this.Close();
        }

        private void frmSummury_Load(object sender, EventArgs e)
        {
            if(sb !=null)
            txtSummury.Text = sb.ToString();
            if(!string.IsNullOrEmpty(st))
            {
                txtSummury.Text = st;

            }

        }
    }
}
