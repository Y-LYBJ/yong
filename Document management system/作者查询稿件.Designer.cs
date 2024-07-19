namespace Document_management_system
{
    partial class 作者查询稿件
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
            dataGridView2 = new DataGridView();
            Back = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(40, 24);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(552, 486);
            dataGridView2.TabIndex = 0;
            // 
            // Back
            // 
            Back.Location = new Point(643, 476);
            Back.Name = "Back";
            Back.Size = new Size(112, 34);
            Back.TabIndex = 1;
            Back.Text = "退出";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // button1
            // 
            button1.Location = new Point(623, 419);
            button1.Name = "button1";
            button1.Size = new Size(159, 39);
            button1.TabIndex = 2;
            button1.Text = "查看修改意见";
            button1.UseVisualStyleBackColor = true;
            // 
            // 作者查询稿件
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(814, 554);
            Controls.Add(button1);
            Controls.Add(Back);
            Controls.Add(dataGridView2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "作者查询稿件";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "作者查询稿件";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView2;
        private Button Back;
        private Button button1;
    }
}