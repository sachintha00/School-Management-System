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
            SMDChildFormOpen.Open(new frmAdminDashboard(),pnlChangeWindow,Color.FromArgb(201, 201, 199));
        }
    }
}
