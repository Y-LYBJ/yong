namespace Document_management_system
{
    partial class 教师决定排期
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
            BtnRevise = new Button();
            BtnOk = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(773, 12);
            Close.Name = "Close";
            Close.Size = new Size(52, 51);
            Close.TabIndex = 0;
            Close.UseVisualStyleBackColor = true;
            // 
            // BtnRevise
            // 
            BtnRevise.Font = new Font("黑体", 13.8F);
            BtnRevise.Location = new Point(214, 414);
            BtnRevise.Name = "BtnRevise";
            BtnRevise.Size = new Size(94, 40);
            BtnRevise.TabIndex = 1;
            BtnRevise.Text = "修改";
            BtnRevise.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            BtnOk.Font = new Font("黑体", 13.8F);
            BtnOk.Location = new Point(545, 414);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(94, 40);
            BtnOk.TabIndex = 2;
            BtnOk.Text = "确定";
            BtnOk.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 317);
            dataGridView1.TabIndex = 3;
            // 
            // 教师决定排期
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 479);
            Controls.Add(dataGridView1);
            Controls.Add(BtnOk);
            Controls.Add(BtnRevise);
            Controls.Add(Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "教师决定排期";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "教师决定排期";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Close;
        private Button BtnRevise;
        private Button BtnOk;
        private DataGridView dataGridView1;
    }
}