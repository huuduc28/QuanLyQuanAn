using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
	internal class Supplier
	{
		public Supplier(int id, string name, string phoneNumber)
		{
			this.idSupplier = id;
			this.nameSupplier = name;
			this.phoneNumber = phoneNumber;
		}

		public Supplier(DataRow row)
		{
			this.idSupplier = (int)row["idSupplier"];
			this.nameSupplier = row["nameSupplier"].ToString();
			this.phoneNumber = row["phoneNumber"].ToString();
		}

		private int idSupplier;
		private string nameSupplier;
		private string phoneNumber;

		public int IdSupplier
		{
			get { return idSupplier; }
			set { idSupplier = value; }
		}

		public string NameSupplier
		{
			get { return this.nameSupplier; }
			set { this.nameSupplier = value; }
		}

		public string PhoneNumber
		{
			get { return this.phoneNumber; }
			set { this.phoneNumber = value; }
		}
	}
}
