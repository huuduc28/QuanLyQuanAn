using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
	internal class Menuf
	{
		public Menuf(string name, int quantity, float price, float totalPrice, string note)
		{
			this.nameFood = name;
			this.quantity = quantity;
			this.price = price;
			this.totalPrice = totalPrice;
			this.note = note;
		}

		public Menuf(DataRow row)
		{
			this.nameFood = row["NameFood"].ToString();
			this.quantity = (int)row["Quantity"];
			this.price = (float)Convert.ToDouble(row["price"].ToString());
			this.totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
			this.note = row["Note"].ToString();
		}


		private string nameFood;
		private int quantity;
		private float price;
		private float totalPrice;
		private string note;

		public string NameFood
		{
			get { return nameFood; }
			set { nameFood = value; }
		}

		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

		public float Price
		{
			get { return price; }
			set { price = value; }
		}

		public float TotalPrice
		{
			get { return totalPrice; }
			set { totalPrice = value; }
		}

		public string Note
		{
			get { return note; }
			set { note = value; }
		}

	}
}
