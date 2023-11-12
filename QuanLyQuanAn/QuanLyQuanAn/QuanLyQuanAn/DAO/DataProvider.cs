using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class DataProvider
	{
		private static DataProvider instance;

		public static DataProvider Instance
		{
			get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
			private set { DataProvider.instance = value; }
		}

		private DataProvider() {}

		private string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyQuanAn;Integrated Security=True";

		public DataTable ExcuteQuerry(string querry, object[] parameter = null)
		{
			DataTable data = new DataTable();
			using (SqlConnection conn = new SqlConnection(connStr))
			{

				conn.Open();

				SqlCommand cmd = new SqlCommand(querry, conn);

				if(parameter != null)
				{
					string[] listPara = querry.Split(' ');
					int i = 0;
					foreach(string item in listPara)
					{
						if(item.Contains('@'))
						{
							cmd.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}
				
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(data);

				conn.Close();
			}
			return data;
		}

		public int ExcuteNonQuerry(string querry, object[] parameter = null)
		{
			int data = 0;
			using (SqlConnection conn = new SqlConnection(connStr))
			{
				
				conn.Open();

				SqlCommand cmd = new SqlCommand(querry, conn);

				if (parameter != null)
				{
					string[] listPara = querry.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							cmd.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}

				data = cmd.ExecuteNonQuery();

				conn.Close();
			}
			return data;
		}


		public object ExcuteScalar(string querry, object[] parameter = null)
		{
			object data = 0;
			using (SqlConnection conn = new SqlConnection(connStr))
			{

				conn.Open();

				SqlCommand cmd = new SqlCommand(querry, conn);

				if (parameter != null)
				{
					string[] listPara = querry.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							cmd.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}

				data = cmd.ExecuteScalar();

				conn.Close();
			}
			return data;
		}
	}
}
