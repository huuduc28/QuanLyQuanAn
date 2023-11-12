using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace QuanLyQuanAn.DTO
{
	internal class Food
	{
		public Food(int id, string name, Image image, int idFC, float price)
		{
			this.idFood = id;
			this.nameFood = name;
			this.imageFood = image;
			this.idFC = idFC;
			this.price = price;
		}
		public Image ConvertByteArrayToImage(byte[] data)
		{
			using(MemoryStream ms = new MemoryStream(data))
			{
				return Image.FromStream(ms);
			}
		}
		public Food(DataRow row)
		{
			this.idFood = (int)row["idFood"];
			this.nameFood = row["nameFood"].ToString();
			this.imageFood = ConvertByteArrayToImage((byte[])row["ImgFood"]);
			this.idFC = (int)row["idFC"];
			this.price = (float)Convert.ToDouble(row["price"].ToString());
		}
		
		private int idFood;
		private string nameFood;
		private Image imageFood;
		private int idFC;
		private float price;

		public int IdFood
		{
			get { return idFood; }
			set { idFood = value; }
		}

		public string NameFood
		{
			get { return nameFood; }
			set { nameFood = value; }
		}

		public Image ImageFood
		{
			get { return imageFood; }
			set { imageFood = value; }
		}
		


		public int IdFC
		{
			get { return idFC; }
			set { idFC = value; }
		}

		public float Price
		{
			get { return price; }
			set
			{
				price = value;
			}
		}



	}
}
