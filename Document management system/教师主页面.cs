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

        private void btnSet_Click(object sender, EventArgs e)
        {

        }

        private void 教师主页面_Load(object sender, EventArgs e)
        {
            tipSet.SetToolTip(BtnSet, "设置");

        }
    }
}
