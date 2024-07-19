using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_management_system
{
    public partial class 编辑决定稿件去留 : Form
    {
        public 编辑查看稿件状态 form2 = new();
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

        public void ChoiceGo(string state)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                conn.Open();
                string sql = "UPDATE Article SET status = '" + state + "',BackAdvice = '" + ArtPage.Advice + "' WHERE article ='" + ArtPage.Article + "'";
                string sql2 = "DELETE FROM Back WHERE article ='" + ArtPage.Article + "'";
                SqlCommand cmd = new SqlCommand(sql);
                SqlCommand cmd2 = new SqlCommand(sql2);
                cmd2.Connection = conn;
                cmd2.ExecuteNonQuery();
                cmd.Connection = conn;
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    MessageBox.Show(state + "成功！", "提示");
                }
                else
                {
                    MessageBox.Show(state + "失败！", "提示");
                }
            }
            catch { MessageBox.Show("出错！"); }
        }

        private void btnHired_Click(object sender, EventArgs e)
        {
            ChoiceGo("录取");
            btnHired.Enabled = false;
            btnRejection.Enabled = false;

        }

        private void btnRejection_Click(object sender, EventArgs e)
        {
            ChoiceGo("退回");
            btnHired.Enabled = false;
            btnRejection.Enabled = false;
        }
    }
}
