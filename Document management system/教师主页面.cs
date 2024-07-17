using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Document_management_system
{
    public partial class 教师主页面 : Form
    {
        public 教师主页面()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            教师设置 form4 = new 教师设置();
            this.Hide();//隐藏当前窗体
            form4.ShowDialog();
        }

        private void 教师主页面_Load(object sender, EventArgs e)
        {
            tipSet.SetToolTip(BtnSet, "设置");

        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            教师查看已录用稿件 form1 = new 教师查看已录用稿件();
            this.Hide();//隐藏当前窗体
            form1.ShowDialog();
        }

        private void BtnScheduling_Click(object sender, EventArgs e)
        {
            教师决定排期 form2 = new 教师决定排期();
            this.Hide();//隐藏当前窗体
            form2.ShowDialog();
        }

        private void BtnManageManuscript_Click(object sender, EventArgs e)
        {
            教师管理稿件 form3 = new 教师管理稿件();
            this.Hide();//隐藏当前窗体
            form3.ShowDialog();
        }
    }
}
