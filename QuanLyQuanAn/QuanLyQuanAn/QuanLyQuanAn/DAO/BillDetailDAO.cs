using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class BillDetailDAO
	{
		private static BillDetailDAO instance;

		public static BillDetailDAO Instance
		{
			get { if (instance == null) instance = new BillDetailDAO(); return BillDetailDAO.instance; }
			private set { BillDetailDAO.instance = value; }
		}

		private BillDetailDAO() { }


		public List<BillDetail> GetListBillDetail(int idBill)
		{
			List<BillDetail> billDetailList = new List<BillDetail>();
			DataTable data = DataProvider.Instance.ExcuteQuerry("SELECT * FROM dbo.BillDetail WHERE IdBill = " + idBill);

			foreach (DataRow item in data.Rows)
			{
				BillDetail detail = new BillDetail(item);
				billDetailList.Add(detail);
			}

			return billDetailList;
		}


		public void InsertBillDetail(int idBill, int idFood, int quantity, string note)
		{
			DataProvider.Instance.ExcuteNonQuerry("EXEC USP_InsertBillDetail @IdBill , @IdFood , @Quantity , @Note", new object[] { idBill, idFood, quantity, note });
		}




	}
}

