namespace Document_management_system
{
    partial class 编辑主页面
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
            lblEdit = new Label();
            btnPending = new Button();
            btnState = new Button();
            SuspendLayout();
            // 
            // Close
            // 
            Close.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Close.BackColor = SystemColors.ButtonHighlight;
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.FlatStyle = FlatStyle.Popup;
            Close.Location = new Point(560, 11);
            Close.Margin = new Padding(2);
            Close.Name = "Close";
            Close.Size = new Size(39, 36);
            Close.TabIndex = 1;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // lblEdit
            // 
            lblEdit.AutoSize = true;
            lblEdit.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblEdit.Location = new Point(12, 11);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(79, 23);
            lblEdit.TabIndex = 2;
            lblEdit.Text = "你好，";
            // 
            // btnPending
            // 
            btnPending.Font = new Font("黑体", 13.8F);
            btnPending.Location = new Point(235, 130);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(153, 51);
            btnPending.TabIndex = 3;
            btnPending.Text = "待处理稿件";
            btnPending.UseVisualStyleBackColor = true;
            // 
            // btnState
            // 
            btnState.Font = new Font("黑体", 13.8F);
            btnState.Location = new Point(235, 253);
            btnState.Name = "btnState";
            btnState.Size = new Size(153, 51);
            btnState.TabIndex = 4;
            btnState.Text = "稿件状态";
            btnState.UseVisualStyleBackColor = true;
            // 
            // 编辑主页面
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 450);
            Controls.Add(btnState);
            Controls.Add(btnPending);
            Controls.Add(lblEdit);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "编辑主页面";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "编辑主页面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private Label lblEdit;
        private Button btnPending;
        private Button btnState;
    }
}