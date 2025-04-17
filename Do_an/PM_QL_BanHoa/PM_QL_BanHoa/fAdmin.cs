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
  public partial class fAdmin : Form {
    public fAdmin() {
      InitializeComponent();
    }

    private void picQLSP_Click(object sender, EventArgs e) {
      fProduct f = new fProduct();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void fAdmin_Load(object sender, EventArgs e) {
      toolTip1.SetToolTip(picEmployee, "Nhân Viên");
      toolTip1.SetToolTip(picCustomer, "Khách Hàng");
      toolTip1.SetToolTip(picInvoice, "Hóa Đơn");
      toolTip1.SetToolTip(picInvoice_details, "Chi Tiết Hóa Đơn");
      toolTip1.SetToolTip(picImport_goods, "Nhập Hàng");
      toolTip1.SetToolTip(picExport_goods, "Xuất Hàng");
      toolTip1.SetToolTip(picStatistics, "Thống Kê");
      toolTip1.SetToolTip(picProduct, "Sản Phẩm");

    }

    private void fAdmin_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }
      
    }

    private void picEmployee_Click(object sender, EventArgs e) {
      fEmployee f = new fEmployee();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void picCustomer_Click(object sender, EventArgs e) {
      fCustomer f = new fCustomer();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void picInvoice_Click(object sender, EventArgs e) {
      fInvoice f = new fInvoice();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void picInvoice_details_Click(object sender, EventArgs e) {
      fInvoice_details f = new fInvoice_details();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void picImport_goods_Click(object sender, EventArgs e) {
      fImport_goods f = new fImport_goods();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void picExport_goods_Click(object sender, EventArgs e) {
      fExport_goods f = new fExport_goods();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void picStatistics_Click(object sender, EventArgs e) {
      fStatistics f = new fStatistics();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void btnLogout_Click(object sender, EventArgs e) {
      fLogin f = new fLogin();
      this.Hide();
      f.ShowDialog();
    }

    private void picProduct_Click(object sender, EventArgs e) {
      fProduct f = new fProduct();
      this.Hide();
      f.ShowDialog();
      this.Show();
    }
  }
}
