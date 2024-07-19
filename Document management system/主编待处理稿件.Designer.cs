namespace Document_management_system
{
    partial class 主编待处理稿件
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
            Deatail = new Button();
            Close = new Button();
            GoBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(617, 587);
            dataGridView1.TabIndex = 0;
            // 
            // Deatail
            // 
            Deatail.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Deatail.Location = new Point(679, 563);
            Deatail.Name = "Deatail";
            Deatail.Size = new Size(177, 57);
            Deatail.TabIndex = 1;
            Deatail.Text = "详细";
            Deatail.UseVisualStyleBackColor = true;
            Deatail.Click += Detail_Click;
            // 
            // Close
            // 
            Close.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Close.BackColor = SystemColors.ButtonHighlight;
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.FlatStyle = FlatStyle.Popup;
            Close.Location = new Point(849, 33);
            Close.Margin = new Padding(2);
            Close.Name = "Close";
            Close.Size = new Size(48, 44);
            Close.TabIndex = 2;
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // GoBack
            // 
            GoBack.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            GoBack.Location = new Point(679, 468);
            GoBack.Name = "GoBack";
            GoBack.Size = new Size(177, 57);
            GoBack.TabIndex = 3;
            GoBack.Text = "拒绝审核";
            GoBack.UseVisualStyleBackColor = true;
            GoBack.Click += GoBack_Click;
            // 
            // 主编待处理稿件
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 674);
            Controls.Add(GoBack);
            Controls.Add(Close);
            Controls.Add(Deatail);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "主编待处理稿件";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "主编待处理稿件";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Deatail;
        private Button Close;
        private Button GoBack;
    }
}