using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM_QL_BanHoa.DAO;
using PM_QL_BanHoa.BUS;

namespace PM_QL_BanHoa.BUS {
  public class AccountBUS {
    private static AccountBUS instance;

    public static AccountBUS Instance {
      get {
        if (instance == null) {
          instance = new AccountBUS();
        }
        return instance;
      }
    }

    public bool Login(string username, string password) {
      return AccountDAO.Instance.Login(username, password);
    }

    public bool Login_Admin(string username, string password) {
      return AccountDAO.Instance.Login_Admin(username, password);
    }
  }
}
