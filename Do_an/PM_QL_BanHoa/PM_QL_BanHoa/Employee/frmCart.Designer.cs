namespace PM_QL_BanHoa.Employee {
	partial class frmCart {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCart));
			this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
			this.lblDeliveryAddress = new System.Windows.Forms.Label();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.lblTotalPrice = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.btnPayment = new System.Windows.Forms.Button();
			this.lblSellQuantity = new System.Windows.Forms.Label();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
			this.lblProductID = new System.Windows.Forms.Label();
			this.lblCustomerPhoneNumber = new System.Windows.Forms.Label();
			this.lblSearchProductName = new System.Windows.Forms.Label();
			this._txtProductName = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnRemoveFromCart = new System.Windows.Forms.Button();
			this.grbCustomerInformation = new System.Windows.Forms.GroupBox();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.colCartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grbSaleProcess = new System.Windows.Forms.GroupBox();
			this.btnSearchProduct = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.grbCustomerInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.grbSaleProcess.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtDeliveryAddress
			// 
			this.txtDeliveryAddress.Location = new System.Drawing.Point(272, 205);
			this.txtDeliveryAddress.Multiline = true;
			this.txtDeliveryAddress.Name = "txtDeliveryAddress";
			this.txtDeliveryAddress.Size = new System.Drawing.Size(298, 75);
			this.txtDeliveryAddress.TabIndex = 25;
			// 
			// lblDeliveryAddress
			// 
			this.lblDeliveryAddress.AutoSize = true;
			this.lblDeliveryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDeliveryAddress.Location = new System.Drawing.Point(84, 205);
			this.lblDeliveryAddress.Name = "lblDeliveryAddress";
			this.lblDeliveryAddress.Size = new System.Drawing.Size(145, 29);
			this.lblDeliveryAddress.TabIndex = 24;
			this.lblDeliveryAddress.Text = "Địa chỉ giao:";
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Location = new System.Drawing.Point(272, 282);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.ReadOnly = true;
			this.txtTotalPrice.Size = new System.Drawing.Size(298, 26);
			this.txtTotalPrice.TabIndex = 23;
			// 
			// lblTotalPrice
			// 
			this.lblTotalPrice.AutoSize = true;
			this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalPrice.Location = new System.Drawing.Point(70, 278);
			this.lblTotalPrice.Name = "lblTotalPrice";
			this.lblTotalPrice.Size = new System.Drawing.Size(132, 29);
			this.lblTotalPrice.TabIndex = 22;
			this.lblTotalPrice.Text = "Thành tiền:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(272, 198);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.ReadOnly = true;
			this.txtPrice.Size = new System.Drawing.Size(298, 26);
			this.txtPrice.TabIndex = 21;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(272, 128);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(298, 26);
			this.txtQuantity.TabIndex = 20;
			this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrice.Location = new System.Drawing.Point(100, 195);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(102, 29);
			this.lblPrice.TabIndex = 19;
			this.lblPrice.Text = "Đơn giá:";
			// 
			// btnPayment
			// 
			this.btnPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayment.BackgroundImage")));
			this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPayment.Location = new System.Drawing.Point(1410, 763);
			this.btnPayment.Name = "btnPayment";
			this.btnPayment.Size = new System.Drawing.Size(101, 101);
			this.btnPayment.TabIndex = 18;
			this.btnPayment.UseVisualStyleBackColor = true;
			this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
			// 
			// lblSellQuantity
			// 
			this.lblSellQuantity.AutoSize = true;
			this.lblSellQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSellQuantity.Location = new System.Drawing.Point(66, 125);
			this.lblSellQuantity.Name = "lblSellQuantity";
			this.lblSellQuantity.Size = new System.Drawing.Size(161, 29);
			this.lblSellQuantity.TabIndex = 16;
			this.lblSellQuantity.Text = "Số lượng bán:";
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(272, 46);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.ReadOnly = true;
			this.txtProductID.Size = new System.Drawing.Size(298, 26);
			this.txtProductID.TabIndex = 15;
			// 
			// txtCustomerPhoneNumber
			// 
			this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(272, 43);
			this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
			this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(298, 26);
			this.txtCustomerPhoneNumber.TabIndex = 7;
			this.txtCustomerPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerPhoneNumber_KeyPress);
			// 
			// lblProductID
			// 
			this.lblProductID.AutoSize = true;
			this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductID.Location = new System.Drawing.Point(56, 43);
			this.lblProductID.Name = "lblProductID";
			this.lblProductID.Size = new System.Drawing.Size(162, 29);
			this.lblProductID.TabIndex = 1;
			this.lblProductID.Text = "Mã sản phẩm:";
			// 
			// lblCustomerPhoneNumber
			// 
			this.lblCustomerPhoneNumber.AutoSize = true;
			this.lblCustomerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerPhoneNumber.Location = new System.Drawing.Point(63, 43);
			this.lblCustomerPhoneNumber.Name = "lblCustomerPhoneNumber";
			this.lblCustomerPhoneNumber.Size = new System.Drawing.Size(160, 29);
			this.lblCustomerPhoneNumber.TabIndex = 0;
			this.lblCustomerPhoneNumber.Text = "Số điện thoại:";
			// 
			// lblSearchProductName
			// 
			this.lblSearchProductName.AutoSize = true;
			this.lblSearchProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearchProductName.Location = new System.Drawing.Point(1024, 23);
			this.lblSearchProductName.Name = "lblSearchProductName";
			this.lblSearchProductName.Size = new System.Drawing.Size(114, 25);
			this.lblSearchProductName.TabIndex = 3;
			this.lblSearchProductName.Text = "Nhập tên:";
			// 
			// _txtProductName
			// 
			this._txtProductName.Location = new System.Drawing.Point(1149, 23);
			this._txtProductName.Name = "_txtProductName";
			this._txtProductName.Size = new System.Drawing.Size(216, 26);
			this._txtProductName.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.btnRemoveFromCart);
			this.panel1.Controls.Add(this.grbCustomerInformation);
			this.panel1.Controls.Add(this.lblSearchProductName);
			this.panel1.Controls.Add(this._txtProductName);
			this.panel1.Controls.Add(this.btnPayment);
			this.panel1.Controls.Add(this.dataGridView);
			this.panel1.Controls.Add(this.grbSaleProcess);
			this.panel1.Controls.Add(this.btnSearchProduct);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1666, 878);
			this.panel1.TabIndex = 4;
			// 
			// btnRemoveFromCart
			// 
			this.btnRemoveFromCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveFromCart.BackgroundImage")));
			this.btnRemoveFromCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRemoveFromCart.Location = new System.Drawing.Point(1195, 763);
			this.btnRemoveFromCart.Name = "btnRemoveFromCart";
			this.btnRemoveFromCart.Size = new System.Drawing.Size(101, 101);
			this.btnRemoveFromCart.TabIndex = 19;
			this.btnRemoveFromCart.UseVisualStyleBackColor = true;
			this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
			// 
			// grbCustomerInformation
			// 
			this.grbCustomerInformation.Controls.Add(this.txtCustomerName);
			this.grbCustomerInformation.Controls.Add(this.lblCustomerName);
			this.grbCustomerInformation.Controls.Add(this.txtDeliveryAddress);
			this.grbCustomerInformation.Controls.Add(this.lblDeliveryAddress);
			this.grbCustomerInformation.Controls.Add(this.txtCustomerPhoneNumber);
			this.grbCustomerInformation.Controls.Add(this.lblCustomerPhoneNumber);
			this.grbCustomerInformation.Location = new System.Drawing.Point(1030, 432);
			this.grbCustomerInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grbCustomerInformation.Name = "grbCustomerInformation";
			this.grbCustomerInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grbCustomerInformation.Size = new System.Drawing.Size(632, 323);
			this.grbCustomerInformation.TabIndex = 15;
			this.grbCustomerInformation.TabStop = false;
			this.grbCustomerInformation.Text = "Thông tin khách hàng";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(272, 117);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(298, 26);
			this.txtCustomerName.TabIndex = 27;
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerName.Location = new System.Drawing.Point(63, 117);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(190, 29);
			this.lblCustomerName.TabIndex = 26;
			this.lblCustomerName.Text = "Tên khách hàng:";
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCartID,
            this.colCustomerID,
            this.colProductID,
            this.colQuantity,
            this.colPrice,
            this.colTotalPrice,
            this.colStatus});
			this.dataGridView.Location = new System.Drawing.Point(3, 71);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(1020, 809);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
			// 
			// colCartID
			// 
			this.colCartID.DataPropertyName = "MaGH";
			this.colCartID.HeaderText = "Mã giỏ hàng";
			this.colCartID.MinimumWidth = 8;
			this.colCartID.Name = "colCartID";
			// 
			// colCustomerID
			// 
			this.colCustomerID.DataPropertyName = "MaKH";
			this.colCustomerID.HeaderText = "Mã khách hàng";
			this.colCustomerID.MinimumWidth = 8;
			this.colCustomerID.Name = "colCustomerID";
			// 
			// colProductID
			// 
			this.colProductID.DataPropertyName = "MaSP";
			this.colProductID.HeaderText = "Mã sản phẩm";
			this.colProductID.MinimumWidth = 8;
			this.colProductID.Name = "colProductID";
			// 
			// colQuantity
			// 
			this.colQuantity.DataPropertyName = "SoLuong";
			this.colQuantity.HeaderText = "Số lượng";
			this.colQuantity.MinimumWidth = 8;
			this.colQuantity.Name = "colQuantity";
			// 
			// colPrice
			// 
			this.colPrice.DataPropertyName = "GiaBanLe";
			this.colPrice.HeaderText = "Giá";
			this.colPrice.MinimumWidth = 8;
			this.colPrice.Name = "colPrice";
			// 
			// colTotalPrice
			// 
			this.colTotalPrice.DataPropertyName = "ThanhTien";
			this.colTotalPrice.HeaderText = "Thành tiền";
			this.colTotalPrice.MinimumWidth = 8;
			this.colTotalPrice.Name = "colTotalPrice";
			// 
			// colStatus
			// 
			this.colStatus.DataPropertyName = "TrangThai";
			this.colStatus.HeaderText = "Trạng thái";
			this.colStatus.MinimumWidth = 8;
			this.colStatus.Name = "colStatus";
			// 
			// grbSaleProcess
			// 
			this.grbSaleProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grbSaleProcess.BackColor = System.Drawing.Color.Transparent;
			this.grbSaleProcess.Controls.Add(this.txtTotalPrice);
			this.grbSaleProcess.Controls.Add(this.lblTotalPrice);
			this.grbSaleProcess.Controls.Add(this.txtPrice);
			this.grbSaleProcess.Controls.Add(this.txtQuantity);
			this.grbSaleProcess.Controls.Add(this.lblPrice);
			this.grbSaleProcess.Controls.Add(this.lblSellQuantity);
			this.grbSaleProcess.Controls.Add(this.txtProductID);
			this.grbSaleProcess.Controls.Add(this.lblProductID);
			this.grbSaleProcess.Location = new System.Drawing.Point(1030, 71);
			this.grbSaleProcess.Name = "grbSaleProcess";
			this.grbSaleProcess.Size = new System.Drawing.Size(633, 354);
			this.grbSaleProcess.TabIndex = 1;
			this.grbSaleProcess.TabStop = false;
			this.grbSaleProcess.Text = "Bán hàng";
			// 
			// btnSearchProduct
			// 
			this.btnSearchProduct.Location = new System.Drawing.Point(1372, 22);
			this.btnSearchProduct.Name = "btnSearchProduct";
			this.btnSearchProduct.Size = new System.Drawing.Size(94, 37);
			this.btnSearchProduct.TabIndex = 14;
			this.btnSearchProduct.Text = "Tìm kiếm";
			this.btnSearchProduct.UseVisualStyleBackColor = true;
			// 
			// frmCart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1689, 903);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCart";
			this.Text = "Giỏ hàng";
			this.Load += new System.EventHandler(this.frmCart_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.grbCustomerInformation.ResumeLayout(false);
			this.grbCustomerInformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.grbSaleProcess.ResumeLayout(false);
			this.grbSaleProcess.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txtDeliveryAddress;
		private System.Windows.Forms.Label lblDeliveryAddress;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label lblTotalPrice;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Button btnPayment;
		private System.Windows.Forms.Label lblSellQuantity;
		private System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
		private System.Windows.Forms.Label lblProductID;
		private System.Windows.Forms.Label lblCustomerPhoneNumber;
		private System.Windows.Forms.Label lblSearchProductName;
		private System.Windows.Forms.TextBox _txtProductName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.GroupBox grbSaleProcess;
		private System.Windows.Forms.Button btnSearchProduct;
		private System.Windows.Forms.GroupBox grbCustomerInformation;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.Button btnRemoveFromCart;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCartID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
	}
}