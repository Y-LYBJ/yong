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
            lblStyle = new Label();
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
            lbl1.Location = new Point(43, 21);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(109, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "文章名称：";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("宋体", 12F);
            lblName.Location = new Point(136, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "名称";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 12F);
            lbl2.Location = new Point(43, 53);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(109, 20);
            lbl2.TabIndex = 2;
            lbl2.Text = "投稿组织：";
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Font = new Font("宋体", 12F);
            lblGroup.Location = new Point(136, 53);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(49, 20);
            lblGroup.TabIndex = 3;
            lblGroup.Text = "组织";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("宋体", 12F);
            lbl3.Location = new Point(407, 53);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(109, 20);
            lbl3.TabIndex = 4;
            lbl3.Text = "文章类型：";
            // 
            // lblStyle
            // 
            lblStyle.AutoSize = true;
            lblStyle.Font = new Font("宋体", 12F);
            lblStyle.Location = new Point(507, 53);
            lblStyle.Name = "lblStyle";
            lblStyle.Size = new Size(49, 20);
            lblStyle.TabIndex = 5;
            lblStyle.Text = "类型";
            // 
            // txtReview
            // 
            txtReview.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtReview.Location = new Point(27, 123);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(689, 252);
            txtReview.TabIndex = 6;
            txtReview.Text = "（200字）";
            // 
            // btnRejection
            // 
            btnRejection.BackColor = Color.Red;
            btnRejection.Font = new Font("黑体", 13.8F);
            btnRejection.Location = new Point(184, 393);
            btnRejection.Name = "btnRejection";
            btnRejection.Size = new Size(117, 45);
            btnRejection.TabIndex = 7;
            btnRejection.Text = "退稿";
            btnRejection.UseVisualStyleBackColor = false;
            // 
            // btnHired
            // 
            btnHired.BackColor = Color.MediumSeaGreen;
            btnHired.Font = new Font("黑体", 13.8F);
            btnHired.Location = new Point(439, 393);
            btnHired.Name = "btnHired";
            btnHired.Size = new Size(117, 45);
            btnHired.TabIndex = 8;
            btnHired.Text = "录用";
            btnHired.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(685, 10);
            Close.Name = "Close";
            Close.Size = new Size(51, 44);
            Close.TabIndex = 9;
            Close.UseVisualStyleBackColor = true;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl4.Location = new Point(27, 91);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(109, 20);
            lbl4.TabIndex = 10;
            lbl4.Text = "主编意见：";
            // 
            // 编辑决定稿件去留
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 450);
            Controls.Add(lbl4);
            Controls.Add(Close);
            Controls.Add(btnHired);
            Controls.Add(btnRejection);
            Controls.Add(txtReview);
            Controls.Add(lblStyle);
            Controls.Add(lbl3);
            Controls.Add(lblGroup);
            Controls.Add(lbl2);
            Controls.Add(lblName);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label lblStyle;
        private TextBox txtReview;
        private Button btnRejection;
        private Button btnHired;
        private Button Close;
        private Label lbl4;
    }
}