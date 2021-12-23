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
    public partial class frmAdminRegister : Form
    {
        public frmAdminRegister()
        {
            InitializeComponent();
            pnlStudent.Width = 1050;
        }

        private void frmMembersStudents_Load(object sender, EventArgs e)
        {

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            pnlStudent.Width = 250;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            pnlStudent.Width = 1050;
        }
    }
}
