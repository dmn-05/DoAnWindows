using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace PM_QL_BanHoa.Employee {
	public partial class frmBillManagement : Form {
		public frmBillManagement() {
			InitializeComponent();
		}

		private void frmBillManagement_FormClosing(object sender, FormClosingEventArgs e) {
			DialogResult result = MessageBox.Show(
				"Bạn có muốn thoát chương trình?",
				"Thông báo",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if ( result == DialogResult.Yes ) {
				e.Cancel = true;
			}
		}

		// Load dữ liệu của hóa đơn từ cơ sở dữ liệu ra màn hình.
		void loadInvoiceData() {
			try {
				string queryString = "SELECT * FROM HoaDon";
				DataTable dataTable = DataProviderBUS.Instance.ExecuteQuery(queryString);
				dataGridView.DataSource = dataTable;
			} catch (Exception exception) {
				MessageBox.Show(
					$"{exception.Message}",
					"Cảnh báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void frmBillManagement_Load(object sender, EventArgs e) {
			// Gọi hàm loadInvoiceData() để load dữ liệu từ bảng HoaDon.
			loadInvoiceData();
		}

		// Nhấn vào một dòng bất kỳ trong DataGridView để chỉnh sửa dữ liệu.
		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex >= 0) {
				DataGridViewRow row = dataGridView.Rows[e.RowIndex];

				txtInvoiceID.Text = row.Cells[0].Value.ToString();
				txtStaffID.Text = row.Cells[1].Value.ToString();
				txtCustomerID.Text = row.Cells[2].Value.ToString();
				dateTimePicker.Text = row.Cells[3].Value.ToString();
				txtStatus.Text = row.Cells[4].Value.ToString();
				txtDeliveryAddress.Text = row.Cells[5].Value.ToString();
				txtTotal.Text = row.Cells[6].Value.ToString();
			}
		}

		// Hàm dùng để thêm thông tin hóa đơn.
		bool addInvoice(int staffID, int customerID, DateTime dateCreated, string status,
										string deliveryAddress, double totalPrice) {
			string queryString =
					"INSERT INTO HoaDon (MaNV, MaKH, NgayLapHoaDon, TrangThai, DiaChiGiao, ThanhTien) " +
					"VALUES (@MaNV, @MaKH, @NgayLapHoaDon, @TrangThai, @DiaChiGiao, @ThanhTien)";

			int result = DataProviderBUS.Instance.ExecuteNonQuery(queryString, new object[] {
					staffID,
					customerID,
					dateCreated,
					status,
					deliveryAddress,
					totalPrice
				});

			// Trả về số dòng được thực thi.
			return result > 0;
		}

		// Thêm hóa đơn mới vào cơ sở dữ liệu.
		private void btnAddInvoice_Click(object sender, EventArgs e) {
			try {
				// Lấy dữ liệu ra từ các TextBox.
				int staffID = int.Parse(txtStaffID.Text.ToString());
				int customerID = int.Parse(txtCustomerID.Text.ToString());
				DateTime dateCreated = dateTimePicker.Value;
				string status = txtStatus.Text.ToString();
				string deliveryAddress = txtDeliveryAddress.Text.ToString();
				double totalPrice = double.Parse(txtTotal.Text.ToString());

				bool success = addInvoice(staffID, customerID, dateCreated, status, deliveryAddress, totalPrice);

				if (success) {
					MessageBox.Show(
						"Thêm hóa đơn thành công",
						"Thông báo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);

					// Gọi hàm loadInvoiceData() để hiển thị dữ liệu vào sau khi thêm hóa đơn.
					loadInvoiceData();
				} else {
					MessageBox.Show(
						"Thêm hóa đơn không thành công",
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

		// Hàm dùng để cập nhật thông tin hóa đơn.
		bool updateInvoice(int staffID, int customerID, DateTime dateTime, string status,
											 string deliveryAddress, double total, int invoiceID) {
			string queryString =
					"UPDATE HoaDon " +
					"SET MaNV = @MaNV, MaKH = @MaKH, NgayLapHoaDon = @NgayLapHoaDon, TrangThai = @TrangThai, DiaChiGiao = @DiaChiGiao, ThanhTien = @ThanhTien " +
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
		private void btnUpdateInvoice_Click(object sender, EventArgs e) {
			try {
				// Lấy dữ liệu ra từ các TextBox.
				int staffID = int.Parse(txtStaffID.Text.ToString());
				int customerID = int.Parse(txtCustomerID.Text.ToString());
				DateTime dateCreated = dateTimePicker.Value;
				string status = txtStatus.Text.ToString();
				string deliveryAddress = txtDeliveryAddress.Text.ToString();
				double totalPrice = double.Parse(txtTotal.Text.ToString());
				int invoiceID = int.Parse(txtInvoiceID.Text.ToString());

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
					loadInvoiceData();
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
