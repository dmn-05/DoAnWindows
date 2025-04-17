using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using PM_QL_BanHoa.BUS;

namespace PM_QL_BanHoa {
  public partial class fEmployee : Form {
    string strKetNoi = "Data Source=.\\SQLEXPRESS01;Initial Catalog=QuanLyBanHang;Integrated Security=True";
    DataSet dsNhanVien = new DataSet();
    SqlDataAdapter daNV;
    public fEmployee() {
      InitializeComponent();
    }

    private void fQLNV_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }
    }

    private void fEmployee_Load(object sender, EventArgs e) {
      dgvEmployee.AutoGenerateColumns = false;
      daNV = new SqlDataAdapter("Select * From NhanVien Where TrangThai = 1", strKetNoi);
      SqlCommandBuilder scb = new SqlCommandBuilder(daNV);
      SqlCommand insCommand = new SqlCommand();
      insCommand.CommandText = "INSERT INTO NhanVien (TenNV, TenDangNhap, MatKhau, SoDienThoai, Email, DiaChi, ChucVu, TrangThai) VALUES (@TenNV, @TenDangNhap, @MatKhau, @SoDienThoai, @Email, @DiaChi, @ChucVu, 1)";
      insCommand.Parameters.Add("@TenNV", SqlDbType.NVarChar, 100, "TenNV");
      insCommand.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar, 100, "TenDangNhap");
      insCommand.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 50, "MatKhau");
      insCommand.Parameters.Add("@SoDienThoai", SqlDbType.VarChar, 10, "SoDienThoai");
      insCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email");
      insCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 1000, "DiaChi");
      insCommand.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 50, "ChucVu");
      daNV.InsertCommand = insCommand;
      LoadDSNhanVien();
    }
    private void LoadDSNhanVien() {
      if (dsNhanVien.Tables["NhanVien"] != null) {
        dsNhanVien.Tables["NhanVien"].Clear();
      }
      daNV.Fill(dsNhanVien, "NhanVien");
      dgvEmployee.DataSource = dsNhanVien.Tables["NhanVien"];
    }

    private void btnSave_Click(object sender, EventArgs e) {
      try {
        // Commit dữ liệu trước khi xóa
        //Khi người dùng nhập dữ liệu vào một ô nhưng chưa nhấn Enter hoặc di chuyển sang ô khác, thì dòng đó vẫn đang ở trạng thái "chỉnh sửa"(dirty row).
        //Nếu bạn cố gắng xóa dòng này mà chưa lưu lại, DataGridView sẽ báo lỗi.
        //Giải pháp: CommitEdit() và EndEdit() giúp xác nhận rằng dữ liệu trong ô hiện tại sẽ được lưu vào DataTable trước khi tiếp tục xóa.
        if (dgvEmployee.IsCurrentRowDirty) {
          dgvEmployee.CommitEdit(DataGridViewDataErrorContexts.Commit);
          dgvEmployee.EndEdit();
        }

        // Hủy dòng mới nếu có
        //Khi DataGridView có một dòng mới chưa có dữ liệu và chưa được lưu, nó sẽ bị coi là một "uncommitted new row".
        //Nếu cố gắng xóa dòng này bằng dgvEmployee.Rows.RemoveAt(i), lỗi "Uncommitted new row cannot be deleted" sẽ xuất hiện.
        //Giải pháp: CancelEdit() giúp loại bỏ trạng thái của dòng mới trước khi thực hiện xóa.
        if (dgvEmployee.CurrentRow != null && dgvEmployee.CurrentRow.IsNewRow) {
          dgvEmployee.CancelEdit();
        }

        // Lặp từ dưới lên để tránh lỗi khi xóa dòng
        for (int i = dgvEmployee.Rows.Count - 1; i >= 0; i--) {
          DataGridViewRow row = dgvEmployee.Rows[i];

          if (
            row.Cells["colTenNV"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colTenNV"].Value.ToString()) ||
            row.Cells["colTenDangNhap"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colTenDangNhap"].Value.ToString()) ||
            row.Cells["colMatKhau"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colMatKhau"].Value.ToString()) ||
            row.Cells["colEmail"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colEmail"].Value.ToString()) ||
            row.Cells["colSoDienThoai"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colSoDienThoai"].Value.ToString()) ||
            row.Cells["colChucVu"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colChucVu"].Value.ToString()) ||
            row.Cells["colDiaChi"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colDiaChi"].Value.ToString())
            ) {
            if (!row.IsNewRow) {
              if (MessageBox.Show($"Bạn có muốn xóa dòng dữ liệu dòng có MaNV {row.Cells["colMaNV"].Value}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                dgvEmployee.Rows.RemoveAt(i);
              } else {
                foreach (DataGridViewCell cell in row.Cells) {
                  if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString())) {
                    dgvEmployee.CurrentCell = cell; // Di chuyển focus đến ô trống
                    dgvEmployee.BeginEdit(true); // Bắt đầu chế độ chỉnh sửa
                    return; // Dừng lại để bắt người dùng nhập mật khẩu
                  }
                }
              }
            }
          }
        }

        // Cập nhật lại database
        SqlCommandBuilder builder = new SqlCommandBuilder(daNV);

      } catch (Exception ex) {
        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }


      if (dsNhanVien.Tables["NhanVien"].Rows.Count > 0) {
        daNV.Update(dsNhanVien, "NhanVien");
        LoadDSNhanVien();
      }
    }

    private void btnSearch_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(txtName.Text)) {
        LoadDSNhanVien();
        return;
      }

      string name = txtName.Text.Trim();
      string query = "SELECT * FROM NhanVien WHERE TenNV LIKE @Name";
      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query, new object[] { "%" + name + "%" });
      if (dsNhanVien.Tables.Contains("NhanVien")) {
        dsNhanVien.Tables["NhanVien"].Clear();  // Xóa dữ liệu cũ
        dsNhanVien.Tables["NhanVien"].Merge(data);  // Gộp dữ liệu mới vào
      } else {
        dsNhanVien.Tables.Add(data);  // Nếu chưa có, thêm bảng mới vào DataSet
        dsNhanVien.Tables["NhanVien"].TableName = "NhanVien"; // Đặt lại tên bảng
      }

      dgvEmployee.DataSource = dsNhanVien.Tables["NhanVien"]; // Cập nhật dữ liệu cho DataGridView
    }

  }
}

