using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class Bill_IngredientDAO
	{
		private static Bill_IngredientDAO instance;

		public static Bill_IngredientDAO Instance
		{
			get { if (instance == null) instance = new Bill_IngredientDAO(); return Bill_IngredientDAO.instance; }
			private set { Bill_IngredientDAO.instance = value; }
		}

		private Bill_IngredientDAO() { }

		public int GetStatusBill(int idB_I)
		{
			DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT * FROM dbo.BILL_Ingredient WHERE IdB_I = " + idB_I);

			if (data.Rows.Count > 0)
			{
				Bill_Ingredient bill = new Bill_Ingredient(data.Rows[0]);

				// trả về id bill
				return bill.StatusBill;
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

		public void CheckOut(int idBill, int discount, float totalPrice)
		{
			string querry = "UPDATE dbo.Bill SET DateOut = GETDATE(), StatusBill = 1, TotalPrice = " + totalPrice + ", Discount = " + discount + " WHERE IdBill = " + idBill;
			DataProvider.Instance.ExcuteNonQuerry(querry);
		}

		public void InsertBill_Ingredient()
		{
			DataProvider.Instance.ExcuteNonQuerry("EXEC USP_InsertBill_Ingredient");
		}

		public int GetMaxIdB_I()
		{
			try
			{
				return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(IdB_I) FROM dbo.BILL_Ingredient");
			}
			catch
			{
				return -1;
			}
		}

		public int GetMaxIdB_IChecked()
		{
			try
			{
				return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(IdB_I) FROM dbo.BILL_Ingredient WHERE StatusBill = 0");
			}
			catch
			{
				return -1;
			}
		}

		public void UpdateBill_Ingredient(int idB_I, float totalPrice)
		{
			DataProvider.Instance.ExcuteNonQuerry("UPDATE dbo.Bill_Ingredient SET StatusBill = 1, TotalPrice = " + totalPrice + " WHERE IdB_I = " + idB_I);
		}


	}
}


