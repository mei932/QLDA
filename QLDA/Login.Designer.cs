namespace QLDA
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtpw = new TextBox();
            bthLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold);
            label1.Location = new Point(121, 74);
            label1.Name = "label1";
            label1.Size = new Size(239, 24);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(49, 193);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(49, 140);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 2;
            label3.Text = "Tài khoản";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(149, 145);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(241, 23);
            txtUser.TabIndex = 3;
            // 
            // txtpw
            // 
            txtpw.Location = new Point(149, 193);
            txtpw.Name = "txtpw";
            txtpw.PasswordChar = '*';
            txtpw.Size = new Size(241, 23);
            txtpw.TabIndex = 4;
            // 
            // bthLogin
            // 
            bthLogin.Font = new Font("Segoe UI", 15F);
            bthLogin.Location = new Point(166, 255);
            bthLogin.Name = "bthLogin";
            bthLogin.Size = new Size(126, 45);
            bthLogin.TabIndex = 5;
            bthLogin.Text = "Đăng nhập";
            bthLogin.UseVisualStyleBackColor = true;
            bthLogin.Click += bthLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(459, 364);
            Controls.Add(bthLogin);
            Controls.Add(txtpw);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtpw;
        private Button bthLogin;
    }
}