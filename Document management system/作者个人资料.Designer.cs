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
            textBox1 = new TextBox();
            BtnInformation = new Button();
            BtnPassword = new Button();
            SuspendLayout();
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(641, 12);
            Close.Name = "Close";
            Close.Size = new Size(47, 48);
            Close.TabIndex = 0;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("宋体", 13.8F);
            lbl1.Location = new Point(143, 88);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(125, 23);
            lbl1.TabIndex = 1;
            lbl1.Text = "组织名称：";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 13.8F);
            lbl2.Location = new Point(189, 140);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(79, 23);
            lbl2.TabIndex = 2;
            lbl2.Text = "账号：";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("宋体", 13.8F);
            lbl3.Location = new Point(143, 192);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(125, 23);
            lbl3.TabIndex = 3;
            lbl3.Text = "所属级别：";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("宋体", 13.8F);
            lbl4.Location = new Point(143, 236);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(125, 23);
            lbl4.TabIndex = 4;
            lbl4.Text = "组织简介：";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("宋体", 12F);
            lblName.Location = new Point(274, 91);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 5;
            lblName.Text = "名称";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("宋体", 12F);
            lblAccount.Location = new Point(274, 143);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(49, 20);
            lblAccount.TabIndex = 6;
            lblAccount.Text = "账号";
            // 
            // lblLeval
            // 
            lblLeval.AutoSize = true;
            lblLeval.Font = new Font("宋体", 12F);
            lblLeval.Location = new Point(274, 195);
            lblLeval.Name = "lblLeval";
            lblLeval.Size = new Size(49, 20);
            lblLeval.TabIndex = 7;
            lblLeval.Text = "级别";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            textBox1.Location = new Point(274, 237);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 138);
            textBox1.TabIndex = 8;
            textBox1.Text = "（100字）";
            // 
            // BtnInformation
            // 
            BtnInformation.Font = new Font("黑体", 13.8F);
            BtnInformation.Location = new Point(146, 407);
            BtnInformation.Name = "BtnInformation";
            BtnInformation.Size = new Size(124, 35);
            BtnInformation.TabIndex = 9;
            BtnInformation.Text = "修改资料";
            BtnInformation.UseVisualStyleBackColor = true;
            // 
            // BtnPassword
            // 
            BtnPassword.Font = new Font("黑体", 13.8F);
            BtnPassword.Location = new Point(408, 407);
            BtnPassword.Name = "BtnPassword";
            BtnPassword.Size = new Size(121, 35);
            BtnPassword.TabIndex = 10;
            BtnPassword.Text = "更改密码";
            BtnPassword.UseVisualStyleBackColor = true;
            // 
            // 作者个人资料
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(BtnPassword);
            Controls.Add(BtnInformation);
            Controls.Add(textBox1);
            Controls.Add(lblLeval);
            Controls.Add(lblAccount);
            Controls.Add(lblName);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "作者个人资料";
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
        private TextBox textBox1;
        private Button BtnInformation;
        private Button BtnPassword;
    }
}