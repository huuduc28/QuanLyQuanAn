using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn.DTO
{
	internal class Account
	{
		public Account(string username, string displayname, string passsword, int typeAccount) 
		{
			this.userName = username;
			this.displayName = displayname;
			this.password = passsword;
			this.typeAccount = typeAccount;
		}

		public Account(DataRow row)
		{
			this.userName = row["userName"].ToString();
			this.displayName = row["displayName"].ToString();
			this.password = row["password"].ToString();
			this.typeAccount = (int)row["typeAccount"];
		}

		private string userName;
		private string displayName;
		private string password;
		private int typeAccount;

		public string UserName
		{
			get { return userName; }
			set { userName = value; }
		}

		public string DisplayName
		{
			get { return displayName; }
			set { displayName = value; }
		}

		public string Password
		{
			get { return password; }
			set
			{
				password = value;
			}
		}

		public int TypeAccount
		{
			get { return typeAccount; }
			set { typeAccount = value; }
		}
	}
}
