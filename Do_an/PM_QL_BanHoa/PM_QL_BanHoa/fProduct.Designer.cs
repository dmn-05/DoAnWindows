namespace PM_QL_BanHoa
{
    partial class fProduct
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProduct));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnSave = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lblUserName = new System.Windows.Forms.Label();
      this.btnSearch = new System.Windows.Forms.Button();
      this.txtName = new System.Windows.Forms.TextBox();
      this.dgvProduct = new System.Windows.Forms.DataGridView();
      this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colGiaBanLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colGiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSoLuongTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
      this.SuspendLayout();
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
      this.btnSave.Location = new System.Drawing.Point(1121, 659);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(70, 70);
      this.btnSave.TabIndex = 3;
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.BackColor = System.Drawing.Color.Transparent;
      this.groupBox2.Controls.Add(this.lblUserName);
      this.groupBox2.Controls.Add(this.btnSearch);
      this.groupBox2.Controls.Add(this.txtName);
      this.groupBox2.Controls.Add(this.dgvProduct);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.ForeColor = System.Drawing.Color.White;
      this.groupBox2.Location = new System.Drawing.Point(26, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1189, 630);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Quản Lý Sản Phẩm";
      // 
      // lblUserName
      // 
      this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblUserName.AutoSize = true;
      this.lblUserName.BackColor = System.Drawing.Color.Transparent;
      this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUserName.ForeColor = System.Drawing.Color.White;
      this.lblUserName.Location = new System.Drawing.Point(615, 37);
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(114, 25);
      this.lblUserName.TabIndex = 21;
      this.lblUserName.Text = "Nhập Tên:";
      // 
      // btnSearch
      // 
      this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
      this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.ForeColor = System.Drawing.Color.Blue;
      this.btnSearch.Location = new System.Drawing.Point(1068, 24);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(50, 50);
      this.btnSearch.TabIndex = 5;
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(751, 31);
      this.txtName.Multiline = true;
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(286, 39);
      this.txtName.TabIndex = 4;
      // 
      // dgvProduct
      // 
      this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colGiaBanLe,
            this.colGiaNhap,
            this.colGiaXuat,
            this.colSoLuongTonKho});
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle1;
      this.dgvProduct.Location = new System.Drawing.Point(28, 87);
      this.dgvProduct.Name = "dgvProduct";
      this.dgvProduct.RowHeadersWidth = 51;
      this.dgvProduct.RowTemplate.Height = 24;
      this.dgvProduct.Size = new System.Drawing.Size(1137, 520);
      this.dgvProduct.TabIndex = 1;
      // 
      // colMaSP
      // 
      this.colMaSP.DataPropertyName = "MaSP";
      this.colMaSP.HeaderText = "MaSP";
      this.colMaSP.MinimumWidth = 6;
      this.colMaSP.Name = "colMaSP";
      // 
      // colTenSP
      // 
      this.colTenSP.DataPropertyName = "TenSP";
      this.colTenSP.HeaderText = "TenSP";
      this.colTenSP.MinimumWidth = 6;
      this.colTenSP.Name = "colTenSP";
      // 
      // colGiaBanLe
      // 
      this.colGiaBanLe.DataPropertyName = "GiaBanLe";
      this.colGiaBanLe.HeaderText = "GiaBanLe";
      this.colGiaBanLe.MinimumWidth = 6;
      this.colGiaBanLe.Name = "colGiaBanLe";
      // 
      // colGiaNhap
      // 
      this.colGiaNhap.DataPropertyName = "GiaNhap";
      this.colGiaNhap.HeaderText = "GiaNhap";
      this.colGiaNhap.MinimumWidth = 6;
      this.colGiaNhap.Name = "colGiaNhap";
      // 
      // colGiaXuat
      // 
      this.colGiaXuat.DataPropertyName = "GiaXuat";
      this.colGiaXuat.HeaderText = "GiaXuat";
      this.colGiaXuat.MinimumWidth = 6;
      this.colGiaXuat.Name = "colGiaXuat";
      // 
      // colSoLuongTonKho
      // 
      this.colSoLuongTonKho.DataPropertyName = "SoLuongTonKho";
      this.colSoLuongTonKho.HeaderText = "SoLuongTonKho";
      this.colSoLuongTonKho.MinimumWidth = 6;
      this.colSoLuongTonKho.Name = "colSoLuongTonKho";
      // 
      // fProduct
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1247, 738);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.btnSave);
      this.DoubleBuffered = true;
      this.ForeColor = System.Drawing.Color.White;
      this.Name = "fProduct";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "fProduct";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fProduct_FormClosing);
      this.Load += new System.EventHandler(this.fProduct_Load);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dgvProduct;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBanLe;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGiaNhap;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGiaXuat;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTonKho;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblUserName;
  }
}