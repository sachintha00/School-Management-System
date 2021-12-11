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
    public partial class frmMembersStudents : Form
    {
        public frmMembersStudents()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMembersStudents_Load(object sender, EventArgs e)
        {
            dgvStudent.Rows.Add(9);
            dgvStudent.Rows[0].Cells[0].Value = "1001";
            dgvStudent.Rows[0].Cells[1].Value = "1001";
            dgvStudent.Rows[0].Cells[2].Value = "1001";
            dgvStudent.Rows[0].Cells[3].Value = "1001";
            dgvStudent.Rows[0].Cells[4].Value = "1001";
            dgvStudent.Rows[0].Cells[5].Value = "1001";
            dgvStudent.Rows[0].Cells[6].Value = "1001";
            dgvStudent.Rows[0].Cells[7].Value = "1001";
            dgvStudent.Rows[0].Cells[8].Value = "1001";

            dgvStudent.Rows[1].Cells[0].Value = "1001";
            dgvStudent.Rows[1].Cells[1].Value = "1001";
            dgvStudent.Rows[1].Cells[2].Value = "1001";
            dgvStudent.Rows[1].Cells[3].Value = "1001";
            dgvStudent.Rows[1].Cells[4].Value = "1001";
            dgvStudent.Rows[1].Cells[5].Value = "1001";
            dgvStudent.Rows[1].Cells[6].Value = "1001";
            dgvStudent.Rows[1].Cells[7].Value = "1001";
            dgvStudent.Rows[1].Cells[8].Value = "1001";
        }
    }
}
