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
    public partial class frmAdminMembers : Form
    {
        public frmAdminMembers()
        {
            InitializeComponent();
        }

        private void frmAdminMembers_Load(object sender, EventArgs e)
        {
            SMDChildFormOpen.OpenWithActiveForm(new frmMembersStudents(), pnlMembersChange, Color.FromArgb(28, 32, 57));
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            SMDChildFormOpen.OpenWithActiveForm(new frmMembersStudents(), pnlMembersChange, Color.FromArgb(28, 32, 57));
        }
    }
}
