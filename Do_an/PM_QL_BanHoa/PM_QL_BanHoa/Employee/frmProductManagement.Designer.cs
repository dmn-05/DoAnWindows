namespace PM_QL_BanHoa.Employee {
	partial class frmProductManagement {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductManagement));
      this.btnSearchProduct = new System.Windows.Forms.Button();
      this.txtProductName = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colExportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colInventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.grbInvoiceProcess = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.grbInvoiceProcess.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnSearchProduct
      // 
      this.btnSearchProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchProduct.BackgroundImage")));
      this.btnSearchProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnSearchProduct.Location = new System.Drawing.Point(216, 357);
      this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnSearchProduct.Name = "btnSearchProduct";
      this.btnSearchProduct.Size = new System.Drawing.Size(133, 123);
      this.btnSearchProduct.TabIndex = 14;
      this.btnSearchProduct.UseVisualStyleBackColor = true;
      this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
      // 
      // txtProductName
      // 
      this.txtProductName.Location = new System.Drawing.Point(253, 256);
      this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtProductName.Name = "txtProductName";
      this.txtProductName.Size = new System.Drawing.Size(249, 22);
      this.txtProductName.TabIndex = 8;
      this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
      this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.panel1.Controls.Add(this.dataGridView);
      this.panel1.Controls.Add(this.grbInvoiceProcess);
      this.panel1.Location = new System.Drawing.Point(11, 10);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1481, 703);
      this.panel1.TabIndex = 2;
      // 
      // dataGridView
      // 
      this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.colRetailPrice,
            this.colImportPrice,
            this.colExportPrice,
            this.colInventoryQuantity});
      this.dataGridView.Location = new System.Drawing.Point(3, 5);
      this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowHeadersWidth = 62;
      this.dataGridView.RowTemplate.Height = 28;
      this.dataGridView.Size = new System.Drawing.Size(907, 698);
      this.dataGridView.TabIndex = 0;
      // 
      // colProductID
      // 
      this.colProductID.DataPropertyName = "MaSp";
      this.colProductID.HeaderText = "Mã sản phẩm";
      this.colProductID.MinimumWidth = 6;
      this.colProductID.Name = "colProductID";
      // 
      // colProductName
      // 
      this.colProductName.DataPropertyName = "TenSP";
      this.colProductName.HeaderText = "Tên sản phẩm";
      this.colProductName.MinimumWidth = 6;
      this.colProductName.Name = "colProductName";
      // 
      // colRetailPrice
      // 
      this.colRetailPrice.DataPropertyName = "GiaBanLe";
      this.colRetailPrice.HeaderText = "Giá bán lẻ";
      this.colRetailPrice.MinimumWidth = 6;
      this.colRetailPrice.Name = "colRetailPrice";
      // 
      // colImportPrice
      // 
      this.colImportPrice.DataPropertyName = "GiaNhap";
      this.colImportPrice.HeaderText = "Giá nhập";
      this.colImportPrice.MinimumWidth = 6;
      this.colImportPrice.Name = "colImportPrice";
      // 
      // colExportPrice
      // 
      this.colExportPrice.DataPropertyName = "GiaXuat";
      this.colExportPrice.HeaderText = "Giá xuất";
      this.colExportPrice.MinimumWidth = 6;
      this.colExportPrice.Name = "colExportPrice";
      // 
      // colInventoryQuantity
      // 
      this.colInventoryQuantity.DataPropertyName = "SoLuongTonKho";
      this.colInventoryQuantity.HeaderText = "Số lượng tồn kho";
      this.colInventoryQuantity.MinimumWidth = 6;
      this.colInventoryQuantity.Name = "colInventoryQuantity";
      // 
      // grbInvoiceProcess
      // 
      this.grbInvoiceProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grbInvoiceProcess.BackColor = System.Drawing.Color.Transparent;
      this.grbInvoiceProcess.Controls.Add(this.btnSearchProduct);
      this.grbInvoiceProcess.Controls.Add(this.txtProductName);
      this.grbInvoiceProcess.Controls.Add(this.label2);
      this.grbInvoiceProcess.Location = new System.Drawing.Point(916, 6);
      this.grbInvoiceProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grbInvoiceProcess.Name = "grbInvoiceProcess";
      this.grbInvoiceProcess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grbInvoiceProcess.Size = new System.Drawing.Size(563, 697);
      this.grbInvoiceProcess.TabIndex = 1;
      this.grbInvoiceProcess.TabStop = false;
      this.grbInvoiceProcess.Text = "Xử lý hóa đơn";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(71, 252);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(138, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "Tên sản phẩm";
      // 
      // frmProductManagement
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1501, 722);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "frmProductManagement";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Quản lý sản phẩm";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductManagement_FormClosing);
      this.Load += new System.EventHandler(this.frmProductManagement_Load);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.grbInvoiceProcess.ResumeLayout(false);
      this.grbInvoiceProcess.PerformLayout();
      this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnSearchProduct;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.GroupBox grbInvoiceProcess;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRetailPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colImportPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colExportPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colInventoryQuantity;
	}
}