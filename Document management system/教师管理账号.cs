using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_management_system
{
    public partial class 教师管理账号 : Form
    {
        public void NewSql()
        {
            SqlConnection conn = new();
            conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
            conn.Open();
            string sql = "select * from Load";
            SqlCommand cmd = new(sql);
            cmd.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Account");
            dataGridView1.DataSource = ds.Tables["Account"];
            conn.Close();
            dataGridView1.Columns["account"].HeaderText = "账号";
            dataGridView1.Columns["id"].HeaderText = "身份";
            dataGridView1.Columns["organization"].HeaderText = "名称";
            dataGridView1.Columns[1].Visible = false;
        }
        public 教师管理账号()
        {
            InitializeComponent();
        }

        private void 教师管理账号_Load(object sender, EventArgs e)
        {
            try
            {
                NewSql();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            教师主页面 form1 = new();
            this.Close();
            form1.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            string strrow = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string all = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (MessageBox.Show("确定注销" + strrow + all + "吗", "注意", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                    conn.Open();
                    string sql = "DELETE FROM Load WHERE account ='" + strrow + "'";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Connection = conn;
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("注销成功", "提示");
                    NewSql();
                }
                catch { MessageBox.Show("注销失败", "警告"); }
            }
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            string pass = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CP.Visible = true;
            oldpass.Text = pass;
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            string strrow = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string pass = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            SQLpromgram s = new SQLpromgram();
            if (!String.IsNullOrEmpty(newpass.Text))
            {
                s.SqlChangePassword(strrow, newpass.Text);
                CP.Visible = false;
                newpass.Clear();
                NewSql();
            }
        }

        private void No_Click(object sender, EventArgs e)
        {
            CP.Visible=false;
        }
    }
}
