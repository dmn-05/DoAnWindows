using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QL_BanHoa {
  public partial class fStatistics : Form {
    DataSet dsDoanhThu = new DataSet();
    DataSet dsHoaDon = new DataSet();
    public fStatistics() {
      InitializeComponent();
    }

    private void btnFilter_Click(object sender, EventArgs e) {
      DateTime datefrom = dateFrom.Value.Date;
      DateTime dateto = dateTo.Value.Date;

      string query = "SELECT SUM(ThanhTien) as revenue FROM HoaDon WHERE NgayLapHoaDon >= @datefrom AND NgayLapHoaDon <= @dateto";
      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query, new object[] { datefrom, dateto });
      
      
      if (dsDoanhThu.Tables.Contains("DoanhThu")) {
        dsDoanhThu.Tables["DoanhThu"].Clear();
        dsDoanhThu.Tables["DoanhThu"].Merge(data);
      } else {
        data.TableName = "DoanhThu";
        dsDoanhThu.Tables.Add(data);
      }

      if (dsDoanhThu.Tables["DoanhThu"].Rows.Count > 0) {
        object doanhThu = dsDoanhThu.Tables["DoanhThu"].Rows[0]["revenue"];
        txtRevenue.Text = doanhThu == DBNull.Value ? "0" : doanhThu.ToString();
      } else {
        txtRevenue.Text = "0";
      }
      txtRevenue.Text += " VNĐ";
      query = "Select * From HoaDon WHERE NgayLapHoaDon >= @datefrom AND NgayLapHoaDon <= @dateto";
      LoadDSHD(query, new object[] { datefrom, dateto });
    }

    private void btnAll_Click(object sender, EventArgs e) {
      string query = "Select SUM(ThanhTien) as 'revenue' From HoaDon";
      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query);
      if (dsDoanhThu.Tables.Contains("DoanhThu")) {
        dsDoanhThu.Tables["DoanhThu"].Clear(); 
        dsDoanhThu.Tables["DoanhThu"].Merge(data);
      } else {
        data.TableName = "DoanhThu"; 
        dsDoanhThu.Tables.Add(data);
      }

      if (dsDoanhThu.Tables["DoanhThu"].Rows.Count > 0) {
        object doanhThu = dsDoanhThu.Tables["DoanhThu"].Rows[0]["revenue"];
        txtRevenue.Text = doanhThu == DBNull.Value ? "0" : doanhThu.ToString();
      } else {
        txtRevenue.Text = "0";
      }
      txtRevenue.Text += " VNĐ";

      query = "Select * From HoaDon";
      LoadDSHD(query);
    }

    private void fStatistics_Load(object sender, EventArgs e) {
      txtRevenue.Text = "0 VNĐ";
      string query = "Select * From HoaDon";
      LoadDSHD(query);
    }
    private void LoadDSHD(string query, object[] parameter = null) {
      DataTable data = DataProviderBUS.Instance.ExecuteQuery(query, parameter);
      data.TableName = "HoaDon";

      if (dsHoaDon.Tables.Contains("HoaDon")) {
        dsHoaDon.Tables["HoaDon"].Clear();
        dsHoaDon.Tables["HoaDon"].Merge(data);
      } else {
        dsHoaDon.Tables.Add(data);
      }

      dgvStatistics.DataSource = dsHoaDon.Tables["HoaDon"];
    }

    private void dateFrom_ValueChanged(object sender, EventArgs e) {
      dateTo.MinDate = dateFrom.Value;
    }
  }
}
