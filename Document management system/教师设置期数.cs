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
    public partial class 教师设置期数 : Form
    {
        public 教师设置期数()
        {
            InitializeComponent();
            NowYear.Text = System.DateTime.Now.Year.ToString();
        }
    }
}
