namespace Document_management_system
{
    partial class 教师设置期数
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
            NowYear = new TextBox();
            SuspendLayout();
            // 
            // NowYear
            // 
            NowYear.BorderStyle = BorderStyle.FixedSingle;
            NowYear.Location = new Point(139, 33);
            NowYear.Name = "NowYear";
            NowYear.ReadOnly = true;
            NowYear.Size = new Size(199, 30);
            NowYear.TabIndex = 0;
            // 
            // 教师设置期数
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 446);
            Controls.Add(NowYear);
            FormBorderStyle = FormBorderStyle.None;
            Name = "教师设置期数";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "教师设置期数";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NowYear;
    }
}