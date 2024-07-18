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

namespace Document_management_system
{
    public partial class 主编审查稿件 : Form
    {
        private string filePath = "你的文件路径"; // 假设文件路径在这里定义

        public 主编审查稿件()
        {
            InitializeComponent();
            RtxtArtical.TextChanged += RtxtArtical_TextChanged; // 绑定TextChanged事件
        }

        private void RtxtArtical_TextChanged(object sender, EventArgs e)
        {
            const int bufferSize = 100; // 每次读取的字节数
            const int charBufferLength = 1024; // 初始字符缓冲区长度
            byte[] byData = new byte[bufferSize];
            StringBuilder charDataBuilder = new StringBuilder(charBufferLength); // 使用StringBuilder来动态扩展字符数据

            try
            {
                FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                file.Seek(0, SeekOrigin.Begin);

                Decoder d = Encoding.UTF8.GetDecoder();

                while (true)
                {
                    int bytesRead = file.Read(byData, 0, bufferSize);
                    if (bytesRead == 0)
                        break; // 文件读取完毕

                    char[] charBuffer = new char[charBufferLength];
                    int charsDecoded = d.GetChars(byData, 0, bytesRead, charBuffer, 0);

                    charDataBuilder.Append(charBuffer, 0, charsDecoded);
                }

                RtxtArtical.Text = charDataBuilder.ToString();
                file.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
