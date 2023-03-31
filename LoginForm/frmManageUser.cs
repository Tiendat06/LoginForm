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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginForm
{
    public partial class frmManageUser : Form
    {
        public frmManageUser()
        {
            InitializeComponent();
        }

        private void frmManageUser_Load(object sender, EventArgs e)
        {
            try
            {
                frmMUser_Load(sender, e);
                btnSave.Enabled = true;
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmMUser_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = @"Data Source=(local);Initial Catalog=tableUserName;Integrated Security=True";
            sqlConn.Open();

            // write code sql
            String sql = "SELECT * FROM tblUser";
            //MessageBox.Show("helloooo");
            // sum up
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            // take Table
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewMUser.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid Error!!");
            }
        }

        private void sqlConnectionFill(object sender, EventArgs e, string sql)
        {
            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = @"Data Source=(local);Initial Catalog=tableUserName;Integrated Security=True";
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            // take Table
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }

        private void dataGridViewMUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // btn effect
                btnSave.Enabled = false;
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;

                // main effect
                string uName = dataGridViewMUser.CurrentRow.Cells[0].Value.ToString();
                string uID = dataGridViewMUser.CurrentRow.Cells[1].Value.ToString();
                string uPass = dataGridViewMUser.CurrentRow.Cells[2].Value.ToString();
                string uIActive = dataGridViewMUser.CurrentRow.Cells[3].Value.ToString();

                txtID.Text = uID;
                txtName.Text = uName;
                txtPass.Text = uPass;
                if (uIActive.Equals("1"))
                {
                    radIsActive.Checked = true;
                }
                else
                {
                    radIsActive.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int isActive;
            if (radIsActive.Checked)
            {
                isActive = 1;
            }
            else
            {
                isActive = 0;
            }
            try
            {
                String sql = string.Format("insert into tblUser " +
                                        "values('{0}', '{1}', '{2}', '{3}', getdate())", 
                                        txtName.Text.ToString(), txtID.Text.ToString(), txtPass.Text.ToString(), isActive);
                btnNew_Click(sender, e);
                sqlConnectionFill(sender, e, sql);
                MessageBox.Show("Save Successfully");
                frmMUser_Load(sender, e);
                //dataGridViewMUser.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                // enabled btn
                btnSave.Enabled = true;
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;

                // main effect
                txtName.Text = null;
                txtID.Text = null;
                txtPass.Text = null;
                radIsActive.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text.ToString();
                string name = txtName.Text.ToString();
                string pass = txtPass.Text.ToString();
                int isAct = radIsActive.Checked ? 1 : 0;

                String sql = string.Format("update tblUser " +
                                        "set UserName='{0}', UserID='{1}', Password='{2}', isActive={3}, DateCreated=getdate() " +
                                        "where userID='{4}'", name, id, pass, isAct, dataGridViewMUser.CurrentRow.Cells[1].Value.ToString());
                //MessageBox.Show(sql);
                sqlConnectionFill(sender, e, sql);
                frmMUser_Load(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "DELETE FROM tblUser " +
                        "where UserID='" + (dataGridViewMUser.CurrentRow.Cells[1].Value.ToString())+"'";

                sqlConnectionFill(sender, e, sql);
                btnNew_Click(sender, e);
                frmMUser_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
