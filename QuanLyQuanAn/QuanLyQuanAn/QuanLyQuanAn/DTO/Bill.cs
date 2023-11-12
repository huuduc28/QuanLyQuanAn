using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
	internal class Bill
	{

		public Bill(int id, DateTime? dateIn, DateTime? dateOut, int status, float totalPrice)
		{
			this.idBill = id;
			this.dateIn = dateIn;
			this.dateOut = dateOut;
			this.statusBill = status;
			this.totalPrice = totalPrice;
		}

		public Bill(DataRow row)
		{
			this.idBill = (int)row["idBill"];
			this.dateIn = (DateTime)row["dateIn"];
			var dateOutTemp = row["dateOut"];
			if(dateOutTemp.ToString() != "")
			{
				this.dateOut = (DateTime)row["dateOut"];
			}
			this.statusBill = (int)row["statusBill"];
			this.totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
		}


		private int idBill;
		private DateTime? dateIn;
		private DateTime? dateOut;
		private int statusBill;
		private float totalPrice;


		public int IdBill
		{
			get { return idBill; }
			set { idBill = value; }
		}

		public DateTime? DateIn 
		{ 
			get { return dateIn; }
			set { dateIn = value; }
		}

		public DateTime? DateOut
		{
			get { return dateOut; }
			set { dateOut = value; }
		}

		public int StatusBill
		{
			get { return statusBill; }
			set { statusBill = value; }
		}

		public float TotalPrice
		{
			get { return totalPrice; }
			set { totalPrice = value; }
		}

	}
}
