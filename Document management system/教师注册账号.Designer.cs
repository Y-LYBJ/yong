namespace Document_management_system
{
    partial class 教师注册账号
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
            txtAccount = new TextBox();
            txtName = new TextBox();
            lbl4 = new Label();
            Close = new Button();
            BtnEnroll = new Button();
            txtLevel = new ComboBox();
            txtIdentity = new ComboBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("宋体", 13.8F);
            lbl1.Location = new Point(306, 110);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(96, 28);
            lbl1.TabIndex = 0;
            lbl1.Text = "账号：";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 13.8F);
            lbl2.Location = new Point(249, 167);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(152, 28);
            lbl2.TabIndex = 1;
            lbl2.Text = "组织名称：";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("宋体", 13.8F);
            lbl3.Location = new Point(249, 227);
            lbl3.Margin = new Padding(4, 0, 4, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(152, 28);
            lbl3.TabIndex = 2;
            lbl3.Text = "所属级别：";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(439, 112);
            txtAccount.Margin = new Padding(4);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(267, 30);
            txtAccount.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(439, 167);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 30);
            txtName.TabIndex = 4;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("宋体", 13.8F);
            lbl4.Location = new Point(306, 286);
            lbl4.Margin = new Padding(4, 0, 4, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(96, 28);
            lbl4.TabIndex = 6;
            lbl4.Text = "身份：";
            // 
            // Close
            // 
            Close.Location = new Point(838, 34);
            Close.Margin = new Padding(4);
            Close.Name = "Close";
            Close.Size = new Size(115, 35);
            Close.TabIndex = 8;
            Close.Text = "关闭";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // BtnEnroll
            // 
            BtnEnroll.Location = new Point(612, 385);
            BtnEnroll.Margin = new Padding(4);
            BtnEnroll.Name = "BtnEnroll";
            BtnEnroll.Size = new Size(115, 35);
            BtnEnroll.TabIndex = 9;
            BtnEnroll.Text = "注册";
            BtnEnroll.UseVisualStyleBackColor = true;
            BtnEnroll.Click += BtnEnroll_Click;
            // 
            // txtLevel
            // 
            txtLevel.FormattingEnabled = true;
            txtLevel.Items.AddRange(new object[] { "校级", "院级", "社团" });
            txtLevel.Location = new Point(439, 223);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(182, 32);
            txtLevel.TabIndex = 12;
            // 
            // txtIdentity
            // 
            txtIdentity.FormattingEnabled = true;
            txtIdentity.Items.AddRange(new object[] { "作者", "编辑", "主编" });
            txtIdentity.Location = new Point(439, 282);
            txtIdentity.Name = "txtIdentity";
            txtIdentity.Size = new Size(182, 32);
            txtIdentity.TabIndex = 13;
            txtIdentity.SelectedIndexChanged += txtIdentity_SelectedIndexChanged;
            // 
            // 教师注册账号
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 540);
            Controls.Add(txtIdentity);
            Controls.Add(txtLevel);
            Controls.Add(BtnEnroll);
            Controls.Add(Close);
            Controls.Add(lbl4);
            Controls.Add(txtName);
            Controls.Add(txtAccount);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "教师注册账号";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "教师注册账号";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private TextBox txtAccount;
        private TextBox txtName;
        private Label lbl4;
        private Button Close;
        private Button BtnEnroll;
        private ComboBox txtLevel;
        private ComboBox txtIdentity;
    }
}