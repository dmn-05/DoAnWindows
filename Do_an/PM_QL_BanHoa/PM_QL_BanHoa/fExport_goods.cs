using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QL_BanHoa {
  public partial class fExport_goods : Form {
    DataSet dsHoaDonXuat = new DataSet();
    List<int> dsMaSP = new List<int>();
    public fExport_goods() {
      InitializeComponent();
    }

    private void fExport_goods_Load(object sender, EventArgs e) {
      dgvExport_goods_goods.AutoGenerateColumns = false;
      LoadMaSP();
      LoadDSHD();
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(cbMaSP.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text)) {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        return;
      }
      Export_goodsDTO HoaDon = new Export_goodsDTO();
      HoaDon.MaSP = int.Parse(cbMaSP.Text.Trim());
      HoaDon.NgayXuat = DateTime.Parse(dateNgayXuat.Text);
      HoaDon.SoLuong = int.Parse(txtSoLuong.Text);
      string query = "SELECT GiaXuat FROM SanPham WHERE MaSP = @MaSP";
      DataTable SanPham = DataProviderBUS.Instance.ExecuteQuery(query, new object[] { HoaDon.MaSP });
      if (SanPham.Rows.Count == 0) {
        MessageBox.Show("Không tìm thấy sản phẩm!");
        return;
      }
      HoaDon.ThanhTien = HoaDon.SoLuong * Convert.ToDouble(SanPham.Rows[0]["GiaXuat"]);
      query = "Insert into XuatHang (MaSP, NgayXuat, SoLuong, ThanhTien) values ( @MaSP , @NgayXuat , @SoLuong , @ThanhTien )";
      int data = DataProviderBUS.Instance.ExecuteNonQuery(query, new Object[] { HoaDon.MaSP, HoaDon.NgayXuat, HoaDon.SoLuong, HoaDon.ThanhTien });
      if (data > 0) {
        MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
        query = "Update SanPham Set SoLuongTonKho = SoLuongTonKho - @soluong Where MaSP = @MaSP";
        DataProviderBUS.Instance.ExecuteNonQuery(query, new object[] { HoaDon.SoLuong, HoaDon.MaSP });
      } else {
        MessageBox.Show("Thêm Không Thành Công", "Thông Báo", MessageBoxButtons.OK);
      }
      LoadDSHD();
    }
    private void LoadDSHD() {
      string query = "Select * From XuatHang";
      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query);
      if (dsHoaDonXuat.Tables.Count > 0) {
        dsHoaDonXuat.Tables[0].Clear();
        dsHoaDonXuat.Tables[0].Merge(data);
      } else {
        dsHoaDonXuat.Tables.Add(data);
      }
      dgvExport_goods_goods.DataSource = dsHoaDonXuat.Tables[0]; // Đặt trực tiếp DataTable vào DataGridView
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
