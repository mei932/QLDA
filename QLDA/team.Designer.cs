namespace QLDA
{
    partial class team
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
            txtLd = new TextBox();
            txtadd = new Button();
            groupBox2 = new GroupBox();
            dgvTeam = new DataGridView();
            txtmaDA = new TextBox();
            txtId = new TextBox();
            btnedit = new Button();
            groupBox1 = new GroupBox();
            txtnhom = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeam).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 15F, FontStyle.Bold);
            label7.Location = new Point(341, 15);
            label7.Name = "label7";
            label7.Size = new Size(61, 24);
            label7.TabIndex = 12;
            label7.Text = "Team";
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
            label6.Location = new Point(19, 105);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 11;
            label6.Text = "Tên nhóm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(381, 47);
            label4.Name = "label4";
            label4.Size = new Size(117, 19);
            label4.TabIndex = 9;
            label4.Text = "Người hướng dẫn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(403, 101);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 8;
            label3.Text = "Mã ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 6;
            label1.Text = "Mã nhóm";
            // 
            // txtLd
            // 
            txtLd.Location = new Point(495, 43);
            txtLd.Name = "txtLd";
            txtLd.Size = new Size(200, 23);
            txtLd.TabIndex = 5;
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
            groupBox2.Controls.Add(dgvTeam);
            groupBox2.Location = new Point(28, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(635, 291);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dgvTeam
            // 
            dgvTeam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeam.Location = new Point(6, 13);
            dgvTeam.Name = "dgvTeam";
            dgvTeam.Size = new Size(614, 272);
            dgvTeam.TabIndex = 0;
            dgvTeam.CellClick += dgvTeam_CellClick;
            // 
            // txtmaDA
            // 
            txtmaDA.Location = new Point(497, 101);
            txtmaDA.Name = "txtmaDA";
            txtmaDA.Size = new Size(200, 23);
            txtmaDA.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(110, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 0;
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
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLd);
            groupBox1.Controls.Add(txtmaDA);
            groupBox1.Controls.Add(txtnhom);
            groupBox1.Controls.Add(txtId);
            groupBox1.Location = new Point(28, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 167);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtnhom
            // 
            txtnhom.Location = new Point(110, 104);
            txtnhom.Name = "txtnhom";
            txtnhom.Size = new Size(200, 23);
            txtnhom.TabIndex = 2;
            // 
            // team
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
            Name = "team";
            Text = "team";
            Load += team_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTeam).EndInit();
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
        private TextBox txtLd;
        private Button txtadd;
        private GroupBox groupBox2;
        private DataGridView dgvTeam;
        private TextBox txtmaDA;
        private TextBox txtId;
        private Button btnedit;
        private GroupBox groupBox1;
        private TextBox txtnhom;
    }
}