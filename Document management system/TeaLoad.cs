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
            StuLoad load = new StuLoad();
            load.load_all("教师");
        }




    }


}
