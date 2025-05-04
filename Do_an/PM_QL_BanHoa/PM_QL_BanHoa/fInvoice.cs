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
      printDoc.PrintPage -= printDoc_PrintPage; // Tránh đăng ký trùng nhiều lần
      printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
      PaperSize customSize = new PaperSize("Custom", 400, 583);
      printDoc.DefaultPageSettings.PaperSize = customSize;
      printDoc.DefaultPageSettings.Margins = new Margins(80, 80, 50, 50);

      PrintPreviewDialog previewDialog = new PrintPreviewDialog();
      previewDialog.Document = printDoc;

      // Tùy chỉnh form preview nếu muốn
      previewDialog.WindowState = FormWindowState.Maximized;
      previewDialog.ShowDialog();
    }

    private void printDoc_PrintPage(object sender, PrintPageEventArgs e) {
      Graphics g = e.Graphics;
      Font font = new Font("Arial", 10);
      Font boldFont = new Font("Arial", 12, FontStyle.Bold);
      Font titleFont = new Font("Arial", 16, FontStyle.Bold);

      int y = 80;
      int leftMargin = 20;
      int rightMargin = e.MarginBounds.Right;

      // Vẽ tiêu đề căn giữa
      string title = "HÓA ĐƠN BÁN HÀNG";
      SizeF titleSize = g.MeasureString(title, titleFont);
      float titleX = e.PageBounds.Width / 2 - titleSize.Width / 2;
      g.DrawString(title, titleFont, Brushes.Black, titleX, 50);

      // Thông tin hóa đơn
      g.DrawString("Mã HĐ: " + txtMaHD.Text, font, Brushes.Black, leftMargin, y); y += 25;
      g.DrawString("Khách hàng: " + txtMaKH.Text, font, Brushes.Black, leftMargin, y); y += 25;
      g.DrawString("Nhân viên: " + txtMaNV.Text, font, Brushes.Black, leftMargin, y); y += 25;
      g.DrawString("Ngày lập: " + dateNgayLapHD.Value.ToShortDateString(), font, Brushes.Black, leftMargin, y); y += 25;
      g.DrawString("Địa chỉ giao: " + txtDiaChiGiao.Text, font, Brushes.Black, leftMargin, y); y += 30;

      // Chi tiết hóa đơn
      g.DrawString("Chi tiết hóa đơn:", boldFont, Brushes.Black, leftMargin, y); y += 30;

      // Căn vị trí các cột
      int xTenSP = leftMargin;
      int xSL = xTenSP + 120;
      int xDonGia = xSL + 60;
      int xThanhTien = xDonGia + 100;

      // Header bảng
      g.DrawString("Tên SP", boldFont, Brushes.Black, xTenSP, y);
      g.DrawString("SL", boldFont, Brushes.Black, xSL, y);
      g.DrawString("Đơn giá", boldFont, Brushes.Black, xDonGia, y);
      g.DrawString("Thành tiền", boldFont, Brushes.Black, xThanhTien, y);
      y += 25;

      // Dữ liệu chi tiết hóa đơn
      DataTable chiTietHoaDon = DataProviderBUS.Instance.ExecuteQuery(
          "SELECT TenSP, SoLuong, GiaBanLe, (SoLuong * GiaBanLe) AS ThanhTien FROM ChiTietHoaDon AS CTHD, SanPham AS SP WHERE CTHD.MaSP = SP.MaSP AND MaHD = @mahd ",
          new object[] { txtMaHD.Text });

      foreach (DataRow row in chiTietHoaDon.Rows) {
        g.DrawString(row["TenSP"].ToString(), font, Brushes.Black, xTenSP, y);
        g.DrawString(row["SoLuong"].ToString(), font, Brushes.Black, xSL, y);
        g.DrawString(string.Format("{0:N0}", row["GiaBanLe"]), font, Brushes.Black, xDonGia, y);
        g.DrawString(string.Format("{0:N0}", row["ThanhTien"]), font, Brushes.Black, xThanhTien, y);
        y += 25;
      }

      y += 20;
      g.DrawString("Tổng cộng: " + txtThanhTien.Text + " VNĐ", boldFont, Brushes.Black, xTenSP, y);
    }
    private void fInvoice_Load(object sender, EventArgs e) {
      dgvInvoice.AutoGenerateColumns = false;

      LoadDSHD();
    }
    private void LoadDSHD() {
      string query = "Select * From HoaDon Where TrangThai = 1";
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
      } else if (Xoa()) {
        MessageBox.Show("Đã xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      } else {
        MessageBox.Show("Đã xóa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      LoadDSHD();
    }
    private bool Xoa() {
      string query = "Update HoaDon Set TrangThai = 0 Where MaHD = @MaHD";
      if (DataProviderBUS.Instance.ExecuteNonQuery(query, new Object[] { txtMaHD.Text }) > 0) {
        return true;
      }
      return false;
    }

    private void btnSearch_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(txtMa.Text)) {
        LoadDSHD();
        return;
      }

      string name = txtMa.Text.Trim();
      string query = "SELECT * FROM HoaDon WHERE MaHD LIKE @MaHD AND TrangThai = 1";

      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query, new object[] { "%" + name + "%" });

      if (dsHoaDon.Tables.Contains("HoaDon")) {
        dsHoaDon.Tables["HoaDon"].Clear();  // Xóa dữ liệu cũ
        dsHoaDon.Tables["HoaDon"].Merge(data);  // Gộp dữ liệu mới vào
      } else {
        data.TableName = "HoaDon";   // Đặt tên bảng trước khi add
        dsHoaDon.Tables.Add(data);   // Rồi mới add vào DataSet
      }


      dgvInvoice.DataSource = dsHoaDon.Tables["HoaDon"]; // Cập nhật dữ liệu cho DataGridView
    }
    // Hàm dùng để cập nhật thông tin hóa đơn.
    bool updateInvoice(int staffID, int customerID, DateTime dateTime, string status,
                                         string deliveryAddress, double total, int invoiceID) {
      string queryString =
              "UPDATE HoaDon " +
              "SET MaNV = @MaNV , MaKH = @MaKH , NgayLapHoaDon = @NgayLapHoaDon , TrangThai = @TrangThai , DiaChiGiao = @DiaChiGiao , ThanhTien = @ThanhTien " +
              "WHERE MaHD = @MaHD";

      int result = DataProviderBUS.Instance.ExecuteNonQuery(queryString, new object[] {
                    staffID,
                    customerID,
                    dateTime,
                    status,
                    deliveryAddress,
                    total,
                    invoiceID
                });

      // Trả về số dòng được thực thi.
      return result > 0;
    }

    // Cập nhật thông tin hóa đơn.
    private void btnEdit_Click(object sender, EventArgs e) {
      try {
        // Lấy dữ liệu ra từ các TextBox.
        int staffID = int.Parse(txtMaNV.Text.ToString());
        int customerID = int.Parse(txtMaKH.Text.ToString());
        DateTime dateCreated = dateNgayLapHD.Value;
        string status = txtTrangThai.Text.ToString();
        string deliveryAddress = txtDiaChiGiao.Text.ToString();
        double totalPrice = double.Parse(txtThanhTien.Text.ToString());
        int invoiceID = int.Parse(txtMaHD.Text.ToString());

        // Gọi hàm updateInvoice() để cập nhật thông tin hóa đơn.
        bool succes = updateInvoice(staffID, customerID, dateCreated, status, deliveryAddress, totalPrice, invoiceID);

        // Kiểm tra xem có thêm thành công hay không?
        if (succes) {
          MessageBox.Show(
              "Chỉnh sửa hóa đơn thành công",
              "Thông báo",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
          );

          // Gọi hàm loadInvoiceData() để hiển thị dữ liệu vào sau khi chỉnh sửa hóa đơn.
          LoadDSHD();
        } else {
          MessageBox.Show(
              "Chỉnh sửa hóa đơn không thành công",
              "Thông báo",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
          );
        }
      } catch (Exception exception) {
        MessageBox.Show(
            $"{exception.Message}",
            "Cảnh báo",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
      }
    }

  }
}
