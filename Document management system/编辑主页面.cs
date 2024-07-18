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
    public partial class 编辑主页面 : Form
    {
        public 编辑主页面()
        {
            InitializeComponent();
            ///    Application.OpenForms["LoadChoice"].Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPending_Click(object sender, EventArgs e)
        {
            编辑待处理稿件 form1 = new();
            form1.ShowDialog();
            this.Close();
        }

        private void LblPassword_Click(object sender, EventArgs e)
        {
            编辑更改密码 form3 = new 编辑更改密码();
            this.Hide();//隐藏当前窗体
            form3.ShowDialog();
        }
    }
}
