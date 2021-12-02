using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNCSchoolManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnPasswordShow_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnPasswordShow_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }
    }
}
