namespace PM_QL_BanHoa
{
    partial class fCustomer
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCustomer));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblUserName = new System.Windows.Forms.Label();
      this.btnSearch = new System.Windows.Forms.Button();
      this.txtName = new System.Windows.Forms.TextBox();
      this.dgvCustomer = new System.Windows.Forms.DataGridView();
      this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnSave = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.BackColor = System.Drawing.Color.Transparent;
      this.groupBox1.Controls.Add(this.lblUserName);
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Controls.Add(this.txtName);
      this.groupBox1.Controls.Add(this.dgvCustomer);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.White;
      this.groupBox1.Location = new System.Drawing.Point(30, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1185, 628);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Quản Lý Khách Hàng";
      // 
      // lblUserName
      // 
      this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblUserName.AutoSize = true;
      this.lblUserName.BackColor = System.Drawing.Color.Transparent;
      this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUserName.ForeColor = System.Drawing.Color.White;
      this.lblUserName.Location = new System.Drawing.Point(652, 31);
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(114, 25);
      this.lblUserName.TabIndex = 25;
      this.lblUserName.Text = "Nhập Tên:";
      // 
      // btnSearch
      // 
      this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
      this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.ForeColor = System.Drawing.Color.Blue;
      this.btnSearch.Location = new System.Drawing.Point(1105, 18);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(50, 50);
      this.btnSearch.TabIndex = 24;
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(788, 25);
      this.txtName.Multiline = true;
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(286, 39);
      this.txtName.TabIndex = 23;
      // 
      // dgvCustomer
      // 
      this.dgvCustomer.AllowUserToOrderColumns = true;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
      this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colSoDienThoai,
            this.colEmail,
            this.colDiaChi});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgvCustomer.Location = new System.Drawing.Point(24, 77);
      this.dgvCustomer.Name = "dgvCustomer";
      this.dgvCustomer.RowHeadersWidth = 51;
      this.dgvCustomer.RowTemplate.Height = 24;
      this.dgvCustomer.Size = new System.Drawing.Size(1133, 545);
      this.dgvCustomer.TabIndex = 0;
      // 
      // colMaKH
      // 
      this.colMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colMaKH.DataPropertyName = "MaKH";
      this.colMaKH.FillWeight = 128.3422F;
      this.colMaKH.HeaderText = "MaKH";
      this.colMaKH.MinimumWidth = 70;
      this.colMaKH.Name = "colMaKH";
      this.colMaKH.ReadOnly = true;
      this.colMaKH.Width = 70;
      // 
      // colTenKH
      // 
      this.colTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colTenKH.DataPropertyName = "TenKH";
      this.colTenKH.FillWeight = 518.8315F;
      this.colTenKH.HeaderText = "TenKH";
      this.colTenKH.MinimumWidth = 140;
      this.colTenKH.Name = "colTenKH";
      this.colTenKH.Width = 190;
      // 
      // colSoDienThoai
      // 
      this.colSoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colSoDienThoai.DataPropertyName = "SoDienThoai";
      this.colSoDienThoai.FillWeight = 25.47104F;
      this.colSoDienThoai.HeaderText = "SoDienThoai";
      this.colSoDienThoai.MinimumWidth = 120;
      this.colSoDienThoai.Name = "colSoDienThoai";
      this.colSoDienThoai.Width = 120;
      // 
      // colEmail
      // 
      this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.colEmail.DataPropertyName = "Email";
      this.colEmail.HeaderText = "Email";
      this.colEmail.MinimumWidth = 100;
      this.colEmail.Name = "colEmail";
      // 
      // colDiaChi
      // 
      this.colDiaChi.DataPropertyName = "DiaChi";
      this.colDiaChi.FillWeight = 25.47104F;
      this.colDiaChi.HeaderText = "DiaChi";
      this.colDiaChi.MinimumWidth = 200;
      this.colDiaChi.Name = "colDiaChi";
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
      this.btnSave.Location = new System.Drawing.Point(1117, 659);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(70, 70);
      this.btnSave.TabIndex = 26;
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // fCustomer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1247, 738);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.groupBox1);
      this.DoubleBuffered = true;
      this.Name = "fCustomer";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "fCustomer";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fCustomer_FormClosing);
      this.Load += new System.EventHandler(this.fCustomer_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
      this.ResumeLayout(false);

        }

    #endregion
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.DataGridView dgvCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    private System.Windows.Forms.Button btnSave;
  }
}