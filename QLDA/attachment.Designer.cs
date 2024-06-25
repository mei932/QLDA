namespace QLDA
{
    partial class attachment
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
            label2 = new Label();
            btnBrowse = new Button();
            txtUploaded_at = new TextBox();
            txtAttachmentId = new TextBox();
            dgvAttachment = new DataGridView();
            txtAttachmentName = new TextBox();
            label7 = new Label();
            txtadd = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            btnedit = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label5 = new Label();
            txtTaskId = new TextBox();
            txtFilePath = new TextBox();
            txtUploadedBy = new TextBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvAttachment).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Bold);
            label2.Location = new Point(322, 4);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 26;
            label2.Text = "Attachment";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(316, 122);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 26);
            btnBrowse.TabIndex = 12;
            btnBrowse.Text = "Chọn";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtUploaded_at
            // 
            txtUploaded_at.Location = new Point(512, 82);
            txtUploaded_at.Name = "txtUploaded_at";
            txtUploaded_at.Size = new Size(200, 23);
            txtUploaded_at.TabIndex = 4;
            // 
            // txtAttachmentId
            // 
            txtAttachmentId.Location = new Point(127, 34);
            txtAttachmentId.Name = "txtAttachmentId";
            txtAttachmentId.Size = new Size(183, 23);
            txtAttachmentId.TabIndex = 0;
            // 
            // dgvAttachment
            // 
            dgvAttachment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttachment.Location = new Point(7, 13);
            dgvAttachment.Name = "dgvAttachment";
            dgvAttachment.Size = new Size(614, 272);
            dgvAttachment.TabIndex = 0;
            dgvAttachment.CellClick += dgvDocument_CellClick;
            // 
            // txtAttachmentName
            // 
            txtAttachmentName.Location = new Point(127, 81);
            txtAttachmentName.Name = "txtAttachmentName";
            txtAttachmentName.Size = new Size(183, 23);
            txtAttachmentName.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Bold);
            label7.Location = new Point(336, -43);
            label7.Name = "label7";
            label7.Size = new Size(61, 24);
            label7.TabIndex = 25;
            label7.Text = "Team";
            // 
            // txtadd
            // 
            txtadd.Location = new Point(676, 249);
            txtadd.Name = "txtadd";
            txtadd.Size = new Size(109, 41);
            txtadd.TabIndex = 22;
            txtadd.Text = "Thêm";
            txtadd.UseVisualStyleBackColor = true;
            txtadd.Click += txtadd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(0, 85);
            label6.Name = "label6";
            label6.Size = new Size(121, 19);
            label6.TabIndex = 11;
            label6.Text = "Attachment_name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(409, 38);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 9;
            label4.Text = "uploaded_by";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(409, 86);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 8;
            label3.Text = "Uploaded_at";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 34);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 6;
            label1.Text = "Attachment_ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(676, 420);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 41);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(676, 329);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(109, 41);
            btnedit.TabIndex = 24;
            btnedit.Text = "Sửa ";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTaskId);
            groupBox1.Controls.Add(txtFilePath);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUploadedBy);
            groupBox1.Controls.Add(txtUploaded_at);
            groupBox1.Controls.Add(txtAttachmentName);
            groupBox1.Controls.Add(txtAttachmentId);
            groupBox1.Location = new Point(16, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 167);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(444, 132);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 16;
            label8.Text = "Task_id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(45, 129);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 15;
            label5.Text = "File_path";
            // 
            // txtTaskId
            // 
            txtTaskId.Location = new Point(512, 128);
            txtTaskId.Name = "txtTaskId";
            txtTaskId.Size = new Size(200, 23);
            txtTaskId.TabIndex = 14;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(127, 125);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(183, 23);
            txtFilePath.TabIndex = 13;
            // 
            // txtUploadedBy
            // 
            txtUploadedBy.Location = new Point(512, 34);
            txtUploadedBy.Name = "txtUploadedBy";
            txtUploadedBy.Size = new Size(200, 23);
            txtUploadedBy.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvAttachment);
            groupBox2.Location = new Point(16, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(635, 291);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // attachment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(818, 530);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(txtadd);
            Controls.Add(btnDelete);
            Controls.Add(btnedit);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "attachment";
            Text = "attachment";
            Load += attachment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttachment).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnBrowse;
        private TextBox txtUploaded_at;
        private TextBox txtAttachmentId;
        private DataGridView dgvAttachment;
        private TextBox txtAttachmentName;
        private Label label7;
        private Button txtadd;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnDelete;
        private Button btnedit;
        private GroupBox groupBox1;
        private TextBox txtUploadedBy;
        private GroupBox groupBox2;
        private TextBox txtTaskId;
        private TextBox txtFilePath;
        private Label label8;
        private Label label5;
    }
}