namespace PM_QL_BanHoa {
  partial class fStatistics {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStatistics));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dgvStatistics = new System.Windows.Forms.DataGridView();
      this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNgayLapHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDiaChiGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtRevenue = new System.Windows.Forms.TextBox();
      this.btnAll = new System.Windows.Forms.Button();
      this.dateTo = new System.Windows.Forms.DateTimePicker();
      this.dateFrom = new System.Windows.Forms.DateTimePicker();
      this.btnFilter = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.BackColor = System.Drawing.Color.Transparent;
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.dgvStatistics);
      this.groupBox1.Controls.Add(this.txtRevenue);
      this.groupBox1.Controls.Add(this.btnAll);
      this.groupBox1.Controls.Add(this.dateTo);
      this.groupBox1.Controls.Add(this.dateFrom);
      this.groupBox1.Controls.Add(this.btnFilter);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.White;
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1223, 714);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thống Kê Doanh Thu";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(751, 91);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(126, 25);
      this.label3.TabIndex = 16;
      this.label3.Text = "Doanh Thu:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(46, 120);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(114, 25);
      this.label2.TabIndex = 15;
      this.label2.Text = "Đến Ngày:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(46, 67);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 25);
      this.label1.TabIndex = 14;
      this.label1.Text = "Từ Ngày:";
      // 
      // dgvStatistics
      // 
      this.dgvStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaKH,
            this.colMaNV,
            this.colNgayLapHoaDon,
            this.colDiaChiGiao,
            this.colThanhTien,
            this.colTrangThai});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvStatistics.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgvStatistics.Location = new System.Drawing.Point(51, 187);
      this.dgvStatistics.Name = "dgvStatistics";
      this.dgvStatistics.RowHeadersWidth = 51;
      this.dgvStatistics.RowTemplate.Height = 24;
      this.dgvStatistics.Size = new System.Drawing.Size(1124, 499);
      this.dgvStatistics.TabIndex = 13;
      // 
      // colMaHD
      // 
      this.colMaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colMaHD.DataPropertyName = "MaHD";
      this.colMaHD.FillWeight = 224.5989F;
      this.colMaHD.HeaderText = "MaHD";
      this.colMaHD.MinimumWidth = 6;
      this.colMaHD.Name = "colMaHD";
      this.colMaHD.Width = 125;
      // 
      // colMaKH
      // 
      this.colMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colMaKH.DataPropertyName = "MaKH";
      this.colMaKH.FillWeight = 224.5989F;
      this.colMaKH.HeaderText = "MaKH";
      this.colMaKH.MinimumWidth = 6;
      this.colMaKH.Name = "colMaKH";
      this.colMaKH.Width = 125;
      // 
      // colMaNV
      // 
      this.colMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colMaNV.DataPropertyName = "MaNV";
      this.colMaNV.FillWeight = 160.9626F;
      this.colMaNV.HeaderText = "MaNV";
      this.colMaNV.MinimumWidth = 6;
      this.colMaNV.Name = "colMaNV";
      this.colMaNV.Width = 125;
      // 
      // colNgayLapHoaDon
      // 
      this.colNgayLapHoaDon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colNgayLapHoaDon.DataPropertyName = "NgayLapHoaDon";
      dataGridViewCellStyle1.Format = "dd/MM/yyyy";
      dataGridViewCellStyle1.NullValue = null;
      this.colNgayLapHoaDon.DefaultCellStyle = dataGridViewCellStyle1;
      this.colNgayLapHoaDon.FillWeight = 22.45989F;
      this.colNgayLapHoaDon.HeaderText = "NgayLapHoaDon";
      this.colNgayLapHoaDon.MinimumWidth = 100;
      this.colNgayLapHoaDon.Name = "colNgayLapHoaDon";
      this.colNgayLapHoaDon.Width = 200;
      // 
      // colDiaChiGiao
      // 
      this.colDiaChiGiao.DataPropertyName = "DiaChiGiao";
      this.colDiaChiGiao.FillWeight = 22.45989F;
      this.colDiaChiGiao.HeaderText = "DiaChiGiao";
      this.colDiaChiGiao.MinimumWidth = 100;
      this.colDiaChiGiao.Name = "colDiaChiGiao";
      // 
      // colThanhTien
      // 
      this.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colThanhTien.DataPropertyName = "ThanhTien";
      this.colThanhTien.FillWeight = 22.45989F;
      this.colThanhTien.HeaderText = "ThanhTien";
      this.colThanhTien.MinimumWidth = 6;
      this.colThanhTien.Name = "colThanhTien";
      this.colThanhTien.Width = 150;
      // 
      // colTrangThai
      // 
      this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colTrangThai.DataPropertyName = "TrangThai";
      this.colTrangThai.FillWeight = 22.45989F;
      this.colTrangThai.HeaderText = "TrangThai";
      this.colTrangThai.MinimumWidth = 6;
      this.colTrangThai.Name = "colTrangThai";
      this.colTrangThai.Width = 150;
      // 
      // txtRevenue
      // 
      this.txtRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRevenue.Location = new System.Drawing.Point(917, 82);
      this.txtRevenue.Multiline = true;
      this.txtRevenue.Name = "txtRevenue";
      this.txtRevenue.ReadOnly = true;
      this.txtRevenue.Size = new System.Drawing.Size(258, 43);
      this.txtRevenue.TabIndex = 12;
      this.txtRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnAll
      // 
      this.btnAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAll.BackgroundImage")));
      this.btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAll.Location = new System.Drawing.Point(606, 54);
      this.btnAll.Name = "btnAll";
      this.btnAll.Size = new System.Drawing.Size(100, 100);
      this.btnAll.TabIndex = 10;
      this.btnAll.UseVisualStyleBackColor = true;
      this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
      // 
      // dateTo
      // 
      this.dateTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateTo.CustomFormat = "dd/MM/yyyy";
      this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateTo.Location = new System.Drawing.Point(179, 115);
      this.dateTo.Name = "dateTo";
      this.dateTo.Size = new System.Drawing.Size(238, 30);
      this.dateTo.TabIndex = 9;
      // 
      // dateFrom
      // 
      this.dateFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateFrom.CustomFormat = "dd/MM/yyyy";
      this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateFrom.Location = new System.Drawing.Point(179, 62);
      this.dateFrom.Name = "dateFrom";
      this.dateFrom.Size = new System.Drawing.Size(238, 30);
      this.dateFrom.TabIndex = 7;
      this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
      // 
      // btnFilter
      // 
      this.btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.BackgroundImage")));
      this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFilter.Location = new System.Drawing.Point(449, 54);
      this.btnFilter.Name = "btnFilter";
      this.btnFilter.Size = new System.Drawing.Size(100, 100);
      this.btnFilter.TabIndex = 5;
      this.btnFilter.UseVisualStyleBackColor = true;
      this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
      // 
      // fStatistics
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1247, 738);
      this.Controls.Add(this.groupBox1);
      this.DoubleBuffered = true;
      this.Name = "fStatistics";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "fStatistics";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.fStatistics_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DateTimePicker dateFrom;
    private System.Windows.Forms.DateTimePicker dateTo;
    private System.Windows.Forms.Button btnAll;
    private System.Windows.Forms.Button btnFilter;
    private System.Windows.Forms.TextBox txtRevenue;
    private System.Windows.Forms.DataGridView dgvStatistics;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLapHoaDon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiGiao;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
  }
}