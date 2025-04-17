using BUS;
using PM_QL_BanHoa.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QL_BanHoa {
  public partial class fInvoice : Form {
    DataSet dsHoaDon = new DataSet();
    PrintDocument printDoc = new PrintDocument();
    public fInvoice() {
      InitializeComponent();
    }

    private void fInvoice_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }
    }

    private void btnPrint_Click(object sender, EventArgs e) {
      printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

      PrintDialog printDialog = new PrintDialog();
      printDialog.Document = printDoc;

      if (printDialog.ShowDialog() == DialogResult.OK) {
        printDoc.Print();
      }
    }

    private void printDoc_PrintPage(object sender, PrintPageEventArgs e) {
      Graphics g = e.Graphics;
      Font font = new Font("Arial", 12);
      Font boldFont = new Font("Arial", 12, FontStyle.Bold);
      int y = 100;

      // Thông tin hóa đơn
      g.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new PointF(250, 50));
      g.DrawString("Mã HĐ: " + txtMaHD.Text, font, Brushes.Black, 100, y); y += 25;
      g.DrawString("Khách hàng: " + txtMaKH.Text, font, Brushes.Black, 100, y); y += 25;
      g.DrawString("Nhân viên: " + txtMaNV.Text, font, Brushes.Black, 100, y); y += 25;
      g.DrawString("Ngày lập: " + dateNgayLapHD.Value.ToShortDateString(), font, Brushes.Black, 100, y); y += 25;
      g.DrawString("Địa chỉ giao: " + txtDiaChiGiao.Text, font, Brushes.Black, 100, y); y += 25;

      y += 20;
      g.DrawString("Chi tiết hóa đơn:", boldFont, Brushes.Black, 100, y); y += 30;

      // Header bảng chi tiết
      g.DrawString("Tên SP", boldFont, Brushes.Black, 100, y);
      g.DrawString("SL", boldFont, Brushes.Black, 300, y);
      g.DrawString("Đơn giá", boldFont, Brushes.Black, 350, y);
      g.DrawString("Thành tiền", boldFont, Brushes.Black, 450, y);
      y += 25;

      // Lấy dữ liệu chi tiết từ DB
      DataTable chiTietHoaDon = DataProviderBUS.Instance.ExecuteQuery(
          "SELECT TenSP, SoLuong, DonGia, (SoLuong * DonGia) AS ThanhTien FROM ChiTietHoaDon WHERE MaHD = @mahd ",
          new object[] { txtMaHD.Text });

      foreach (DataRow row in chiTietHoaDon.Rows) {
        g.DrawString(row["TenSP"].ToString(), font, Brushes.Black, 100, y);
        g.DrawString(row["SoLuong"].ToString(), font, Brushes.Black, 300, y);
        g.DrawString(string.Format("{0:N0}", row["DonGia"]), font, Brushes.Black, 350, y);
        g.DrawString(string.Format("{0:N0}", row["ThanhTien"]), font, Brushes.Black, 450, y);
        y += 25;
      }
      y += 20;
      g.DrawString("Tổng cộng: " + txtThanhTien.Text + " VNĐ", boldFont, Brushes.Black, 100, y);
    }

    private void fInvoice_Load(object sender, EventArgs e) {
      dgvInvoice.AutoGenerateColumns = false;

      LoadDSHD();
    }
    private void LoadDSHD() {
      string query = "Select * From HoaDon";
      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query);
      if (dsHoaDon.Tables.Count > 0) {
        dsHoaDon.Tables[0].Clear();
        dsHoaDon.Tables[0].Merge(data);
      } else {
        dsHoaDon.Tables.Add(data);
      }
      dgvInvoice.DataSource = dsHoaDon.Tables[0]; // Đặt trực tiếp DataTable vào DataGridView
    }

    private void dgvInvoice_SelectionChanged(object sender, EventArgs e) {
      if (dgvInvoice.SelectedRows.Count > 0) {
        DataGridViewRow row = dgvInvoice.SelectedRows[0];

        txtMaHD.Text = row.Cells["colMaHD"].Value != DBNull.Value ? row.Cells["colMaHD"].Value.ToString() : "";
        txtMaKH.Text = row.Cells["colMaKH"].Value != DBNull.Value ? row.Cells["colMaKH"].Value.ToString() : "";
        txtMaNV.Text = row.Cells["colMaNV"].Value != DBNull.Value ? row.Cells["colMaNV"].Value.ToString() : "";
        txtThanhTien.Text = row.Cells["colThanhTien"].Value != DBNull.Value ? row.Cells["colThanhTien"].Value.ToString() : "";
        txtDiaChiGiao.Text = row.Cells["colDiaChiGiao"].Value != DBNull.Value ? row.Cells["colDiaChiGiao"].Value.ToString() : "";
        txtTrangThai.Text = row.Cells["colTrangThai"].Value != DBNull.Value ? row.Cells["colTrangThai"].Value.ToString() : "";

        if (row.Cells["colNgayLapHoaDon"].Value != DBNull.Value) {
          dateNgayLapHD.Value = Convert.ToDateTime(row.Cells["colNgayLapHoaDon"].Value);
        } else {
          dateNgayLapHD.Value = DateTime.Now;
        }
      }
    }

    private void btnDelete_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(txtMaHD.Text)) {
        MessageBox.Show("Bạn chưa chọn!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      else if(Xoa()){
        MessageBox.Show("Đã xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      } else {
        MessageBox.Show("Đã xóa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      LoadDSHD();
    }
    private bool Xoa() {
      string query = "Delete From HoaDon Where MaHD = @MaHD";
      if (DataProviderBUS.Instance.ExecuteNonQuery(query, new Object[] { txtMaHD.Text }) > 0) {
        return true;
      }
      return false;
    }
  }
}
