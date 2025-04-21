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
	public partial class frmSale : Form {
		public frmSale() {
			InitializeComponent();
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
					'%' + productName + '%'
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

			if ( result == DialogResult.No ) {
				e.Cancel = true;
			}
		}

		private void btnSearchProduct_Click(object sender, EventArgs e) {
			string productName = txtProductName.Text.ToString().Trim();
			searchProductsByName(productName);
		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {

		}
	}
}
