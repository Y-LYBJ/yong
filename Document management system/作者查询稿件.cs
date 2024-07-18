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
    public partial class 作者查询稿件 : Form
    {
        public 作者查询稿件()
        {
            InitializeComponent();
            try
            {
                SqlConnection conn = new();
                conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                conn.Open();
                string sql = "select article,type,status from Article WHERE organization = '" + ShowPage.User + "'";
                SqlCommand cmd = new(sql);
                cmd.Connection = conn;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds1 = new DataSet();
                adapter.Fill(ds1, "Article");
                dataGridView2.DataSource = ds1.Tables["Article"];
                conn.Close();
                dataGridView2.Columns["article"].HeaderText = "稿件名称";
                dataGridView2.Columns["type"].HeaderText = "稿件类型";
                dataGridView2.Columns["status"].HeaderText = "稿件状态";
            }
            catch
            {
                MessageBox.Show("出错");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            作者主页面 form1 = new();
            form1.Show();
            this.Close();
        }
    }
}
