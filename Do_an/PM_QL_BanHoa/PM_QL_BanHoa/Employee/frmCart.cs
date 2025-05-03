using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using BUS;
using DTO;

namespace PM_QL_BanHoa.Employee {
	public partial class frmCart : Form {
		public frmCart() {
			InitializeComponent();
		}

		void loadCartData() {
			try {
				string queryString = "SELECT * FROM GioHang WHERE TrangThai = 0";
				DataTable dataTable = DataProviderBUS.Instance.ExecuteQuery(queryString);
				dataGridView.DataSource = dataTable;
			} catch (Exception exception) {
				MessageBox.Show(
					$"{exception.Message}",
					"Cảnh báo!",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void frmCart_Load(object sender, EventArgs e) {
			loadCartData();
		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex >= 0) {
				DataGridViewRow row = dataGridView.Rows[e.RowIndex];

				txtProductID.Text = row.Cells[2].Value.ToString();
				txtQuantity.Text = row.Cells[3].Value.ToString();
				txtPrice.Text = row.Cells[4].Value.ToString();
				txtTotalPrice.Text = row.Cells[5].Value.ToString();
			}
		}

		void getCustomerName(string phoneNumber) {
			string queryString = "SELECT TenKH FROM KhachHang WHERE SoDienThoai = @SoDienThoai";

			DataTable result = DataProviderBUS.Instance.ExecuteQuery(queryString, new object[] { phoneNumber });

			if (result.Rows.Count > 0) {
				string customerName = result.Rows[0]["TenKH"].ToString();
				txtCustomerName.Text = customerName;
			} else {
				MessageBox.Show(
					"Không tìm thấy khách hàng!",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
				txtCustomerName.Text = "";
			}
		}

		private void txtCustomerPhoneNumber_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Enter) {
				e.Handled = true;

				string phoneNumber = txtCustomerPhoneNumber.Text.Trim();

				if (!string.IsNullOrEmpty(phoneNumber)) {
					getCustomerName(phoneNumber);
				} else {
					MessageBox.Show(
						"Vui lòng nhập số điện thoại!",
						"Thông báo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);
				}
			}
		}

		// Cập nhật thông tin từ giao diện qua CSDL.
		bool updateProductInCart(int cartID, int customerID, int productID, int quantity, double price) {
			string queryString =
				"UPDATE GioHang " +
				"SET MaKH = @MaKH, " +
				"MaSP = @MaSP, " +
				"SoLuong = @SoLuong, " +
				"GiaBanLe = @GiaBanLe " +
				"WHERE MaGH = @MaGH";

			object[] parameters = new object[] {
				customerID,
				productID,
				quantity,
				price,
				cartID
			};

			int result = DataProviderBUS.Instance.ExecuteNonQuery(queryString, parameters);

			return result > 0;
		}

		private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Enter) {
				e.Handled = true;

				int quantity = int.Parse(txtQuantity.Text.Trim());
				double price = double.Parse(txtPrice.Text.Trim());
				double totalPrice = quantity * price;

				txtTotalPrice.Text = totalPrice.ToString();

				int productID = int.Parse(txtProductID.Text.Trim());
				int _quantity = int.Parse(txtQuantity.Text.Trim());
				double _price = double.Parse(txtPrice.Text.Trim());

				if (dataGridView.CurrentRow != null) {
					DataGridViewRow currentRow = dataGridView.CurrentRow;

					int customerID = int.Parse(currentRow.Cells["colCustomerID"].Value.ToString());
					int cartID = int.Parse(currentRow.Cells["colCartID"].Value.ToString());

					currentRow.Cells["colQuantity"].Value = quantity;
					currentRow.Cells["colTotalPrice"].Value = totalPrice;

					// Thực hiện cập nhật thông tin.
					bool isSuccess = updateProductInCart(cartID, customerID, productID, _quantity, _price);

					// Kiểm tra nếu cập nhật thành công thì thông báo cho người dùng.
					if (isSuccess) {
						MessageBox.Show(
							"Chỉnh sửa giỏ hàng thành công!",
							"Thông báo!",
							MessageBoxButtons.OK,
							MessageBoxIcon.Information
						);
					} else {
						MessageBox.Show(
							"Chỉnh sửa giỏ hàng không thành công!",
							"Thông báo!",
							MessageBoxButtons.OK,
							MessageBoxIcon.Warning
						);
					}
				}
			}
		}

		// Tạo hóa đơn mới
		int createNewInvoice(int staffID, int customerID, DateTime dateCreated, int state,
													string deliveryAddress, double totalPrice) {
			string queryString =
				"INSERT INTO HoaDon (MaNV, MaKH, NgayLapHoaDon, TrangThai, DiaChiGiao, ThanhTien) " +
				"OUTPUT INSERTED.MaHD " +
				"VALUES (@MaNV, @MaKH, @NgayLapHoaDon, @TrangThai, @DiaChiGiao, @ThanhTien)";

			object[] parameters = new object[] {
				staffID,
				customerID,
				dateCreated,
				state,
				deliveryAddress,
				totalPrice
			};

			object result = DataProviderBUS.Instance.ExcuteScalar(queryString, parameters);

			return Convert.ToInt32(result);
		}

		// Thêm vào bảng ChiTietHoaDon
		bool addToDetailInvoice(int invoiceID, int productID, int quantity) {
			string queryString =
				"INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong) " +
				"VALUES (@MaHD, @MaSP, @SoLuong)";

			object[] parameters = new object[] {
				invoiceID,
				productID,
				quantity
			};

			int result = DataProviderBUS.Instance.ExecuteNonQuery(queryString, parameters);

			return result > 0;
		}

		object GetInvoiceID() {
			string queryString = "SELECT TOP 1 MaHD FROM HoaDon ORDER BY MaHD DESC";
			return DataProviderBUS.Instance.ExcuteScalar(queryString);
		}

		private void btnPayment_Click(object sender, EventArgs e) {
			// Kiểm tra xem đã lấy mã nhân viên thông qua phiên đăng nhập hay chưa?
			//if (CurrentSession.CurrentEmployee != null) {
			//	int staffID = CurrentSession.CurrentEmployee.MaNV;
			//	MessageBox.Show($"Mã nhân viên: {staffID}");
			//} else {
			//	MessageBox.Show("Chưa đăng nhập nhân viên!");
			//}

			// Lấy mã nhân viên thông qua phiên đăng nhập (session) hiện tại.
			int staffID = CurrentSession.CurrentEmployee.MaNV;

			// Lấy thời gian hiện tại là ngày lập hóa đơn.
			DateTime dateCreated = DateTime.Now;

			// Trạng thái của hóa đơn đã thanh toán là 2.
			int isSuccessfulPayment = 2;

			int invoiceID = 0;

			List<(int productID, int quantity)> invoiceDetails = new List<(int productID, int quantity)>();

			if (dataGridView.CurrentRow != null) {
				DataGridViewRow currentRow = dataGridView.CurrentRow;
				int customerID = int.Parse(currentRow.Cells["colCustomerID"].Value.ToString());

				// Địa chỉ giao.
				if (string.IsNullOrWhiteSpace(txtDeliveryAddress.Text)) {
					MessageBox.Show(
						"Vui lòng nhập địa chỉ giao hàng!",
						"Thông báo!",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);
					return;
				}

				string deliveryAddress = txtDeliveryAddress.Text.Trim();

				// Tính tổng tiền.
				double totalPrice = 0;
				foreach (DataGridViewRow _currentRow in dataGridView.Rows) {
					if (_currentRow.IsNewRow) {
						continue;
					}

					if (_currentRow.Cells["colTotalPrice"].Value.ToString() != null) {
						totalPrice += double.Parse(_currentRow.Cells["colTotalPrice"].Value.ToString());
					}
				}

				// Thêm vào List để sử dụng sau.
				foreach (DataGridViewRow row in dataGridView.Rows) {
					if (row.IsNewRow) {
						continue;
					}

					int productID = int.Parse(row.Cells["colProductID"].Value.ToString());
					int quantity = int.Parse(row.Cells["colQuantity"].Value.ToString());

					invoiceDetails.Add((productID, quantity));
				}

				// Lấy ra mã giỏ hàng.
				// Sau khi nhấn thanh toán thì đánh dấu TrangThai của hóa đơn = 2
				// Tức là đã thanh toán.
				int cartID = 0;
				bool isSuccessToRemoveFromCart = false;

				// Sau khi nhấn thanh toán thì duyệt qua từng hàng và đánh dấu TrangThai = 2
				// tức là đã thanh toán.
				foreach (DataGridViewRow __currentRow in dataGridView.Rows) {
					if (__currentRow.IsNewRow) {
						continue;
					}

					if (__currentRow.Cells["colCartID"].Value.ToString() != null) {
						cartID = int.Parse(__currentRow.Cells["colCartID"].Value.ToString());

						isSuccessToRemoveFromCart = removeFromCart(isSuccessfulPayment, cartID);

						// Nếu không xóa khỏi giỏ hàng thành công thì thoát khỏi và thông báo thanh toán thất bại.
						if (!isSuccessToRemoveFromCart) {
							break;
						}
					}
				}

				// Tải lại danh sách giỏ hàng.
				loadCartData();

				invoiceID = createNewInvoice(staffID, customerID, dateCreated, isSuccessfulPayment, deliveryAddress, totalPrice);

				if (invoiceID > 0 && isSuccessToRemoveFromCart) {
					MessageBox.Show(
						"Thanh toán thành công",
						"Thông báo!",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);
				} else {
					MessageBox.Show(
						"Thanh toán không thành công",
						"Thông báo!",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);
				}
			}

			// Lấy ra mã hóa đơn.
			//int invoiceID = int.Parse(GetInvoiceID().ToString());

			// Thêm vào bảng ChiTietHoaDon.
			foreach (var item in invoiceDetails) {
				addToDetailInvoice(invoiceID, item.productID, item.quantity);
			}

			//foreach (DataGridViewRow __currentRow in dataGridView.Rows) {
			//	if (__currentRow.IsNewRow) {
			//		continue;
			//	}

			//	// Lấy ra mã sản phẩm.
			//	int productID = 0;
			//	if (__currentRow.Cells["colProductID"].Value != null) {
			//		productID = int.Parse(__currentRow.Cells["colProductID"].Value.ToString());
			//	}

			//	// Lấy ra số lượng của mã sản phẩm.
			//	int quantity = 0;
			//	if (__currentRow.Cells["colQuantity"].Value != null) {
			//		quantity = int.Parse(__currentRow.Cells["colQuantity"].Value.ToString());
			//	}

			//	addToDetailInvoice(invoiceID, productID, quantity);
			//}
		}

		bool removeFromCart(int state, int cartID) {
			string queryString =
				"UPDATE GioHang " +
				"SET TrangThai = @TrangThai " +
				"WHERE MaGH = @MaGH";

			object[] parameters = new object[] {
				state,
				cartID
			};

			int result = DataProviderBUS.Instance.ExecuteNonQuery(queryString, parameters);
			return result > 0;
		}

		private void btnRemoveFromCart_Click(object sender, EventArgs e) {
			// State to remove product from cart.
			// TrangThai = 2 tức là xóa ra khỏi giỏ hàng.
			int state = 2;

			// Lấy ra MaGH.
			if (dataGridView.CurrentRow != null) {
				DataGridViewRow currentRow = dataGridView.CurrentRow;

				int cartID = int.Parse(currentRow.Cells["colCartID"].Value.ToString());

				bool isSuccess = removeFromCart(state, cartID);

				if (isSuccess) {
					MessageBox.Show(
						"Xóa sản phẩm khỏi giỏ hàng thành công!",
						"Thông báo!",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);
				} else {
					MessageBox.Show(
						"Xóa sản phẩm khỏi giỏ hàng không thành công!",
						"Thông báo!",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);
				}
			}

			loadCartData();
		}
	}
}
