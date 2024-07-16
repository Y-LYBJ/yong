namespace Document_management_system
{
    partial class 作者更改密码
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
            lbl2 = new Label();
            lbl3 = new Label();
            txtOriginal = new TextBox();
            txtRefresh = new TextBox();
            txtFresh = new TextBox();
            Close = new Button();
            BtnOk = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("宋体", 13.8F);
            lbl1.Location = new Point(99, 119);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(102, 23);
            lbl1.TabIndex = 0;
            lbl1.Text = "原密码：";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 13.8F);
            lbl2.Location = new Point(99, 192);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(102, 23);
            lbl2.TabIndex = 1;
            lbl2.Text = "新密码：";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("宋体", 13.8F);
            lbl3.Location = new Point(53, 265);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(148, 23);
            lbl3.TabIndex = 2;
            lbl3.Text = "确认新密码：";
            // 
            // txtOriginal
            // 
            txtOriginal.Font = new Font("宋体", 12F);
            txtOriginal.Location = new Point(212, 115);
            txtOriginal.Name = "txtOriginal";
            txtOriginal.Size = new Size(175, 30);
            txtOriginal.TabIndex = 3;
            // 
            // txtRefresh
            // 
            txtRefresh.Font = new Font("宋体", 12F);
            txtRefresh.Location = new Point(212, 188);
            txtRefresh.Name = "txtRefresh";
            txtRefresh.Size = new Size(175, 30);
            txtRefresh.TabIndex = 4;
            // 
            // txtFresh
            // 
            txtFresh.Font = new Font("宋体", 12F);
            txtFresh.Location = new Point(212, 261);
            txtFresh.Name = "txtFresh";
            txtFresh.Size = new Size(175, 30);
            txtFresh.TabIndex = 5;
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(423, 12);
            Close.Name = "Close";
            Close.Size = new Size(54, 51);
            Close.TabIndex = 6;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // BtnOk
            // 
            BtnOk.Font = new Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnOk.Location = new Point(330, 399);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(94, 37);
            BtnOk.TabIndex = 7;
            BtnOk.Text = "确认";
            BtnOk.UseVisualStyleBackColor = true;
            // 
            // 作者更改密码
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 486);
            Controls.Add(BtnOk);
            Controls.Add(Close);
            Controls.Add(txtFresh);
            Controls.Add(txtRefresh);
            Controls.Add(txtOriginal);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "作者更改密码";
            Text = "作者更改密码";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private TextBox txtOriginal;
        private TextBox txtRefresh;
        private TextBox txtFresh;
        private Button Close;
        private Button BtnOk;
    }
}