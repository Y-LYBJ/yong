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
    public partial class 主编待处理稿件 : Form
    {
        主编主页面 w1 = new();
        缓存过渡窗体 form1 = new();
        public 主编待处理稿件()
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
                string sql = "SELECT Article.article,organization,type,url,checkState FROM Article inner join Back on Article.article = Back.article  where auditor = '" + ShowPage.User + "'";
                SqlCommand cmd = new(sql);
                cmd.Connection = conn;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds1 = new DataSet();
                adapter.Fill(ds1, "Article");
                dataGridView1.DataSource = ds1.Tables["Article"];
                conn.Close();
                dataGridView1.Columns["article"].HeaderText = "稿件名称";
                dataGridView1.Columns["organization"].HeaderText = "组织";
                dataGridView1.Columns["type"].HeaderText = "类型";
                dataGridView1.Columns["checkState"].HeaderText = "审核状态";
                dataGridView1.Columns[3].Visible = false;
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

        private void Detail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ArtPage.Article = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ArtPage.Path = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.Close();
                form1.Show();
            }
            else { MessageBox.Show("未选中！", "警告"); }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ArtPage.Article = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                    conn.Open();
                    string sql = "UPDATE Back SET checkState = '拒审'，audior = '' where article= '" + ArtPage.Article + "'";
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("已拒审");
                    NewSql();
                }
                catch { MessageBox.Show("出错！"); }
            }
            else { MessageBox.Show("未选中！", "警告"); }
        }
    }
}
