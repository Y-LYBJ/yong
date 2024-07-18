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
    public partial class 作者修改资料 : Form
    {
        public SQLpromgram s = new();
        private
            作者个人资料 w1 = new();
            作者主页面 w2 = new();
        public 作者修改资料()
        {
            InitializeComponent();
            lblAccount.Text = ShowPage.Account;
            lblName.Text = ShowPage.User;
            lblLeval.Text = ShowPage.Level;
            lblDescreption.Text = ShowPage.Descreption;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            w1.Show();
            this.Close();
        }


        private void BtnOk_Click_1(object sender, EventArgs e)
        {
            if (lblDescreption.Text.Length > 100)
            {
                MessageBox.Show("简介字数不能超过100！", "提醒");
            }
            else
            {
                try
                {
                    s.SqlChangeDes(lblDescreption.Text);
                    MessageBox.Show("修改成功");
                    w2.Show();
                    this.Close();
                }
                catch { MessageBox.Show("修改失败..."); }
            }
        }
    }
}
