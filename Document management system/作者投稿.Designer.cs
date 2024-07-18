namespace Document_management_system
{
    partial class 作者投稿
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
            lblName = new Label();
            lbl2 = new Label();
            lblStyle = new Label();
            txtName = new TextBox();
            btnSubmit = new Button();
            Close = new Button();
            UpLoad = new Button();
            txtType = new ComboBox();
            textBox1 = new TextBox();
            Status = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("宋体", 12F);
            lbl1.Location = new Point(15, 31);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(130, 24);
            lbl1.TabIndex = 0;
            lbl1.Text = "组织名称：";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("宋体", 12F);
            lblName.Location = new Point(130, 31);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(58, 24);
            lblName.TabIndex = 1;
            lblName.Text = "名称";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 13.8F);
            lbl2.Location = new Point(181, 136);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(152, 28);
            lbl2.TabIndex = 2;
            lbl2.Text = "稿件名称：";
            // 
            // lblStyle
            // 
            lblStyle.AutoSize = true;
            lblStyle.Font = new Font("宋体", 13.8F);
            lblStyle.Location = new Point(226, 221);
            lblStyle.Margin = new Padding(4, 0, 4, 0);
            lblStyle.Name = "lblStyle";
            lblStyle.Size = new Size(96, 28);
            lblStyle.TabIndex = 3;
            lblStyle.Text = "类型：";
            // 
            // txtName
            // 
            txtName.Font = new Font("宋体", 13.8F);
            txtName.Location = new Point(353, 136);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 39);
            txtName.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSubmit.Location = new Point(552, 485);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(115, 48);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "提交";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(776, 14);
            Close.Margin = new Padding(4);
            Close.Name = "Close";
            Close.Size = new Size(65, 61);
            Close.TabIndex = 8;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // UpLoad
            // 
            UpLoad.BackgroundImage = Properties.Resources.上传;
            UpLoad.BackgroundImageLayout = ImageLayout.Stretch;
            UpLoad.Location = new Point(343, 339);
            UpLoad.Name = "UpLoad";
            UpLoad.Size = new Size(202, 194);
            UpLoad.TabIndex = 9;
            UpLoad.UseVisualStyleBackColor = true;
            UpLoad.Click += UpLoad_Click;
            // 
            // txtType
            // 
            txtType.FormattingEnabled = true;
            txtType.Items.AddRange(new object[] { "新闻稿", "通知" });
            txtType.Location = new Point(352, 217);
            txtType.Name = "txtType";
            txtType.Size = new Size(182, 32);
            txtType.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 303);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(480, 30);
            textBox1.TabIndex = 11;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Status.Location = new Point(48, 544);
            Status.Name = "Status";
            Status.Size = new Size(62, 31);
            Status.TabIndex = 12;
            Status.Text = "状态";
            Status.Visible = false;
            // 
            // 作者投稿
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 600);
            Controls.Add(Status);
            Controls.Add(textBox1);
            Controls.Add(txtType);
            Controls.Add(UpLoad);
            Controls.Add(Close);
            Controls.Add(btnSubmit);
            Controls.Add(txtName);
            Controls.Add(lblStyle);
            Controls.Add(lbl2);
            Controls.Add(lblName);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "作者投稿";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "作者投稿";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lblName;
        private Label lbl2;
        private Label lblStyle;
        private TextBox txtName;
        private Button btnSubmit;
        private Button Close;
        private Button UpLoad;
        private ComboBox txtType;
        private TextBox textBox1;
        private Label Status;
    }
}