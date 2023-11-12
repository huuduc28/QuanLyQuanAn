using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class AccountDAO
	{
		private static AccountDAO instance;

		public static AccountDAO Instance
		{
			get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
			private set { AccountDAO.instance = value; }
		}

		private AccountDAO() { }

		public bool Login(string username, string password)
		{
			string querry = "SELECT * FROM dbo.Account WHERE UserName = '" + username + "' AND Password = '" + password +"'";

			DataTable result = DataProvider.Instance.ExcuteQuerry(querry);

			return result.Rows.Count > 0;
		}


		public void InsertAccount(string userName, string displayName, string password, string typeAccount)
		{
			string querry = "INSERT INTO dbo.Account VALUES ('" + userName + "', N'" + displayName + "', '" + password + "', N'" + typeAccount +"')" ;

			DataProvider.Instance.ExcuteNonQuerry(querry);
		}

		public void DeleteAccount(string userName)
		{
			string querry = "DELETE FROM dbo.Account WHERE UserName = '" + userName + "'";
			DataProvider.Instance.ExcuteNonQuerry(querry);
		}

		public void EditAccount(string userName, string displayName, string typeAccount)
		{
			string querry = "UPDATE dbo.Account SET TypeAccount = N'" + typeAccount + "', displayName = N'" + displayName + "' WHERE UserName = '" + userName + "'";
			DataProvider.Instance.ExcuteNonQuerry(querry);
		}

		public bool CheckAdmin(string username)
		{
			string querry = "SELECT * FROM dbo.Account WHERE UserName = '" + username + "' AND TypeAccount = N'Quản lí'";

			DataTable result = DataProvider.Instance.ExcuteQuerry(querry);

			return result.Rows.Count > 0;
		}

	}
}
