using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace PM_QL_BanHoa.DAO {
	public class EmployeeDAO {
		private static EmployeeDAO instance;
		public static EmployeeDAO Instance {
			get {
				if (instance == null) instance = new EmployeeDAO();
				return instance;
			}
		}

		private EmployeeDAO() { }

		public EmployeeDTO GetByUsername(string username) {
			string query = "SELECT * FROM NhanVien WHERE TenDangNhap = @username";
			DataTable data = DataProviderDAO.Instance.ExecuteQuery(query, new object[] { username });

			if (data.Rows.Count > 0) {
				DataRow row = data.Rows[0];
				return new EmployeeDTO {
					MaNV = (int)row["MaNV"],
					TenNV = row["TenNV"].ToString(),
					TenDangNhap = row["TenDangNhap"].ToString(),
					MatKhau = row["MatKhau"].ToString(),
					SoDienThoai = row["SoDienThoai"].ToString(),
					Email = row["Email"].ToString(),
					DiaChi = row["DiaChi"].ToString(),
					ChucVu = row["ChucVu"].ToString(),
					TrangThai = (int)row["TrangThai"]
				};
			}

			return null;
		}
	}
}
