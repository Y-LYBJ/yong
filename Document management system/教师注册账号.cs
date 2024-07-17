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
    public partial class 教师注册账号 : Form
    {
        public 教师注册账号()
        {
            InitializeComponent();
        }

        private void BtnEnroll_Click(object sender, EventArgs e)
        {
            SQLpromgram s = new SQLpromgram();
            if (!String.IsNullOrEmpty(txtAccount.Text) && !String.IsNullOrEmpty(txtIdentity.Text))
            {
                SqlConnection conn = new();
                conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                conn.Open();
                string sql = "select * from Load where account= '" + txtAccount + "'";
                SqlCommand cmd = new(sql);
                cmd.Connection = conn;
                SqlDataReader mys = cmd.ExecuteReader();
                if (mys.HasRows)
                {
                    conn.Close();
                    MessageBox.Show("该账号已存在！");
                }
                else
                {
                    conn.Close();
                    s.SqlEnroll(txtAccount.Text, txtName.Text, txtIdentity.Text);
                }
            }
            else { MessageBox.Show("所填信息必需齐全！"); }
        }

        private void txtIdentity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtIdentity.Text != "作者")
            {
                txtLevel.Enabled = false;
                txtLevel.Text = "";
            }
            else
            {
                txtLevel.Enabled = true;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            教师设置 form1 = new();
            form1.ShowDialog();
        }
    }
}
