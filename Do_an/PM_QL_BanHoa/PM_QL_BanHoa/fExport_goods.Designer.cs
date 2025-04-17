namespace PM_QL_BanHoa {
  partial class fExport_goods {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fExport_goods));
      this.cbMaSP = new System.Windows.Forms.ComboBox();
      this.dgvExport_goods_goods = new System.Windows.Forms.DataGridView();
      this.colMaHDXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colNgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnAdd = new System.Windows.Forms.Button();
      this.dateNgayXuat = new System.Windows.Forms.DateTimePicker();
      this.txtSoLuong = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvExport_goods_goods)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // cbMaSP
      // 
      this.cbMaSP.FormattingEnabled = true;
      this.cbMaSP.Location = new System.Drawing.Point(152, 70);
      this.cbMaSP.Name = "cbMaSP";
      this.cbMaSP.Size = new System.Drawing.Size(229, 33);
      this.cbMaSP.TabIndex = 43;
      // 
      // dgvExport_goods_goods
      // 
      this.dgvExport_goods_goods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvExport_goods_goods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvExport_goods_goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvExport_goods_goods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHDXuat,
            this.colMaSP,
            this.colNgayXuat,
            this.colSoLuong,
            this.colThanhTien});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvExport_goods_goods.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgvExport_goods_goods.Location = new System.Drawing.Point(26, 46);
      this.dgvExport_goods_goods.Name = "dgvExport_goods_goods";
      this.dgvExport_goods_goods.RowHeadersWidth = 51;
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
      this.dgvExport_goods_goods.RowsDefaultCellStyle = dataGridViewCellStyle3;
      this.dgvExport_goods_goods.RowTemplate.Height = 24;
      this.dgvExport_goods_goods.Size = new System.Drawing.Size(786, 657);
      this.dgvExport_goods_goods.TabIndex = 0;
      // 
      // colMaHDXuat
      // 
      this.colMaHDXuat.DataPropertyName = "MaHDXuat";
      this.colMaHDXuat.HeaderText = "MaHDXuat";
      this.colMaHDXuat.MinimumWidth = 6;
      this.colMaHDXuat.Name = "colMaHDXuat";
      // 
      // colMaSP
      // 
      this.colMaSP.DataPropertyName = "MaSP";
      this.colMaSP.HeaderText = "MaSP";
      this.colMaSP.MinimumWidth = 6;
      this.colMaSP.Name = "colMaSP";
      // 
      // colNgayXuat
      // 
      this.colNgayXuat.DataPropertyName = "NgayXuat";
      dataGridViewCellStyle1.Format = "dd/MM/yyyy";
      dataGridViewCellStyle1.NullValue = null;
      this.colNgayXuat.DefaultCellStyle = dataGridViewCellStyle1;
      this.colNgayXuat.HeaderText = "NgayXuat";
      this.colNgayXuat.MinimumWidth = 100;
      this.colNgayXuat.Name = "colNgayXuat";
      // 
      // colSoLuong
      // 
      this.colSoLuong.DataPropertyName = "SoLuong";
      this.colSoLuong.HeaderText = "SoLuong";
      this.colSoLuong.MinimumWidth = 6;
      this.colSoLuong.Name = "colSoLuong";
      // 
      // colThanhTien
      // 
      this.colThanhTien.DataPropertyName = "ThanhTien";
      this.colThanhTien.HeaderText = "ThanhTien";
      this.colThanhTien.MinimumWidth = 6;
      this.colThanhTien.Name = "colThanhTien";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
      this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1247, 738);
      this.tableLayoutPanel1.TabIndex = 3;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.BackColor = System.Drawing.Color.Transparent;
      this.groupBox1.Controls.Add(this.dgvExport_goods_goods);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(841, 732);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Quản Lý Xuất Hàng";
      // 
      // groupBox2
      // 
      this.groupBox2.BackColor = System.Drawing.Color.Transparent;
      this.groupBox2.Controls.Add(this.cbMaSP);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.btnAdd);
      this.groupBox2.Controls.Add(this.dateNgayXuat);
      this.groupBox2.Controls.Add(this.txtSoLuong);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.ForeColor = System.Drawing.Color.Indigo;
      this.groupBox2.Location = new System.Drawing.Point(850, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(394, 732);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Xử Lý";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(14, 253);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(112, 25);
      this.label5.TabIndex = 38;
      this.label5.Text = "Số Lượng:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 73);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(78, 25);
      this.label4.TabIndex = 36;
      this.label4.Text = "MaSP:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 162);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(114, 25);
      this.label2.TabIndex = 35;
      this.label2.Text = "NgayXuat:";
      // 
      // btnAdd
      // 
      this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
      this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
      this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnAdd.ForeColor = System.Drawing.Color.Black;
      this.btnAdd.Location = new System.Drawing.Point(134, 590);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(161, 100);
      this.btnAdd.TabIndex = 32;
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // dateNgayXuat
      // 
      this.dateNgayXuat.CustomFormat = "dd/MM/yyyy";
      this.dateNgayXuat.Enabled = false;
      this.dateNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateNgayXuat.Location = new System.Drawing.Point(152, 157);
      this.dateNgayXuat.Name = "dateNgayXuat";
      this.dateNgayXuat.Size = new System.Drawing.Size(229, 30);
      this.dateNgayXuat.TabIndex = 42;
      // 
      // txtSoLuong
      // 
      this.txtSoLuong.Location = new System.Drawing.Point(152, 250);
      this.txtSoLuong.Name = "txtSoLuong";
      this.txtSoLuong.Size = new System.Drawing.Size(229, 30);
      this.txtSoLuong.TabIndex = 39;
      // 
      // fExport_goods
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1247, 738);
      this.Controls.Add(this.tableLayoutPanel1);
      this.DoubleBuffered = true;
      this.Name = "fExport_goods";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "fExport_goods";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.fExport_goods_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvExport_goods_goods)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cbMaSP;
    private System.Windows.Forms.DataGridView dgvExport_goods_goods;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.DateTimePicker dateNgayXuat;
    private System.Windows.Forms.TextBox txtSoLuong;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaHDXuat;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
    private System.Windows.Forms.DataGridViewTextBoxColumn colNgayXuat;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
  }
}