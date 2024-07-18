﻿using System;
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
        private Boolean fals = true; // 定义一个布尔变量用于控制图片和密码显示状态
        public StuLoad()
        {
            InitializeComponent();
            IconShow.BackgroundImage = Document_management_system.Properties.Resources.闭眼; // 默认显示隐藏密码的图标
        }

        public void load_all(string id)
        {
            if (!String.IsNullOrEmpty(Account.Text) && !String.IsNullOrEmpty(Password.Text))
            {  //非空检验
                SQLpromgram s = new();
                if (s.SqlLoad(Account.Text, Password.Text, id))
                {
                    MessageBox.Show("登录成功！", "提示");
                    w1 = new 作者主页面();
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

        private void autior_Click(object sender, EventArgs e)
        {
            load_all("作者");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_all("编辑");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load_all("教师");
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
