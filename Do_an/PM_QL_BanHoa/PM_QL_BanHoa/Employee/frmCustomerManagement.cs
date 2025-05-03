using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace PM_QL_BanHoa.Employee {
	public partial class frmCustomerManagement : Form {
		public frmCustomerManagement() {
			InitializeComponent();
		}

		private void frmCustomerManagement_FormClosing(object sender, FormClosingEventArgs e) {
			if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
				e.Cancel = true;
			}
		}

		// Load dữ liệu của khách hàng từ cơ sở dữ liệu ra màn hình.
		void loadCustomerData() {
			try {
				string queryString = "SELECT * FROM KhachHang";
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

		private void frmCustomerManagement_Load(object sender, EventArgs e) {
			// Gọi hàm loadCustomerData() để load dữ liệu từ bảng KhachHang.
			loadCustomerData();
		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex >= 0) {
				DataGridViewRow row = dataGridView.Rows[e.RowIndex];

				txtCustomerID.Text = row.Cells[0].Value.ToString();
				txtCustomerName.Text = row.Cells[1].Value.ToString();
				txtPhoneNumber.Text = row.Cells[2].Value.ToString();
				txtEmail.Text = row.Cells[3].Value.ToString();
				txtAddress.Text = row.Cells[4].Value.ToString();
			}
		}

		// Hàm dùng để thêm thông tin khách hàng.
		bool addCustomerInformation(string customerName, string phoneNumber,
																string email, string address) {
			string queryString =
				"INSERT INTO KhachHang (TenKH, SoDienThoai, Email, DiaChi)" +
				"VALUES (@TenKH, @SoDienThoai, @Email, @DiaChi)";

			int result = DataProviderBUS.Instance.ExecuteNonQuery(queryString, new object[] {
				customerName,
				phoneNumber,
				email,
				address
			});

			// Trả về số dòng được thực thi.
			return result > 0;
		}

		private void btnAddCustomer_Click(object sender, EventArgs e) {
			try {
				// Lấy dữ liệu ra từ các TextBox.
				string customerName = txtCustomerName.Text.ToString();
				string phoneNumber = txtPhoneNumber.Text.ToString();
				string email = txtEmail.Text.ToString();
				string address = txtAddress.Text.ToString();

				bool succes = addCustomerInformation(customerName, phoneNumber, email, address);

				if (succes) {
					MessageBox.Show(
						"Thêm thông tin khách hàng thành công",
						"Thông báo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);

					// Sau khi thêm thông tin thì hiển thị thông tin khách hàng mới lên DataGridView ngay.
					loadCustomerData();
				} else {
					MessageBox.Show(
						"Thêm thông tin khách hàng không thành công",
						"Cảnh báo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
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

		// Hàm dùng để cập nhật thông tin khách hàng.
		bool updateCustomerInformation(int customerID, string customerName, string phoneNumber,
																	 string email, string address) {
			string queryString =
				"UPDATE KhachHang " +
				"SET TenKH = @TenKH, SoDienThoai = @SoDienThoai, Email = @Email, DiaChi = @DiaChi " +
				"WHERE MaKH = @MaKH";

			int result = DataProviderBUS.Instance.ExecuteNonQuery(queryString, new object[] {
				customerName,
				phoneNumber,
				email,
				address,
				customerID
			});

			return result > 0;
		}


		// Hàm cập nhật thông tin khách hàng.
		private void btnUpdateCustomerInformation_Click(object sender, EventArgs e) {
			try {
				// Lấy dữ liệu ra từ các TextBox để chỉnh sửa thông tin.
				int customerID = int.Parse(txtCustomerID.Text.ToString());
				string customerName = txtCustomerName.Text.ToString();
				string phoneNumber = txtPhoneNumber.Text.ToString();
				string email = txtEmail.Text.ToString();
				string address = txtAddress.Text.ToString();

				bool success = updateCustomerInformation(customerID, customerName, phoneNumber, email, address);

				if (success) {
					MessageBox.Show(
						"Chỉnh sửa thông tin khách hàng thành công",
						"Thông báo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
					);

					// Load lại thông tin sau khi đã chỉnh sửa thành công.
					loadCustomerData();
				} else {
					MessageBox.Show(
						"Chỉnh sửa thông tin khách hàng không thành công",
						"Cảnh báo",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
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

		void searchCustomer(string customerName) {
			try {
				string queryString = "SELECT * FROM KhachHang WHERE TenKH LIKE @TenKH";
				object[] parameters = new object[] {
					'%' + customerName + '%'
				};
				DataTable dataTable = DataProviderBUS.Instance.ExecuteQuery(queryString, parameters);
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

		private void btnSearch_Click(object sender, EventArgs e) {
			string customerName = txtSearchCustomerName.Text.Trim();
			searchCustomer(customerName);
		}
	}
}
