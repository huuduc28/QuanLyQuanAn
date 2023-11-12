using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
	internal class BillDetail
	{
		public BillDetail(int idBill, int idFood, int quantity)
		{
			this.idBill = idBill;
			this.idFood = idFood;
			this.quantity = quantity;
		}

		public BillDetail(DataRow row)
		{
			this.idBill = (int)row["idBill"];
			this.idFood = (int)row["idFood"];
			this.quantity = (int)row["quantity"];
		}

		private int idBill;
		private int idFood;
		private int quantity;

		public int IdBill
		{
			get { return idBill; }
			set { idBill = value; }
		}

		public int IdFood
		{
			get { return idFood; }
			set { idFood = value; }
		}

		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}
	}
}
