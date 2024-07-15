using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_management_system
{
    public partial class StuLoad : Form
    {
        private
            作者主页面 w1;
        编辑主页面 w2;
        主编主页面 w3;
        public StuLoad()
        {
            InitializeComponent();
        }

        private void autior_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Account.Text) && !String.IsNullOrEmpty(Password.Text))
            {  //非空检验
                SQLpromgram s = new();
                if (s.SqlLoad(Account.Text, Password.Text, "作者"))
                {
                    MessageBox.Show("登录成功！", "提示");
                    w1 = new 作者主页面();
                    w1.Show();
                    this.Hide();
                }
                else MessageBox.Show("账号或密码错误");
            }
            else MessageBox.Show("输入不能为空！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Account.Text) && !String.IsNullOrEmpty(Password.Text))
            {  //非空检验
                SQLpromgram s = new();
                if (s.SqlLoad(Account.Text, Password.Text, "编辑"))
                {
                    MessageBox.Show("登录成功！", "提示");
                    w2 = new 编辑主页面();
                    w2.Show();
                    this.Hide();
                }
                else MessageBox.Show("账号或密码错误");
            }
            else MessageBox.Show("输入不能为空！");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Account.Text) && !String.IsNullOrEmpty(Password.Text))
            {  //非空检验
                SQLpromgram s = new();
                if (s.SqlLoad(Account.Text, Password.Text, "主编"))
                {
                    MessageBox.Show("登录成功！", "提示");
                    w3 = new 主编主页面();
                    w3.Show();
                    this.Hide();
                }
                else MessageBox.Show("账号或密码错误");
            }
            else MessageBox.Show("输入不能为空！");
        }
    }
}
