namespace Document_management_system
{
    partial class 作者修改资料
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
            lbl1 = new Label();
            lblName = new Label();
            lblAccount = new Label();
            lbl3 = new Label();
            lblLeval = new Label();
            lbl2 = new Label();
            BtnOk = new Button();
            textBox1 = new TextBox();
            lbl4 = new Label();
            SuspendLayout();
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(629, 12);
            Close.Name = "Close";
            Close.Size = new Size(59, 53);
            Close.TabIndex = 0;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("宋体", 13.8F);
            lbl1.Location = new Point(133, 91);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(125, 23);
            lbl1.TabIndex = 1;
            lbl1.Text = "组织名称：";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("宋体", 12F);
            lblName.Location = new Point(274, 94);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "名称";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("宋体", 12F);
            lblAccount.Location = new Point(274, 147);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(49, 20);
            lblAccount.TabIndex = 3;
            lblAccount.Text = "账号";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("宋体", 13.8F);
            lbl3.Location = new Point(133, 202);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(125, 23);
            lbl3.TabIndex = 4;
            lbl3.Text = "所属级别：";
            // 
            // lblLeval
            // 
            lblLeval.AutoSize = true;
            lblLeval.Font = new Font("宋体", 12F);
            lblLeval.Location = new Point(274, 202);
            lblLeval.Name = "lblLeval";
            lblLeval.Size = new Size(49, 20);
            lblLeval.TabIndex = 5;
            lblLeval.Text = "级别";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 13.8F);
            lbl2.Location = new Point(163, 147);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(79, 23);
            lbl2.TabIndex = 6;
            lbl2.Text = "账号：";
            // 
            // BtnOk
            // 
            BtnOk.Font = new Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnOk.Location = new Point(555, 428);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(94, 45);
            BtnOk.TabIndex = 8;
            BtnOk.Text = "确定";
            BtnOk.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 256);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 138);
            textBox1.TabIndex = 9;
            textBox1.Text = "（100字）";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("宋体", 13.8F);
            lbl4.Location = new Point(133, 256);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(125, 23);
            lbl4.TabIndex = 10;
            lbl4.Text = "组织简介：";
            // 
            // 作者修改资料
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(lbl4);
            Controls.Add(textBox1);
            Controls.Add(BtnOk);
            Controls.Add(lbl2);
            Controls.Add(lblLeval);
            Controls.Add(lbl3);
            Controls.Add(lblAccount);
            Controls.Add(lblName);
            Controls.Add(lbl1);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "作者修改资料";
            Text = "作者修改资料";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private Label lbl1;
        private Label lblName;
        private Label lblAccount;
        private Label lbl3;
        private Label lblLeval;
        private Label lbl2;
        private Button BtnOk;
        private TextBox textBox1;
        private Label lbl4;
    }
}