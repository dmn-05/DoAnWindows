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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colExportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colInventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSearchProduct = new System.Windows.Forms.Button();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.grbSaleProcess = new System.Windows.Forms.GroupBox();
			this.btnPayment = new System.Windows.Forms.Button();
			this.lblSellQuantity = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblProductID = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.lblInvoiceID = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.panel1.SuspendLayout();
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
			this.dataGridView.Location = new System.Drawing.Point(3, 5);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(907, 698);
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
			this.btnSearchProduct.Location = new System.Drawing.Point(105, 505);
			this.btnSearchProduct.Name = "btnSearchProduct";
			this.btnSearchProduct.Size = new System.Drawing.Size(150, 75);
			this.btnSearchProduct.TabIndex = 14;
			this.btnSearchProduct.Text = "Tìm kiếm sản phẩm";
			this.btnSearchProduct.UseVisualStyleBackColor = true;
			this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(252, 229);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(250, 22);
			this.txtProductName.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.dataGridView);
			this.panel1.Controls.Add(this.grbSaleProcess);
			this.panel1.Location = new System.Drawing.Point(11, 10);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1481, 703);
			this.panel1.TabIndex = 3;
			// 
			// grbSaleProcess
			// 
			this.grbSaleProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grbSaleProcess.BackColor = System.Drawing.Color.Transparent;
			this.grbSaleProcess.Controls.Add(this.lblInvoiceID);
			this.grbSaleProcess.Controls.Add(this.txtPrice);
			this.grbSaleProcess.Controls.Add(this.lblPrice);
			this.grbSaleProcess.Controls.Add(this.btnPayment);
			this.grbSaleProcess.Controls.Add(this.lblSellQuantity);
			this.grbSaleProcess.Controls.Add(this.textBox1);
			this.grbSaleProcess.Controls.Add(this.btnSearchProduct);
			this.grbSaleProcess.Controls.Add(this.txtProductName);
			this.grbSaleProcess.Controls.Add(this.txtProductID);
			this.grbSaleProcess.Controls.Add(this.label2);
			this.grbSaleProcess.Controls.Add(this.lblProductID);
			this.grbSaleProcess.Location = new System.Drawing.Point(916, 6);
			this.grbSaleProcess.Name = "grbSaleProcess";
			this.grbSaleProcess.Size = new System.Drawing.Size(562, 697);
			this.grbSaleProcess.TabIndex = 1;
			this.grbSaleProcess.TabStop = false;
			this.grbSaleProcess.Text = "Bán hàng";
			// 
			// btnPayment
			// 
			this.btnPayment.Location = new System.Drawing.Point(336, 505);
			this.btnPayment.Name = "btnPayment";
			this.btnPayment.Size = new System.Drawing.Size(150, 75);
			this.btnPayment.TabIndex = 18;
			this.btnPayment.Text = "Thanh toán";
			this.btnPayment.UseVisualStyleBackColor = true;
			// 
			// lblSellQuantity
			// 
			this.lblSellQuantity.AutoSize = true;
			this.lblSellQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSellQuantity.Location = new System.Drawing.Point(69, 287);
			this.lblSellQuantity.Name = "lblSellQuantity";
			this.lblSellQuantity.Size = new System.Drawing.Size(134, 25);
			this.lblSellQuantity.TabIndex = 16;
			this.lblSellQuantity.Text = "Số lượng bán:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(252, 295);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(250, 22);
			this.textBox1.TabIndex = 15;
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(252, 55);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.ReadOnly = true;
			this.txtProductID.Size = new System.Drawing.Size(250, 22);
			this.txtProductID.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(69, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên sản phẩm:";
			// 
			// lblProductID
			// 
			this.lblProductID.AutoSize = true;
			this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductID.Location = new System.Drawing.Point(69, 55);
			this.lblProductID.Name = "lblProductID";
			this.lblProductID.Size = new System.Drawing.Size(137, 25);
			this.lblProductID.TabIndex = 0;
			this.lblProductID.Text = "Mã sản phẩm:";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrice.Location = new System.Drawing.Point(72, 360);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(85, 25);
			this.lblPrice.TabIndex = 19;
			this.lblPrice.Text = "Đơn giá:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(252, 360);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(250, 22);
			this.txtPrice.TabIndex = 20;
			// 
			// lblInvoiceID
			// 
			this.lblInvoiceID.AutoSize = true;
			this.lblInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInvoiceID.Location = new System.Drawing.Point(72, 116);
			this.lblInvoiceID.Name = "lblInvoiceID";
			this.lblInvoiceID.Size = new System.Drawing.Size(122, 25);
			this.lblInvoiceID.TabIndex = 21;
			this.lblInvoiceID.Text = "Mã hóa đơn:";
			// 
			// frmSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1502, 723);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmSale";
			this.Text = "Bán hàng";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSale_FormClosing);
			this.Load += new System.EventHandler(this.frmSale_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
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
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox grbSaleProcess;
		private System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblProductID;
		private System.Windows.Forms.Label lblSellQuantity;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnPayment;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label lblInvoiceID;
	}
}