namespace Document_management_system
{
    partial class TeaLoad
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
            label1 = new Label();
            label2 = new Label();
            Account = new TextBox();
            Password = new TextBox();
            Tea_load = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(56, 58);
            label1.Name = "label1";
            label1.Size = new Size(99, 36);
            label1.TabIndex = 0;
            label1.Text = "账号：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(56, 131);
            label2.Name = "label2";
            label2.Size = new Size(99, 36);
            label2.TabIndex = 1;
            label2.Text = "密码：";
            // 
            // Account
            // 
            Account.Location = new Point(161, 64);
            Account.Name = "Account";
            Account.Size = new Size(350, 30);
            Account.TabIndex = 2;
            // 
            // Password
            // 
            Password.Location = new Point(161, 137);
            Password.Name = "Password";
            Password.Size = new Size(350, 30);
            Password.TabIndex = 3;
            // 
            // Tea_load
            // 
            Tea_load.FlatStyle = FlatStyle.Popup;
            Tea_load.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Tea_load.Location = new Point(191, 207);
            Tea_load.Name = "Tea_load";
            Tea_load.Size = new Size(169, 54);
            Tea_load.TabIndex = 4;
            Tea_load.Text = "登录";
            Tea_load.Click += Tea_load_Click;
            // 
            // TeaLoad
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 296);
            Controls.Add(Tea_load);
            Controls.Add(Password);
            Controls.Add(Account);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TeaLoad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "教师端登录";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox Account;
        private TextBox Password;
        private Button Tea_load;
    }
}