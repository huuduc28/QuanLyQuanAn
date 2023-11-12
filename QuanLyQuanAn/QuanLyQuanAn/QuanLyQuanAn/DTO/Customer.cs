using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
	internal class Customer
	{
		public Customer(string phoneNumber, string nameCustomer)
		{
			this.phoneNumber = phoneNumber;
			this.nameCustomer = nameCustomer;

		}

		public Customer(DataRow row)
		{
			this.phoneNumber = row["phoneNumber"].ToString();
			this.nameCustomer = row["nameCustomer"].ToString();

		}

		private string phoneNumber;
		private string nameCustomer;

		public string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}

		public string NameCustomer
		{
			get { return nameCustomer; }
			set { nameCustomer = value; }
		}

	}
}
