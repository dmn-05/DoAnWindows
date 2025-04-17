using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QL_BanHoa.Employee {
	public partial class frmBillManagement : Form {
		public frmBillManagement() {
			InitializeComponent();
		}

		private void frmBillManagement_FormClosing(object sender, FormClosingEventArgs e) {
			if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
				e.Cancel = true;
			}
		}

		// Load dữ liệu của hóa đơn có sẵn từ cơ sở dữ liệu ra màn hình.
		void loadBillData() {
			string connectionString = "Data Source=.\\sqlexpress01;Initial Catalog=QuanLyBanHang;Integrated Security=True";

			using (SqlConnection connection = new SqlConnection(connectionString)) {
				try {
					connection.Open();
					string queryString = "select * from HoaDon";
					SqlCommand command = new SqlCommand(queryString, connection);
					SqlDataAdapter adapter = new SqlDataAdapter(command);
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);
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
		}

		private void frmBillManagement_Load(object sender, EventArgs e) {
			// Invoke function to load data from HoaDon table.
			loadBillData();
		}
	}
}
