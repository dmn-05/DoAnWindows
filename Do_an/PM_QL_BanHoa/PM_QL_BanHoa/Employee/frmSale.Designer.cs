namespace PM_QL_BanHoa.Employee {
	partial class frmSale {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colExportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colInventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnSearchProduct = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.lblSearchProductName = new System.Windows.Forms.Label();
      this._txtProductName = new System.Windows.Forms.TextBox();
      this.grbSaleProcess = new System.Windows.Forms.GroupBox();
      this.btnViewCart = new System.Windows.Forms.Button();
      this.txtTotalPrice = new System.Windows.Forms.TextBox();
      this.lblTotalPrice = new System.Windows.Forms.Label();
      this.txtPrice = new System.Windows.Forms.TextBox();
      this.txtQuantity = new System.Windows.Forms.TextBox();
      this.lblPrice = new System.Windows.Forms.Label();
      this.btnAddToCart = new System.Windows.Forms.Button();
      this.lblSellQuantity = new System.Windows.Forms.Label();
      this.txtProductName = new System.Windows.Forms.TextBox();
      this.txtProductID = new System.Windows.Forms.TextBox();
      this.lblProductName = new System.Windows.Forms.Label();
      this.lblProductID = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.grbSaleProcess.SuspendLayout();
      this.SuspendLayout();
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
      this.dataGridView.Location = new System.Drawing.Point(3, 57);
      this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowHeadersWidth = 62;
      this.dataGridView.RowTemplate.Height = 28;
      this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView.Size = new System.Drawing.Size(907, 647);
      this.dataGridView.TabIndex = 0;
      this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
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
      // btnSearchProduct
      // 
      this.btnSearchProduct.Location = new System.Drawing.Point(388, 10);
      this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnSearchProduct.Name = "btnSearchProduct";
      this.btnSearchProduct.Size = new System.Drawing.Size(84, 30);
      this.btnSearchProduct.TabIndex = 14;
      this.btnSearchProduct.Text = "Tìm kiếm";
      this.btnSearchProduct.UseVisualStyleBackColor = true;
      this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
      this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.dataGridView);
      this.panel1.Controls.Add(this.grbSaleProcess);
      this.panel1.Location = new System.Drawing.Point(11, 10);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1481, 703);
      this.panel1.TabIndex = 3;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.Transparent;
      this.panel2.Controls.Add(this.btnSearchProduct);
      this.panel2.Controls.Add(this.lblSearchProductName);
      this.panel2.Controls.Add(this._txtProductName);
      this.panel2.Location = new System.Drawing.Point(916, 5);
      this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(563, 47);
      this.panel2.TabIndex = 15;
      // 
      // lblSearchProductName
      // 
      this.lblSearchProductName.AutoSize = true;
      this.lblSearchProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSearchProductName.Location = new System.Drawing.Point(79, 11);
      this.lblSearchProductName.Name = "lblSearchProductName";
      this.lblSearchProductName.Size = new System.Drawing.Size(90, 20);
      this.lblSearchProductName.TabIndex = 3;
      this.lblSearchProductName.Text = "Nhập tên:";
      // 
      // _txtProductName
      // 
      this._txtProductName.Location = new System.Drawing.Point(189, 11);
      this._txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this._txtProductName.Name = "_txtProductName";
      this._txtProductName.Size = new System.Drawing.Size(192, 22);
      this._txtProductName.TabIndex = 2;
      this._txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtProductName_KeyPress);
      // 
      // grbSaleProcess
      // 
      this.grbSaleProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grbSaleProcess.BackColor = System.Drawing.Color.Transparent;
      this.grbSaleProcess.Controls.Add(this.btnViewCart);
      this.grbSaleProcess.Controls.Add(this.txtTotalPrice);
      this.grbSaleProcess.Controls.Add(this.lblTotalPrice);
      this.grbSaleProcess.Controls.Add(this.txtPrice);
      this.grbSaleProcess.Controls.Add(this.txtQuantity);
      this.grbSaleProcess.Controls.Add(this.lblPrice);
      this.grbSaleProcess.Controls.Add(this.btnAddToCart);
      this.grbSaleProcess.Controls.Add(this.lblSellQuantity);
      this.grbSaleProcess.Controls.Add(this.txtProductName);
      this.grbSaleProcess.Controls.Add(this.txtProductID);
      this.grbSaleProcess.Controls.Add(this.lblProductName);
      this.grbSaleProcess.Controls.Add(this.lblProductID);
      this.grbSaleProcess.Location = new System.Drawing.Point(916, 57);
      this.grbSaleProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grbSaleProcess.Name = "grbSaleProcess";
      this.grbSaleProcess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grbSaleProcess.Size = new System.Drawing.Size(563, 642);
      this.grbSaleProcess.TabIndex = 1;
      this.grbSaleProcess.TabStop = false;
      this.grbSaleProcess.Text = "Bán hàng";
      // 
      // btnViewCart
      // 
      this.btnViewCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewCart.BackgroundImage")));
      this.btnViewCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnViewCart.Location = new System.Drawing.Point(127, 399);
      this.btnViewCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnViewCart.Name = "btnViewCart";
      this.btnViewCart.Size = new System.Drawing.Size(100, 92);
      this.btnViewCart.TabIndex = 26;
      this.btnViewCart.UseVisualStyleBackColor = true;
      this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
      // 
      // txtTotalPrice
      // 
      this.txtTotalPrice.Location = new System.Drawing.Point(245, 318);
      this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtTotalPrice.Name = "txtTotalPrice";
      this.txtTotalPrice.ReadOnly = true;
      this.txtTotalPrice.Size = new System.Drawing.Size(265, 22);
      this.txtTotalPrice.TabIndex = 23;
      // 
      // lblTotalPrice
      // 
      this.lblTotalPrice.AutoSize = true;
      this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotalPrice.Location = new System.Drawing.Point(88, 319);
      this.lblTotalPrice.Name = "lblTotalPrice";
      this.lblTotalPrice.Size = new System.Drawing.Size(111, 25);
      this.lblTotalPrice.TabIndex = 22;
      this.lblTotalPrice.Text = "Thành tiền:";
      // 
      // txtPrice
      // 
      this.txtPrice.Location = new System.Drawing.Point(245, 258);
      this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtPrice.Name = "txtPrice";
      this.txtPrice.ReadOnly = true;
      this.txtPrice.Size = new System.Drawing.Size(265, 22);
      this.txtPrice.TabIndex = 21;
      // 
      // txtQuantity
      // 
      this.txtQuantity.Location = new System.Drawing.Point(245, 201);
      this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtQuantity.Name = "txtQuantity";
      this.txtQuantity.Size = new System.Drawing.Size(265, 22);
      this.txtQuantity.TabIndex = 20;
      this.txtQuantity.MouseLeave += new System.EventHandler(this.txtQuantity_MouseLeave);
      // 
      // lblPrice
      // 
      this.lblPrice.AutoSize = true;
      this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPrice.Location = new System.Drawing.Point(115, 255);
      this.lblPrice.Name = "lblPrice";
      this.lblPrice.Size = new System.Drawing.Size(85, 25);
      this.lblPrice.TabIndex = 19;
      this.lblPrice.Text = "Đơn giá:";
      // 
      // btnAddToCart
      // 
      this.btnAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.BackgroundImage")));
      this.btnAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnAddToCart.Location = new System.Drawing.Point(355, 399);
      this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnAddToCart.Name = "btnAddToCart";
      this.btnAddToCart.Size = new System.Drawing.Size(100, 92);
      this.btnAddToCart.TabIndex = 18;
      this.btnAddToCart.UseVisualStyleBackColor = true;
      this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
      // 
      // lblSellQuantity
      // 
      this.lblSellQuantity.AutoSize = true;
      this.lblSellQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSellQuantity.Location = new System.Drawing.Point(63, 199);
      this.lblSellQuantity.Name = "lblSellQuantity";
      this.lblSellQuantity.Size = new System.Drawing.Size(134, 25);
      this.lblSellQuantity.TabIndex = 16;
      this.lblSellQuantity.Text = "Số lượng bán:";
      // 
      // txtProductName
      // 
      this.txtProductName.Location = new System.Drawing.Point(245, 136);
      this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtProductName.Name = "txtProductName";
      this.txtProductName.ReadOnly = true;
      this.txtProductName.Size = new System.Drawing.Size(265, 22);
      this.txtProductName.TabIndex = 15;
      // 
      // txtProductID
      // 
      this.txtProductID.Location = new System.Drawing.Point(245, 71);
      this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtProductID.Name = "txtProductID";
      this.txtProductID.ReadOnly = true;
      this.txtProductID.Size = new System.Drawing.Size(265, 22);
      this.txtProductID.TabIndex = 7;
      // 
      // lblProductName
      // 
      this.lblProductName.AutoSize = true;
      this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblProductName.Location = new System.Drawing.Point(53, 134);
      this.lblProductName.Name = "lblProductName";
      this.lblProductName.Size = new System.Drawing.Size(144, 25);
      this.lblProductName.TabIndex = 1;
      this.lblProductName.Text = "Tên sản phẩm:";
      // 
      // lblProductID
      // 
      this.lblProductID.AutoSize = true;
      this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblProductID.Location = new System.Drawing.Point(63, 71);
      this.lblProductID.Name = "lblProductID";
      this.lblProductID.Size = new System.Drawing.Size(137, 25);
      this.lblProductID.TabIndex = 0;
      this.lblProductID.Text = "Mã sản phẩm:";
      // 
      // frmSale
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1501, 722);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "frmSale";
      this.Text = "Bán hàng";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSale_FormClosing);
      this.Load += new System.EventHandler(this.frmSale_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.grbSaleProcess.ResumeLayout(false);
      this.grbSaleProcess.PerformLayout();
      this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRetailPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colImportPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colExportPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colInventoryQuantity;
		private System.Windows.Forms.Button btnSearchProduct;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox grbSaleProcess;
		private System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.Label lblProductID;
		private System.Windows.Forms.Label lblSellQuantity;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Button btnAddToCart;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label lblSearchProductName;
		private System.Windows.Forms.TextBox _txtProductName;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label lblTotalPrice;
		private System.Windows.Forms.Button btnViewCart;
		private System.Windows.Forms.Panel panel2;
	}
}