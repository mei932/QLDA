namespace QLDA
{
    partial class TrangChu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            panel_menu = new Panel();
            pictureBox1 = new PictureBox();
            panel_bt = new Panel();
            btnus = new Button();
            lblWelcome1 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel_body = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lblWelcome = new Label();
            panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_bt.SuspendLayout();
            panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_menu
            // 
            panel_menu.BackColor = Color.FromArgb(255, 192, 192);
            panel_menu.Controls.Add(pictureBox1);
            panel_menu.Controls.Add(panel_bt);
            panel_menu.Location = new Point(1, 2);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(234, 572);
            panel_menu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 115);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel_bt
            // 
            panel_bt.Controls.Add(btnus);
            panel_bt.Controls.Add(lblWelcome1);
            panel_bt.Controls.Add(button5);
            panel_bt.Controls.Add(button4);
            panel_bt.Controls.Add(button3);
            panel_bt.Controls.Add(button2);
            panel_bt.Controls.Add(button1);
            panel_bt.Location = new Point(0, 134);
            panel_bt.Name = "panel_bt";
            panel_bt.Size = new Size(234, 425);
            panel_bt.TabIndex = 0;
            // 
            // btnus
            // 
            btnus.BackColor = Color.FromArgb(255, 128, 128);
            btnus.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnus.Location = new Point(3, 346);
            btnus.Name = "btnus";
            btnus.Size = new Size(222, 47);
            btnus.TabIndex = 5;
            btnus.Text = "Quản lý người dùng";
            btnus.UseVisualStyleBackColor = false;
            btnus.Click += button6_Click;
            // 
            // lblWelcome1
            // 
            lblWelcome1.AutoSize = true;
            lblWelcome1.BackColor = Color.FromArgb(255, 192, 192);
            lblWelcome1.Font = new Font("Segoe UI", 11F);
            lblWelcome1.ForeColor = Color.Blue;
            lblWelcome1.Location = new Point(11, 396);
            lblWelcome1.Name = "lblWelcome1";
            lblWelcome1.Size = new Size(50, 20);
            lblWelcome1.TabIndex = 2;
            lblWelcome1.Text = "label1";
            lblWelcome1.Click += label1_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 128);
            button5.Font = new Font("Arial", 12F, FontStyle.Bold);
            button5.Location = new Point(3, 272);
            button5.Name = "button5";
            button5.Size = new Size(222, 47);
            button5.TabIndex = 4;
            button5.Text = "Document";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Font = new Font("Arial", 12F, FontStyle.Bold);
            button4.Location = new Point(3, 206);
            button4.Name = "button4";
            button4.Size = new Size(222, 47);
            button4.TabIndex = 3;
            button4.Text = "Quản lý task";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Arial", 12F, FontStyle.Bold);
            button3.Location = new Point(3, 135);
            button3.Name = "button3";
            button3.Size = new Size(222, 47);
            button3.TabIndex = 2;
            button3.Text = "Quản lý Team";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            button2.Location = new Point(3, 66);
            button2.Name = "button2";
            button2.Size = new Size(222, 47);
            button2.TabIndex = 1;
            button2.Text = "Attachment";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(222, 47);
            button1.TabIndex = 0;
            button1.Text = "Quản lý dự án";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel_body
            // 
            panel_body.BackColor = SystemColors.ActiveCaption;
            panel_body.Controls.Add(pictureBox2);
            panel_body.Controls.Add(label2);
            panel_body.Controls.Add(lblWelcome);
            panel_body.Location = new Point(232, 2);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(834, 569);
            panel_body.TabIndex = 1;
            panel_body.Paint += panel_body_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(68, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(705, 430);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(656, 7);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F);
            lblWelcome.ForeColor = Color.Red;
            lblWelcome.Location = new Point(696, 7);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 21);
            lblWelcome.TabIndex = 0;
            lblWelcome.Click += label1_Click;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1066, 571);
            Controls.Add(panel_menu);
            Controls.Add(panel_body);
            ForeColor = SystemColors.ControlText;
            Name = "TrangChu";
            Text = "Trang chủ ";
            Load += Form1_Load;
            panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_bt.ResumeLayout(false);
            panel_bt.PerformLayout();
            panel_body.ResumeLayout(false);
            panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_menu;
        private Panel panel_bt;
        private Panel panel_body;
        private Button button1;
        private Button btnus;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label lblWelcome;
        private Label label2;
        private Label lblWelcome1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
