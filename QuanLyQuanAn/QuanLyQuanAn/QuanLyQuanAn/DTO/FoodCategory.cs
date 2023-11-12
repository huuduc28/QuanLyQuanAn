using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class FoodCategory
	{
		public FoodCategory(int idFC, string nameFC)
		{
			this.idFC = idFC;
			this.nameFC = nameFC;
		}

		public FoodCategory(DataRow row)
		{
			this.idFC = (int)row["idFC"];
			this.nameFC = (string)row["nameFC"];
		}

		private int idFC;
		private string nameFC;

		public int IdFC
		{
			get { return idFC; }
			set { idFC = value; }
		}

		public string NameFC
		{
			get { return nameFC; }
			set { nameFC = value; }
		}
	}
}
