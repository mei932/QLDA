namespace QLDA
{
    public partial class TrangChu : Form
    {
        private string loggedInUserId;
        private string loggedInUserRole;


        public TrangChu(string userId, string userRole)
        {
            InitializeComponent();
            loggedInUserId = userId;
            loggedInUserRole = userRole;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelcome1.Text = "Xin chào " + loggedInUserRole + " | Đăng xuất";
            lblWelcome1.Click += new EventHandler(label1_Click_1);

            MessageBox.Show("Bạn đang đăng nhập với vai trò: " + loggedInUserRole);
            if (loggedInUserRole != "Admin")
            {
                btnus.Visible = false;
            }
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Project());
        }



        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new attachment(loggedInUserId));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new team());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new task());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new document());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new user());

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
            Login loginForm = new Login();
            loginForm.Show(); // Show the login form
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
            Login loginForm = new Login();
            loginForm.Show(); // Show the login form
        }
    }
}

