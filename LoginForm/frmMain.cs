using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudents f = new frmStudents();
            f.MdiParent = this;
            f.Show();
        }

        private void mangeUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUser f = new frmManageUser();
            f.MdiParent = this;
            f.Show();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser f = new frmUser();
            // f child in parent
            f.MdiParent = this;
            f.Show();
        }
    }
}
