namespace Document_management_system
{
    partial class StuLoad
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
            autior = new Button();
            button3 = new Button();
            button1 = new Button();
            IconShow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)IconShow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(46, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 31);
            label1.TabIndex = 0;
            label1.Text = "账号：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(46, 109);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 31);
            label2.TabIndex = 1;
            label2.Text = "密码：";
            // 
            // Account
            // 
            Account.Location = new Point(132, 53);
            Account.Margin = new Padding(2);
            Account.Name = "Account";
            Account.Size = new Size(287, 27);
            Account.TabIndex = 2;
            // 
            // Password
            // 
            Password.Location = new Point(132, 114);
            Password.Margin = new Padding(2);
            Password.Name = "Password";
            Password.Size = new Size(287, 27);
            Password.TabIndex = 3;
            // 
            // autior
            // 
            autior.BackgroundImage = Properties.Resources.闭眼;
            autior.FlatStyle = FlatStyle.Popup;
            autior.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            autior.Location = new Point(46, 172);
            autior.Margin = new Padding(2);
            autior.Name = "autior";
            autior.Size = new Size(108, 37);
            autior.TabIndex = 5;
            autior.Text = "作者登录";
            autior.Click += autior_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button3.Location = new Point(310, 172);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(108, 37);
            button3.TabIndex = 6;
            button3.Text = "主编登录";
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(181, 172);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(108, 37);
            button1.TabIndex = 7;
            button1.Text = "编辑登录";
            button1.Click += button1_Click;
            // 
            // IconShow
            // 
            IconShow.BackgroundImage = Properties.Resources.闭眼;
            IconShow.BackgroundImageLayout = ImageLayout.Stretch;
            IconShow.Location = new Point(424, 114);
            IconShow.Name = "IconShow";
            IconShow.Size = new Size(40, 31);
            IconShow.TabIndex = 8;
            IconShow.TabStop = false;
            IconShow.Click += IconShow_Click;
            // 
            // StuLoad
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 247);
            Controls.Add(IconShow);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(autior);
            Controls.Add(Password);
            Controls.Add(Account);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "StuLoad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学生端登录";
            ((System.ComponentModel.ISupportInitialize)IconShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Account;
        private TextBox Password;
        private Button autior;
        private Button button3;
        private Button button1;
        private PictureBox IconShow;
    }
}