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
    public partial class 教师管理稿件 : Form
    {
        public 教师主页面 w1 = new();
        public 教师管理稿件()
        {
            InitializeComponent();
        }

        public void NewSql()
        {
            try
            {
                SqlConnection conn = new();
                conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                conn.Open();
                string sql = "SELECT * FROM Article";
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
                dataGridView1.Columns["status"].HeaderText = "状态";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
            catch
            {
                MessageBox.Show("出错");
                this.Close();
                w1.Show();
            }
        }
    }
}
