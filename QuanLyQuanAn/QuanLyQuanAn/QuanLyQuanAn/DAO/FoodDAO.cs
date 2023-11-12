using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class FoodDAO
	{
		private static FoodDAO instance;

		public static FoodDAO Instance
		{
			get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
			private set { FoodDAO.instance = value; }
		}

		private FoodDAO() { }


		public List<Food> GetFoodByCategoryID(int idFC)
		{
			List<Food> foodList = new List<Food>();

			string querry = "SELECT * FROM dbo.FOOD WHERE IdFC = " + idFC;

			DataTable data = DataProvider.Instance.ExcuteQuerry(querry);

			foreach (DataRow item in data.Rows)
			{
				Food food = new Food(item);
				foodList.Add(food);

			}


			return foodList;
		}

		public List<Food> GetListFood()
		{
			List<Food> foodList = new List<Food>();

			string querry = "SELECT * FROM dbo.FOOD";

			DataTable data = DataProvider.Instance.ExcuteQuerry(querry);

			foreach (DataRow item in data.Rows)
			{
				Food food = new Food(item);
				foodList.Add(food);

			}
			return foodList;
		}
        public void InsertFood(string nameFood, int idfc, double price, Array imgfood)
        {
            DataProvider.Instance.ExcuteNonQuerry("EXEC USP_InsertFood @NameFood , @IdFC , @Price  , @ImgFood ", new object[] { nameFood, idfc, price, imgfood });
        }

        public void deleteFood(int idFood)
        {
            string querry = "DELETE FROM dbo.Food WHERE IdFood = " + idFood;
            DataProvider.Instance.ExcuteQuerry(querry);
        }
        public void EditFood(int idFood, double newPrice)
        {
            string querry = "Update dbo.Food SET Price = '" + newPrice + "' WHERE IdFood = " + idFood;
            DataProvider.Instance.ExcuteQuerry(querry);
        }
    }
}
