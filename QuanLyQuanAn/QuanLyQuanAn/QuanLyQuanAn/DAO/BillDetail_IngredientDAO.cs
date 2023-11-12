using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class BillDetail_IngredientDAO
	{
		private static BillDetail_IngredientDAO instance;

		public static BillDetail_IngredientDAO Instance
		{
			get { if (instance == null) instance = new BillDetail_IngredientDAO(); return BillDetail_IngredientDAO.instance; }
			private set { BillDetail_IngredientDAO.instance = value; }
		}

		private BillDetail_IngredientDAO() { }


		public List<BillDetail_Ingredient> GetListBillDetail_Ingredient(int idB_I)
		{
			List<BillDetail_Ingredient> billDetailList = new List<BillDetail_Ingredient>();
			DataTable data = DataProvider.Instance.ExcuteQuerry("EXEC USP_GetListBillDetail_IngredientByIdB_I @IdB_I", new object[] { idB_I});

			foreach (DataRow item in data.Rows)
			{
				BillDetail_Ingredient detail = new BillDetail_Ingredient(item);
				billDetailList.Add(detail);
			}

			return billDetailList;
		}


		public void InsertBillDetail_Ingredient(int idBill, int idIngredient,int idSupplier, int quantity)
		{
			DataProvider.Instance.ExcuteNonQuerry("EXEC USP_InsertBillDetail_Ingredient @IdB_I , @IdIngredient , @IdSupplier , @Quantity", new object[] { idBill, idIngredient, idSupplier, quantity });
		}

		public void UpdateBillDetail_Ingredient(int idB_I)
		{
			DataProvider.Instance.ExcuteNonQuerry("UPDATE dbo.BillDetail_Ingredient SET StatusBill = 1 WHERE IdB_I = " + idB_I);
		}


	}
}

