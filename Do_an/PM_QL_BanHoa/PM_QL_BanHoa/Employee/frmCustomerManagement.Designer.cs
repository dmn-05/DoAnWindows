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
      this.btnUpdateCustomerInformation = new System.Windows.Forms.Button();
      this.btnAddCustomer = new System.Windows.Forms.Button();
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
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.grbCustomerManagement = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.grbCustomerManagement.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnUpdateCustomerInformation
      // 
      this.btnUpdateCustomerInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomerInformation.BackgroundImage")));
      this.btnUpdateCustomerInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnUpdateCustomerInformation.Location = new System.Drawing.Point(347, 522);
      this.btnUpdateCustomerInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnUpdateCustomerInformation.Name = "btnUpdateCustomerInformation";
      this.btnUpdateCustomerInformation.Size = new System.Drawing.Size(100, 92);
      this.btnUpdateCustomerInformation.TabIndex = 15;
      this.btnUpdateCustomerInformation.UseVisualStyleBackColor = true;
      this.btnUpdateCustomerInformation.Click += new System.EventHandler(this.btnUpdateCustomerInformation_Click);
      // 
      // btnAddCustomer
      // 
      this.btnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.BackgroundImage")));
      this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnAddCustomer.Location = new System.Drawing.Point(109, 522);
      this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnAddCustomer.Name = "btnAddCustomer";
      this.btnAddCustomer.Size = new System.Drawing.Size(100, 92);
      this.btnAddCustomer.TabIndex = 14;
      this.btnAddCustomer.UseVisualStyleBackColor = true;
      this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(251, 289);
      this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(249, 22);
      this.txtEmail.TabIndex = 12;
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(251, 354);
      this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtAddress.Multiline = true;
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(249, 100);
      this.txtAddress.TabIndex = 11;
      // 
      // txtPhoneNumber
      // 
      this.txtPhoneNumber.Location = new System.Drawing.Point(251, 217);
      this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtPhoneNumber.Name = "txtPhoneNumber";
      this.txtPhoneNumber.Size = new System.Drawing.Size(249, 22);
      this.txtPhoneNumber.TabIndex = 9;
      // 
      // txtCustomerName
      // 
      this.txtCustomerName.Location = new System.Drawing.Point(251, 154);
      this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtCustomerName.Name = "txtCustomerName";
      this.txtCustomerName.Size = new System.Drawing.Size(249, 22);
      this.txtCustomerName.TabIndex = 8;
      // 
      // txtCustomerID
      // 
      this.txtCustomerID.Location = new System.Drawing.Point(251, 90);
      this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtCustomerID.Name = "txtCustomerID";
      this.txtCustomerID.ReadOnly = true;
      this.txtCustomerID.Size = new System.Drawing.Size(249, 22);
      this.txtCustomerID.TabIndex = 7;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(67, 286);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(60, 25);
      this.label7.TabIndex = 6;
      this.label7.Text = "Email";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(67, 396);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(71, 25);
      this.label6.TabIndex = 5;
      this.label6.Text = "Địa chỉ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(67, 213);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(126, 25);
      this.label3.TabIndex = 2;
      this.label3.Text = "Số điện thoại";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(67, 90);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(147, 25);
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
      this.panel1.Controls.Add(this.dataGridView);
      this.panel1.Controls.Add(this.grbCustomerManagement);
      this.panel1.Location = new System.Drawing.Point(11, 10);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1481, 703);
      this.panel1.TabIndex = 1;
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
      this.dataGridView.Location = new System.Drawing.Point(3, 5);
      this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowHeadersWidth = 62;
      this.dataGridView.RowTemplate.Height = 28;
      this.dataGridView.Size = new System.Drawing.Size(907, 698);
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
      this.grbCustomerManagement.Controls.Add(this.btnUpdateCustomerInformation);
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
      this.grbCustomerManagement.Location = new System.Drawing.Point(916, 6);
      this.grbCustomerManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grbCustomerManagement.Name = "grbCustomerManagement";
      this.grbCustomerManagement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grbCustomerManagement.Size = new System.Drawing.Size(563, 697);
      this.grbCustomerManagement.TabIndex = 1;
      this.grbCustomerManagement.TabStop = false;
      this.grbCustomerManagement.Text = "Quản lý khách hàng";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(67, 150);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(154, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "Tên khách hàng";
      // 
      // frmCustomerManagement
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1501, 722);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "frmCustomerManagement";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Quản lý khách hàng";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerManagement_FormClosing);
      this.Load += new System.EventHandler(this.frmCustomerManagement_Load);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.grbCustomerManagement.ResumeLayout(false);
      this.grbCustomerManagement.PerformLayout();
      this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnUpdateCustomerInformation;
		private System.Windows.Forms.Button btnAddCustomer;
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
	}
}