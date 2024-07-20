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
using static Document_management_system.SQLpromgram;

namespace Document_management_system
{
    public partial class 教师设置期数 : Form
    {
        private 教师设置 w1 = new();


        // 数据访问类实例，用于与数据库交互
        private PublicationDataAccess dataAccess;
        // 当前期刊设置的实体类实例，存储期刊的设置信息
        private PublicationSetting currentSetting;

        public 教师设置期数()
        {
            InitializeComponent();
            // 初始化数据访问类，传入数据库连接字符串
            dataAccess = new PublicationDataAccess("Data Source=192.168.1.6,1433;Initial Catalog=\"management system\";Integrated Security=True;User ID = sa;pwd = 123456");
            InitializeForm(); // 初始化窗体的其他设置
        }
        // 初始化窗体的设置
        private void InitializeForm()
        {
            // 从数据库加载当前设置
            currentSetting = dataAccess.GetPublicationSetting();
            if (currentSetting != null)
            {
                // 更新下拉列表的值
                comboBoxPublicationFrequency.SelectedItem = currentSetting.Frequency;
                // 设置累计发表期数和最新发表日期为只读
                numericUpDownIssuesCount.Value = currentSetting.PublishedIssuesCount;
                numericUpDownIssuesCount.Enabled = false; // 禁用控件

                dateTimePickerLastPublishedDate.Value = currentSetting.LastPublishedDate;
                dateTimePickerLastPublishedDate.Enabled = false; // 禁用控件

            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            w1.Show();
        }

        private void btnSaveFrequency_Click(object sender, EventArgs e)
        {
            btnSaveFrequency.Enabled = false;
            comboBoxPublicationFrequency.Enabled = false;
            // 更新数据库的逻辑
            currentSetting.Frequency = comboBoxPublicationFrequency.SelectedItem.ToString();
            MessageBox.Show("发表频率已更新。");
            switch (currentSetting.Frequency)
            {
                case "月刊":
                    currentSetting.LastPublishedDate = currentSetting.LastPublishedDate.AddMonths(1);
                    dateTimePickerLastPublishedDate.Value = currentSetting.LastPublishedDate;
                    break;
                case "半月刊":
                    currentSetting.LastPublishedDate = currentSetting.LastPublishedDate.AddDays(15);
                    dateTimePickerLastPublishedDate.Value = currentSetting.LastPublishedDate;
                    break;
                case "旬刊":
                    currentSetting.LastPublishedDate = currentSetting.LastPublishedDate.AddDays(10);
                    dateTimePickerLastPublishedDate.Value = currentSetting.LastPublishedDate;
                    break;
                case "周刊":
                    currentSetting.LastPublishedDate = currentSetting.LastPublishedDate.AddDays(7);
                    dateTimePickerLastPublishedDate.Value = currentSetting.LastPublishedDate;
                    break;
            }
        }

        private void btnAddIssue_Click(object sender, EventArgs e)
        {
            // 根据发表频率计算新的累计发表期数和最后发表日期
            currentSetting.PublishedIssuesCount++;
            // 更新数据库中的设置
            dataAccess.UpdatePublicationSetting(currentSetting);
            // 显示消息框提示用户已增加一期
            MessageBox.Show("已增加一期。");
            // 更新控件的值
            numericUpDownIssuesCount.Value = currentSetting.PublishedIssuesCount;
            dateTimePickerLastPublishedDate.Value = currentSetting.LastPublishedDate;
            btnSaveFrequency.Enabled = true;
            comboBoxPublicationFrequency.Enabled = true;
        }
    }
}
