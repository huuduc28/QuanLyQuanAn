using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class FoodCategoryDAO
	{
		private static FoodCategoryDAO instance;

		public static FoodCategoryDAO Instance
		{
			get { if (instance == null) instance = new FoodCategoryDAO(); return FoodCategoryDAO.instance; }
			private set { FoodCategoryDAO.instance = value; }
		}

		private FoodCategoryDAO() { }

		public List<FoodCategory> GetListFoodCategory()
		{
			List<FoodCategory> foodCategoryList = new List<FoodCategory>();
			


			string querry = "SELECT * FROM dbo.FoodCategory";
			DataTable data = DataProvider.Instance.ExcuteQuerry(querry);

			foreach(DataRow item in data.Rows)
			{
				FoodCategory foodCategory = new FoodCategory(item);
				foodCategoryList.Add(foodCategory);

			}

			return foodCategoryList;
		}
	}
}
