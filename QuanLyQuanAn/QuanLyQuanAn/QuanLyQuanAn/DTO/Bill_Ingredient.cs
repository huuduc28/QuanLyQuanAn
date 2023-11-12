using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
	internal class Bill_Ingredient
	{
		public Bill_Ingredient(int id, DateTime? dateIn, int status, float totalPrice)
		{
			this.idB_I = id;
			this.dateIn = dateIn;
			this.status = status;
			this.totalPrice = totalPrice;
		}

		public Bill_Ingredient(DataRow row)
		{
			this.idB_I = (int)row["idB_I"];

			var dateOutTemp = row["dateIn"];
			if (dateOutTemp.ToString() != "")
			{
				this.dateIn = (DateTime)row["dateIn"];
			}
			this.status = (int)row["statusBill"];
			this.totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
		}


		private int idB_I;
		private DateTime? dateIn;
		private int status;
		private float totalPrice;


		public int IdB_I
		{
			get { return idB_I; }
			set { idB_I = value; }
		}

		public DateTime? DateIn
		{
			get { return dateIn; }
			set { dateIn = value; }
		}

		public int StatusBill
		{
			get { return status; }
			set { status = value; }

		}

		public float TotalPrice
		{
			get { return totalPrice; }
			set { totalPrice = value; }
		}
	}
}
