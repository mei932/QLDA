namespace QLDA
{
    partial class task
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtadd = new Button();
            groupBox2 = new GroupBox();
            dgvTask = new DataGridView();
            txtStatus = new TextBox();
            txtProjectId = new TextBox();
            txtDescription = new TextBox();
            txtTaskId = new TextBox();
            btnedit = new Button();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            txtAssignedTo = new TextBox();
            txtTaskName = new TextBox();
            dtpDueDate = new DateTimePicker();
            dtpDeadline = new DateTimePicker();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTask).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Bold);
            label7.Location = new Point(320, 13);
            label7.Name = "label7";
            label7.Size = new Size(175, 24);
            label7.TabIndex = 12;
            label7.Text = "Quản lý nhiệm vụ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(681, 435);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 41);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(13, 62);
            label6.Name = "label6";
            label6.Size = new Size(91, 19);
            label6.TabIndex = 11;
            label6.Text = "Tên nhiệm vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(58, 102);
            label5.Name = "label5";
            label5.Size = new Size(46, 19);
            label5.TabIndex = 10;
            label5.Text = "Mô tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(394, 28);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 9;
            label4.Text = "Ngày hạn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(394, 62);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 8;
            label3.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(392, 138);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 7;
            label2.Text = "Deadline";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 6;
            label1.Text = "Mã nhiệm vụ";
            // 
            // txtadd
            // 
            txtadd.Location = new Point(681, 260);
            txtadd.Name = "txtadd";
            txtadd.Size = new Size(109, 41);
            txtadd.TabIndex = 9;
            txtadd.Text = "Thêm";
            txtadd.UseVisualStyleBackColor = true;
            txtadd.Click += txtadd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvTask);
            groupBox2.Location = new Point(28, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(635, 291);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dgvTask
            // 
            dgvTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTask.Location = new Point(6, 13);
            dgvTask.Name = "dgvTask";
            dgvTask.Size = new Size(614, 272);
            dgvTask.TabIndex = 0;
            dgvTask.CellClick += dgvP_CellClick;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(497, 62);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(200, 23);
            txtStatus.TabIndex = 4;
            // 
            // txtProjectId
            // 
            txtProjectId.Location = new Point(497, 102);
            txtProjectId.Name = "txtProjectId";
            txtProjectId.Size = new Size(200, 23);
            txtProjectId.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(110, 102);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 23);
            txtDescription.TabIndex = 1;
            // 
            // txtTaskId
            // 
            txtTaskId.Location = new Point(110, 22);
            txtTaskId.Name = "txtTaskId";
            txtTaskId.Size = new Size(200, 23);
            txtTaskId.TabIndex = 0;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(681, 344);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(109, 41);
            btnedit.TabIndex = 11;
            btnedit.Text = "Sửa ";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDeadline);
            groupBox1.Controls.Add(dtpDueDate);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtAssignedTo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(txtProjectId);
            groupBox1.Controls.Add(txtTaskName);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtTaskId);
            groupBox1.Location = new Point(28, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 167);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(397, 102);
            label9.Name = "label9";
            label9.Size = new Size(72, 19);
            label9.TabIndex = 15;
            label9.Text = "Mã dự án ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(0, 139);
            label8.Name = "label8";
            label8.Size = new Size(112, 19);
            label8.TabIndex = 14;
            label8.Text = "Người đảm nhận";
            // 
            // txtAssignedTo
            // 
            txtAssignedTo.Location = new Point(110, 138);
            txtAssignedTo.Name = "txtAssignedTo";
            txtAssignedTo.Size = new Size(200, 23);
            txtAssignedTo.TabIndex = 13;
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(110, 62);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(200, 23);
            txtTaskName.TabIndex = 2;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(497, 29);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(200, 23);
            dtpDueDate.TabIndex = 16;
            // 
            // dtpDeadline
            // 
            dtpDeadline.Location = new Point(497, 135);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(200, 23);
            dtpDeadline.TabIndex = 17;
            // 
            // task
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
            Name = "task";
            Text = "task";
            Load += task_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTask).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button btnDelete;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button txtadd;
        private GroupBox groupBox2;
        private DataGridView dgvTask;
        private TextBox txtStatus;
        private TextBox txtProjectId;
        private TextBox txtDescription;
        private TextBox txtTaskId;
        private Button btnedit;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtAssignedTo;
        private TextBox txtTaskName;
        private Label label9;
        private DateTimePicker dtpDeadline;
        private DateTimePicker dtpDueDate;
    }
}