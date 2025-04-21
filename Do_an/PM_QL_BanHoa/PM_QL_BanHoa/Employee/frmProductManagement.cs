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
	public partial class frmProductManagement : Form {
		public frmProductManagement() {
			InitializeComponent();
		}

		private void frmProductManagement_FormClosing(object sender, FormClosingEventArgs e) {
			if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
				e.Cancel = true;
			}
		}

		// Hàm dùng để load dữ liệu từ bảng SanPham từ cơ sở dữ liệu.
		void loadProductData() {
			try {
				string queryString = "SELECT * FROM SanPham";
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

		private void frmProductManagement_Load(object sender, EventArgs e) {
			loadProductData();
		}

		// Hàm tìm kiếm sản phẩm
		void searchProduct(string productName) {
			string queryString = "SELECT * FROM SanPham WHERE TenSP LIKE @TenSP";
			DataTable dataTable = DataProviderBUS.Instance.ExecuteQuery(queryString, new object[] { '%' + productName + '%'});
			dataGridView.DataSource = dataTable;
		}

		private void btnSearchProduct_Click(object sender, EventArgs e) {
			try {
				string productName = txtProductName.Text.ToString().Trim();
				searchProduct(productName);
			} catch (Exception exception) {
				MessageBox.Show(
					$"{exception.Message}",
					"Cảnh báo",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private void txtProductName_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				e.SuppressKeyPress = true;
				try {
					string productName = txtProductName.Text.ToString().Trim();
					searchProduct(productName);
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
}
