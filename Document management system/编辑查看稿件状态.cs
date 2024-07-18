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
                string sql = "select article,checkState,auditor from Back";
                SqlCommand cmd = new(sql);
                cmd.Connection = conn;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds1 = new DataSet();
                adapter.Fill(ds1, "Article");
                dataGridView1.DataSource = ds1.Tables["Article"];
                SqlDataReader mys = cmd.ExecuteReader();
                dataGridView1.Columns["article"].HeaderText = "稿件名称";
                dataGridView1.Columns["checkState"].HeaderText = "稿件状态";
                dataGridView1.Columns["auditor"].HeaderText = "审核员";
                conn.Close();

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
    }
}
