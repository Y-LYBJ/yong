namespace Document_management_system
{
    partial class 编辑查看稿件状态
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
            Close = new Button();
            Detail = new Button();
            Show = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(678, 497);
            dataGridView1.TabIndex = 0;
            // 
            // Close
            // 
            Close.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Close.BackColor = SystemColors.ButtonHighlight;
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.FlatStyle = FlatStyle.Popup;
            Close.Location = new Point(902, 18);
            Close.Margin = new Padding(2);
            Close.Name = "Close";
            Close.Size = new Size(48, 43);
            Close.TabIndex = 2;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // Detail
            // 
            Detail.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Detail.Location = new Point(740, 455);
            Detail.Name = "Detail";
            Detail.Size = new Size(181, 60);
            Detail.TabIndex = 3;
            Detail.Text = "稿件详细";
            Detail.UseVisualStyleBackColor = true;
            Detail.Click += Detail_Click;
            // 
            // Show
            // 
            Show.AutoSize = true;
            Show.Location = new Point(797, 401);
            Show.Name = "Show";
            Show.Size = new Size(46, 24);
            Show.TabIndex = 4;
            Show.Text = "提醒";
            Show.Visible = false;
            // 
            // 编辑查看稿件状态
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 540);
            Controls.Add(Show);
            Controls.Add(Detail);
            Controls.Add(Close);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "编辑查看稿件状态";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "编辑查看稿件状态";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Close;
        private Button Detail;
        private Label Show;
    }
}