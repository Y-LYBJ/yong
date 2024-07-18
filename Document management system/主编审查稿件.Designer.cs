namespace Document_management_system
{
    partial class 主编审查稿件
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
            RtxtArtical = new RichTextBox();
            txtReview = new TextBox();
            lbl1 = new Label();
            btnCancel = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // RtxtArtical
            // 
            RtxtArtical.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            RtxtArtical.Location = new Point(12, 12);
            RtxtArtical.Name = "RtxtArtical";
            RtxtArtical.ScrollBars = RichTextBoxScrollBars.Vertical;
            RtxtArtical.Size = new Size(741, 786);
            RtxtArtical.TabIndex = 1;
            RtxtArtical.Text = "（文章内容）";
            RtxtArtical.TextChanged += RtxtArtical_TextChanged;
            // 
            // txtReview
            // 
            txtReview.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtReview.Location = new Point(798, 131);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(455, 310);
            txtReview.TabIndex = 2;
            txtReview.Text = "(200字)";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl1.Location = new Point(798, 99);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(109, 20);
            lbl1.TabIndex = 3;
            lbl1.Text = "审查意见：";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.PaleTurquoise;
            btnCancel.Font = new Font("黑体", 13.8F);
            btnCancel.Location = new Point(857, 520);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "返回";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.PaleGreen;
            btnOk.Font = new Font("黑体", 13.8F);
            btnOk.Location = new Point(1126, 520);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 40);
            btnOk.TabIndex = 5;
            btnOk.Text = "提交";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // 主编审查稿件
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 810);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(lbl1);
            Controls.Add(txtReview);
            Controls.Add(RtxtArtical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "主编审查稿件";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "主编审查稿件";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RtxtArtical;
        private TextBox txtReview;
        private Label lbl1;
        private Button btnCancel;
        private Button btnOk;
    }
}