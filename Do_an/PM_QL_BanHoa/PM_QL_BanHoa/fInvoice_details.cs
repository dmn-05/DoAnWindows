using BUS;
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

namespace PM_QL_BanHoa {
  public partial class fInvoice_details : Form {
    DataSet dsCTHoaDon = new DataSet();
    public fInvoice_details() {
      InitializeComponent();
    }

    private void fInvoice_details_Load(object sender, EventArgs e) {
      dgvInvoice_details.AutoGenerateColumns = false;
      LoadDSHD();
    }
    private void LoadDSHD() {
      string query = "Select * From ChiTietHoaDon";
      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query);
      if (dsCTHoaDon.Tables.Count > 0) {
        dsCTHoaDon.Tables[0].Clear();
        dsCTHoaDon.Tables[0].Merge(data);
      } else {
        dsCTHoaDon.Tables.Add(data);
      }
      dgvInvoice_details.DataSource = dsCTHoaDon.Tables[0]; // Đặt trực tiếp DataTable vào DataGridView
    }

    private void fInvoice_details_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }
    }
    private void btnSearch_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(txtMa.Text)) {
        LoadDSHD();
        return;
      }

      string name = txtMa.Text.Trim();
      string query = "SELECT * FROM ChiTietHoaDon WHERE MaHD LIKE @MaHD";

      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query, new object[] { "%" + name + "%" });

      if (dsCTHoaDon.Tables.Contains("CTHoaDon")) {
        dsCTHoaDon.Tables["CTHoaDon"].Clear();  // Xóa dữ liệu cũ
        dsCTHoaDon.Tables["CTHoaDon"].Merge(data);  // Gộp dữ liệu mới vào
      } else {
        dsCTHoaDon.Tables.Add(data);  // Nếu chưa có, thêm bảng mới vào DataSet
        dsCTHoaDon.Tables["CTHoaDon"].TableName = "CTHoaDon"; // Đặt lại tên bảng
      }

      dgvInvoice_details.DataSource = dsCTHoaDon.Tables["CTHoaDon"]; // Cập nhật dữ liệu cho DataGridView
    }
  }
}
