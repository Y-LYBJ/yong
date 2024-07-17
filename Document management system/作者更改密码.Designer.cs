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
            lbl1.Location = new Point(121, 143);
            lbl1.Margin = new Padding(4, 0, 4, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(124, 28);
            lbl1.TabIndex = 0;
            lbl1.Text = "原密码：";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("宋体", 13.8F);
            lbl2.Location = new Point(121, 230);
            lbl2.Margin = new Padding(4, 0, 4, 0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(124, 28);
            lbl2.TabIndex = 1;
            lbl2.Text = "新密码：";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("宋体", 13.8F);
            lbl3.Location = new Point(65, 318);
            lbl3.Margin = new Padding(4, 0, 4, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(180, 28);
            lbl3.TabIndex = 2;
            lbl3.Text = "确认新密码：";
            // 
            // txtOriginal
            // 
            txtOriginal.Font = new Font("宋体", 12F);
            txtOriginal.Location = new Point(259, 138);
            txtOriginal.Margin = new Padding(4);
            txtOriginal.Name = "txtOriginal";
            txtOriginal.ReadOnly = true;
            txtOriginal.Size = new Size(213, 35);
            txtOriginal.TabIndex = 3;
            // 
            // txtRefresh
            // 
            txtRefresh.Font = new Font("宋体", 12F);
            txtRefresh.Location = new Point(259, 226);
            txtRefresh.Margin = new Padding(4);
            txtRefresh.Name = "txtRefresh";
            txtRefresh.Size = new Size(213, 35);
            txtRefresh.TabIndex = 4;
            // 
            // txtFresh
            // 
            txtFresh.Font = new Font("宋体", 12F);
            txtFresh.Location = new Point(259, 313);
            txtFresh.Margin = new Padding(4);
            txtFresh.Name = "txtFresh";
            txtFresh.Size = new Size(213, 35);
            txtFresh.TabIndex = 5;
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(517, 14);
            Close.Margin = new Padding(4);
            Close.Name = "Close";
            Close.Size = new Size(66, 61);
            Close.TabIndex = 6;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // BtnOk
            // 
            BtnOk.Font = new Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnOk.Location = new Point(403, 479);
            BtnOk.Margin = new Padding(4);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(115, 44);
            BtnOk.TabIndex = 7;
            BtnOk.Text = "确认";
            BtnOk.UseVisualStyleBackColor = true;
            // 
            // 作者更改密码
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 583);
            Controls.Add(BtnOk);
            Controls.Add(Close);
            Controls.Add(txtFresh);
            Controls.Add(txtRefresh);
            Controls.Add(txtOriginal);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "作者更改密码";
            StartPosition = FormStartPosition.CenterScreen;
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