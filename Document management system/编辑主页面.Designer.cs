namespace Document_management_system
{
    partial class 编辑主页面
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
            lblEdit = new Label();
            BtnPending = new Button();
            BtnState = new Button();
            User = new Label();
            LblPassword = new Label();
            SuspendLayout();
            // 
            // Close
            // 
            Close.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Close.BackColor = SystemColors.ButtonHighlight;
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.FlatStyle = FlatStyle.Popup;
            Close.Location = new Point(560, 11);
            Close.Margin = new Padding(2);
            Close.Name = "Close";
            Close.Size = new Size(39, 36);
            Close.TabIndex = 1;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // lblEdit
            // 
            lblEdit.AutoSize = true;
            lblEdit.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblEdit.Location = new Point(12, 11);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(79, 23);
            lblEdit.TabIndex = 2;
            lblEdit.Text = "你好，";
            // 
            // BtnPending
            // 
            BtnPending.Font = new Font("黑体", 13.8F);
            BtnPending.Location = new Point(235, 130);
            BtnPending.Name = "BtnPending";
            BtnPending.Size = new Size(153, 51);
            BtnPending.TabIndex = 3;
            BtnPending.Text = "待处理稿件";
            BtnPending.UseVisualStyleBackColor = true;
            BtnPending.Click += BtnPending_Click;
            // 
            // BtnState
            // 
            BtnState.Font = new Font("黑体", 13.8F);
            BtnState.Location = new Point(235, 253);
            BtnState.Name = "BtnState";
            BtnState.Size = new Size(153, 51);
            BtnState.TabIndex = 4;
            BtnState.Text = "稿件状态";
            BtnState.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            User.Location = new Point(74, 11);
            User.Name = "User";
            User.Size = new Size(56, 23);
            User.TabIndex = 8;
            User.Text = "用户";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LblPassword.ForeColor = SystemColors.HotTrack;
            LblPassword.Location = new Point(479, 421);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(119, 20);
            LblPassword.TabIndex = 9;
            LblPassword.Text = "修改密码...";
            LblPassword.Click += LblPassword_Click;
            // 
            // 编辑主页面
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 450);
            Controls.Add(LblPassword);
            Controls.Add(User);
            Controls.Add(BtnState);
            Controls.Add(BtnPending);
            Controls.Add(lblEdit);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "编辑主页面";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "编辑主页面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private Label lblEdit;
        private Button BtnPending;
        private Button BtnState;
        private Label User;
        private Label LblPassword;
    }
}