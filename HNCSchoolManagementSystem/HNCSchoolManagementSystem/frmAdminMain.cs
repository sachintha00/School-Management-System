using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDLogic;

namespace HNCSchoolManagementSystem
{
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmAdminDash(), pnlChangeWindow, Color.FromArgb(28, 32, 57));
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmAdminDash(), pnlChangeWindow, Color.FromArgb(28, 32, 57));
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.Open(new frmAdminMembers(), pnlChangeWindow, Color.FromArgb(28, 32, 57));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
