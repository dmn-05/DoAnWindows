namespace PM_QL_BanHoa
{
    partial class fEmployee
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmployee));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.lblUserName = new System.Windows.Forms.Label();
      this.btnSearch = new System.Windows.Forms.Button();
      this.dgvEmployee = new System.Windows.Forms.DataGridView();
      this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnSave = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.BackColor = System.Drawing.Color.Transparent;
      this.groupBox1.Controls.Add(this.txtName);
      this.groupBox1.Controls.Add(this.lblUserName);
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Controls.Add(this.dgvEmployee);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.White;
      this.groupBox1.Location = new System.Drawing.Point(26, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1185, 621);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Quản Lý Nhân Viên";
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(790, 29);
      this.txtName.Multiline = true;
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(286, 39);
      this.txtName.TabIndex = 27;
      // 
      // lblUserName
      // 
      this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblUserName.AutoSize = true;
      this.lblUserName.BackColor = System.Drawing.Color.Transparent;
      this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUserName.ForeColor = System.Drawing.Color.White;
      this.lblUserName.Location = new System.Drawing.Point(654, 35);
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(114, 25);
      this.lblUserName.TabIndex = 29;
      this.lblUserName.Text = "Nhập Tên:";
      // 
      // btnSearch
      // 
      this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
      this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.ForeColor = System.Drawing.Color.Blue;
      this.btnSearch.Location = new System.Drawing.Point(1107, 22);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(50, 50);
      this.btnSearch.TabIndex = 28;
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // dgvEmployee
      // 
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
      this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colTenDangNhap,
            this.colMatKhau,
            this.colSoDienThoai,
            this.colEmail,
            this.colDiaChi,
            this.colChucVu,
            this.colTrangThai});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgvEmployee.Location = new System.Drawing.Point(24, 81);
      this.dgvEmployee.Name = "dgvEmployee";
      this.dgvEmployee.RowHeadersWidth = 51;
      this.dgvEmployee.RowTemplate.Height = 24;
      this.dgvEmployee.Size = new System.Drawing.Size(1133, 534);
      this.dgvEmployee.TabIndex = 0;
      // 
      // colMaNV
      // 
      this.colMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colMaNV.DataPropertyName = "MaNV";
      this.colMaNV.FillWeight = 128.3422F;
      this.colMaNV.HeaderText = "MaNV";
      this.colMaNV.MinimumWidth = 70;
      this.colMaNV.Name = "colMaNV";
      this.colMaNV.ReadOnly = true;
      this.colMaNV.Width = 70;
      // 
      // colTenNV
      // 
      this.colTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colTenNV.DataPropertyName = "TenNV";
      this.colTenNV.FillWeight = 518.8315F;
      this.colTenNV.HeaderText = "TenNV";
      this.colTenNV.MinimumWidth = 140;
      this.colTenNV.Name = "colTenNV";
      this.colTenNV.Width = 200;
      // 
      // colTenDangNhap
      // 
      this.colTenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colTenDangNhap.DataPropertyName = "TenDangNhap";
      this.colTenDangNhap.FillWeight = 25.47104F;
      this.colTenDangNhap.HeaderText = "TenDangNhap";
      this.colTenDangNhap.MinimumWidth = 140;
      this.colTenDangNhap.Name = "colTenDangNhap";
      this.colTenDangNhap.Width = 140;
      // 
      // colMatKhau
      // 
      this.colMatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colMatKhau.DataPropertyName = "MatKhau";
      this.colMatKhau.FillWeight = 25.47104F;
      this.colMatKhau.HeaderText = "MatKhau";
      this.colMatKhau.MinimumWidth = 50;
      this.colMatKhau.Name = "colMatKhau";
      this.colMatKhau.Width = 125;
      // 
      // colSoDienThoai
      // 
      this.colSoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colSoDienThoai.DataPropertyName = "SoDienThoai";
      this.colSoDienThoai.FillWeight = 25.47104F;
      this.colSoDienThoai.HeaderText = "SoDienThoai";
      this.colSoDienThoai.MinimumWidth = 100;
      this.colSoDienThoai.Name = "colSoDienThoai";
      this.colSoDienThoai.Width = 125;
      // 
      // colEmail
      // 
      this.colEmail.DataPropertyName = "Email";
      this.colEmail.HeaderText = "Email";
      this.colEmail.MinimumWidth = 120;
      this.colEmail.Name = "colEmail";
      // 
      // colDiaChi
      // 
      this.colDiaChi.DataPropertyName = "DiaChi";
      this.colDiaChi.FillWeight = 25.47104F;
      this.colDiaChi.HeaderText = "DiaChi";
      this.colDiaChi.MinimumWidth = 150;
      this.colDiaChi.Name = "colDiaChi";
      // 
      // colChucVu
      // 
      this.colChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colChucVu.DataPropertyName = "ChucVu";
      this.colChucVu.FillWeight = 25.47104F;
      this.colChucVu.HeaderText = "ChucVu";
      this.colChucVu.MinimumWidth = 139;
      this.colChucVu.Name = "colChucVu";
      this.colChucVu.Width = 139;
      // 
      // colTrangThai
      // 
      this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colTrangThai.DataPropertyName = "TrangThai";
      this.colTrangThai.FillWeight = 25.47104F;
      this.colTrangThai.HeaderText = "TrangThai";
      this.colTrangThai.MinimumWidth = 139;
      this.colTrangThai.Name = "colTrangThai";
      this.colTrangThai.Width = 139;
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.BackColor = System.Drawing.Color.Transparent;
      this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
      this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.Black;
      this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSave.Location = new System.Drawing.Point(1113, 631);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(70, 70);
      this.btnSave.TabIndex = 30;
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // fEmployee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1243, 710);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnSave);
      this.DoubleBuffered = true;
      this.ForeColor = System.Drawing.Color.White;
      this.Name = "fEmployee";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "fQLNV";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fQLNV_FormClosing);
      this.Load += new System.EventHandler(this.fEmployee_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEmployee;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnSave;
  }
}