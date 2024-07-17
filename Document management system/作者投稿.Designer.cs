namespace Document_management_system
{
    partial class 作者投稿
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
            lblStyle = new Label();
            txtName = new TextBox();
            txtStyle = new TextBox();
            btnAdd = new Button();
            btnSubmit = new Button();
            Close = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("宋体", 12F);
            lbl1.Location = new Point(12, 26);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(109, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "组织名称：";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("宋体", 12F);
            lblName.Location = new Point(106, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "名称";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 13.8F);
            lbl2.Location = new Point(148, 113);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(125, 23);
            lbl2.TabIndex = 2;
            lbl2.Text = "稿件名称：";
            // 
            // lblStyle
            // 
            lblStyle.AutoSize = true;
            lblStyle.Font = new Font("宋体", 13.8F);
            lblStyle.Location = new Point(185, 184);
            lblStyle.Name = "lblStyle";
            lblStyle.Size = new Size(79, 23);
            lblStyle.TabIndex = 3;
            lblStyle.Text = "类型：";
            // 
            // txtName
            // 
            txtName.Font = new Font("宋体", 13.8F);
            txtName.Location = new Point(289, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(246, 34);
            txtName.TabIndex = 4;
            // 
            // txtStyle
            // 
            txtStyle.Font = new Font("宋体", 13.8F);
            txtStyle.Location = new Point(289, 184);
            txtStyle.Name = "txtStyle";
            txtStyle.Size = new Size(125, 34);
            txtStyle.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.加号;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Location = new Point(252, 272);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(165, 129);
            btnAdd.TabIndex = 6;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSubmit.Location = new Point(452, 404);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 40);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "提交";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(635, 12);
            Close.Name = "Close";
            Close.Size = new Size(53, 51);
            Close.TabIndex = 8;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // 作者投稿
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(Close);
            Controls.Add(btnSubmit);
            Controls.Add(btnAdd);
            Controls.Add(txtStyle);
            Controls.Add(txtName);
            Controls.Add(lblStyle);
            Controls.Add(lbl2);
            Controls.Add(lblName);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "作者投稿";
            Text = "作者投稿";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lblName;
        private Label lbl2;
        private Label lblStyle;
        private TextBox txtName;
        private TextBox txtStyle;
        private Button btnAdd;
        private Button btnSubmit;
        private Button Close;
    }
}