namespace QLDA
{
    partial class user
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
            label7 = new Label();
            btnDelete = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtmk = new TextBox();
            txtadd = new Button();
            groupBox2 = new GroupBox();
            dgvuser = new DataGridView();
            txtemail = new TextBox();
            txtId = new TextBox();
            btnedit = new Button();
            groupBox1 = new GroupBox();
            txtname = new TextBox();
            textrole = new TextBox();
            label2 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvuser).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Bold);
            label7.Location = new Point(303, 13);
            label7.Name = "label7";
            label7.Size = new Size(200, 24);
            label7.TabIndex = 18;
            label7.Text = "Quản lý người dùng";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(681, 435);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 41);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(19, 105);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 11;
            label6.Text = "Tên người dùng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(403, 26);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 9;
            label4.Text = "Mật khẩu ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(419, 69);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 8;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 6;
            label1.Text = "Mã người dùng";
            // 
            // txtmk
            // 
            txtmk.Location = new Point(497, 22);
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(200, 23);
            txtmk.TabIndex = 5;
            // 
            // txtadd
            // 
            txtadd.Location = new Point(681, 260);
            txtadd.Name = "txtadd";
            txtadd.Size = new Size(109, 41);
            txtadd.TabIndex = 15;
            txtadd.Text = "Thêm";
            txtadd.UseVisualStyleBackColor = true;
            txtadd.Click += txtadd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvuser);
            groupBox2.Location = new Point(28, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(635, 291);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dgvuser
            // 
            dgvuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvuser.Location = new Point(6, 13);
            dgvuser.Name = "dgvuser";
            dgvuser.Size = new Size(614, 272);
            dgvuser.TabIndex = 0;
            dgvuser.CellClick += dgvuser_CellClick;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(497, 69);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(200, 23);
            txtemail.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(129, 47);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 0;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(681, 344);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(109, 41);
            btnedit.TabIndex = 17;
            btnedit.Text = "Sửa ";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textrole);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtmk);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(28, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 167);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtname
            // 
            txtname.Location = new Point(129, 104);
            txtname.Name = "txtname";
            txtname.Size = new Size(200, 23);
            txtname.TabIndex = 2;
            // 
            // textrole
            // 
            textrole.Location = new Point(497, 121);
            textrole.Name = "textrole";
            textrole.Size = new Size(200, 23);
            textrole.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(419, 121);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 13;
            label2.Text = "Vai trò";
            // 
            // user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(818, 530);
            Controls.Add(label7);
            Controls.Add(btnDelete);
            Controls.Add(txtadd);
            Controls.Add(groupBox2);
            Controls.Add(btnedit);
            Controls.Add(groupBox1);
            Name = "user";
            Text = "user";
            Load += user_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvuser).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button btnDelete;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtmk;
        private Button txtadd;
        private GroupBox groupBox2;
        private DataGridView dgvuser;
        private TextBox txtemail;
        private TextBox txtId;
        private Button btnedit;
        private GroupBox groupBox1;
        private TextBox txtname;
        private Label label2;
        private TextBox textrole;
    }
}