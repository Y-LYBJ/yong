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
            button1 = new Button();
            SuspendLayout();
            // 
            // BtnRegistered
            // 
            BtnRegistered.Location = new Point(292, 85);
            BtnRegistered.Name = "BtnRegistered";
            BtnRegistered.Size = new Size(137, 61);
            BtnRegistered.TabIndex = 0;
            BtnRegistered.Text = "注册账号";
            BtnRegistered.UseVisualStyleBackColor = true;
            BtnRegistered.Click += BtnRegistered_Click;
            // 
            // BtnManage
            // 
            BtnManage.Location = new Point(292, 171);
            BtnManage.Name = "BtnManage";
            BtnManage.Size = new Size(137, 61);
            BtnManage.TabIndex = 1;
            BtnManage.Text = "管理账号";
            BtnManage.UseVisualStyleBackColor = true;
            BtnManage.Click += BtnManage_Click;
            // 
            // BtnScheduling
            // 
            BtnScheduling.Location = new Point(292, 256);
            BtnScheduling.Name = "BtnScheduling";
            BtnScheduling.Size = new Size(137, 61);
            BtnScheduling.TabIndex = 2;
            BtnScheduling.Text = "设置期数";
            BtnScheduling.UseVisualStyleBackColor = true;
            BtnScheduling.Click += BtnScheduling_Click;
            // 
            // button1
            // 
            button1.Location = new Point(659, 25);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "关闭";
            button1.UseVisualStyleBackColor = true;
            // 
            // 教师设置
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
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
        private Button button1;
    }
}