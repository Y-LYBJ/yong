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
    public partial class TeaLoad : Form
    {
        private static 教师主页面 w1;
        private Boolean fals = true;
        public TeaLoad()
        {
            InitializeComponent();
            IconShow.BackgroundImage = Document_management_system.Properties.Resources.睁眼;
        }

        private void Tea_load_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Account.Text) && !String.IsNullOrEmpty(Password.Text))
            {  //非空检验
                SQLpromgram s = new();
                if (s.SqlLoad(Account.Text, Password.Text, "教师"))
                {
                    MessageBox.Show("登录成功！", "提示");
                    w1 = new 教师主页面();
                    w1.Show();
                    this.Hide();
                    ShowPage.Account = Account.Text;
                    ShowPage.Password = Password.Text;
                    s.SqlAuthor();
                }
                else MessageBox.Show("账号或密码错误");
            }
            else MessageBox.Show("输入不能为空！");
        }

        private void IconShow_Click(object sender, EventArgs e)
        {
            if (fals == true)
            {
                // 切换密码显示状态
                Password.PasswordChar = '\0'; // 显示密码

                // 切换图标
                IconShow.BackgroundImage = Document_management_system.Properties.Resources.睁眼; // 显示显示密码的图标

                fals = false;
            }
            else
            {
                // 切换密码显示状态
                Password.PasswordChar = '*'; // 隐藏密码

                // 切换图标
                IconShow.BackgroundImage = Document_management_system.Properties.Resources.闭眼; // 显示隐藏密码的图标

                fals = true;
            }
        }
    }
}
