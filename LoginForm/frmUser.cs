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
    public partial class frmUser : Form
    {
        // command line
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            //frmLogin f = new frmLogin();
            //f.ShowDialog();

            SqlConnection conn = new SqlConnection();
            /* Connection name; Database Name; True */
            conn.ConnectionString = @"Data Source=(local);Initial Catalog=tableUserName;Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT * FROM tblUser";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewTblUser.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid error");
            }
            
        }
    }
}
