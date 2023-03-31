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
    public partial class frmStudents : Form
    {
        //static SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-8UQRCMU;Initial Catalog=school;Integrated Security=True");
        //sqlConn.ConnectionString = @"Data Source=DESKTOP-8UQRCMU;Initial Catalog=school;Integrated Security=True";
        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            // open sql sever
            try
            {
                #region cmt
                //SqlConnection sqlConn = new SqlConnection();
                //sqlConn.ConnectionString = @"Data Source=DESKTOP-8UQRCMU;Initial Catalog=school;Integrated Security=True";
                //sqlConn.Open();

                //// write code sql
                //String sql = "SELECT * FROM student";
                ////MessageBox.Show("helloooo");
                //// sum up
                //SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //// take Table
                //DataTable dt = new DataTable();
                //adapter.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                //    dataGridViewStudents.DataSource = dt;
                //}
                //else
                //{
                //    MessageBox.Show("Invalid Error!!");
                //}
                #endregion
                frmStu_Load(sender, e);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // enabled btn
            btnClear.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // btn effect
                btnAdd.Enabled = false;
                btnClear.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

                // main effect
                string hoTen = dataGridViewStudents.CurrentRow.Cells[1].Value.ToString();
                string ngaySinh = dataGridViewStudents.CurrentRow.Cells[2].Value.ToString();
                string tmpGioiTinh = dataGridViewStudents.CurrentRow.Cells[3].Value.ToString();
                string email = dataGridViewStudents.CurrentRow.Cells[4].Value.ToString();

                txtName.Text = hoTen;
                txtEmail.Text = email;
                dtimeBirth.Text = ngaySinh;
                if (tmpGioiTinh.Equals("True"))
                {
                    radMale.Checked = true;
                }
                else
                {
                    radFemale.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmStu_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection();
                                        // (local): sql in machine; DB; SSPI: Windows authentication
            sqlConn.ConnectionString = @"Data Source=(local);Initial Catalog=school;Integrated Security=True";
            sqlConn.Open();

            // write code sql
            String sql = "SELECT * FROM student";
            //MessageBox.Show("helloooo");
            // sum up
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            // take Table
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewStudents.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid Error!!");
            }
        }

        private void sqlConnectionFill(object sender, EventArgs e, string sql)
        {
            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = @"Data Source=(local);Initial Catalog=school;Integrated Security=True";
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            // take Table
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int rad;
            if (radMale.Checked)
            {
                rad = 1;
            }
            else
            {
                rad = 0;
            }
            try
            {
                #region cmt
                //SqlConnection sqlConn = new SqlConnection();
                //sqlConn.ConnectionString = @"Data Source=DESKTOP-8UQRCMU;Initial Catalog=school;Integrated Security=True";
                //sqlConn.Open();
                ////MessageBox.Show(Convert.ToDateTime(dtimeBirth.Text).ToString());
                //SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //// take Table
                //DataTable dt = new DataTable();
                //adapter.Fill(dt);
                #endregion
                String sql = "INSERT INTO student " +
                        "VALUES('" + txtName.Text.ToString() + "','" + Convert.ToDateTime(dtimeBirth.Text).ToShortDateString() +
                                "'," + rad + ",'" + txtEmail.Text.ToString() + "')";
                sqlConnectionFill(sender, e, sql);
                btnClear_Click(sender, e);
                frmStu_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridViewStudents.CurrentRow.Cells[0].Value.ToString());
            try
            {
                #region cmt
                //SqlConnection sqlConn = new SqlConnection();
                //sqlConn.ConnectionString = @"Data Source=DESKTOP-8UQRCMU;Initial Catalog=school;Integrated Security=True";
                //sqlConn.Open();

                //SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //SqlDataAdapter ap = new SqlDataAdapter(cmd);

                //DataTable dt = new DataTable();
                //ap.Fill(dt);
                #endregion
                String sql = "DELETE FROM student " +
                        "where maso=" + (dataGridViewStudents.CurrentRow.Cells[0].Value.ToString());
                sqlConnectionFill(sender, e, sql);
                btnClear_Click(sender, e);
                frmStu_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maso = dataGridViewStudents.CurrentRow.Cells[0].Value.ToString();
            string hoTen = txtName.Text.ToString();
            string ngaySinh = Convert.ToDateTime(dtimeBirth.Text).ToShortDateString();
            //MessageBox.Show(ngaySinh);

            int gioiTinh;
            if (radMale.Checked) {
                gioiTinh = 1;
            }
            else
            {
                gioiTinh = 0;
            }
            string email = txtEmail.Text.ToString();
            try
            {
                #region cmt
                //SqlConnection sqlConn = new SqlConnection();
                //sqlConn.ConnectionString = @"Data Source=DESKTOP-8UQRCMU; Initial Catalog=school; Integrated Security=True";
                //sqlConn.Open();
                //MessageBox.Show(sql);

                //SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //adapter.Fill(dt);
                #endregion
                String sql = string.Format("update student " +
                            "set hoTen='{0}', ngaySinh='{1}', gioiTinh={2}, email='{3}' " +
                            "where maso={4}", hoTen, ngaySinh, gioiTinh, email, maso);
                sqlConnectionFill(sender, e, sql);
                frmStu_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //string maso = dataGridViewStudents.CurrentRow.Cells[0].Value.ToString();
            try
            {
                // enabled btn
                btnAdd.Enabled = true;
                btnClear.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;

                // main effect
                txtName.Text = null;
                txtEmail.Text = null;
                radMale.Checked = false;
                radFemale.Checked = false;
                dtimeBirth.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
