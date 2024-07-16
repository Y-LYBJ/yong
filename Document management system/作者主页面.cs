﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_management_system
{
    public partial class 作者主页面 : Form
    {
        public 作者主页面()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            作者个人资料 form2 = new 作者个人资料();
            this.Hide();//隐藏当前窗体
            form2.ShowDialog();
            Application.ExitThread(); //退出当前窗体，这一步很重要，否则最后可能无法将所有进程关闭。最好是在跳转页面后，将之前的页面退出。

        }
    }
}
