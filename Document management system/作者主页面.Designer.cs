namespace Document_management_system
{
    partial class 作者主页面
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
            SuspendLayout();
            // 
            // Close
            // 
            Close.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Close.BackColor = SystemColors.ButtonHighlight;
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.FlatStyle = FlatStyle.Popup;
            Close.Location = new Point(12, 12);
            Close.Name = "Close";
            Close.Size = new Size(48, 43);
            Close.TabIndex = 1;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // 作者主页面
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 704);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "作者主页面";
            Text = "作者主页面";
            ResumeLayout(false);
        }

        #endregion

        private Button Close;
    }
}