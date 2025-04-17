using PM_QL_BanHoa.BUS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PM_QL_BanHoa.DAO;

namespace BUS {
  public class DataProviderBUS {
    private static DataProviderBUS instance;


    public static DataProviderBUS Instance {
      get {
        if (instance == null) {
          instance = new DataProviderBUS();
        }
        return instance;
      }
    }
    public DataTable ExecuteQuery(string query, object[] parameter = null) {
      return DataProviderDAO.Instance.ExecuteQuery(query, parameter);
    }
    public int ExecuteNonQuery(string query, object[] parameter = null) {
      return DataProviderDAO.Instance.ExecuteNonQuery(query, parameter);
    }
  }
}
