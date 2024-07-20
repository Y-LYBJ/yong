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
            Close = new Button();
            groupBox1 = new GroupBox();
            Cancel = new Button();
            OK = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 63);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(700, 404);
            dataGridView1.TabIndex = 0;
            // 
            // BtnRevise
            // 
            BtnRevise.Font = new Font("黑体", 13.8F);
            BtnRevise.Location = new Point(248, 501);
            BtnRevise.Margin = new Padding(4);
            BtnRevise.Name = "BtnRevise";
            BtnRevise.Size = new Size(154, 44);
            BtnRevise.TabIndex = 1;
            BtnRevise.Text = "设置排期";
            BtnRevise.UseVisualStyleBackColor = true;
            BtnRevise.Click += BtnRevise_Click;
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(759, 13);
            Close.Margin = new Padding(4);
            Close.Name = "Close";
            Close.Size = new Size(58, 55);
            Close.TabIndex = 3;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Cancel);
            groupBox1.Controls.Add(OK);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(472, 474);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 135);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(160, 92);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(72, 34);
            Cancel.TabIndex = 3;
            Cancel.Text = "取消";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // OK
            // 
            OK.Location = new Point(50, 92);
            OK.Name = "OK";
            OK.Size = new Size(72, 34);
            OK.TabIndex = 2;
            OK.Text = "确定";
            OK.UseVisualStyleBackColor = true;
            OK.Click += OK_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(50, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 32);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 27);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 0;
            label2.Text = "选择期数：";
            // 
            // 主编拟定排期
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 640);
            Controls.Add(groupBox1);
            Controls.Add(Close);
            Controls.Add(BtnRevise);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "主编拟定排期";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "主编拟定排期";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnRevise;
        private Button Close;
        private GroupBox groupBox1;
        private Button OK;
        private ComboBox comboBox1;
        private Label label2;
        private Button Cancel;
    }
}