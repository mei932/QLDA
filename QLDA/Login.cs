using Microsoft.Data.SqlClient;
using QLDA.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA
{
    public partial class Login : Form
    {
        public string LoggedInUserId { get; private set; }
        public string LoggedInUserRole { get; private set; }
        public Login()
        {
            InitializeComponent();
        }

        private void bthLogin_Click(object sender, EventArgs e)
        {

            string username = txtUser.Text.Trim();
            string password = txtpw.Text.Trim();

            if (ValidateLogin(username, password))
            {
                /*MessageBox.Show("Bạn đang đăng nhập với vai trò: " + LoggedInUserRole);*/
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private bool ValidateLogin(string username, string password)
        {
           

            using (SqlConnection conn = connection.GetSqlConnection())
            {
                string query = "SELECT user_id, role FROM Userr WHERE username = @Username AND password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        LoggedInUserId = reader["user_id"].ToString();
                        LoggedInUserRole = reader["role"].ToString();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message);
                    return false;
                }
            }
        }

    }
}
