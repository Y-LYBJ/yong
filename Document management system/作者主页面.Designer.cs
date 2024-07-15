namespace Document_management_system
{
    partial class 作者主页面
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
            lblAuthor = new Label();
            btnSubmission = new Button();
            btnInquire = new Button();
            btnInformation = new Button();
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
            Close.Size = new Size(39, 37);
            Close.TabIndex = 1;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblAuthor.Location = new Point(12, 11);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(79, 23);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "你好，";
            // 
            // btnSubmission
            // 
            btnSubmission.Font = new Font("黑体", 13.8F);
            btnSubmission.Location = new Point(235, 132);
            btnSubmission.Name = "btnSubmission";
            btnSubmission.Size = new Size(114, 43);
            btnSubmission.TabIndex = 3;
            btnSubmission.Text = "我要投稿";
            btnSubmission.UseVisualStyleBackColor = true;
            // 
            // btnInquire
            // 
            btnInquire.Font = new Font("黑体", 13.8F);
            btnInquire.Location = new Point(235, 206);
            btnInquire.Name = "btnInquire";
            btnInquire.Size = new Size(114, 43);
            btnInquire.TabIndex = 4;
            btnInquire.Text = "稿件查询";
            btnInquire.UseVisualStyleBackColor = true;
            // 
            // btnInformation
            // 
            btnInformation.Font = new Font("黑体", 13.8F);
            btnInformation.Location = new Point(235, 279);
            btnInformation.Name = "btnInformation";
            btnInformation.Size = new Size(114, 43);
            btnInformation.TabIndex = 5;
            btnInformation.Text = "个人资料";
            btnInformation.UseVisualStyleBackColor = true;
            // 
            // 作者主页面
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 450);
            Controls.Add(btnInformation);
            Controls.Add(btnInquire);
            Controls.Add(btnSubmission);
            Controls.Add(lblAuthor);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "作者主页面";
            Text = "作者主页面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private Label lblAuthor;
        private Button btnSubmission;
        private Button btnInquire;
        private Button btnInformation;
    }
}