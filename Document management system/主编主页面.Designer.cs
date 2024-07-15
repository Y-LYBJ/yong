namespace Document_management_system
{
    partial class 主编主页面
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
            lblChiefEditor = new Label();
            BtnCensor = new Button();
            BtnDrafting = new Button();
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
            Close.TabIndex = 0;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // lblChiefEditor
            // 
            lblChiefEditor.AutoSize = true;
            lblChiefEditor.Font = new Font("宋体", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblChiefEditor.Location = new Point(12, 11);
            lblChiefEditor.Name = "lblChiefEditor";
            lblChiefEditor.Size = new Size(79, 23);
            lblChiefEditor.TabIndex = 1;
            lblChiefEditor.Text = "你好，";
            // 
            // BtnCensor
            // 
            BtnCensor.Font = new Font("黑体", 13.8F);
            BtnCensor.Location = new Point(233, 134);
            BtnCensor.Name = "BtnCensor";
            BtnCensor.Size = new Size(123, 51);
            BtnCensor.TabIndex = 2;
            BtnCensor.Text = "审查稿件";
            BtnCensor.UseVisualStyleBackColor = true;
            // 
            // BtnDrafting
            // 
            BtnDrafting.Font = new Font("黑体", 13.8F);
            BtnDrafting.Location = new Point(233, 234);
            BtnDrafting.Name = "BtnDrafting";
            BtnDrafting.Size = new Size(123, 51);
            BtnDrafting.TabIndex = 3;
            BtnDrafting.Text = "拟定排期";
            BtnDrafting.UseVisualStyleBackColor = true;
            // 
            // 主编主页面
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 450);
            Controls.Add(BtnDrafting);
            Controls.Add(BtnCensor);
            Controls.Add(lblChiefEditor);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "主编主页面";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "主编主页面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private Label lblChiefEditor;
        private Button BtnCensor;
        private Button BtnDrafting;
    }
}