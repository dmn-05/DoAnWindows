namespace PM_QL_BanHoa.Employee {
	partial class frmCustomerManagement {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerManagement));
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearchCustomerName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grbCustomerManagement = new System.Windows.Forms.GroupBox();
			this.btnUpdataCustomerInformation = new System.Windows.Forms.Button();
			this.btnAddCustomer = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.grbCustomerManagement.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(282, 362);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(280, 26);
			this.txtEmail.TabIndex = 12;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(282, 443);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(280, 124);
			this.txtAddress.TabIndex = 11;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(282, 271);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(280, 26);
			this.txtPhoneNumber.TabIndex = 9;
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(282, 192);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(280, 26);
			this.txtCustomerName.TabIndex = 8;
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Location = new System.Drawing.Point(282, 112);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.ReadOnly = true;
			this.txtCustomerID.Size = new System.Drawing.Size(280, 26);
			this.txtCustomerID.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(75, 357);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 29);
			this.label7.TabIndex = 6;
			this.label7.Text = "Email";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(75, 495);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 29);
			this.label6.TabIndex = 5;
			this.label6.Text = "Địa chỉ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(75, 266);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Số điện thoại";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(75, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã khách hàng";
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
			this.panel1.Controls.Add(this.grbCustomerManagement);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1666, 878);
			this.panel1.TabIndex = 1;
			// 
			// btnSearch
			// 
			this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSearch.Location = new System.Drawing.Point(449, 11);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(45, 45);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearchCustomerName
			// 
			this.txtSearchCustomerName.Location = new System.Drawing.Point(275, 20);
			this.txtSearchCustomerName.Name = "txtSearchCustomerName";
			this.txtSearchCustomerName.Size = new System.Drawing.Size(150, 26);
			this.txtSearchCustomerName.TabIndex = 3;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(143, 16);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(116, 29);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Nhập tên:";
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerID,
            this.colCustomerName,
            this.colPhoneNumber,
            this.colEmail,
            this.colAddress});
			this.dataGridView.Location = new System.Drawing.Point(3, 6);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.Size = new System.Drawing.Size(1020, 872);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
			// 
			// colCustomerID
			// 
			this.colCustomerID.DataPropertyName = "MaKH";
			this.colCustomerID.HeaderText = "Mã khách hàng";
			this.colCustomerID.MinimumWidth = 8;
			this.colCustomerID.Name = "colCustomerID";
			// 
			// colCustomerName
			// 
			this.colCustomerName.DataPropertyName = "TenKH";
			this.colCustomerName.HeaderText = "Tên khách hàng";
			this.colCustomerName.MinimumWidth = 8;
			this.colCustomerName.Name = "colCustomerName";
			// 
			// colPhoneNumber
			// 
			this.colPhoneNumber.DataPropertyName = "SoDienThoai";
			this.colPhoneNumber.HeaderText = "Số điện thoại";
			this.colPhoneNumber.MinimumWidth = 8;
			this.colPhoneNumber.Name = "colPhoneNumber";
			// 
			// colEmail
			// 
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.HeaderText = "Email";
			this.colEmail.MinimumWidth = 8;
			this.colEmail.Name = "colEmail";
			// 
			// colAddress
			// 
			this.colAddress.DataPropertyName = "DiaChi";
			this.colAddress.HeaderText = "Địa chỉ";
			this.colAddress.MinimumWidth = 6;
			this.colAddress.Name = "colAddress";
			// 
			// grbCustomerManagement
			// 
			this.grbCustomerManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grbCustomerManagement.BackColor = System.Drawing.Color.Transparent;
			this.grbCustomerManagement.Controls.Add(this.btnUpdataCustomerInformation);
			this.grbCustomerManagement.Controls.Add(this.btnAddCustomer);
			this.grbCustomerManagement.Controls.Add(this.txtEmail);
			this.grbCustomerManagement.Controls.Add(this.txtAddress);
			this.grbCustomerManagement.Controls.Add(this.txtPhoneNumber);
			this.grbCustomerManagement.Controls.Add(this.txtCustomerName);
			this.grbCustomerManagement.Controls.Add(this.txtCustomerID);
			this.grbCustomerManagement.Controls.Add(this.label7);
			this.grbCustomerManagement.Controls.Add(this.label6);
			this.grbCustomerManagement.Controls.Add(this.label3);
			this.grbCustomerManagement.Controls.Add(this.label2);
			this.grbCustomerManagement.Controls.Add(this.label1);
			this.grbCustomerManagement.Location = new System.Drawing.Point(1030, 87);
			this.grbCustomerManagement.Name = "grbCustomerManagement";
			this.grbCustomerManagement.Size = new System.Drawing.Size(633, 792);
			this.grbCustomerManagement.TabIndex = 1;
			this.grbCustomerManagement.TabStop = false;
			this.grbCustomerManagement.Text = "Quản lý khách hàng";
			// 
			// btnUpdataCustomerInformation
			// 
			this.btnUpdataCustomerInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdataCustomerInformation.BackgroundImage")));
			this.btnUpdataCustomerInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnUpdataCustomerInformation.Location = new System.Drawing.Point(403, 623);
			this.btnUpdataCustomerInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnUpdataCustomerInformation.Name = "btnUpdataCustomerInformation";
			this.btnUpdataCustomerInformation.Size = new System.Drawing.Size(84, 94);
			this.btnUpdataCustomerInformation.TabIndex = 17;
			this.btnUpdataCustomerInformation.UseVisualStyleBackColor = true;
			this.btnUpdataCustomerInformation.Click += new System.EventHandler(this.btnUpdateCustomerInformation_Click);
			// 
			// btnAddCustomer
			// 
			this.btnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.BackgroundImage")));
			this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddCustomer.Location = new System.Drawing.Point(175, 623);
			this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAddCustomer.Name = "btnAddCustomer";
			this.btnAddCustomer.Size = new System.Drawing.Size(84, 94);
			this.btnAddCustomer.TabIndex = 16;
			this.btnAddCustomer.UseVisualStyleBackColor = true;
			this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(75, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên khách hàng";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.lblName);
			this.panel2.Controls.Add(this.btnSearch);
			this.panel2.Controls.Add(this.txtSearchCustomerName);
			this.panel2.Location = new System.Drawing.Point(1030, 13);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(627, 68);
			this.panel2.TabIndex = 5;
			// 
			// frmCustomerManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1689, 903);
			this.Controls.Add(this.panel1);
			this.Name = "frmCustomerManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý khách hàng";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerManagement_FormClosing);
			this.Load += new System.EventHandler(this.frmCustomerManagement_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.grbCustomerManagement.ResumeLayout(false);
			this.grbCustomerManagement.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.GroupBox grbCustomerManagement;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
		private System.Windows.Forms.TextBox txtSearchCustomerName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnUpdataCustomerInformation;
		private System.Windows.Forms.Button btnAddCustomer;
		private System.Windows.Forms.Panel panel2;
	}
}