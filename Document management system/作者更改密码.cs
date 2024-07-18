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
    public partial class 作者更改密码 : Form
    {
        public SQLpromgram s = new();
        private Boolean fals = true;
        public 作者更改密码()
        {
            InitializeComponent();
            txtOriginal.Text = ShowPage.Password;
            IconShow1.BackgroundImage = Document_management_system.Properties.Resources.睁眼;
            IconShow2.BackgroundImage = Document_management_system.Properties.Resources.睁眼;
            IconShow3.BackgroundImage = Document_management_system.Properties.Resources.睁眼;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            作者个人资料 form2 = new 作者个人资料();
            form2.Show();
            this.Close();
        }

        private void BtnOk_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFresh.Text))
            {
                if (txtFresh.Text != txtOriginal.Text)
                {
                    if (!String.IsNullOrEmpty(txtRefresh.Text))
                    {
                        if (txtFresh.Text == txtRefresh.Text)
                        {
                            s.SqlChangePassword(ShowPage.Account, txtFresh.Text);
                            txtOriginal.Text = ShowPage.Password;
                        }
                        else MessageBox.Show("两次输入需相同！", "提示");
                    }
                    else MessageBox.Show("请再次输入密码！");
                }
                else MessageBox.Show("新密码不能与旧密码相同！");
            }
            else MessageBox.Show("新密码不能为空！");
        }

        private void IconShow1_Click(object sender, EventArgs e)
        {
            if (fals == true)
            {
                // 切换密码显示状态
                txtOriginal.PasswordChar = '\0'; // 显示密码

                // 切换图标
                IconShow1.BackgroundImage = Document_management_system.Properties.Resources.睁眼; // 显示显示密码的图标

                fals = false;
            }
            else
            {
                // 切换密码显示状态
                txtOriginal.PasswordChar = '*'; // 隐藏密码

                // 切换图标
                IconShow1.BackgroundImage = Document_management_system.Properties.Resources.闭眼; // 显示隐藏密码的图标

                fals = true;
            }
        }

        private void IconShow2_Click(object sender, EventArgs e)
        {
            if (fals == true)
            {
                // 切换密码显示状态
                txtRefresh.PasswordChar = '\0'; // 显示密码

                // 切换图标
                IconShow2.BackgroundImage = Document_management_system.Properties.Resources.睁眼; // 显示显示密码的图标

                fals = false;
            }
            else
            {
                // 切换密码显示状态
                txtRefresh.PasswordChar = '*'; // 隐藏密码

                // 切换图标
                IconShow2.BackgroundImage = Document_management_system.Properties.Resources.闭眼; // 显示隐藏密码的图标

                fals = true;
            }
        }

        private void IconShow3_Click(object sender, EventArgs e)
        {
            if (fals == true)
            {
                // 切换密码显示状态
                txtFresh.PasswordChar = '\0'; // 显示密码

                // 切换图标
                IconShow3.BackgroundImage = Document_management_system.Properties.Resources.睁眼; // 显示显示密码的图标

                fals = false;
            }
            else
            {
                // 切换密码显示状态
                txtFresh.PasswordChar = '*'; // 隐藏密码

                // 切换图标
                IconShow3.BackgroundImage = Document_management_system.Properties.Resources.闭眼; // 显示隐藏密码的图标

                fals = true;
            }
        }
    }

}
