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
    public partial class document : Form
    {
        ModyfiAll modyfiall = new ModyfiAll();
        public document()
        {
            InitializeComponent();
        }
        private bool ValidateDocumentInput()
        {
            if (string.IsNullOrWhiteSpace(txtDocumentId.Text))
            {
                MessageBox.Show("ID tài liệu không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDocumentName.Text))
            {
                MessageBox.Show("Tên tài liệu không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                MessageBox.Show("Đường dẫn tệp không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTaskId.Text))
            {
                MessageBox.Show("ID công việc không được để trống.");
                return false;
            }

            return true;
        }

        private void ClearDocumentTextBoxes()
        {
            txtDocumentId.Clear();
            txtDocumentName.Clear();
            txtFilePath.Clear();
            txtTaskId.Clear();
        }


        public void LoadDocumentData()
        {
            try
            {
                if (modyfiall != null)
                {
                    string query = "SELECT * FROM Document"; // Query to get all data from Document table
                    DataTable dataTable = modyfiall.Table(query);
                    dgvDocument.DataSource = dataTable; // Bind data to DataGridView
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

        private void document_Load(object sender, EventArgs e)
        {
            LoadDocumentData();
        }

        private void txtadd_Click(object sender, EventArgs e)
        {
            if (ValidateDocumentInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string sqlCheck = "SELECT COUNT(*) FROM Document WHERE document_id = @DocumentId";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@DocumentId", txtDocumentId.Text);

                try
                {
                    conn.Open();
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("ID tài liệu đã tồn tại!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra ID tài liệu: " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                string queryInsert = "INSERT INTO Document (document_id, document_name, file_path, task_id) VALUES (@DocumentId, @DocumentName, @FilePath, @TaskId)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                cmdInsert.Parameters.AddWithValue("@DocumentId", txtDocumentId.Text);
                cmdInsert.Parameters.AddWithValue("@DocumentName", txtDocumentName.Text);
                cmdInsert.Parameters.AddWithValue("@FilePath", txtFilePath.Text);
                cmdInsert.Parameters.AddWithValue("@TaskId", txtTaskId.Text);

                try
                {
                    conn.Open();
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("Thêm tài liệu thành công!");
                    LoadDocumentData(); // Reload document data
                    ClearDocumentTextBoxes(); // Clear textboxes after successful addition
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm tài liệu: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (ValidateDocumentInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string queryUpdate = "UPDATE Document SET document_name = @DocumentName, file_path = @FilePath, task_id = @TaskId WHERE document_id = @DocumentId";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@DocumentId", txtDocumentId.Text);
                cmdUpdate.Parameters.AddWithValue("@DocumentName", txtDocumentName.Text);
                cmdUpdate.Parameters.AddWithValue("@FilePath", txtFilePath.Text);
                cmdUpdate.Parameters.AddWithValue("@TaskId", txtTaskId.Text);

                try
                {
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật tài liệu thành công!");
                    LoadDocumentData(); // Reload document data
                    ClearDocumentTextBoxes(); // Clear textboxes after successful update
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật tài liệu: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvDocument.Rows.Count > 1)
            {
                string choose = dgvDocument.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE FROM Document WHERE document_id = '" + choose + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa tài liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modyfiall.Command(query);
                        MessageBox.Show("Xóa tài liệu thành công!");
                        LoadDocumentData(); // Reload document data
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tài liệu: " + ex.Message);
                }
            }
        }

        private void dgvDocument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocument.Rows.Count >= 0 && e.RowIndex >= 0)
            {
                txtDocumentId.Text = dgvDocument.SelectedRows[0].Cells[0].Value.ToString();
                txtDocumentName.Text = dgvDocument.SelectedRows[0].Cells[1].Value.ToString();
                txtFilePath.Text = dgvDocument.SelectedRows[0].Cells[2].Value.ToString();
                txtTaskId.Text = dgvDocument.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
