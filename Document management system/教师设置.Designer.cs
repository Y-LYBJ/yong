namespace Document_management_system
{
    partial class 教师设置
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
            BtnRegistered = new Button();
            BtnManage = new Button();
            BtnScheduling = new Button();
            Close = new Button();
            SuspendLayout();
            // 
            // BtnRegistered
            // 
            BtnRegistered.Font = new Font("黑体", 13.8F);
            BtnRegistered.Location = new Point(225, 109);
            BtnRegistered.Name = "BtnRegistered";
            BtnRegistered.Size = new Size(137, 61);
            BtnRegistered.TabIndex = 0;
            BtnRegistered.Text = "注册账号";
            BtnRegistered.UseVisualStyleBackColor = true;
            BtnRegistered.Click += BtnRegistered_Click;
            // 
            // BtnManage
            // 
            BtnManage.Font = new Font("黑体", 13.8F);
            BtnManage.Location = new Point(225, 198);
            BtnManage.Name = "BtnManage";
            BtnManage.Size = new Size(137, 61);
            BtnManage.TabIndex = 1;
            BtnManage.Text = "管理账号";
            BtnManage.UseVisualStyleBackColor = true;
            BtnManage.Click += BtnManage_Click;
            // 
            // BtnScheduling
            // 
            BtnScheduling.Font = new Font("黑体", 13.8F);
            BtnScheduling.Location = new Point(225, 293);
            BtnScheduling.Name = "BtnScheduling";
            BtnScheduling.Size = new Size(137, 61);
            BtnScheduling.TabIndex = 2;
            BtnScheduling.Text = "设置期数";
            BtnScheduling.UseVisualStyleBackColor = true;
            BtnScheduling.Click += BtnScheduling_Click;
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(548, 12);
            Close.Name = "Close";
            Close.Size = new Size(50, 45);
            Close.TabIndex = 3;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // 教师设置
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 450);
            Controls.Add(Close);
            Controls.Add(BtnScheduling);
            Controls.Add(BtnManage);
            Controls.Add(BtnRegistered);
            FormBorderStyle = FormBorderStyle.None;
            Name = "教师设置";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "教师设置";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnRegistered;
        private Button BtnManage;
        private Button BtnScheduling;
        private Button Close;
    }
}