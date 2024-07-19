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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Document_management_system
{
    public partial class 编辑待处理稿件 : Form
    {
        public 编辑主页面 w1 = new();
        public 编辑待处理稿件()
        {
            InitializeComponent();
            NewSql();
            Check();
        }
        public void NewSql()
        {
            try
            {
                SqlConnection conn = new();
                conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                conn.Open();
                string sql = "select article,type,status from Article WHERE status = '自由'";
                SqlCommand cmd = new(sql);
                cmd.Connection = conn;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds2 = new DataSet();
                adapter.Fill(ds2, "Article");
                dataGridView1.DataSource = ds2.Tables["Article"];
                conn.Close();
                dataGridView1.Columns["article"].HeaderText = "稿件名称";
                dataGridView1.Columns["type"].HeaderText = "稿件类型";
                dataGridView1.Columns["status"].HeaderText = "稿件状态";
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
            w1.Show();
            this.Close();
        }

        public void Check()
        {
            SqlConnection conn = new();
            conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
            conn.Open();
            string sql = "select organization from Load where id = '主编'";
            SqlCommand cmd = new(sql);
            cmd.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds3 = new DataSet();
            adapter.Fill(ds3, "Check");
            foreach (DataRow row in ds3.Tables["Check"].Rows)
            {
                string str = row["organization"].ToString();
                listBox1.Items.Add(str);
            }
            conn.Close();
        }

        private void Choice_Click(object sender, EventArgs e)
        { 
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                groupBox1.Visible = true;
                Choice.Enabled = false;
            }
            else { MessageBox.Show("选中为空"); }
        }

        private void no_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            Choice.Enabled = true;
        }
        private void yes_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            Choice.Enabled = true;
            string article = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string all = listBox1.Text;
            if (MessageBox.Show("确定将《" + article + "》分配给" + all + "吗", "注意", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                { 
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                    conn.Open();
                    string sql1 = "INSERT INTO Back (article,checkState,auditor) VALUES ('";
                    string sql2 = article + "','" + "审核中" + "','" + all + "')";
                    string sql = sql1 + sql2;
                    SqlCommand cmd = new SqlCommand(sql);
                    string sql3 = "UPDATE Article SET status ='审核中' WHERE article = '" + article + "'";
                    SqlCommand cmd2 = new SqlCommand(sql3);
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd2.Connection = conn;
                    cmd2.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("分配成功", "提示");
                    NewSql();
                }
                catch { MessageBox.Show("分配失败", "警告"); }
            }


        }
    }
}
