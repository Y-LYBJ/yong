namespace Document_management_system
{
    partial class 编辑决定稿件去留
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
            lbl1 = new Label();
            lblName = new Label();
            lbl2 = new Label();
            lblGroup = new Label();
            lbl3 = new Label();
            lblType = new Label();
            txtReview = new TextBox();
            btnRejection = new Button();
            btnHired = new Button();
            Close = new Button();
            lbl4 = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("宋体", 12F);
            lbl1.Location = new Point(53, 25);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(130, 24);
            lbl1.TabIndex = 0;
            lbl1.Text = "文章名称：";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("宋体", 12F);
            lblName.Location = new Point(166, 25);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(58, 24);
            lblName.TabIndex = 1;
            lblName.Text = "名称";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 12F);
            lbl2.Location = new Point(53, 64);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(130, 24);
            lbl2.TabIndex = 2;
            lbl2.Text = "投稿组织：";
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Font = new Font("宋体", 12F);
            lblGroup.Location = new Point(166, 64);
            lblGroup.Margin = new Padding(4, 0, 4, 0);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(58, 24);
            lblGroup.TabIndex = 3;
            lblGroup.Text = "组织";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("宋体", 12F);
            lbl3.Location = new Point(497, 64);
            lbl3.Margin = new Padding(4, 0, 4, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(130, 24);
            lbl3.TabIndex = 4;
            lbl3.Text = "文章类型：";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("宋体", 12F);
            lblType.Location = new Point(620, 64);
            lblType.Margin = new Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(58, 24);
            lblType.TabIndex = 5;
            lblType.Text = "类型";
            // 
            // txtReview
            // 
            txtReview.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtReview.Location = new Point(33, 148);
            txtReview.Margin = new Padding(4);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.ReadOnly = true;
            txtReview.Size = new Size(841, 302);
            txtReview.TabIndex = 6;
            txtReview.Text = "（200字）";
            // 
            // btnRejection
            // 
            btnRejection.BackColor = Color.Red;
            btnRejection.Font = new Font("黑体", 13.8F);
            btnRejection.Location = new Point(225, 472);
            btnRejection.Margin = new Padding(4);
            btnRejection.Name = "btnRejection";
            btnRejection.Size = new Size(143, 54);
            btnRejection.TabIndex = 7;
            btnRejection.Text = "退稿";
            btnRejection.UseVisualStyleBackColor = false;
            // 
            // btnHired
            // 
            btnHired.BackColor = Color.MediumSeaGreen;
            btnHired.Font = new Font("黑体", 13.8F);
            btnHired.Location = new Point(537, 472);
            btnHired.Margin = new Padding(4);
            btnHired.Name = "btnHired";
            btnHired.Size = new Size(143, 54);
            btnHired.TabIndex = 8;
            btnHired.Text = "录用";
            btnHired.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(837, 12);
            Close.Margin = new Padding(4);
            Close.Name = "Close";
            Close.Size = new Size(62, 53);
            Close.TabIndex = 9;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl4.Location = new Point(33, 109);
            lbl4.Margin = new Padding(4, 0, 4, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(130, 24);
            lbl4.TabIndex = 10;
            lbl4.Text = "主编意见：";
            // 
            // 编辑决定稿件去留
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 540);
            Controls.Add(lbl4);
            Controls.Add(Close);
            Controls.Add(btnHired);
            Controls.Add(btnRejection);
            Controls.Add(txtReview);
            Controls.Add(lblType);
            Controls.Add(lbl3);
            Controls.Add(lblGroup);
            Controls.Add(lbl2);
            Controls.Add(lblName);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "编辑决定稿件去留";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "编辑决定稿件去留";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lblName;
        private Label lbl2;
        private Label lblGroup;
        private Label lbl3;
        private Label lblType;
        private TextBox txtReview;
        private Button btnRejection;
        private Button btnHired;
        private Button Close;
        private Label lbl4;
    }
}