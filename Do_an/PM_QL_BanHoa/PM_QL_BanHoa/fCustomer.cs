using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using PM_QL_BanHoa.BUS;

namespace PM_QL_BanHoa {
  public partial class fCustomer : Form {
    string strKetNoi = "Data Source=.\\SQLEXPRESS01;Initial Catalog=QuanLyBanHang;Integrated Security=True";
    DataSet dsKhachHang = new DataSet();
    SqlDataAdapter daKH;
    public fCustomer() {
      InitializeComponent();
    }

    private void fCustomer_Load(object sender, EventArgs e) {
      dgvCustomer.AutoGenerateColumns = false;
      daKH = new SqlDataAdapter("Select * From KhachHang", strKetNoi);
      SqlCommandBuilder scb = new SqlCommandBuilder(daKH);
      SqlCommand insCommand = new SqlCommand();
      insCommand.CommandText = "INSERT INTO KhachHang (TenKH, SoDienThoai, Email, DiaChi) VALUES (@TenKH, @SoDienThoai, @Email, @DiaChi)";
      insCommand.Parameters.Add("@TenKH", SqlDbType.NVarChar, 100, "TenKH");
      insCommand.Parameters.Add("@SoDienThoai", SqlDbType.VarChar, 10, "SoDienThoai");
      insCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email");
      insCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 1000, "DiaChi");
      daKH.InsertCommand = insCommand;
      LoadDSKhachHang();
    }
    private void LoadDSKhachHang() {
      if (dsKhachHang.Tables["KhachHang"] != null) {
        dsKhachHang.Tables["KhachHang"].Clear();
      }
      daKH.Fill(dsKhachHang, "KhachHang");
      dgvCustomer.DataSource = dsKhachHang.Tables["KhachHang"];
    }

    private void btnSave_Click(object sender, EventArgs e) {
      try {
        // Commit dữ liệu trước khi xóa
        //Khi người dùng nhập dữ liệu vào một ô nhưng chưa nhấn Enter hoặc di chuyển sang ô khác, thì dòng đó vẫn đang ở trạng thái "chỉnh sửa"(dirty row).
        //Nếu bạn cố gắng xóa dòng này mà chưa lưu lại, DataGridView sẽ báo lỗi.
        //Giải pháp: CommitEdit() và EndEdit() giúp xác nhận rằng dữ liệu trong ô hiện tại sẽ được lưu vào DataTable trước khi tiếp tục xóa.
        if (dgvCustomer.IsCurrentRowDirty) {
          dgvCustomer.CommitEdit(DataGridViewDataErrorContexts.Commit);
          dgvCustomer.EndEdit();
        }

        // Hủy dòng mới nếu có
        //Khi DataGridView có một dòng mới chưa có dữ liệu và chưa được lưu, nó sẽ bị coi là một "uncommitted new row".
        //Nếu cố gắng xóa dòng này bằng dgvCustomer.Rows.RemoveAt(i), lỗi "Uncommitted new row cannot be deleted" sẽ xuất hiện.
        //Giải pháp: CancelEdit() giúp loại bỏ trạng thái của dòng mới trước khi thực hiện xóa.
        if (dgvCustomer.CurrentRow != null && dgvCustomer.CurrentRow.IsNewRow) {
          dgvCustomer.CancelEdit();
        }

        // Lặp từ dưới lên để tránh lỗi khi xóa dòng
        for (int i = dgvCustomer.Rows.Count - 1; i >= 0; i--) {
          DataGridViewRow row = dgvCustomer.Rows[i];

          if (
            row.Cells["colTenKH"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colTenKH"].Value.ToString()) ||
            row.Cells["colEmail"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colEmail"].Value.ToString()) ||
            row.Cells["colSoDienThoai"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colSoDienThoai"].Value.ToString()) ||
            row.Cells["colDiaChi"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colDiaChi"].Value.ToString())
            ) {
            if (!row.IsNewRow) {
              if (MessageBox.Show($"Bạn có muốn xóa dòng dữ liệu dòng có MaKH {row.Cells["colMaKH"].Value}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                dgvCustomer.Rows.RemoveAt(i);
              } else {
                foreach (DataGridViewCell cell in row.Cells) {
                  if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString())) {
                    dgvCustomer.CurrentCell = cell; // Di chuyển focus đến ô MatKhau
                    dgvCustomer.BeginEdit(true); // Bắt đầu chế độ chỉnh sửa
                    return; // Dừng lại để bắt người dùng nhập mật khẩu
                  }
                }
              }
            }
          }
        }

        // Cập nhật lại database
        SqlCommandBuilder builder = new SqlCommandBuilder(daKH);

      } catch (Exception ex) {
        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }


      if (dsKhachHang.Tables["KhachHang"].Rows.Count > 0) {
        daKH.Update(dsKhachHang, "KhachHang");
        LoadDSKhachHang();
      }
    }

    private void fCustomer_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }

    }

    private void btnSearch_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(txtName.Text)) {
        LoadDSKhachHang();
        return;
      }

      string name = txtName.Text.Trim();
      string query = "SELECT * FROM KhachHang WHERE TenKH LIKE @Name";

      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query, new object[] { "%" + name + "%" });

      if (dsKhachHang.Tables.Contains("KhachHang")) {
        dsKhachHang.Tables["KhachHang"].Clear();  // Xóa dữ liệu cũ
        dsKhachHang.Tables["KhachHang"].Merge(data);  // Gộp dữ liệu mới vào
      } else {
        dsKhachHang.Tables.Add(data);  // Nếu chưa có, thêm bảng mới vào DataSet
        dsKhachHang.Tables["KhachHang"].TableName = "KhachHang"; // Đặt lại tên bảng
      }

      dgvCustomer.DataSource = dsKhachHang.Tables["KhachHang"]; // Cập nhật dữ liệu cho DataGridView
    }
  }
}
