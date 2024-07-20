namespace Document_management_system
{
    partial class 教师设置期数
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            Close = new Button();
            btnAddIssue = new Button();
            dateTimePickerLastPublishedDate = new DateTimePicker();
            numericUpDownIssuesCount = new NumericUpDown();
            comboBoxPublicationFrequency = new ComboBox();
            btnSaveFrequency = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIssuesCount).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("黑体", 12F);
            lbl1.Location = new Point(140, 64);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(130, 24);
            lbl1.TabIndex = 1;
            lbl1.Text = "期刊类型：";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("黑体", 12F);
            lbl2.Location = new Point(68, 135);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(202, 24);
            lbl2.TabIndex = 2;
            lbl2.Text = "当前总发表期数：";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("黑体", 12F);
            lbl3.Location = new Point(44, 214);
            lbl3.Margin = new Padding(4, 0, 4, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(226, 24);
            lbl3.TabIndex = 3;
            lbl3.Text = "最新一期发布日期：";
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(627, 13);
            Close.Margin = new Padding(4);
            Close.Name = "Close";
            Close.Size = new Size(43, 41);
            Close.TabIndex = 6;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // btnAddIssue
            // 
            btnAddIssue.Font = new Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAddIssue.Location = new Point(278, 300);
            btnAddIssue.Margin = new Padding(4);
            btnAddIssue.Name = "btnAddIssue";
            btnAddIssue.Size = new Size(115, 43);
            btnAddIssue.TabIndex = 7;
            btnAddIssue.Text = "增刊";
            btnAddIssue.UseVisualStyleBackColor = true;
            btnAddIssue.Click += btnAddIssue_Click;
            // 
            // dateTimePickerLastPublishedDate
            // 
            dateTimePickerLastPublishedDate.Enabled = false;
            dateTimePickerLastPublishedDate.Font = new Font("黑体", 12F);
            dateTimePickerLastPublishedDate.Location = new Point(278, 209);
            dateTimePickerLastPublishedDate.Margin = new Padding(4);
            dateTimePickerLastPublishedDate.Name = "dateTimePickerLastPublishedDate";
            dateTimePickerLastPublishedDate.Size = new Size(305, 35);
            dateTimePickerLastPublishedDate.TabIndex = 8;
            dateTimePickerLastPublishedDate.Value = new DateTime(2024, 7, 20, 15, 19, 0, 0);
            // 
            // numericUpDownIssuesCount
            // 
            numericUpDownIssuesCount.Enabled = false;
            numericUpDownIssuesCount.Font = new Font("黑体", 12F);
            numericUpDownIssuesCount.Location = new Point(283, 135);
            numericUpDownIssuesCount.Margin = new Padding(4);
            numericUpDownIssuesCount.Name = "numericUpDownIssuesCount";
            numericUpDownIssuesCount.Size = new Size(183, 35);
            numericUpDownIssuesCount.TabIndex = 9;
            // 
            // comboBoxPublicationFrequency
            // 
            comboBoxPublicationFrequency.Font = new Font("黑体", 12F);
            comboBoxPublicationFrequency.FormattingEnabled = true;
            comboBoxPublicationFrequency.Items.AddRange(new object[] { "月刊", "半月刊", "旬刊", "周刊" });
            comboBoxPublicationFrequency.Location = new Point(281, 64);
            comboBoxPublicationFrequency.Margin = new Padding(4);
            comboBoxPublicationFrequency.Name = "comboBoxPublicationFrequency";
            comboBoxPublicationFrequency.Size = new Size(184, 32);
            comboBoxPublicationFrequency.TabIndex = 10;
            // 
            // btnSaveFrequency
            // 
            btnSaveFrequency.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSaveFrequency.Location = new Point(507, 64);
            btnSaveFrequency.Margin = new Padding(4);
            btnSaveFrequency.Name = "btnSaveFrequency";
            btnSaveFrequency.Size = new Size(76, 35);
            btnSaveFrequency.TabIndex = 11;
            btnSaveFrequency.Text = "确定";
            btnSaveFrequency.UseVisualStyleBackColor = true;
            btnSaveFrequency.Click += btnSaveFrequency_Click;
            // 
            // 教师设置期数
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 395);
            Controls.Add(btnSaveFrequency);
            Controls.Add(comboBoxPublicationFrequency);
            Controls.Add(numericUpDownIssuesCount);
            Controls.Add(dateTimePickerLastPublishedDate);
            Controls.Add(btnAddIssue);
            Controls.Add(Close);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "教师设置期数";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "教师设置期数";
            ((System.ComponentModel.ISupportInitialize)numericUpDownIssuesCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Button Close;
        private Button btnAddIssue;
        private DateTimePicker dateTimePickerLastPublishedDate;
        private NumericUpDown numericUpDownIssuesCount;
        private ComboBox comboBoxPublicationFrequency;
        private Button btnSaveFrequency;
    }
}