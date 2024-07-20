namespace Document_management_system
{
    partial class 缓存过渡窗体
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
            OK = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // OK
            // 
            OK.Location = new Point(87, 139);
            OK.Name = "OK";
            OK.Size = new Size(112, 34);
            OK.TabIndex = 0;
            OK.Text = "确定";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 1;
            label1.Text = "加载中......";
            // 
            // 缓存过渡窗体
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 243);
            Controls.Add(label1);
            Controls.Add(OK);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "缓存过渡窗体";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "缓存过渡窗体";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OK;
        private Label label1;
    }
}