﻿namespace Document_management_system
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
            BtnSubmission = new Button();
            BtnInquire = new Button();
            BtnInformation = new Button();
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
            // BtnSubmission
            // 
            BtnSubmission.Font = new Font("黑体", 13.8F);
            BtnSubmission.Location = new Point(235, 132);
            BtnSubmission.Name = "BtnSubmission";
            BtnSubmission.Size = new Size(114, 43);
            BtnSubmission.TabIndex = 3;
            BtnSubmission.Text = "我要投稿";
            BtnSubmission.UseVisualStyleBackColor = true;
            // 
            // BtnInquire
            // 
            BtnInquire.Font = new Font("黑体", 13.8F);
            BtnInquire.Location = new Point(235, 206);
            BtnInquire.Name = "BtnInquire";
            BtnInquire.Size = new Size(114, 43);
            BtnInquire.TabIndex = 4;
            BtnInquire.Text = "稿件查询";
            BtnInquire.UseVisualStyleBackColor = true;
            // 
            // BtnInformation
            // 
            BtnInformation.Font = new Font("黑体", 13.8F);
            BtnInformation.Location = new Point(235, 279);
            BtnInformation.Name = "BtnInformation";
            BtnInformation.Size = new Size(114, 43);
            BtnInformation.TabIndex = 5;
            BtnInformation.Text = "个人资料";
            BtnInformation.UseVisualStyleBackColor = true;
            // 
            // 作者主页面
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 450);
            Controls.Add(BtnInformation);
            Controls.Add(BtnInquire);
            Controls.Add(BtnSubmission);
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
        private Button BtnSubmission;
        private Button BtnInquire;
        private Button BtnInformation;
    }
}