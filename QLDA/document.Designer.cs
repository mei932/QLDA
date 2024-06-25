namespace QLDA
{
    partial class document
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
            txtFilePath = new TextBox();
            txtadd = new Button();
            groupBox2 = new GroupBox();
            dgvDocument = new DataGridView();
            txtTaskId = new TextBox();
            txtDocumentId = new TextBox();
            btnedit = new Button();
            groupBox1 = new GroupBox();
            btnBrowse = new Button();
            txtDocumentName = new TextBox();
            label2 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocument).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Bold);
            label7.Location = new Point(332, -25);
            label7.Name = "label7";
            label7.Size = new Size(61, 24);
            label7.TabIndex = 18;
            label7.Text = "Team";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(672, 438);
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
            label6.Size = new Size(74, 19);
            label6.TabIndex = 11;
            label6.Text = "Tên tệp tin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(359, 47);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 9;
            label4.Text = "Đường dẫn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(359, 101);
            label3.Name = "label3";
            label3.Size = new Size(94, 19);
            label3.TabIndex = 8;
            label3.Text = "Mã nhiệm vụ ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 6;
            label1.Text = "Mã tệp tin";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(443, 43);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(200, 23);
            txtFilePath.TabIndex = 5;
            // 
            // txtadd
            // 
            txtadd.Location = new Point(672, 267);
            txtadd.Name = "txtadd";
            txtadd.Size = new Size(109, 41);
            txtadd.TabIndex = 15;
            txtadd.Text = "Thêm";
            txtadd.UseVisualStyleBackColor = true;
            txtadd.Click += txtadd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDocument);
            groupBox2.Location = new Point(12, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(635, 291);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dgvDocument
            // 
            dgvDocument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocument.Location = new Point(7, 13);
            dgvDocument.Name = "dgvDocument";
            dgvDocument.Size = new Size(614, 272);
            dgvDocument.TabIndex = 0;
            dgvDocument.CellClick += dgvDocument_CellClick;
            // 
            // txtTaskId
            // 
            txtTaskId.Location = new Point(459, 101);
            txtTaskId.Name = "txtTaskId";
            txtTaskId.Size = new Size(200, 23);
            txtTaskId.TabIndex = 4;
            // 
            // txtDocumentId
            // 
            txtDocumentId.Location = new Point(110, 46);
            txtDocumentId.Name = "txtDocumentId";
            txtDocumentId.Size = new Size(200, 23);
            txtDocumentId.TabIndex = 0;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(672, 347);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(109, 41);
            btnedit.TabIndex = 17;
            btnedit.Text = "Sửa ";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFilePath);
            groupBox1.Controls.Add(txtTaskId);
            groupBox1.Controls.Add(txtDocumentName);
            groupBox1.Controls.Add(txtDocumentId);
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 167);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(649, 41);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 26);
            btnBrowse.TabIndex = 12;
            btnBrowse.Text = "Chọn";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtDocumentName
            // 
            txtDocumentName.Location = new Point(110, 104);
            txtDocumentName.Name = "txtDocumentName";
            txtDocumentName.Size = new Size(200, 23);
            txtDocumentName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Bold);
            label2.Location = new Point(318, 22);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 19;
            label2.Text = "Document";
            // 
            // document
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(818, 530);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(btnDelete);
            Controls.Add(txtadd);
            Controls.Add(groupBox2);
            Controls.Add(btnedit);
            Controls.Add(groupBox1);
            Name = "document";
            Text = "document";
            Load += document_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocument).EndInit();
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
        private TextBox txtFilePath;
        private Button txtadd;
        private GroupBox groupBox2;
        private DataGridView dgvDocument;
        private TextBox txtTaskId;
        private TextBox txtDocumentId;
        private Button btnedit;
        private GroupBox groupBox1;
        private TextBox txtDocumentName;
        private Label label2;
        private Button btnBrowse;
    }
}