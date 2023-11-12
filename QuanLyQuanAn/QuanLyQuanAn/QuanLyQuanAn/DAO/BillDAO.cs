using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class BillDAO
	{
		private static BillDAO instance;

		public static BillDAO Instance
		{
			get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
			private set { BillDAO.instance = value; }
		}

		private BillDAO() { }

		public int GetUncheckIdBillByIdTable(int idTable)
		{
			DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT * FROM dbo.Bill WHERE IdTable = " + idTable + " AND StatusBill = 0");

			if(data.Rows.Count > 0)
			{
				Bill bill = new Bill(data.Rows[0]);

				// trả về id bill
				return bill.IdBill;
			}
			
			return -1;
		}

		public string GetDateByIdBill(int idBill)
		{
			DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT * FROM dbo.Bill WHERE IdBill = " + idBill + "");

			if (data.Rows.Count > 0)
			{
				Bill bill = new Bill(data.Rows[0]);

				// trả về id bill
				return bill.DateOut.ToString();
			}

			return "ERROR";
		}

		public void CheckOut(int idBill ,int discount, float totalPrice)
		{
			string querry = "UPDATE dbo.Bill SET DateOut = GETDATE(), StatusBill = 1, TotalPrice = " + totalPrice + ", Discount = " + discount + " WHERE IdBill = " + idBill;
			DataProvider.Instance.ExcuteNonQuerry(querry);
		}

		public void InsertBill(int idTable)
		{   
			DataProvider.Instance.ExcuteNonQuerry("EXEC USP_InsertBill @IdTable", new object[] {idTable});

		}

		public int GetMaxIdBill()
		{
			try
			{
				return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(IdBill) FROM dbo.Bill");
			}
			catch
			{
				return -1;
			}
		}

		public DataTable GetBillListByDate(DateTime dateIn, DateTime dateOut)
		{
			return DataProvider.Instance.ExcuteQuerry("EXEC USP_GetListBillByDate @DateIn , @DateOut", new object[] { dateIn, dateOut });


		}

	}
}


