using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM_QL_BanHoa.DAO;
namespace PM_QL_BanHoa.DAO {
  public class AccountDAO {
    private static AccountDAO instance;
    public AccountDAO() { }

    public static AccountDAO Instance {
      get { if (instance == null) { instance = new AccountDAO(); } return AccountDAO.instance; }
      set => instance = value;
    }

    public bool Login(string username, string password) {
      string query = "EXEC dbo.USP_Login @username , @password";
      DataTable data = DataProviderDAO.Instance.ExecuteQuery(query, new object[] { username, password });
      return data.Rows.Count > 0;
    }
    public bool Login_Admin(string username, string password) {
      string query = "EXEC dbo.USP_Login_Admin @username , @password";
      DataTable data = DataProviderDAO.Instance.ExecuteQuery(query, new object[] { username, password });
      return data.Rows.Count > 0;
    }
  }
}
