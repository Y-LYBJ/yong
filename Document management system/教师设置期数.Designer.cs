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
            lbl1.Location = new Point(76, 87);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(149, 20);
            lbl1.TabIndex = 1;
            lbl1.Text = "期刊发布频率：";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("黑体", 12F);
            lbl2.Location = new Point(37, 144);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(189, 20);
            lbl2.TabIndex = 2;
            lbl2.Text = "当前累计发表期数：";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("黑体", 12F);
            lbl3.Location = new Point(37, 210);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(189, 20);
            lbl3.TabIndex = 3;
            lbl3.Text = "最新一期发布日期：";
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(554, 12);
            Close.Name = "Close";
            Close.Size = new Size(55, 44);
            Close.TabIndex = 6;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // btnAddIssue
            // 
            btnAddIssue.Font = new Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAddIssue.Location = new Point(250, 350);
            btnAddIssue.Name = "btnAddIssue";
            btnAddIssue.Size = new Size(94, 36);
            btnAddIssue.TabIndex = 7;
            btnAddIssue.Text = "增刊";
            btnAddIssue.UseVisualStyleBackColor = true;
            btnAddIssue.Click += btnAddIssue_Click;
            // 
            // dateTimePickerLastPublishedDate
            // 
            dateTimePickerLastPublishedDate.Font = new Font("黑体", 12F);
            dateTimePickerLastPublishedDate.Location = new Point(228, 206);
            dateTimePickerLastPublishedDate.Name = "dateTimePickerLastPublishedDate";
            dateTimePickerLastPublishedDate.Size = new Size(250, 30);
            dateTimePickerLastPublishedDate.TabIndex = 8;
            // 
            // numericUpDownIssuesCount
            // 
            numericUpDownIssuesCount.Font = new Font("黑体", 12F);
            numericUpDownIssuesCount.Location = new Point(232, 144);
            numericUpDownIssuesCount.Name = "numericUpDownIssuesCount";
            numericUpDownIssuesCount.Size = new Size(150, 30);
            numericUpDownIssuesCount.TabIndex = 9;
            // 
            // comboBoxPublicationFrequency
            // 
            comboBoxPublicationFrequency.Font = new Font("黑体", 12F);
            comboBoxPublicationFrequency.FormattingEnabled = true;
            comboBoxPublicationFrequency.Items.AddRange(new object[] { "月刊", "半月刊", "旬刊", "周刊" });
            comboBoxPublicationFrequency.Location = new Point(231, 85);
            comboBoxPublicationFrequency.Name = "comboBoxPublicationFrequency";
            comboBoxPublicationFrequency.Size = new Size(151, 28);
            comboBoxPublicationFrequency.TabIndex = 10;
            // 
            // btnSaveFrequency
            // 
            btnSaveFrequency.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSaveFrequency.Location = new Point(416, 85);
            btnSaveFrequency.Name = "btnSaveFrequency";
            btnSaveFrequency.Size = new Size(62, 29);
            btnSaveFrequency.TabIndex = 11;
            btnSaveFrequency.Text = "保存";
            btnSaveFrequency.UseVisualStyleBackColor = true;
            btnSaveFrequency.Click += btnSaveFrequency_Click;
            // 
            // 教师设置期数
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 442);
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