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
            form1.Show();
            this.Hide();
        }

        private void BtnState_Click(object sender, EventArgs e)
        {
            编辑查看稿件状态 form2 = new();
            form2.Show();
            this.Hide();
        }
    }
}
