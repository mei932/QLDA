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
using System.Xml.Linq;

namespace QLDA
{
    public partial class team : Form
    {
        ModyfiAll modyfiall = new ModyfiAll();
        public team()
        {
            InitializeComponent();
        }

        private void team_Load(object sender, EventArgs e)
        {
            load();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("ID không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtnhom.Text))
            {
                MessageBox.Show("Mã nhóm không được để trống.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLd.Text))
            {
                MessageBox.Show("Mã leader không được để trống.");
                return false;

            }
            if (string.IsNullOrWhiteSpace(txtmaDA.Text))
            {
                MessageBox.Show("Mã dự án không được để trống.");
                return false;
            }

            return true;
        }

        public void load()
        {
            try
            {
                if (modyfiall != null)
                {
                    string query = "SELECT * FROM Team"; // Truy vấn lấy tất cả dữ liệu từ bảng Project
                    DataTable dataTable = modyfiall.Table(query);
                    dgvTeam.DataSource = dataTable; // Đổ dữ liệu vào DataGridView
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

        private void txtadd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string sqlCheck = "SELECT COUNT(*) FROM Team WHERE team_id = @Id";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@Id", txtId.Text);

                try
                {
                    conn.Open();
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("ID đã tồn tại!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra ID : " + ex.Message);
                    return;
                }
                finally
                {
                    conn.Close();
                }

                string queryInsert = "INSERT INTO Team (team_id, team_name, team_leader, project_id) VALUES (@Id, @Name, @ld, @pj)";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, conn);
                cmdInsert.Parameters.AddWithValue("@Id", txtId.Text);
                cmdInsert.Parameters.AddWithValue("@Name", txtnhom.Text);
                cmdInsert.Parameters.AddWithValue("@ld", txtLd.Text);
                cmdInsert.Parameters.AddWithValue("@pj", txtmaDA.Text);



                try
                {
                    conn.Open();
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    load(); // Tải lại dữ liệu trong DataGridView
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
            txtnhom.Clear();
            txtId.Clear();
            txtmaDA.Clear();

        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SqlConnection conn = connection.GetSqlConnection();
                string queryUpdate = "UPDATE Team SET team_name = @Name, team_leader = @Ld, project_id = @ProjectId WHERE team_id = @Id";
                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@Id", txtId.Text);
                cmdUpdate.Parameters.AddWithValue("@Name", txtnhom.Text);
                cmdUpdate.Parameters.AddWithValue("@Ld", txtLd.Text);
                cmdUpdate.Parameters.AddWithValue("@ProjectId", txtmaDA.Text);

                try
                {
                    conn.Open();
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật nhóm thành công!");
                    load(); // Tải lại dữ liệu trong DataGridView
                    ClearTextBoxes(); // Xóa các TextBox sau khi cập nhật thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật nhóm: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeam.Rows.Count > 1)
            {
                string choose = dgvTeam.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE Team ";
                query += " WHERE team_id = '" + choose + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modyfiall.Command(query);
                        MessageBox.Show("Bạn đã xóa thành công!");
                        team_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        private void dgvTeam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTeam.Rows.Count >= 0 && e.RowIndex >= 0)
            {
                txtId.Text = dgvTeam.SelectedRows[0].Cells[0].Value.ToString();
                txtnhom.Text = dgvTeam.SelectedRows[0].Cells[1].Value.ToString();
                txtLd.Text = dgvTeam.SelectedRows[0].Cells[2].Value.ToString();
                txtmaDA.Text = dgvTeam.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
