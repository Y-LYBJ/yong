﻿namespace Document_management_system
{
    partial class 作者查看修改意见
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
            txtReview = new TextBox();
            lblReview = new Label();
            Close = new Button();
            SuspendLayout();
            // 
            // txtReview
            // 
            txtReview.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtReview.Location = new Point(35, 113);
            txtReview.Margin = new Padding(4, 4, 4, 4);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.ReadOnly = true;
            txtReview.Size = new Size(864, 386);
            txtReview.TabIndex = 0;
            // 
            // lblReview
            // 
            lblReview.AutoSize = true;
            lblReview.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblReview.Location = new Point(35, 71);
            lblReview.Margin = new Padding(4, 0, 4, 0);
            lblReview.Name = "lblReview";
            lblReview.Size = new Size(152, 28);
            lblReview.TabIndex = 1;
            lblReview.Text = "修改意见：";
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(872, 14);
            Close.Margin = new Padding(4, 4, 4, 4);
            Close.Name = "Close";
            Close.Size = new Size(51, 48);
            Close.TabIndex = 2;
            Close.UseVisualStyleBackColor = true;
            // 
            // 作者查看修改意见
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 540);
            Controls.Add(Close);
            Controls.Add(lblReview);
            Controls.Add(txtReview);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "作者查看修改意见";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "作者查看修改意见";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReview;
        private Label lblReview;
        private Button Close;
    }
}