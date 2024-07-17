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
            lblDescreption = new TextBox();
            lbl4 = new Label();
            SuspendLayout();
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(769, 14);
            Close.Margin = new Padding(4);
            Close.Name = "Close";
            Close.Size = new Size(72, 64);
            Close.TabIndex = 0;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("宋体", 13.8F);
            lbl1.Location = new Point(163, 109);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(152, 28);
            lbl1.TabIndex = 1;
            lbl1.Text = "组织名称：";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("宋体", 12F);
            lblName.Location = new Point(335, 113);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(58, 24);
            lblName.TabIndex = 2;
            lblName.Text = "名称";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("宋体", 12F);
            lblAccount.Location = new Point(335, 176);
            lblAccount.Margin = new Padding(4, 0, 4, 0);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(58, 24);
            lblAccount.TabIndex = 3;
            lblAccount.Text = "账号";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("宋体", 13.8F);
            lbl3.Location = new Point(163, 242);
            lbl3.Margin = new Padding(4, 0, 4, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(152, 28);
            lbl3.TabIndex = 4;
            lbl3.Text = "所属级别：";
            // 
            // lblLeval
            // 
            lblLeval.AutoSize = true;
            lblLeval.Font = new Font("宋体", 12F);
            lblLeval.Location = new Point(335, 242);
            lblLeval.Margin = new Padding(4, 0, 4, 0);
            lblLeval.Name = "lblLeval";
            lblLeval.Size = new Size(58, 24);
            lblLeval.TabIndex = 5;
            lblLeval.Text = "级别";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 13.8F);
            lbl2.Location = new Point(199, 176);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(96, 28);
            lbl2.TabIndex = 6;
            lbl2.Text = "账号：";
            // 
            // BtnOk
            // 
            BtnOk.Font = new Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnOk.Location = new Point(678, 514);
            BtnOk.Margin = new Padding(4);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(115, 54);
            BtnOk.TabIndex = 8;
            BtnOk.Text = "确定";
            BtnOk.UseVisualStyleBackColor = true;
            // 
            // lblDescreption
            // 
            lblDescreption.Location = new Point(335, 307);
            lblDescreption.Margin = new Padding(4);
            lblDescreption.Multiline = true;
            lblDescreption.Name = "lblDescreption";
            lblDescreption.ReadOnly = true;
            lblDescreption.Size = new Size(391, 165);
            lblDescreption.TabIndex = 9;
            lblDescreption.Text = "（100字）";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("宋体", 13.8F);
            lbl4.Location = new Point(163, 307);
            lbl4.Margin = new Padding(4, 0, 4, 0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(152, 28);
            lbl4.TabIndex = 10;
            lbl4.Text = "组织简介：";
            // 
            // 作者修改资料
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 600);
            Controls.Add(lbl4);
            Controls.Add(lblDescreption);
            Controls.Add(BtnOk);
            Controls.Add(lbl2);
            Controls.Add(lblLeval);
            Controls.Add(lbl3);
            Controls.Add(lblAccount);
            Controls.Add(lblName);
            Controls.Add(lbl1);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "作者修改资料";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox lblDescreption;
        private Label lbl4;
    }
}