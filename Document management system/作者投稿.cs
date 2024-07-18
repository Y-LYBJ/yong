using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
