namespace PM_QL_BanHoa.Employee {
	partial class frmBillManagement {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillManagement));
      this.grbInvoiceProcess = new System.Windows.Forms.GroupBox();
      this.btnUpdateInvoice = new System.Windows.Forms.Button();
      this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.txtStatus = new System.Windows.Forms.TextBox();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
      this.txtCustomerID = new System.Windows.Forms.TextBox();
      this.txtStaffID = new System.Windows.Forms.TextBox();
      this.txtInvoiceID = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.colBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colAddressDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.grbInvoiceProcess.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // grbInvoiceProcess
      // 
      this.grbInvoiceProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grbInvoiceProcess.BackColor = System.Drawing.Color.Transparent;
      this.grbInvoiceProcess.Controls.Add(this.btnUpdateInvoice);
      this.grbInvoiceProcess.Controls.Add(this.dateTimePicker);
      this.grbInvoiceProcess.Controls.Add(this.txtStatus);
      this.grbInvoiceProcess.Controls.Add(this.txtTotal);
      this.grbInvoiceProcess.Controls.Add(this.txtDeliveryAddress);
      this.grbInvoiceProcess.Controls.Add(this.txtCustomerID);
      this.grbInvoiceProcess.Controls.Add(this.txtStaffID);
      this.grbInvoiceProcess.Controls.Add(this.txtInvoiceID);
      this.grbInvoiceProcess.Controls.Add(this.label7);
      this.grbInvoiceProcess.Controls.Add(this.label6);
      this.grbInvoiceProcess.Controls.Add(this.label5);
      this.grbInvoiceProcess.Controls.Add(this.label4);
      this.grbInvoiceProcess.Controls.Add(this.label3);
      this.grbInvoiceProcess.Controls.Add(this.label2);
      this.grbInvoiceProcess.Controls.Add(this.label1);
      this.grbInvoiceProcess.Location = new System.Drawing.Point(916, 6);
      this.grbInvoiceProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grbInvoiceProcess.Name = "grbInvoiceProcess";
      this.grbInvoiceProcess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grbInvoiceProcess.Size = new System.Drawing.Size(563, 697);
      this.grbInvoiceProcess.TabIndex = 1;
      this.grbInvoiceProcess.TabStop = false;
      this.grbInvoiceProcess.Text = "Xử lý hóa đơn";
      // 
      // btnUpdateInvoice
      // 
      this.btnUpdateInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateInvoice.BackgroundImage")));
      this.btnUpdateInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnUpdateInvoice.Location = new System.Drawing.Point(259, 569);
      this.btnUpdateInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnUpdateInvoice.Name = "btnUpdateInvoice";
      this.btnUpdateInvoice.Size = new System.Drawing.Size(75, 75);
      this.btnUpdateInvoice.TabIndex = 15;
      this.btnUpdateInvoice.UseVisualStyleBackColor = true;
      this.btnUpdateInvoice.Click += new System.EventHandler(this.btnUpdateInvoice_Click);
      // 
      // dateTimePicker
      // 
      this.dateTimePicker.Location = new System.Drawing.Point(259, 238);
      this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dateTimePicker.Name = "dateTimePicker";
      this.dateTimePicker.Size = new System.Drawing.Size(249, 22);
      this.dateTimePicker.TabIndex = 13;
      // 
      // txtStatus
      // 
      this.txtStatus.Location = new System.Drawing.Point(259, 302);
      this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtStatus.Name = "txtStatus";
      this.txtStatus.Size = new System.Drawing.Size(249, 22);
      this.txtStatus.TabIndex = 12;
      // 
      // txtTotal
      // 
      this.txtTotal.Location = new System.Drawing.Point(259, 500);
      this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.Size = new System.Drawing.Size(249, 22);
      this.txtTotal.TabIndex = 11;
      // 
      // txtDeliveryAddress
      // 
      this.txtDeliveryAddress.Location = new System.Drawing.Point(259, 357);
      this.txtDeliveryAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtDeliveryAddress.Multiline = true;
      this.txtDeliveryAddress.Name = "txtDeliveryAddress";
      this.txtDeliveryAddress.Size = new System.Drawing.Size(249, 100);
      this.txtDeliveryAddress.TabIndex = 10;
      // 
      // txtCustomerID
      // 
      this.txtCustomerID.Location = new System.Drawing.Point(259, 174);
      this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtCustomerID.Name = "txtCustomerID";
      this.txtCustomerID.Size = new System.Drawing.Size(249, 22);
      this.txtCustomerID.TabIndex = 9;
      // 
      // txtStaffID
      // 
      this.txtStaffID.Location = new System.Drawing.Point(259, 111);
      this.txtStaffID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtStaffID.Name = "txtStaffID";
      this.txtStaffID.Size = new System.Drawing.Size(249, 22);
      this.txtStaffID.TabIndex = 8;
      // 
      // txtInvoiceID
      // 
      this.txtInvoiceID.Location = new System.Drawing.Point(259, 47);
      this.txtInvoiceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtInvoiceID.Name = "txtInvoiceID";
      this.txtInvoiceID.ReadOnly = true;
      this.txtInvoiceID.Size = new System.Drawing.Size(249, 22);
      this.txtInvoiceID.TabIndex = 7;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(75, 298);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(100, 25);
      this.label7.TabIndex = 6;
      this.label7.Text = "Trạng thái";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(75, 496);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(105, 25);
      this.label6.TabIndex = 5;
      this.label6.Text = "Thành tiền";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(77, 391);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(113, 25);
      this.label5.TabIndex = 4;
      this.label5.Text = "Địa chỉ giao";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(75, 234);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(165, 25);
      this.label4.TabIndex = 3;
      this.label4.Text = "Ngày lập hóa đơn";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(75, 170);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(147, 25);
      this.label3.TabIndex = 2;
      this.label3.Text = "Mã khách hàng";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(75, 107);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(130, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "Mã nhân viên";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(75, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(116, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Mã hóa đơn";
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackColor = System.Drawing.Color.Transparent;
      this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
      this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.panel1.Controls.Add(this.dataGridView);
      this.panel1.Controls.Add(this.grbInvoiceProcess);
      this.panel1.Location = new System.Drawing.Point(12, 11);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1481, 703);
      this.panel1.TabIndex = 0;
      // 
      // dataGridView
      // 
      this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBillID,
            this.colStaffID,
            this.colCustomerID,
            this.colDate,
            this.colStatus,
            this.colAddressDelivery,
            this.colTotal});
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
      // colBillID
      // 
      this.colBillID.DataPropertyName = "MaHD";
      this.colBillID.HeaderText = "Mã hóa đơn";
      this.colBillID.MinimumWidth = 8;
      this.colBillID.Name = "colBillID";
      // 
      // colStaffID
      // 
      this.colStaffID.DataPropertyName = "MaNV";
      this.colStaffID.HeaderText = "Mã nhân viên";
      this.colStaffID.MinimumWidth = 8;
      this.colStaffID.Name = "colStaffID";
      // 
      // colCustomerID
      // 
      this.colCustomerID.DataPropertyName = "MaKH";
      this.colCustomerID.HeaderText = "Mã khách hàng";
      this.colCustomerID.MinimumWidth = 8;
      this.colCustomerID.Name = "colCustomerID";
      // 
      // colDate
      // 
      this.colDate.DataPropertyName = "NgayLapHoaDon";
      this.colDate.HeaderText = "Ngày lập hóa đơn";
      this.colDate.MinimumWidth = 8;
      this.colDate.Name = "colDate";
      // 
      // colStatus
      // 
      this.colStatus.DataPropertyName = "TrangThai";
      this.colStatus.HeaderText = "Trạng thái";
      this.colStatus.MinimumWidth = 8;
      this.colStatus.Name = "colStatus";
      // 
      // colAddressDelivery
      // 
      this.colAddressDelivery.DataPropertyName = "DiaChiGiao";
      this.colAddressDelivery.HeaderText = "Địa chỉ giao";
      this.colAddressDelivery.MinimumWidth = 8;
      this.colAddressDelivery.Name = "colAddressDelivery";
      // 
      // colTotal
      // 
      this.colTotal.DataPropertyName = "ThanhTien";
      this.colTotal.HeaderText = "Thành tiền";
      this.colTotal.MinimumWidth = 8;
      this.colTotal.Name = "colTotal";
      // 
      // frmBillManagement
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1501, 722);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "frmBillManagement";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Quản lý hóa đơn";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBillManagement_FormClosing);
      this.Load += new System.EventHandler(this.frmBillManagement_Load);
      this.grbInvoiceProcess.ResumeLayout(false);
      this.grbInvoiceProcess.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox grbInvoiceProcess;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBillID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStaffID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAddressDelivery;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtDeliveryAddress;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.TextBox txtStaffID;
		private System.Windows.Forms.TextBox txtInvoiceID;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUpdateInvoice;
	}
}