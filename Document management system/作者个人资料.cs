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
    public partial class 作者个人资料 : Form
    {
        public 作者个人资料()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            作者修改资料 form3 = new 作者修改资料();
            this.Hide();//隐藏当前窗体
            form3.ShowDialog();
            Application.ExitThread();
        }

        private void BtnPassword_Click(object sender, EventArgs e)
        {
            作者更改密码 form4 = new 作者更改密码();
            this.Hide();//隐藏当前窗体
            form4.ShowDialog();
            Application.ExitThread();
        }
    }
}
