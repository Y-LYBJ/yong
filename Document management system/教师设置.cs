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
    public partial class 教师设置 : Form
    {
        public 教师设置()
        {
            InitializeComponent();
        }

        private void BtnScheduling_Click(object sender, EventArgs e)
        {
            教师设置期数 form3 = new 教师设置期数();
            this.Hide();//隐藏当前窗体
            form3.ShowDialog();
        }

        private void BtnRegistered_Click(object sender, EventArgs e)
        {
            教师注册账号 form1 = new 教师注册账号();
            this.Hide();//隐藏当前窗体
            form1.ShowDialog();
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            教师管理账号 form2 = new 教师管理账号();
            this.Hide();//隐藏当前窗体
            form2.ShowDialog();
        }
    }
}
