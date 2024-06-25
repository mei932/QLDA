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
    public partial class task : Form
    {
        ModyfiAll modyfiall = new ModyfiAll();
        public task()
        {
            InitializeComponent();
        }

        private void task_Load(object sender, EventArgs e)
        {
            LoadTaskData();
        }
        private bool ValidateTaskInput()
        {
            if (string.IsNullOrWhiteSpace(txtTaskId.Text))
            {
                MessageBox.Show("ID công việc không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Tên công việc không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Mô tả không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAssignedTo.Text))
            {
                MessageBox.Show("Người được giao không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Trạng thái không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProjectId.Text))
            {
                MessageBox.Show("ID dự án không được để trống.");
                return false;
            }

            return true;
        }

        private void ClearTaskTextBoxes()
        {
            txtTaskId.Clear();
            txtTaskName.Clear();
            txtDescription.Clear();
            txtAssignedTo.Clear();
            txtStatus.Clear();
            txtProjectId.Clear();
        }
        public void LoadTaskData()
        {
            try
            {
                if (modyfiall != null)
                {
                    string query = "SELECT * FROM Task"; // Query to get all data from the Task table
                    DataTable dataTable = modyfiall.Table(query);
                    dgvTask.DataSource = dataTable; // Bind data to DataGridView for tasks
                }
                else
                {
                    MessageBox.Show("Đối tượng ModyfiAll chưa được khởi tạo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }


        private void txtadd_Click(object sender, EventArgs e)
        {
            if (ValidateTaskInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string sqlCheck = "SELECT COUNT(*) FROM Task WHERE task_id = @taskId";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@taskId", txtTaskId.Text);

                try
                {
                    conn.Open();
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("ID công việc đã tồn tại!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra ID công việc: " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                string queryInsert = "INSERT INTO Task (task_id, task_name, description, assigned_to, due_date, status, project_id, deadline) VALUES (@taskId, @taskName, @description, @assignedTo, @dueDate, @status, @projectId, @deadline)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                cmdInsert.Parameters.AddWithValue("@taskId", txtTaskId.Text);
                cmdInsert.Parameters.AddWithValue("@taskName", txtTaskName.Text);
                cmdInsert.Parameters.AddWithValue("@description", txtDescription.Text);
                cmdInsert.Parameters.AddWithValue("@assignedTo", txtAssignedTo.Text);
                cmdInsert.Parameters.AddWithValue("@dueDate", dtpDueDate.Value);
                cmdInsert.Parameters.AddWithValue("@status", txtStatus.Text);
                cmdInsert.Parameters.AddWithValue("@projectId", txtProjectId.Text);
                cmdInsert.Parameters.AddWithValue("@deadline", dtpDeadline.Value);

                try
                {
                    conn.Open();
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("Thêm công việc thành công!");
                    LoadTaskData(); // Reload task data
                    ClearTaskTextBoxes(); // Clear textboxes after successful addition
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm công việc: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (ValidateTaskInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string queryUpdate = "UPDATE Task SET task_name = @taskName, description = @description, assigned_to = @assignedTo, due_date = @dueDate, status = @status, project_id = @projectId, deadline = @deadline WHERE task_id = @taskId";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@taskId", txtTaskId.Text);
                cmdUpdate.Parameters.AddWithValue("@taskName", txtTaskName.Text);
                cmdUpdate.Parameters.AddWithValue("@description", txtDescription.Text);
                cmdUpdate.Parameters.AddWithValue("@assignedTo", txtAssignedTo.Text);
                cmdUpdate.Parameters.AddWithValue("@dueDate", dtpDueDate.Value);
                cmdUpdate.Parameters.AddWithValue("@status", txtStatus.Text);
                cmdUpdate.Parameters.AddWithValue("@projectId", txtProjectId.Text);
                cmdUpdate.Parameters.AddWithValue("@deadline", dtpDeadline.Value);

                try
                {
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật công việc thành công!");
                    LoadTaskData(); // Reload task data
                    ClearTaskTextBoxes(); // Clear textboxes after successful update
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật công việc: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTask.Rows.Count > 1)
            {
                string choose = dgvTask.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM Task WHERE task_id = '" + choose + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa công việc này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modyfiall.Command(query);
                        MessageBox.Show("Xóa công việc thành công!");
                        LoadTaskData(); // Reload task data
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa công việc: " + ex.Message);
                }
            }
        }

        private void dgvP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTask.Rows.Count >= 0 && e.RowIndex >= 0)
            {
                txtTaskId.Text = dgvTask.SelectedRows[0].Cells[0].Value.ToString();
                txtTaskName.Text = dgvTask.SelectedRows[0].Cells[1].Value.ToString();
                txtDescription.Text = dgvTask.SelectedRows[0].Cells[2].Value.ToString();
                txtAssignedTo.Text = dgvTask.SelectedRows[0].Cells[3].Value.ToString();
                dtpDueDate.Value = Convert.ToDateTime(dgvTask.SelectedRows[0].Cells[4].Value);
                txtStatus.Text = dgvTask.SelectedRows[0].Cells[5].Value.ToString();
                txtProjectId.Text = dgvTask.SelectedRows[0].Cells[6].Value.ToString();
                dtpDeadline.Value = Convert.ToDateTime(dgvTask.SelectedRows[0].Cells[7].Value);
            }
        }
    }
}
