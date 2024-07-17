using System;
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
            User.Text = ShowPage.User;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            作者个人资料 form2 = new 作者个人资料();
            this.Close();//关闭当前窗体
            form2.Show();

        }

        private void BtnSubmission_Click(object sender, EventArgs e)
        {
            作者投稿 form5 = new 作者投稿();
            this.Close();//关闭当前窗体
            form5.ShowDialog();
        }

        private void BtnInquire_Click(object sender, EventArgs e)
        {
            作者查询稿件 form1 = new();
            this.Close();
            form1.ShowDialog();
        }
    }
}
