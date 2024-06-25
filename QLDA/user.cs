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
    public partial class user : Form
    {
        ModyfiAll modyfiall = new ModyfiAll();
        public user()
        {
            InitializeComponent();
        }
        private bool ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("User ID cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Username cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtmk.Text))
            {
                MessageBox.Show("Password cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Email cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textrole.Text))
            {
                MessageBox.Show("Role cannot be empty.");
                return false;
            }

            return true;
        }

        private void ClearUserTextBoxes()
        {
            txtId.Clear();
            txtname.Clear();
            txtmk.Clear();
            txtemail.Clear();
            textrole.Clear();
        }
        public void LoadUserData()
        {
            try
            {
                if (modyfiall != null)
                {
                    string query = "SELECT * FROM Userr"; // Query to get all data from the Userr table
                    DataTable dataTable = modyfiall.Table(query);
                    dgvuser.DataSource = dataTable; // Bind data to DataGridView for users
                }
                else
                {
                    MessageBox.Show("ModyfiAll object is not initialized.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void user_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void dgvuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvuser.Rows.Count >= 0 && e.RowIndex >= 0)
            {
                txtId.Text = dgvuser.SelectedRows[0].Cells[0].Value.ToString();
                txtname.Text = dgvuser.SelectedRows[0].Cells[1].Value.ToString();
                txtmk.Text = dgvuser.SelectedRows[0].Cells[2].Value.ToString();
                txtemail.Text = dgvuser.SelectedRows[0].Cells[3].Value.ToString();
                textrole.Text = dgvuser.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void txtadd_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string sqlCheck = "SELECT COUNT(*) FROM Userr WHERE user_id = @userId";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@userId", txtId.Text);

                try
                {
                    conn.Open();
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("User ID already exists!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking user ID: " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                string queryInsert = "INSERT INTO Userr (user_id, username, password, email, role) VALUES (@userId, @username, @password,@email, @role)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                cmdInsert.Parameters.AddWithValue("@userId", txtId.Text);
                cmdInsert.Parameters.AddWithValue("@username", txtname.Text);
                cmdInsert.Parameters.AddWithValue("@password", txtmk.Text);
                cmdInsert.Parameters.AddWithValue("@email", txtemail.Text);
                cmdInsert.Parameters.AddWithValue("@role", textrole.Text);

                try
                {
                    conn.Open();
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("User added successfully!");
                    LoadUserData(); // Reload user data
                    ClearUserTextBoxes(); // Clear textboxes after successful addition
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding user: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string queryUpdate = "UPDATE Userr SET username = @username, password = @password, email = @role WHERE user_id = @userId";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@userId", txtId.Text);
                cmdUpdate.Parameters.AddWithValue("@username", txtname.Text);
                cmdUpdate.Parameters.AddWithValue("@password", txtmk.Text);
                cmdUpdate.Parameters.AddWithValue("@email", txtemail   .Text);
                cmdUpdate.Parameters.AddWithValue("@role", textrole.Text);

                try
                {
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully!");
                    LoadUserData(); // Reload user data
                    ClearUserTextBoxes(); // Clear textboxes after successful update
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvuser.Rows.Count > 1)
            {
                string choose = dgvuser.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM Userr WHERE user_id = '" + choose + "'";
                try
                {
                    if (MessageBox.Show("Do you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modyfiall.Command(query);
                        MessageBox.Show("User deleted successfully!");
                        LoadUserData(); // Reload user data
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
        }
    }
}
