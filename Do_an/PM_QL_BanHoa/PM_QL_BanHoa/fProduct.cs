using BUS;
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

namespace PM_QL_BanHoa {
  public partial class fProduct : Form {
    string strKetNoi = "Data Source=.\\SQLEXPRESS01;Initial Catalog=QuanLyBanHang;Integrated Security=True";
    DataSet dsSanPham = new DataSet();
    SqlDataAdapter daSP;
    public fProduct() {
      InitializeComponent();
    }
    private void fProduct_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }
    }

    private void fProduct_Load(object sender, EventArgs e) {
      dgvProduct.AutoGenerateColumns = false;
      daSP = new SqlDataAdapter("Select * From SanPham", strKetNoi);
      SqlCommandBuilder scb = new SqlCommandBuilder(daSP);
      SqlCommand insCommand = new SqlCommand();
      insCommand.CommandText = "INSERT INTO SanPham (TenSP, GiaBanLe, GiaNhap, GiaXuat, SoLuongTonKho) VALUES (@TenSP, @GiaBanLe, @GiaNhap, @GiaXuat, @SoLuongTonKho)";
      insCommand.Parameters.Add("@TenSP", SqlDbType.NVarChar, 100, "TenSP");
      insCommand.Parameters.Add("@GiaBanLe", SqlDbType.NVarChar, 100, "GiaBanLe");
      insCommand.Parameters.Add("@GiaNhap", SqlDbType.NVarChar, 50, "GiaNhap");
      insCommand.Parameters.Add("@GiaXuat", SqlDbType.VarChar, 10, "GiaXuat");
      insCommand.Parameters.Add("@SoLuongTonKho", SqlDbType.NVarChar, 100, "SoLuongTonKho");
      daSP.InsertCommand = insCommand;
      LoadDSSanPham();
    }
    private void LoadDSSanPham() {
      if (dsSanPham.Tables["SanPham"] != null) {
        dsSanPham.Tables["SanPham"].Clear();
      }
      daSP.Fill(dsSanPham, "SanPham");
      dgvProduct.DataSource = dsSanPham.Tables["SanPham"];
    }

    private void btnSave_Click(object sender, EventArgs e) {
      try {
        // Commit dữ liệu trước khi xóa
        //Khi người dùng nhập dữ liệu vào một ô nhưng chưa nhấn Enter hoặc di chuyển sang ô khác, thì dòng đó vẫn đang ở trạng thái "chỉnh sửa"(dirty row).
        //Nếu bạn cố gắng xóa dòng này mà chưa lưu lại, DataGridView sẽ báo lỗi.
        //Giải pháp: CommitEdit() và EndEdit() giúp xác nhận rằng dữ liệu trong ô hiện tại sẽ được lưu vào DataTable trước khi tiếp tục xóa.
        if (dgvProduct.IsCurrentRowDirty) {
          dgvProduct.CommitEdit(DataGridViewDataErrorContexts.Commit);
          dgvProduct.EndEdit();
        }

        // Hủy dòng mới nếu có
        //Khi DataGridView có một dòng mới chưa có dữ liệu và chưa được lưu, nó sẽ bị coi là một "uncommitted new row".
        //Nếu cố gắng xóa dòng này bằng dgvProduct.Rows.RemoveAt(i), lỗi "Uncommitted new row cannot be deleted" sẽ xuất hiện.
        //Giải pháp: CancelEdit() giúp loại bỏ trạng thái của dòng mới trước khi thực hiện xóa.
        if (dgvProduct.CurrentRow != null && dgvProduct.CurrentRow.IsNewRow) {
          dgvProduct.CancelEdit();
        }

        // Lặp từ dưới lên để tránh lỗi khi xóa dòng
        for (int i = dgvProduct.Rows.Count - 1; i >= 0; i--) {
          DataGridViewRow row = dgvProduct.Rows[i];

          if (
            row.Cells["colTenSP"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colTenSP"].Value.ToString()) ||
            row.Cells["colGiaBanLe"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colGiaBanLe"].Value.ToString()) ||
            row.Cells["colGiaNhap"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colGiaNhap"].Value.ToString()) ||
            row.Cells["colSoLuongTonKho"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colSoLuongTonKho"].Value.ToString()) ||
            row.Cells["colGiaXuat"].Value == null || string.IsNullOrWhiteSpace(row.Cells["colGiaXuat"].Value.ToString())
            ) {
            if (!row.IsNewRow) {
              if (MessageBox.Show($"Bạn có muốn xóa dòng dữ liệu dòng có MaSP {row.Cells["colMaSP"].Value}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                dgvProduct.Rows.RemoveAt(i);
              } else {
                foreach (DataGridViewCell cell in row.Cells) {
                  if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString())) {
                    dgvProduct.CurrentCell = cell; // Di chuyển focus đến ô trống
                    dgvProduct.BeginEdit(true); // Bắt đầu chế độ chỉnh sửa
                    return; // Dừng lại để bắt người dùng nhập mật khẩu
                  }
                }
              }
            }
          }
        }

        // Cập nhật lại database
        SqlCommandBuilder builder = new SqlCommandBuilder(daSP);

      } catch (Exception ex) {
        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }


      if (dsSanPham.Tables["SanPham"].Rows.Count > 0) {
        daSP.Update(dsSanPham, "SanPham");
        LoadDSSanPham();
      }
    }

    private void btnSearch_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(txtName.Text)) {
        LoadDSSanPham();
        return;
      }

      string name = txtName.Text.Trim();
      string query = "SELECT * FROM SanPham WHERE TenSP LIKE @Name";

      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query, new object[] { "%" + name + "%" });

      if (dsSanPham.Tables.Contains("SanPham")) {
        dsSanPham.Tables["SanPham"].Clear();  // Xóa dữ liệu cũ
        dsSanPham.Tables["SanPham"].Merge(data);  // Gộp dữ liệu mới vào
      } else {
        dsSanPham.Tables.Add(data);  // Nếu chưa có, thêm bảng mới vào DataSet
        dsSanPham.Tables["SanPham"].TableName = "SanPham"; // Đặt lại tên bảng
      }

      dgvProduct.DataSource = dsSanPham.Tables["SanPham"]; // Cập nhật dữ liệu cho DataGridView
    }
  }
}
