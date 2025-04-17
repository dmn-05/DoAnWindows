namespace PM_QL_BanHoa {
  partial class fSales {
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSales));
      this.ptbBillManagement = new System.Windows.Forms.PictureBox();
      this.ptbCustomerManagement = new System.Windows.Forms.PictureBox();
      this.ptbProductManagement = new System.Windows.Forms.PictureBox();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.ptbBillManagement)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ptbCustomerManagement)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ptbProductManagement)).BeginInit();
      this.SuspendLayout();
      // 
      // ptbBillManagement
      // 
      this.ptbBillManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbBillManagement.BackgroundImage")));
      this.ptbBillManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ptbBillManagement.Location = new System.Drawing.Point(101, 141);
      this.ptbBillManagement.Name = "ptbBillManagement";
      this.ptbBillManagement.Size = new System.Drawing.Size(150, 150);
      this.ptbBillManagement.TabIndex = 0;
      this.ptbBillManagement.TabStop = false;
      this.ptbBillManagement.Click += new System.EventHandler(this.ptbBillManagement_Click);
      // 
      // ptbCustomerManagement
      // 
      this.ptbCustomerManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbCustomerManagement.BackgroundImage")));
      this.ptbCustomerManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ptbCustomerManagement.Location = new System.Drawing.Point(329, 141);
      this.ptbCustomerManagement.Name = "ptbCustomerManagement";
      this.ptbCustomerManagement.Size = new System.Drawing.Size(150, 150);
      this.ptbCustomerManagement.TabIndex = 1;
      this.ptbCustomerManagement.TabStop = false;
      this.ptbCustomerManagement.Click += new System.EventHandler(this.ptbCustomerManagement_Click);
      // 
      // ptbProductManagement
      // 
      this.ptbProductManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbProductManagement.BackgroundImage")));
      this.ptbProductManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ptbProductManagement.Location = new System.Drawing.Point(556, 141);
      this.ptbProductManagement.Name = "ptbProductManagement";
      this.ptbProductManagement.Size = new System.Drawing.Size(150, 150);
      this.ptbProductManagement.TabIndex = 2;
      this.ptbProductManagement.TabStop = false;
      this.ptbProductManagement.Click += new System.EventHandler(this.ptbProductManagement_Click);
      // 
      // fSales
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ptbProductManagement);
      this.Controls.Add(this.ptbCustomerManagement);
      this.Controls.Add(this.ptbBillManagement);
      this.Name = "fSales";
      this.Text = "fSales";
      this.Load += new System.EventHandler(this.fSales_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ptbBillManagement)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ptbCustomerManagement)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ptbProductManagement)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox ptbBillManagement;
    private System.Windows.Forms.PictureBox ptbCustomerManagement;
    private System.Windows.Forms.PictureBox ptbProductManagement;
    private System.Windows.Forms.ToolTip toolTip;
  }
}