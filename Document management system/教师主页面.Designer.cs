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
            BtnManageManuscript = new Button();
            BtnSet = new Button();
            tipSet = new ToolTip(components);
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
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTeacher.Location = new Point(12, 11);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(79, 23);
            lblTeacher.TabIndex = 2;
            lblTeacher.Text = "你好，";
            // 
            // BtnInput
            // 
            BtnInput.Font = new Font("黑体", 13.8F);
            BtnInput.Location = new Point(205, 109);
            BtnInput.Name = "BtnInput";
            BtnInput.Size = new Size(190, 51);
            BtnInput.TabIndex = 3;
            BtnInput.Text = "查看已录用稿件";
            BtnInput.UseVisualStyleBackColor = true;
            // 
            // BtnScheduling
            // 
            BtnScheduling.Font = new Font("黑体", 13.8F);
            BtnScheduling.Location = new Point(205, 186);
            BtnScheduling.Name = "BtnScheduling";
            BtnScheduling.Size = new Size(190, 51);
            BtnScheduling.TabIndex = 4;
            BtnScheduling.Text = "决定排期";
            BtnScheduling.UseVisualStyleBackColor = true;
            // 
            // BtnManageManuscript
            // 
            BtnManageManuscript.Font = new Font("黑体", 13.8F);
            BtnManageManuscript.Location = new Point(205, 266);
            BtnManageManuscript.Name = "BtnManageManuscript";
            BtnManageManuscript.Size = new Size(190, 51);
            BtnManageManuscript.TabIndex = 5;
            BtnManageManuscript.Text = "管理稿件";
            BtnManageManuscript.UseVisualStyleBackColor = true;
            // 
            // BtnSet
            // 
            BtnSet.BackgroundImage = Properties.Resources.设置按钮;
            BtnSet.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSet.FlatStyle = FlatStyle.Popup;
            BtnSet.Location = new Point(509, 367);
            BtnSet.Name = "BtnSet";
            BtnSet.Size = new Size(67, 58);
            BtnSet.TabIndex = 6;
            BtnSet.UseVisualStyleBackColor = true;
            BtnSet.Click += btnSet_Click;
            // 
            // 教师主页面
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 450);
            Controls.Add(BtnSet);
            Controls.Add(BtnManageManuscript);
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
        private Button BtnManageManuscript;
        private Button BtnSet;
        private ToolTip tipSet;
    }
}