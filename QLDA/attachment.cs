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
    public partial class attachment : Form
    {
        private string loggedInUserId;
        ModyfiAll modyfiall = new ModyfiAll();

        public attachment(string userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void dgvDocument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAttachment.Rows.Count >= 0 && e.RowIndex >= 0)
            {
                txtAttachmentId.Text = dgvAttachment.SelectedRows[0].Cells[0].Value.ToString();
                txtAttachmentName.Text = dgvAttachment.SelectedRows[0].Cells[1].Value.ToString();
                txtFilePath.Text = dgvAttachment.SelectedRows[0].Cells[2].Value.ToString();
                txtUploadedBy.Text = dgvAttachment.SelectedRows[0].Cells[3].Value.ToString();
                // Note: You might want to format the date appropriately if needed
                txtTaskId.Text = dgvAttachment.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void ClearAttachmentTextBoxes()
        {
            txtAttachmentId.Clear();
            txtAttachmentName.Clear();
            txtFilePath.Clear();
            txtUploadedBy.Clear();
            txtTaskId.Clear();
        }
        private bool ValidateAttachmentInput()
        {
            if (string.IsNullOrWhiteSpace(txtAttachmentId.Text))
            {
                MessageBox.Show("ID đính kèm không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAttachmentName.Text))
            {
                MessageBox.Show("Tên đính kèm không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                MessageBox.Show("Đường dẫn tệp không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUploadedBy.Text))
            {
                MessageBox.Show("Người tải lên không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTaskId.Text))
            {
                MessageBox.Show("ID công việc không được để trống.");
                return false;
            }

            return true;
        }

        private void attachment_Load(object sender, EventArgs e)
        {
            LoadAttachmentData();
        }
        public void LoadAttachmentData()
        {
            try
            {
                if (modyfiall != null)
                {
                    string query = "SELECT * FROM Attachment"; // Query to get all data from Attachment table
                    DataTable dataTable = modyfiall.Table(query);
                    dgvAttachment.DataSource = dataTable; // Bind data to DataGridView
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
            if (ValidateAttachmentInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string sqlCheck = "SELECT COUNT(*) FROM Attachment WHERE attachment_id = @AttachmentId";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@AttachmentId", txtAttachmentId.Text);

                try
                {
                    conn.Open();
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("ID đính kèm đã tồn tại!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra ID đính kèm: " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                string queryInsert = "INSERT INTO Attachment (attachment_id, attachment_name, file_path, uploaded_by, uploaded_at, task_id) VALUES (@AttachmentId, @AttachmentName, @FilePath, @UploadedBy, @UploadedAt, @TaskId)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                cmdInsert.Parameters.AddWithValue("@AttachmentId", txtAttachmentId.Text);
                cmdInsert.Parameters.AddWithValue("@AttachmentName", txtAttachmentName.Text);
                cmdInsert.Parameters.AddWithValue("@FilePath", txtFilePath.Text);
                cmdInsert.Parameters.AddWithValue("@UploadedBy", loggedInUserId); // Use logged-in user ID
                cmdInsert.Parameters.AddWithValue("@UploadedAt", DateTime.Now);
                cmdInsert.Parameters.AddWithValue("@TaskId", txtTaskId.Text);

                try
                {
                    conn.Open();
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("Thêm đính kèm thành công!");
                    LoadAttachmentData(); // Reload attachment data
                    ClearAttachmentTextBoxes(); // Clear textboxes after successful addition
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm đính kèm: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (ValidateAttachmentInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string queryUpdate = "UPDATE Attachment SET attachment_name = @AttachmentName, file_path = @FilePath, uploaded_by = @UploadedBy, uploaded_at = @UploadedAt, task_id = @TaskId WHERE attachment_id = @AttachmentId";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@AttachmentId", txtAttachmentId.Text);
                cmdUpdate.Parameters.AddWithValue("@AttachmentName", txtAttachmentName.Text);
                cmdUpdate.Parameters.AddWithValue("@FilePath", txtFilePath.Text);
                cmdUpdate.Parameters.AddWithValue("@UploadedBy", loggedInUserId); // Use logged-in user ID
                cmdUpdate.Parameters.AddWithValue("@UploadedAt", DateTime.Now);
                cmdUpdate.Parameters.AddWithValue("@TaskId", txtTaskId.Text);

                try
                {
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật đính kèm thành công!");
                    LoadAttachmentData(); // Reload attachment data
                    ClearAttachmentTextBoxes(); // Clear textboxes after successful update
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật đính kèm: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
