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
    public partial class Project : Form
    {
        private ModyfiAll modyfiAll;
        public Project()
        {
            InitializeComponent();
            modyfiAll = new ModyfiAll();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            LoadProjectData();
        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("ID không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên dự án không được để trống.");
                return false;
            }

            if (!DateTime.TryParse(txtStartDate.Text, out _))
            {
                MessageBox.Show("Ngày bắt đầu không hợp lệ.");
                return false;
            }

            if (!DateTime.TryParse(txtEndate.Text, out _))
            {
                MessageBox.Show("Ngày kết thúc không hợp lệ.");
                return false;
            }

            if (!decimal.TryParse(txtBudget.Text, out _))
            {
                MessageBox.Show("Ngân sách không hợp lệ.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Trạng thái không được để trống.");
                return false;
            }

            return true;
        }
        private void LoadProjectData()
        {
            try
            {
                if (modyfiAll != null)
                {
                    string query = "SELECT * FROM Project"; // Truy vấn lấy tất cả dữ liệu từ bảng Project
                    DataTable dataTable = modyfiAll.Table(query);
                    dgvP.DataSource = dataTable; // Đổ dữ liệu vào DataGridView
                }
                else
                {
                    MessageBox.Show("ModyfiAll object is not initialized.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtadd_Click(object sender, EventArgs e)
        {

            if (ValidateInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string sqlCheck = "SELECT COUNT(*) FROM Project WHERE project_id = @Id";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@Id", txtId.Text);

                try
                {
                    conn.Open();
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("ID dự án đã tồn tại!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra ID dự án: " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                string queryInsert = "INSERT INTO Project (project_id, project_name, start_date, end_date, budget, status) VALUES (@Id, @Name, @StartDate, @EndDate, @Budget, @Status)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                cmdInsert.Parameters.AddWithValue("@Id", txtId.Text);
                cmdInsert.Parameters.AddWithValue("@Name", txtName.Text);
                cmdInsert.Parameters.AddWithValue("@StartDate", DateTime.Parse(txtStartDate.Text));
                cmdInsert.Parameters.AddWithValue("@EndDate", DateTime.Parse(txtEndate.Text));
                cmdInsert.Parameters.AddWithValue("@Budget", decimal.Parse(txtBudget.Text));
                cmdInsert.Parameters.AddWithValue("@Status", txtStatus.Text);

                try
                {
                    conn.Open();
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("Thêm dự án thành công!");
                    LoadProjectData(); // Tải lại dữ liệu trong DataGridView
                    ClearTextBoxes(); // Xóa các TextBox sau khi thêm thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm dự án: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }


        }

        private void ClearTextBoxes()
        {
            txtId.Clear();
            txtName.Clear();
            txtStartDate.Clear();
            txtEndate.Clear();
            txtBudget.Clear();
            txtStatus.Clear();
        }

        private void dgvP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvP.Rows.Count >= 0)
            {
                txtId.Text = dgvP.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvP.SelectedRows[0].Cells[1].Value.ToString();
                txtStartDate.Text = dgvP.SelectedRows[0].Cells[2].Value.ToString();
                txtEndate.Text = dgvP.SelectedRows[0].Cells[3].Value.ToString();
                txtBudget.Text = dgvP.SelectedRows[0].Cells[4].Value.ToString();
                txtStatus.Text = dgvP.SelectedRows[0].Cells[5].Value.ToString();

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string queryUpdate = "UPDATE Project SET project_name = @Name, start_date = @StartDate, end_date = @EndDate, budget = @Budget, status = @Status WHERE project_id = @Id";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@Id", txtId.Text);
                cmdUpdate.Parameters.AddWithValue("@Name", txtName.Text);
                cmdUpdate.Parameters.AddWithValue("@StartDate", DateTime.Parse(txtStartDate.Text));
                cmdUpdate.Parameters.AddWithValue("@EndDate", DateTime.Parse(txtEndate.Text));
                cmdUpdate.Parameters.AddWithValue("@Budget", decimal.Parse(txtBudget.Text));
                cmdUpdate.Parameters.AddWithValue("@Status", txtStatus.Text);

                try
                {
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật dự án thành công!");
                    LoadProjectData(); // Tải lại dữ liệu trong DataGridView
                    ClearTextBoxes(); // Xóa các TextBox sau khi cập nhật thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật dự án: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check lớn hơn 1 dòng
            if (dgvP.Rows.Count > 1)
            {
                string choose = dgvP.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE Project ";
                query += " WHERE project_id = '" + choose + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modyfiAll.Command(query);
                        MessageBox.Show("Bạn đã xóa thành công!");
                        Project_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }
    }
}
