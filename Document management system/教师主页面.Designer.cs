namespace Document_management_system
{
    partial class 教师主页面
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
            components = new System.ComponentModel.Container();
            Close = new Button();
            lblTeacher = new Label();
            BtnInput = new Button();
            BtnScheduling = new Button();
            BtnSet = new Button();
            tipSet = new ToolTip(components);
            User = new Label();
            SuspendLayout();
            // 
            // Close
            // 
            Close.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Close.BackColor = SystemColors.ButtonHighlight;
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.FlatStyle = FlatStyle.Popup;
            Close.Location = new Point(450, 11);
            Close.Margin = new Padding(2);
            Close.Name = "Close";
            Close.Size = new Size(48, 43);
            Close.TabIndex = 1;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTeacher.Location = new Point(15, 13);
            lblTeacher.Margin = new Padding(4, 0, 4, 0);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(96, 28);
            lblTeacher.TabIndex = 2;
            lblTeacher.Text = "你好，";
            // 
            // BtnInput
            // 
            BtnInput.Font = new Font("黑体", 13.8F);
            BtnInput.Location = new Point(152, 105);
            BtnInput.Margin = new Padding(4);
            BtnInput.Name = "BtnInput";
            BtnInput.Size = new Size(232, 61);
            BtnInput.TabIndex = 3;
            BtnInput.Text = "查看已录用稿件";
            BtnInput.UseVisualStyleBackColor = true;
            BtnInput.Click += BtnInput_Click;
            // 
            // BtnScheduling
            // 
            BtnScheduling.Font = new Font("黑体", 13.8F);
            BtnScheduling.Location = new Point(152, 203);
            BtnScheduling.Margin = new Padding(4);
            BtnScheduling.Name = "BtnScheduling";
            BtnScheduling.Size = new Size(232, 61);
            BtnScheduling.TabIndex = 4;
            BtnScheduling.Text = "决定排期";
            BtnScheduling.UseVisualStyleBackColor = true;
            BtnScheduling.Click += BtnScheduling_Click;
            // 
            // BtnSet
            // 
            BtnSet.BackgroundImage = Properties.Resources.设置按钮;
            BtnSet.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSet.FlatStyle = FlatStyle.Popup;
            BtnSet.Location = new Point(446, 328);
            BtnSet.Margin = new Padding(4);
            BtnSet.Name = "BtnSet";
            BtnSet.Size = new Size(52, 45);
            BtnSet.TabIndex = 6;
            BtnSet.UseVisualStyleBackColor = true;
            BtnSet.Click += BtnSet_Click;
            // 
            // tipSet
            // 
            tipSet.AutomaticDelay = 50;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            User.Location = new Point(92, 13);
            User.Margin = new Padding(4, 0, 4, 0);
            User.Name = "User";
            User.Size = new Size(68, 28);
            User.TabIndex = 7;
            User.Text = "用户";
            // 
            // 教师主页面
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 383);
            Controls.Add(User);
            Controls.Add(BtnSet);
            Controls.Add(BtnScheduling);
            Controls.Add(BtnInput);
            Controls.Add(lblTeacher);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "教师主页面";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "教师主页面";
            Load += 教师主页面_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private Label lblTeacher;
        private Button BtnInput;
        private Button BtnScheduling;
        private Button BtnSet;
        private ToolTip tipSet;
        private Label User;
    }
}