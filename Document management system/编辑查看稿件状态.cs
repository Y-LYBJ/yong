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

namespace Document_management_system
{
    public partial class 编辑查看稿件状态 : Form
    {
        public 编辑主页面 w1 = new();

        public 编辑查看稿件状态()
        {
            InitializeComponent();
            NewSql();
        }

        public void NewSql()
        {
            try
            {
                SqlConnection conn = new();
                conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                conn.Open();
                string sql = "select * from Back";
                SqlCommand cmd = new(sql);
                cmd.Connection = conn;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds1 = new DataSet();
                adapter.Fill(ds1, "Article");
                dataGridView1.DataSource = ds1.Tables["Article"];
                conn.Close();
                dataGridView1.Columns["article"].HeaderText = "稿件名称";
                dataGridView1.Columns["checkState"].HeaderText = "稿件状态";
                dataGridView1.Columns["auditor"].HeaderText = "审核员";
                dataGridView1.Columns[2].Visible = false;

            }
            catch
            {
                MessageBox.Show("出错");
                this.Close();
                w1.Show();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            w1.Show();
        }

        public void SqlArt()     ///引入文章信息
        {
            SqlConnection conn = new();
            conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
            conn.Open();
            string sql = "select * from Article where article= '" + ArtPage.Article + "'";
            SqlCommand cmd = new(sql);
            cmd.Connection = conn;
            SqlDataReader mys = cmd.ExecuteReader();
            while (mys.Read())
            {
                ArtPage.Organize = mys.GetString(mys.GetOrdinal("organization"));
                ArtPage.Type= mys.GetString(mys.GetOrdinal("type"));
            }
        }
        private void Detail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    string state = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    if (state == "已审核")
                    {
                        ArtPage.Article = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        ArtPage.Advice = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        SqlArt();
                        this.Close();
                        编辑决定稿件去留 form1 = new();
                        form1.ShowDialog();
                        Show.Visible = false;
                    }
                    else
                    {
                        Show.Text = "文章审核尚未通过";
                        Show.Visible = true;
                    }
                }
                catch (Exception ex) { MessageBox.Show("错误"); }
            }
            else { MessageBox.Show("选中为空！"); }
        }
    }
}
