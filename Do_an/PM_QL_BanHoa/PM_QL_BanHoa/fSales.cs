using PM_QL_BanHoa.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PM_QL_BanHoa;

namespace PM_QL_BanHoa {
  public partial class fSales : Form {
    public fSales() {
      InitializeComponent();
    }
    private void fSales_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }
    }

    private void ptbBillManagement_Click(object sender, EventArgs e) {
      frmBillManagement f = new frmBillManagement();
      
      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void ptbCustomerManagement_Click(object sender, EventArgs e) {
      frmCustomerManagement f = new frmCustomerManagement();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void ptbProductManagement_Click(object sender, EventArgs e) {
      frmProductManagement f = new frmProductManagement();

      this.Hide();
      f.ShowDialog();
      this.Show();
    }

    private void fSales_Load(object sender, EventArgs e) {
      toolTip.SetToolTip(this.ptbBillManagement, "Quản lý hóa đơn");
      toolTip.SetToolTip(this.ptbCustomerManagement, "Quản lý khách hàng");
      toolTip.SetToolTip(this.ptbProductManagement, "Quản lý sản phẩm");
    }
  }
}
