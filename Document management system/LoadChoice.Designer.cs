namespace Document_management_system
{
    partial class LoadChoice
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            teacher = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(66, 58);
            button1.Name = "button1";
            button1.Size = new Size(235, 60);
            button1.TabIndex = 0;
            button1.Text = "学生端";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // teacher
            // 
            teacher.FlatStyle = FlatStyle.Popup;
            teacher.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            teacher.Location = new Point(66, 160);
            teacher.Name = "teacher";
            teacher.Size = new Size(235, 60);
            teacher.TabIndex = 1;
            teacher.Text = "教师端";
            teacher.UseVisualStyleBackColor = true;
            teacher.Click += teacher_Click;
            // 
            // LoadChoice
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 284);
            Controls.Add(teacher);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "LoadChoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "文章投稿与稿件管理系统登录";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button teacher;
    }
}
