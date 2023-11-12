using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
	internal class BillDetail_Ingredient
	{
		public BillDetail_Ingredient(int idBill, int idIngredient, string nameIngredient, int idSupplier, string nameSupplier, int quantity, float price, float totalPrice)
		{
			this.idB_I = idBill;
			this.idIngredient = idIngredient;
			this.nameIngredient = nameIngredient;
			this.idSupplier = idSupplier;
			this.nameSupplier = nameSupplier;
			this.quantity = quantity;
			this.price = price;
			this.totalPrice = totalPrice;
		}

		public BillDetail_Ingredient(DataRow row)
		{
			//this.idB_I = (int)row["idB_I"];
			//this.idIngredient = (int)row["idIngredient"];
			this.nameIngredient = row["nameIngredient"].ToString();
			//this.idSupplier = (int)row["idSupplier"];
			this.nameSupplier = row["nameSupplier"].ToString();
			this.quantity = (int)row["quantity"];
			this.price = (float)Convert.ToDouble(row["price"].ToString());
			this.totalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
		}

		private int idB_I;
		private int idIngredient;
		private string nameIngredient;
		private int idSupplier;
		private string nameSupplier;
		private int quantity;
		private float price;
		private float totalPrice;

		public int IdB_I
		{
			get { return idB_I; }
			set { idB_I = value; }
		}

		public int IdIngredient
		{
			get { return idIngredient; }
			set { idIngredient = value; }
		}

		public string NameIngredient
		{
			get { return nameIngredient; }
			set { nameIngredient = value; }
		}

		public int IdSupplier
		{
			get { return idSupplier; }
			set { idSupplier = value; }
		}

		public string NameSupplier
		{
			get { return nameSupplier; }
			set { nameSupplier = value; }
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

	}
}
