using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using PM_QL_BanHoa.DAO;

namespace BUS {
	public class EmployeeBUS {
		private static EmployeeBUS instance;
		public static EmployeeBUS Instance {
			get {
				if (instance == null) {
					instance = new EmployeeBUS();
				}
				return instance;
			}
		}

		private EmployeeBUS() { }

		public EmployeeDTO GetEmployeeByUsername(string username) {
			return EmployeeDAO.Instance.GetByUsername(username);
		}
	}
}
