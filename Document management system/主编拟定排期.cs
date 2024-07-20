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
    public partial class 主编拟定排期 : Form
    {
        public 主编主页面 w1 = new();
        public 主编拟定排期()
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
                string sql = "SELECT article,organization,type,nowRank FROM Article WHERE status = '录取' and RankState = '未拟定'";
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
                dataGridView1.Columns["nowRank"].HeaderText = "当前排期";
            }
            catch
            {
                MessageBox.Show("出错");
                this.Close();
                w1.Show();
            }
        }

        public void Check()
        {
            SqlConnection conn = new();
            conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
            conn.Open();
            string sql = "select AllCount from Teacher";
            SqlCommand cmd = new(sql);
            cmd.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Count");
            foreach (DataRow row in ds.Tables["Count"].Rows)
            {
                string str = row["AllCount"].ToString();
                comboBox1.Items.Add(str);
            }
            conn.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            w1.Show();
        }

        private void BtnRevise_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                groupBox1.Visible = true;
            }
            else { MessageBox.Show("选中为空"); }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                string article = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("确定决定将" + article + "分配到" + comboBox1.Text + "吗", "注意", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                        conn.Open();
                        string sql = "UPDATE Article SET RankState = '已拟定', nowRank = '" + comboBox1.Text + "' WHERE article = '" + article + "'";
                        SqlCommand cmd = new SqlCommand(sql);
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("排期成功", "提示");
                        NewSql();
                    }
                    catch { MessageBox.Show("排期失败", "警告"); }
                    groupBox1.Visible = false;
                }
            }
            else { MessageBox.Show("请选择期数!"); }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
