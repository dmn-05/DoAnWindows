using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using PM_QL_BanHoa.DAO;

namespace PM_QL_BanHoa.DAO {
	public class DataProviderDAO {
		private string ConnectionSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
		private static DataProviderDAO instance;

		public static DataProviderDAO Instance {
			get {
				if (instance == null) {
					instance = new DataProviderDAO();
				}
				return DataProviderDAO.instance;
			}

			private set => instance = value;
		}

		public DataTable ExecuteQuery(string query, object[] parameter = null) {
			DataTable data = new DataTable();

			using (SqlConnection connection = new SqlConnection(ConnectionSTR)) {
				connection.Open();
				SqlCommand sqlCommand = new SqlCommand(query, connection);

				if (parameter != null) {
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string para in listPara) {
						if (para.Contains('@')) {
							sqlCommand.Parameters.AddWithValue(para, parameter[i]);
							i++;
						}
					}
				}

				SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
				adapter.Fill(data);
			}

			return data;
		}

		// Start
		// _ExcuteNonQuery() của Quân
		public int _ExecuteNonQuery(string query, object[] parameter = null) {
			int data = 0;

			using (SqlConnection connection = new SqlConnection(ConnectionSTR)) {
				connection.Open();

				using (SqlCommand command = new SqlCommand(query, connection)) {
					if (parameter != null) {
						// Tìm tất cả các tham số @... trong query (theo thứ tự)
						string[] listPara = query.Split(new char[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
						int i = 0;

						foreach (string item in listPara) {
							if (item.StartsWith("@")) {
								command.Parameters.AddWithValue(item, parameter[i]);
								i++;
							}
						}
					}

					data = command.ExecuteNonQuery();
				}
			}

			return data;
		}
		// End

		public object _ExecuteScalar(string query, object[] parameter = null) {
			object data = null;

			using (SqlConnection connection = new SqlConnection(ConnectionSTR)) {
				connection.Open();

				using (SqlCommand command = new SqlCommand(query, connection)) {
					if (parameter != null) {
						// Tìm tất cả các tham số @... trong query (theo thứ tự)
						string[] listPara = query.Split(new char[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
						int i = 0;

						foreach (string item in listPara) {
							if (item.StartsWith("@")) {
								command.Parameters.AddWithValue(item, parameter[i]);
								i++;
							}
						}
					}

					data = command.ExecuteScalar();
				}
			}

			return data;
		}


		public int ExecuteNonQuery(string query, object[] parameter = null) {
			int data = 0;
			using (SqlConnection connection = new SqlConnection(ConnectionSTR)) {
				connection.Open();
				SqlCommand sqlCommand = new SqlCommand(query, connection);

				if (parameter != null) {
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string para in listPara) {
						if (para.Contains('@')) {
							sqlCommand.Parameters.AddWithValue(para, parameter[i]);
							i++;
						}
					}
				}

				data = sqlCommand.ExecuteNonQuery();
			}

			return data;
		}

		public object ExecuteScalar(string query, object[] parameter = null) {
			object data = 0;
			using (SqlConnection connection = new SqlConnection(ConnectionSTR)) {
				connection.Open();
				SqlCommand sqlCommand = new SqlCommand(query, connection);

				if (parameter != null) {
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string para in listPara) {
						if (para.Contains('@')) {
							sqlCommand.Parameters.AddWithValue(para, parameter[i]);
							i++;
						}
					}
				}

				data = sqlCommand.ExecuteScalar();

			}

			return data;
		}
	}
}
