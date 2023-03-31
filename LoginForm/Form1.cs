using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
                                    /* Connection name; Database Name; True */
            conn.ConnectionString = @"Data Source=DESKTOP-8UQRCMU;Initial Catalog=tableUserName;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT UserID, Password FROM tblUser WHERE " +
                        "UserID='" + txtUserID.Text + "' and Password='" + txtPassword.Text + "'";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid error");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you wanna exit?", "Exit Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
