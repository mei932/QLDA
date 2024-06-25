namespace QLDA
{
    partial class Project
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
            dgvP = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEndate = new TextBox();
            txtBudget = new TextBox();
            txtStatus = new TextBox();
            txtName = new TextBox();
            txtStartDate = new TextBox();
            txtId = new TextBox();
            groupBox2 = new GroupBox();
            txtadd = new Button();
            btnDelete = new Button();
            btnedit = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvP).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvP
            // 
            dgvP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvP.Location = new Point(6, 13);
            dgvP.Name = "dgvP";
            dgvP.Size = new Size(614, 272);
            dgvP.TabIndex = 0;
            dgvP.CellClick += dgvP_CellClick;
            dgvP.CellContentClick += dgvP_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEndate);
            groupBox1.Controls.Add(txtBudget);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtStartDate);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 167);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(19, 72);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 11;
            label6.Text = "Tên dự án ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(19, 130);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 10;
            label5.Text = "Ngày bắt đầu ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(394, 28);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 9;
            label4.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(394, 72);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 8;
            label3.Text = "Ngân sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(394, 126);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 7;
            label2.Text = "Trạng thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(19, 28);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 6;
            label1.Text = "Mã dự  án";
            // 
            // txtEndate
            // 
            txtEndate.Location = new Point(497, 28);
            txtEndate.Name = "txtEndate";
            txtEndate.Size = new Size(200, 23);
            txtEndate.TabIndex = 5;
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(497, 72);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(200, 23);
            txtBudget.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(497, 126);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(200, 23);
            txtStatus.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 2;
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new Point(110, 126);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(200, 23);
            txtStartDate.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(110, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvP);
            groupBox2.Location = new Point(12, 227);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(635, 291);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtadd
            // 
            txtadd.Location = new Point(665, 262);
            txtadd.Name = "txtadd";
            txtadd.Size = new Size(109, 41);
            txtadd.TabIndex = 3;
            txtadd.Text = "Thêm";
            txtadd.UseVisualStyleBackColor = true;
            txtadd.Click += txtadd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(665, 437);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 41);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(665, 346);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(109, 41);
            btnedit.TabIndex = 5;
            btnedit.Text = "Sửa ";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Bold);
            label7.Location = new Point(325, 17);
            label7.Name = "label7";
            label7.Size = new Size(73, 24);
            label7.TabIndex = 6;
            label7.Text = "Dự án ";
            // 
            // Project
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(818, 530);
            Controls.Add(label7);
            Controls.Add(btnedit);
            Controls.Add(btnDelete);
            Controls.Add(txtadd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Project";
            Text = "Project";
            Load += Project_Load;
            ((System.ComponentModel.ISupportInitialize)dgvP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvP;
        private GroupBox groupBox1;
        private TextBox txtEndate;
        private TextBox txtBudget;
        private TextBox txtStatus;
        private TextBox txtName;
        private TextBox txtStartDate;
        private TextBox txtId;
        private GroupBox groupBox2;
        private Button txtadd;
        private Button btnDelete;
        private Button btnedit;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
    }
}