using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Document_management_system
{
    public partial class 作者投稿 : Form
    {
        public 作者投稿()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            作者主页面 form1 = new();
            form1.Show();
    }

        private void Clean()
        {
            txtName.Clear();
            txtType.Text="";
            textBox1.Clear();
        }

        private void UpLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog.FileName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer(2000);
            string FileName = textBox1.Text;
            if (!String.IsNullOrEmpty(txtName.Text)&& !String.IsNullOrEmpty(txtType.Text))
            {
                try
                {
                    WebClient client = new WebClient();
                    string NewFileName = txtName.Text + ".docx";
                    string url = "D:\\文章\\稿件管理\\学生稿件上传\\" + NewFileName;
                    byte[] res = client.UploadFile(url, FileName);
                    Status.Text = "上传成功";
                    Status.Visible = true;
                    SaveArticle(txtName.Text, ShowPage.User, txtType.Text, url);
                    Clean();
                }
                catch
                {
                    Status.Text = "上传失败，请检查文件";
                    Status.Visible = true;
                }
            }
            else { MessageBox.Show("请输入保存名称和类型！"); }
        }

        public void SaveArticle(string Name, string organi, string type, string url)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
            conn.Open();
            string sql1 = "INSERT INTO Article (article,organization,url,type) VALUES ('";
            string sql2 = Name + "','" + organi + "','" + url + "','" + type + "')";
            string sql = sql1 + sql2;
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
        }
    }
}
