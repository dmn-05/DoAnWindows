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
using DTO;

namespace PM_QL_BanHoa.Employee {
	public partial class frmSale : Form {
		public List<CartDTO> cart;

		public List<CartDTO> getList() {
			return this.cart;
		}

		public frmSale() {
			InitializeComponent();
			cart = new List<CartDTO>();
		}

		void loadProductData() {
			try {
				string queryString = "SELECT * FROM SanPham";
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

		// Hàm tìm kiếm sản phẩm
		void searchProductsByName(string productName) {
			try {
				string queryString = "SELECT * FROM SanPham WHERE TenSP LIKE @TenSP";
				DataTable dataTable = DataProviderBUS.Instance.ExecuteQuery(queryString, new object[] {
					"%" + productName + "%"
				});
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

		private void frmSale_Load(object sender, EventArgs e) {
			loadProductData();
		}

		private void frmSale_FormClosing(object sender, FormClosingEventArgs e) {
			DialogResult result = MessageBox.Show(
				"Bạn có muốn thoát chương trình?",
				"Thông báo",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (result == DialogResult.No) {
				e.Cancel = true;
			}
		}

		private void btnSearchProduct_Click(object sender, EventArgs e) {
			string productName = _txtProductName.Text.ToString().Trim();
			searchProductsByName(productName);
		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
			if (e.RowIndex >= 0) {
				DataGridViewRow row = dataGridView.Rows[e.RowIndex];

				txtProductID.Text = row.Cells[0].Value.ToString();
				txtProductName.Text = row.Cells[1].Value.ToString();
				txtPrice.Text = row.Cells[2].Value.ToString();

				double price = double.Parse(txtPrice.Text.ToString().Trim());
				int quantity = 1;

				if (!int.TryParse(txtQuantity.Text.ToString().Trim(), out quantity)) {
					quantity = 1;
				}

				txtTotalPrice.Text = (quantity * price).ToString();
			}
		}

		private void txtQuantity_MouseLeave(object sender, EventArgs e) {
			string quantity = txtQuantity.Text.ToString().Trim();
			string price = txtPrice.Text.ToString().Trim();

			if (string.IsNullOrEmpty(quantity)) {
				MessageBox.Show(
					"Vui lòng nhập số lượng!",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				txtQuantity.Focus();
				return;
			}

			if (!int.TryParse(quantity, out int _quantity) || _quantity <= 0) {
				MessageBox.Show(
					"Số lượng phải là một số nguyên dương!",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				txtQuantity.Focus();
				return;
			}

			txtTotalPrice.Text = (double.Parse(quantity) * double.Parse(price)).ToString();

		}

		public bool addProductsToCart(int productID, int quantity, double price, int state) {
			string queryString =
				"INSERT INTO GioHang (MaSP, SoLuong, GiaBanLe, TrangThai) " +
				"VALUES ( @MaSP , @SoLuong , @GiaBanLe , @TrangThai )";

			object[] paramters = new object[] {
				productID,
				quantity,
				price,
				state
			};

			int result = DataProviderBUS.Instance.ExecuteNonQuery(queryString, paramters);

			return result > 0;
		}

		private void btnAddToCart_Click(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(txtProductID.Text) ||
					string.IsNullOrWhiteSpace(txtProductName.Text) ||
					string.IsNullOrWhiteSpace(txtQuantity.Text) ||
					string.IsNullOrWhiteSpace(txtPrice.Text)) {
				MessageBox.Show(
					"Vui lòng nhập đủ thông tin!",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			// Chuyển đổi dữ liệu từ các ô nhập.
			int productID = int.Parse(txtProductID.Text.Trim());
			int quantity = int.Parse(txtQuantity.Text.Trim());
			double price = double.Parse(txtPrice.Text.Trim());
			int state = 0;

			// Thêm sản phẩm vào giỏ hàng ở đây
			bool isSuccess = addProductsToCart(productID, quantity, price, state);

			if (isSuccess) {
				MessageBox.Show(
					"Thêm vào giỏ hàng thành công!",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			} else {
				MessageBox.Show(
					"Thêm vào giỏ hàng không thành công!",
					"Thông báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
			}
		}

		private void btnViewCart_Click(object sender, EventArgs e) {
			frmCart cart = new frmCart();

			this.Hide();
			cart.ShowDialog();
			this.Show();
		}

		// Nhập tên sản phẩm cần tìm, sau đó nhấn phím Enter thì sẽ hiển thị ra thông tin sản phẩm.
		private void _txtProductName_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Enter) {
				e.Handled = true;
				string productName = _txtProductName.Text.ToString().Trim();
				searchProductsByName(productName);
			}
		}
	}
}
