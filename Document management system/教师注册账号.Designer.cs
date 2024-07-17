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
            txtLeval = new TextBox();
            lbl4 = new Label();
            txtIdentity = new TextBox();
            button1 = new Button();
            BtnEnroll = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("宋体", 13.8F);
            lbl1.Location = new Point(250, 92);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(79, 23);
            lbl1.TabIndex = 0;
            lbl1.Text = "账号：";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 13.8F);
            lbl2.Location = new Point(204, 139);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(125, 23);
            lbl2.TabIndex = 1;
            lbl2.Text = "组织名称：";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("宋体", 13.8F);
            lbl3.Location = new Point(204, 189);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(125, 23);
            lbl3.TabIndex = 2;
            lbl3.Text = "所属级别：";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(359, 93);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(125, 27);
            txtAccount.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(359, 139);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            // 
            // txtLeval
            // 
            txtLeval.Location = new Point(359, 189);
            txtLeval.Name = "txtLeval";
            txtLeval.Size = new Size(125, 27);
            txtLeval.TabIndex = 5;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("宋体", 13.8F);
            lbl4.Location = new Point(250, 238);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(79, 23);
            lbl4.TabIndex = 6;
            lbl4.Text = "身份：";
            // 
            // txtIdentity
            // 
            txtIdentity.Location = new Point(359, 238);
            txtIdentity.Name = "txtIdentity";
            txtIdentity.Size = new Size(125, 27);
            txtIdentity.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(686, 28);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "关闭";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnEnroll
            // 
            BtnEnroll.Location = new Point(501, 321);
            BtnEnroll.Name = "BtnEnroll";
            BtnEnroll.Size = new Size(94, 29);
            BtnEnroll.TabIndex = 9;
            BtnEnroll.Text = "注册";
            BtnEnroll.UseVisualStyleBackColor = true;
            // 
            // 教师注册账号
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEnroll);
            Controls.Add(button1);
            Controls.Add(txtIdentity);
            Controls.Add(lbl4);
            Controls.Add(txtLeval);
            Controls.Add(txtName);
            Controls.Add(txtAccount);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox txtLeval;
        private Label lbl4;
        private TextBox txtIdentity;
        private Button button1;
        private Button BtnEnroll;
    }
}