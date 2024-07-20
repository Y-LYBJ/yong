namespace Document_management_system
{
    partial class 主编主页面
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
            lblChiefEditor = new Label();
            BtnCensor = new Button();
            BtnDrafting = new Button();
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
            Close.Location = new Point(684, 13);
            Close.Margin = new Padding(2);
            Close.Name = "Close";
            Close.Size = new Size(48, 43);
            Close.TabIndex = 0;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // lblChiefEditor
            // 
            lblChiefEditor.AutoSize = true;
            lblChiefEditor.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblChiefEditor.Location = new Point(15, 13);
            lblChiefEditor.Margin = new Padding(4, 0, 4, 0);
            lblChiefEditor.Name = "lblChiefEditor";
            lblChiefEditor.Size = new Size(96, 28);
            lblChiefEditor.TabIndex = 1;
            lblChiefEditor.Text = "你好，";
            // 
            // BtnCensor
            // 
            BtnCensor.Font = new Font("黑体", 13.8F);
            BtnCensor.Location = new Point(285, 161);
            BtnCensor.Margin = new Padding(4);
            BtnCensor.Name = "BtnCensor";
            BtnCensor.Size = new Size(150, 61);
            BtnCensor.TabIndex = 2;
            BtnCensor.Text = "审查稿件";
            BtnCensor.UseVisualStyleBackColor = true;
            BtnCensor.Click += BtnCensor_Click;
            // 
            // BtnDrafting
            // 
            BtnDrafting.Font = new Font("黑体", 13.8F);
            BtnDrafting.Location = new Point(285, 281);
            BtnDrafting.Margin = new Padding(4);
            BtnDrafting.Name = "BtnDrafting";
            BtnDrafting.Size = new Size(150, 61);
            BtnDrafting.TabIndex = 3;
            BtnDrafting.Text = "拟定排期";
            BtnDrafting.UseVisualStyleBackColor = true;
            BtnDrafting.Click += BtnDrafting_Click;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            User.Location = new Point(90, 13);
            User.Margin = new Padding(4, 0, 4, 0);
            User.Name = "User";
            User.Size = new Size(68, 28);
            User.TabIndex = 8;
            User.Text = "用户";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LblPassword.ForeColor = SystemColors.HotTrack;
            LblPassword.Location = new Point(587, 505);
            LblPassword.Margin = new Padding(4, 0, 4, 0);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(142, 24);
            LblPassword.TabIndex = 10;
            LblPassword.Text = "修改密码...";
            LblPassword.Click += LblPassword_Click;
            // 
            // 主编主页面
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 540);
            Controls.Add(LblPassword);
            Controls.Add(User);
            Controls.Add(BtnDrafting);
            Controls.Add(BtnCensor);
            Controls.Add(lblChiefEditor);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "主编主页面";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "主编主页面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private Label lblChiefEditor;
        private Button BtnCensor;
        private Button BtnDrafting;
        private Label User;
        private Label LblPassword;
    }
}