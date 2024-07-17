namespace Document_management_system
{
    partial class 教师管理账号
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
            Exit = new Button();
            ChangePass = new Button();
            Logout = new Button();
            CP = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            newpass = new TextBox();
            oldpass = new TextBox();
            No = new Button();
            Yes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            CP.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(721, 441);
            dataGridView1.TabIndex = 0;
            // 
            // Exit
            // 
            Exit.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Exit.Location = new Point(791, 454);
            Exit.Name = "Exit";
            Exit.Size = new Size(124, 55);
            Exit.TabIndex = 1;
            Exit.Text = "退出";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // ChangePass
            // 
            ChangePass.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ChangePass.Location = new Point(791, 68);
            ChangePass.Name = "ChangePass";
            ChangePass.Size = new Size(124, 48);
            ChangePass.TabIndex = 2;
            ChangePass.Text = "修改密码";
            ChangePass.UseVisualStyleBackColor = true;
            ChangePass.Click += ChangePass_Click;
            // 
            // Logout
            // 
            Logout.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Logout.Location = new Point(791, 153);
            Logout.Name = "Logout";
            Logout.Size = new Size(124, 44);
            Logout.TabIndex = 3;
            Logout.Text = "注销账户";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // CP
            // 
            CP.Controls.Add(label2);
            CP.Controls.Add(label1);
            CP.Controls.Add(newpass);
            CP.Controls.Add(oldpass);
            CP.Controls.Add(No);
            CP.Controls.Add(Yes);
            CP.Location = new Point(763, 232);
            CP.Name = "CP";
            CP.Size = new Size(196, 195);
            CP.TabIndex = 4;
            CP.TabStop = false;
            CP.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 5;
            label2.Text = "新密码";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 4;
            label1.Text = "原密码";
            // 
            // newpass
            // 
            newpass.Location = new Point(6, 105);
            newpass.Name = "newpass";
            newpass.Size = new Size(175, 30);
            newpass.TabIndex = 3;
            // 
            // oldpass
            // 
            oldpass.Location = new Point(6, 45);
            oldpass.Name = "oldpass";
            oldpass.ReadOnly = true;
            oldpass.Size = new Size(175, 30);
            oldpass.TabIndex = 2;
            // 
            // No
            // 
            No.Location = new Point(104, 159);
            No.Name = "No";
            No.Size = new Size(59, 30);
            No.TabIndex = 1;
            No.Text = "取消";
            No.UseVisualStyleBackColor = true;
            No.Click += No_Click;
            // 
            // Yes
            // 
            Yes.Location = new Point(28, 159);
            Yes.Name = "Yes";
            Yes.Size = new Size(59, 30);
            Yes.TabIndex = 0;
            Yes.Text = "确定";
            Yes.UseVisualStyleBackColor = true;
            Yes.Click += Yes_Click;
            // 
            // 教师管理账号
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 540);
            Controls.Add(CP);
            Controls.Add(Logout);
            Controls.Add(ChangePass);
            Controls.Add(Exit);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "教师管理账号";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "教师管理账号";
            Load += 教师管理账号_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            CP.ResumeLayout(false);
            CP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button Exit;
        private Button ChangePass;
        private Button Logout;
        private GroupBox CP;
        private Button Yes;
        private Button No;
        private Label label2;
        private Label label1;
        private TextBox newpass;
        private TextBox oldpass;
    }
}