using System.Drawing;

namespace PM_QL_BanHoa
{
    partial class fLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.lblUserName = new System.Windows.Forms.Label();
      this.chkShowPass = new System.Windows.Forms.CheckBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.panel1.BackColor = System.Drawing.Color.Transparent;
      this.panel1.Controls.Add(this.txtPassword);
      this.panel1.Controls.Add(this.lblPassword);
      this.panel1.Controls.Add(this.txtUserName);
      this.panel1.Controls.Add(this.lblUserName);
      this.panel1.Controls.Add(this.chkShowPass);
      this.panel1.Controls.Add(this.btnLogin);
      this.panel1.Location = new System.Drawing.Point(319, 327);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(613, 270);
      this.panel1.TabIndex = 16;
      // 
      // txtPassword
      // 
      this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.Location = new System.Drawing.Point(248, 98);
      this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(259, 27);
      this.txtPassword.TabIndex = 2;
      this.txtPassword.UseSystemPasswordChar = true;
      this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.BackColor = System.Drawing.Color.Transparent;
      this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPassword.Location = new System.Drawing.Point(60, 101);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(108, 25);
      this.lblPassword.TabIndex = 16;
      this.lblPassword.Text = "Mật khẩu:";
      // 
      // txtUserName
      // 
      this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUserName.Location = new System.Drawing.Point(248, 46);
      this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(259, 27);
      this.txtUserName.TabIndex = 1;
      this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
      // 
      // lblUserName
      // 
      this.lblUserName.AutoSize = true;
      this.lblUserName.BackColor = System.Drawing.Color.Transparent;
      this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUserName.Location = new System.Drawing.Point(60, 48);
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(165, 25);
      this.lblUserName.TabIndex = 20;
      this.lblUserName.Text = "Tên đăng nhập:";
      // 
      // chkShowPass
      // 
      this.chkShowPass.AutoSize = true;
      this.chkShowPass.BackColor = System.Drawing.Color.Transparent;
      this.chkShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkShowPass.Location = new System.Drawing.Point(380, 150);
      this.chkShowPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.chkShowPass.Name = "chkShowPass";
      this.chkShowPass.Size = new System.Drawing.Size(127, 20);
      this.chkShowPass.TabIndex = 3;
      this.chkShowPass.Text = "Hiện mật khẩu";
      this.chkShowPass.UseVisualStyleBackColor = true;
      this.chkShowPass.Click += new System.EventHandler(this.chkShowPass_CheckedChanged);
      // 
      // btnLogin
      // 
      this.btnLogin.BackColor = System.Drawing.Color.DarkGreen;
      this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLogin.ForeColor = System.Drawing.Color.White;
      this.btnLogin.Location = new System.Drawing.Point(236, 204);
      this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(169, 41);
      this.btnLogin.TabIndex = 4;
      this.btnLogin.Text = "Đăng Nhập";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // fLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1247, 738);
      this.Controls.Add(this.panel1);
      this.DoubleBuffered = true;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "fLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Đăng nhập";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.fLogin_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtUserName;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.CheckBox chkShowPass;
    private System.Windows.Forms.Button btnLogin;
  }
}

