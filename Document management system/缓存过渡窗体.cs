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
    public partial class 缓存过渡窗体 : Form
    {
        public 缓存过渡窗体()
        {
            InitializeComponent();
        }

        private void 缓存过渡窗体_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            主编审查稿件 w1 = new();
            this.Close();
            w1.Show();
        }
    }
}
