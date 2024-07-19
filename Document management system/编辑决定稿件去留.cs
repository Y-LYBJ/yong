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
    public partial class 编辑决定稿件去留 : Form
    {
        public 编辑决定稿件去留()
        {
            InitializeComponent();
            lblGroup.Text = ArtPage.Organize;
            lblName.Text = ArtPage.Article;
            lblType.Text = ArtPage.Type;
            txtReview.Text = ArtPage.Advice;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            编辑查看稿件状态 w1 = new();
            w1.Show();
        }
    }
}
