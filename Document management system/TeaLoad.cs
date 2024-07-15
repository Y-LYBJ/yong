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
        public TeaLoad()
        {
            InitializeComponent();
        }

        private void Tea_load_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Account.Text) && !String.IsNullOrEmpty(Password.Text))
            {  //非空检验
                SQLpromgram s = new();
                if (s.SqlLoad(Account.Text, Password.Text,"教师"))
                {
                    MessageBox.Show("登录成功！", "提示");
                    w1 = new 教师主页面();
                    w1.Show();
                    this.Hide();
                }
                else MessageBox.Show("账号或密码错误");
            }
            else MessageBox.Show("输入不能为空！"); 
        }




    }


}
