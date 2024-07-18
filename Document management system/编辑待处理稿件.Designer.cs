namespace Document_management_system
{
    partial class 编辑待处理稿件
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
            Choice = new Button();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            no = new Button();
            yes = new Button();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(540, 497);
            dataGridView1.TabIndex = 0;
            // 
            // Choice
            // 
            Choice.Location = new Point(587, 446);
            Choice.Name = "Choice";
            Choice.Size = new Size(88, 63);
            Choice.TabIndex = 1;
            Choice.Text = "分配\r\n稿件";
            Choice.UseVisualStyleBackColor = true;
            Choice.Click += Choice_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(6, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(126, 124);
            listBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(no);
            groupBox1.Controls.Add(yes);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(568, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 156);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // no
            // 
            no.Location = new Point(138, 87);
            no.Name = "no";
            no.Size = new Size(72, 34);
            no.TabIndex = 4;
            no.Text = "取消";
            no.UseVisualStyleBackColor = true;
            no.Click += no_Click;
            // 
            // yes
            // 
            yes.Location = new Point(138, 29);
            yes.Name = "yes";
            yes.Size = new Size(72, 34);
            yes.TabIndex = 3;
            yes.Text = "确定";
            yes.UseVisualStyleBackColor = true;
            yes.Click += yes_Click;
            // 
            // Close
            // 
            Close.BackgroundImage = Properties.Resources.关闭按钮;
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Location = new Point(722, 12);
            Close.Margin = new Padding(4);
            Close.Name = "Close";
            Close.Size = new Size(62, 53);
            Close.TabIndex = 10;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // 编辑待处理稿件
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 540);
            Controls.Add(Close);
            Controls.Add(groupBox1);
            Controls.Add(Choice);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "编辑待处理稿件";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "编辑待处理稿件";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Choice;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Button no;
        private Button yes;
        private Button Close;
    }
}