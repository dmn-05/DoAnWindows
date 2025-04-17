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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.colBillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAddressDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 6);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1658, 872);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.dataGridView);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1650, 839);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Tạo hóa đơn";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBillID,
            this.colStaffID,
            this.colCustomerID,
            this.colDate,
            this.colStatus,
            this.colAddressDelivery,
            this.colTotal});
			this.dataGridView.Location = new System.Drawing.Point(6, 6);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.Size = new System.Drawing.Size(1018, 823);
			this.dataGridView.TabIndex = 0;
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
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1249, 611);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Chỉnh sửa hóa đơn";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1664, 878);
			this.panel1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(1236, 82);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 26);
			this.textBox1.TabIndex = 1;
			// 
			// frmBillManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1688, 902);
			this.Controls.Add(this.panel1);
			this.Name = "frmBillManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý hóa đơn";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBillManagement_FormClosing);
			this.Load += new System.EventHandler(this.frmBillManagement_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBillID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStaffID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAddressDelivery;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
		private System.Windows.Forms.TextBox textBox1;
	}
}