namespace Document_management_system
{
    partial class 作者个人资料
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
            Close = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lblName = new Label();
            lblAccount = new Label();
            lblLeval = new Label();
            lblDescreption = new TextBox();
            BtnInformation = new Button();
            BtnPassword = new Button();
            SuspendLayout();
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(783, 14);
            Close.Margin = new Padding(4);
            Close.Name = "Close";
            Close.Size = new Size(57, 58);
            Close.TabIndex = 0;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("宋体", 13.8F);
            lbl1.Location = new Point(175, 106);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(152, 28);
            lbl1.TabIndex = 1;
            lbl1.Text = "组织名称：";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 13.8F);
            lbl2.Location = new Point(231, 168);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(96, 28);
            lbl2.TabIndex = 2;
            lbl2.Text = "账号：";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("宋体", 13.8F);
            lbl3.Location = new Point(175, 230);
            lbl3.Margin = new Padding(4, 0, 4, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(152, 28);
            lbl3.TabIndex = 3;
            lbl3.Text = "所属级别：";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("宋体", 13.8F);
            lbl4.Location = new Point(175, 283);
            lbl4.Margin = new Padding(4, 0, 4, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(152, 28);
            lbl4.TabIndex = 4;
            lbl4.Text = "组织简介：";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("宋体", 12F);
            lblName.Location = new Point(335, 109);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(58, 24);
            lblName.TabIndex = 5;
            lblName.Text = "名称";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("宋体", 12F);
            lblAccount.Location = new Point(335, 172);
            lblAccount.Margin = new Padding(4, 0, 4, 0);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(58, 24);
            lblAccount.TabIndex = 6;
            lblAccount.Text = "账号";
            // 
            // lblLeval
            // 
            lblLeval.AutoSize = true;
            lblLeval.Font = new Font("宋体", 12F);
            lblLeval.Location = new Point(335, 234);
            lblLeval.Margin = new Padding(4, 0, 4, 0);
            lblLeval.Name = "lblLeval";
            lblLeval.Size = new Size(58, 24);
            lblLeval.TabIndex = 7;
            lblLeval.Text = "级别";
            // 
            // lblDescreption
            // 
            lblDescreption.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblDescreption.Location = new Point(335, 284);
            lblDescreption.Margin = new Padding(4);
            lblDescreption.Multiline = true;
            lblDescreption.Name = "lblDescreption";
            lblDescreption.Size = new Size(391, 165);
            lblDescreption.TabIndex = 8;
            lblDescreption.Text = "（100字）";
            // 
            // BtnInformation
            // 
            BtnInformation.Font = new Font("黑体", 13.8F);
            BtnInformation.Location = new Point(178, 488);
            BtnInformation.Margin = new Padding(4);
            BtnInformation.Name = "BtnInformation";
            BtnInformation.Size = new Size(152, 42);
            BtnInformation.TabIndex = 9;
            BtnInformation.Text = "修改简介";
            BtnInformation.UseVisualStyleBackColor = true;
            BtnInformation.Click += BtnInformation_Click;
            // 
            // BtnPassword
            // 
            BtnPassword.Font = new Font("黑体", 13.8F);
            BtnPassword.Location = new Point(499, 488);
            BtnPassword.Margin = new Padding(4);
            BtnPassword.Name = "BtnPassword";
            BtnPassword.Size = new Size(148, 42);
            BtnPassword.TabIndex = 10;
            BtnPassword.Text = "更改密码";
            BtnPassword.UseVisualStyleBackColor = true;
            BtnPassword.Click += BtnPassword_Click;
            // 
            // 作者个人资料
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 600);
            Controls.Add(BtnPassword);
            Controls.Add(BtnInformation);
            Controls.Add(lblDescreption);
            Controls.Add(lblLeval);
            Controls.Add(lblAccount);
            Controls.Add(lblName);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "作者个人资料";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "作者个人资料";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lblName;
        private Label lblAccount;
        private Label lblLeval;
        private TextBox lblDescreption;
        private Button BtnInformation;
        private Button BtnPassword;
    }
}