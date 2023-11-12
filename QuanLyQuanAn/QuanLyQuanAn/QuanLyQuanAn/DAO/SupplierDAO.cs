using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class SupplierDAO
	{
		private static SupplierDAO instance;

		public static SupplierDAO Instance
		{
			get { if (instance == null) instance = new SupplierDAO(); return SupplierDAO.instance; }
			private set { SupplierDAO.instance = value; }
		}

		private SupplierDAO() { }

		public DataTable GetTableListSupplier()
		{
			return DataProvider.Instance.ExcuteQuerry("SELECT IdSupplier AS N'Mã NCC', NameSupplier AS N'Tên Nhà Cung Cấp', PhoneNumber AS N'Số điện thoại' FROM Supplier");
		}

		public List<Supplier> GetListSupplier()
		{
			List<Supplier> supplierList = new List<Supplier>();

			string querry = "SELECT * FROM dbo.Supplier";
			DataTable data = DataProvider.Instance.ExcuteQuerry(querry);

			foreach (DataRow item in data.Rows)
			{
				Supplier supplier = new Supplier(item);
				supplierList.Add(supplier);

			}

			return supplierList;
		}

		public int CheckPhoneNumberSupplierExist(string phoneNumber)
		{
			string querry = "SELECT COUNT(*) FROM dbo.Supplier WHERE PhoneNumber = '" + phoneNumber + "'";
			return (int)DataProvider.Instance.ExcuteScalar(querry);
		}

		public void InsertSupplier(string phoneNumber, string name)
		{
			string querry = "INSERT INTO dbo.supplier(NameSupplier, PhoneNumber) VALUES(N'" + name + "', '" + phoneNumber + "')";
			DataProvider.Instance.ExcuteQuerry(querry);
		}

		public void DeleteSupplier(int id)
		{
			string querry = "DELETE FROM dbo.Supplier WHERE IdSupplier = " + id;
			DataProvider.Instance.ExcuteQuerry(querry);
		}

		public void EditSupplier(int id, string newPhoneNumber, string newName)
		{
			string querry = "Update dbo.Supplier SET PhoneNumber = '" + newPhoneNumber + "', NameSupplier = N'" + newName + "' WHERE IdSupplier = " + id;
			DataProvider.Instance.ExcuteQuerry(querry);
		}
	}
}
