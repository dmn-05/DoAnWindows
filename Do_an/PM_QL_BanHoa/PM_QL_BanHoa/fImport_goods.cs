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
using DTO;

namespace PM_QL_BanHoa {
  public partial class fImport_goods : Form {
    DataSet dsHoaDonNhap = new DataSet();
    List<int> dsMaSP = new List<int>();
    public fImport_goods() {
      InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(cbMaSP.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text)) {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        return;
      }
      Import_goodsDTO HoaDon = new Import_goodsDTO();
      HoaDon.MaSP = int.Parse(cbMaSP.Text.Trim());
      HoaDon.NgayNhap = DateTime.Parse(dateNgayNhap.Text);
      HoaDon.SoLuong = int.Parse(txtSoLuong.Text);
      string query = "SELECT GiaNhap FROM SanPham WHERE MaSP = @MaSP";
      DataTable SanPham = DataProviderBUS.Instance.ExecuteQuery(query, new object[] { HoaDon.MaSP });
      if (SanPham.Rows.Count == 0) {
        MessageBox.Show("Không tìm thấy sản phẩm!");
        return;
      }
      HoaDon.ThanhTien = HoaDon.SoLuong * Convert.ToDouble(SanPham.Rows[0]["GiaNhap"]);
      query = "Insert into NhapHang (MaSP, NgayNhap, SoLuong, ThanhTien) values ( @MaSP , @NgayNhap , @SoLuong , @ThanhTien )";
      int data = DataProviderBUS.Instance.ExecuteNonQuery(query, new Object[] { HoaDon.MaSP, HoaDon.NgayNhap, HoaDon.SoLuong, HoaDon.ThanhTien });
      if (data > 0) {
        MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
        query = "Update SanPham Set SoLuongTonKho = SoLuongTonKho + @soluong Where MaSP = @MaSP";
        DataProviderBUS.Instance.ExecuteNonQuery(query, new object[] { HoaDon.SoLuong, HoaDon.MaSP });
      } else {
        MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK);
      }
      LoadDSHD();
    }
    private void LoadDSHD() {
      string query = "Select * From NhapHang";
      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query);
      if (dsHoaDonNhap.Tables.Count > 0) {
        dsHoaDonNhap.Tables[0].Clear();
        dsHoaDonNhap.Tables[0].Merge(data);
      } else {
        dsHoaDonNhap.Tables.Add(data);
      }
      dgvfImport_goods.DataSource = dsHoaDonNhap.Tables[0]; // Đặt trực tiếp DataTable vào DataGridView
    }
    private void fImport_goods_Load(object sender, EventArgs e) {
      dgvfImport_goods.AutoGenerateColumns = false;
      LoadMaSP();
      LoadDSHD();
    }
    private void LoadMaSP() {
      string query = "SELECT MaSP FROM SanPham";

      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query);

      foreach (DataRow row in data.Rows) {
        dsMaSP.Add(Convert.ToInt32(row["MaSP"]));
      }
      cbMaSP.DataSource = dsMaSP;
    }

    private void fImport_goods_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }
    }
  }
}
