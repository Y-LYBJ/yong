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
            txtReview = new TextBox();
            lbl1 = new Label();
            btnCancel = new Button();
            btnOk = new Button();
            RtxtArtical = new RichTextBox();
            SuspendLayout();
            // 
            // txtReview
            // 
            txtReview.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtReview.Location = new Point(975, 157);
            txtReview.Margin = new Padding(4);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(555, 371);
            txtReview.TabIndex = 2;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl1.Location = new Point(975, 119);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(130, 24);
            lbl1.TabIndex = 3;
            lbl1.Text = "审查意见：";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.PaleTurquoise;
            btnCancel.Font = new Font("黑体", 13.8F);
            btnCancel.Location = new Point(1047, 624);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 48);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "返回";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.PaleGreen;
            btnOk.Font = new Font("黑体", 13.8F);
            btnOk.Location = new Point(1376, 624);
            btnOk.Margin = new Padding(4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(115, 48);
            btnOk.TabIndex = 5;
            btnOk.Text = "提交";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // RtxtArtical
            // 
            RtxtArtical.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            RtxtArtical.Location = new Point(13, 13);
            RtxtArtical.Margin = new Padding(4);
            RtxtArtical.Name = "RtxtArtical";
            RtxtArtical.ReadOnly = true;
            RtxtArtical.ScrollBars = RichTextBoxScrollBars.Vertical;
            RtxtArtical.Size = new Size(905, 942);
            RtxtArtical.TabIndex = 1;
            RtxtArtical.Text = "";
            // 
            // 主编审查稿件
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 972);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(lbl1);
            Controls.Add(txtReview);
            Controls.Add(RtxtArtical);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "主编审查稿件";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "主编审查稿件";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtReview;
        private Label lbl1;
        private Button btnCancel;
        private Button btnOk;
        private RichTextBox RtxtArtical;
    }
}