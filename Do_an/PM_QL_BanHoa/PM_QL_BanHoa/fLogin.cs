﻿using BUS;
using DTO;
using PM_QL_BanHoa.BUS;
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


namespace PM_QL_BanHoa {
  public partial class fLogin : Form {
    public fLogin() {
      InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e) {
      string Username = txtUserName.Text;
      string Password = txtPassword.Text;

      if (Login_Admin(Username, Password)) {
        CurrentSession.CurrentEmployee = EmployeeBUS.Instance.GetEmployeeByUsername(Username);
        fAdmin f = new fAdmin();
        this.txtUserName.Clear();
        this.txtPassword.Clear();
        this.Hide();
        f.ShowDialog();
        this.Show();
      } else if (Login(Username, Password)) {
				CurrentSession.CurrentEmployee = EmployeeBUS.Instance.GetEmployeeByUsername(Username);
				fSales f = new fSales();
        this.txtUserName.Clear();
        this.txtPassword.Clear();
        this.Hide();
        f.ShowDialog();
        this.Show();
      } else {
        MessageBox.Show("Đăng nhập thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
      }
    }
    private bool Login(string username, string password) {
      return AccountBUS.Instance.Login(username, password);
    }
    private bool Login_Admin(string username, string password) {
      return AccountBUS.Instance.Login_Admin(username, password);
    }
    private void fLogin_FormClosing(object sender, FormClosingEventArgs e) {
      if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
        e.Cancel = true;
      }
    }

    private void chkShowPass_CheckedChanged(object sender, EventArgs e) {
      if (chkShowPass.Checked == true) {
        txtPassword.UseSystemPasswordChar = false;
      } else {
        txtPassword.UseSystemPasswordChar = true;
      }
    }

    private void fLogin_Load(object sender, EventArgs e) {
     
    }


		private void txtUserName_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Enter) {
				e.Handled = true;
				btnLogin.PerformClick();
			}
		}

		private void txtPassword_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Enter) {
				e.Handled = true;
				btnLogin.PerformClick();
			}
		}

	}
}
