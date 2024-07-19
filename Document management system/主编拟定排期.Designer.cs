namespace Document_management_system
{
    partial class 主编拟定排期
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
            dataGridView1 = new DataGridView();
            BtnRevise = new Button();
            BtnOk = new Button();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(787, 337);
            dataGridView1.TabIndex = 0;
            // 
            // BtnRevise
            // 
            BtnRevise.Font = new Font("黑体", 13.8F);
            BtnRevise.Location = new Point(227, 472);
            BtnRevise.Name = "BtnRevise";
            BtnRevise.Size = new Size(94, 37);
            BtnRevise.TabIndex = 1;
            BtnRevise.Text = "修改";
            BtnRevise.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            BtnOk.Font = new Font("黑体", 13.8F);
            BtnOk.Location = new Point(545, 472);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(94, 37);
            BtnOk.TabIndex = 2;
            BtnOk.Text = "确定";
            BtnOk.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(811, 12);
            Close.Name = "Close";
            Close.Size = new Size(58, 47);
            Close.TabIndex = 3;
            Close.UseVisualStyleBackColor = true;
            // 
            // 主编拟定排期
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 552);
            Controls.Add(Close);
            Controls.Add(BtnOk);
            Controls.Add(BtnRevise);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "主编拟定排期";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "主编拟定排期";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnRevise;
        private Button BtnOk;
        private Button Close;
    }
}