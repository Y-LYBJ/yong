using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Metadata;
using Word = Microsoft.Office.Interop.Word;
using System.Data.SqlClient;

namespace Document_management_system
{
    public partial class 主编审查稿件 : Form
    {
        private string filePath = ArtPage.Path; // 假设文件路径在这里定义

        public 主编审查稿件()
        {
            InitializeComponent();
            ArtShow(filePath);
        }

        private void ArtShow(string fileName)
        {
            Word.Application app = new Word.Application();//可以打开word
            Word.Document doc = null;      //需要记录打开的word

            object missing = System.Reflection.Missing.Value;
            object File = fileName;
            object readOnly = true;//只读
            object isVisible = true;

            object unknow = Type.Missing;

            try
            {
                doc = app.Documents.Open(ref File, ref missing, ref readOnly,
                 ref missing, ref missing, ref missing, ref missing, ref missing,
                 ref missing, ref missing, ref missing, ref isVisible, ref missing,
                 ref missing, ref missing, ref missing);

                RtxtArtical.Text = doc.Content.Text;//richTextBox1.Text = doc.Content.Text;//显示无格式数据
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close(ref missing, ref missing, ref missing);
                    doc = null;
                }

                if (app != null)
                {
                    app.Quit(ref missing, ref missing, ref missing);
                    app = null;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            主编主页面 w1 = new();
            w1.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtReview.Text))
            {
                if (MessageBox.Show("确定提交审核意见吗，提交后不可修改","提示",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = "Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456";
                        conn.Open();
                        string sql = "UPDATE Back SET advice = '" + txtReview.Text + "',checkState = '已审核' where article= '" + ArtPage.Article + "'";
                        SqlCommand cmd = new SqlCommand(sql);
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("意见提交成功");
                        btnOk.Enabled = false;
                        txtReview.ReadOnly = true;
                    }
                    catch { MessageBox.Show("请输入正确的文字信息！"); }
                }
            }
            else
            {
                MessageBox.Show("请输入您的审核意见！", "提醒");
            }
        }
    }
}
