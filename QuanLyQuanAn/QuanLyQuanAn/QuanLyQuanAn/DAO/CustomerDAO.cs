using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class CustomerDAO
	{
		private static CustomerDAO instance;

		public static CustomerDAO Instance
		{
			get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
			private set { CustomerDAO.instance = value; }
		}

		private CustomerDAO() { }	

		public void PlusPointToCustomer(string phoneNumber, float totalPrice)
		{
			int point = (int)(totalPrice * 0.00003f);
			string querry = "UPDATE dbo.Customer SET Point = Point + " + point + " WHERE PhoneNumber = '" + phoneNumber + "'";
			DataProvider.Instance.ExcuteNonQuerry(querry);
		}

		public int CheckCustomerExist(string phoneNumber)
		{
			string querry = "SELECT COUNT(*) FROM dbo.Customer WHERE PhoneNumber = '" + phoneNumber + "'";
			return (int)DataProvider.Instance.ExcuteScalar(querry);
		}

		public void InsertCustomer(string phoneNumber, string name, int point)
		{
			string querry = "INSERT INTO dbo.Customer VALUES('" + phoneNumber + "', N'" + name + "', " + point + ")";
			DataProvider.Instance.ExcuteQuerry(querry);
		}

		public void DeleteCustomer(string phoneNumber)
		{
			string querry = "DELETE FROM dbo.Customer WHERE PhoneNumber = '" + phoneNumber + "'";
			DataProvider.Instance.ExcuteQuerry(querry);
		}

		public void EditCustomer(string phoneNumber, string newPhoneNumber, string newName)
		{
			string querry = "Update dbo.Customer SET PhoneNumber = '" + newPhoneNumber + "', NameCustomer = N'" + newName + "' WHERE PhoneNumber = '" + phoneNumber + "'"; ;
			DataProvider.Instance.ExcuteQuerry(querry);
		}

		public string GetNameCustomerByPhoneNumber(string phoneNumber)
		{

			DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT * FROM dbo.Customer WHERE phoneNumber = '" + phoneNumber + "'");

			if (data.Rows.Count > 0)
			{
				Customer customer = new Customer(data.Rows[0]);

				return customer.NameCustomer.ToString();
			}

			return "ERROR";
		}

	}
}
