using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class StorageDAO
	{
		private static StorageDAO instance;

		public static StorageDAO Instance
		{
			get { if (instance == null) instance = new StorageDAO(); return StorageDAO.instance; }
			private set { StorageDAO.instance = value; }
		}
        private StorageDAO() { }
        public void DeleteStorage(string id)
        {
            string querry = "DELETE FROM dbo.Storage WHERE IdIngredient = " + id;
            DataProvider.Instance.ExcuteQuerry(querry);
        }

        public void EditStorage(string id, string newQuantity)
        {
            string querry = "Update dbo.Storage SET Quantity = '" + newQuantity + "' WHERE IdIngredient = " + id;
            DataProvider.Instance.ExcuteQuerry(querry);
        }

        public DataTable GetListIngredientOutOfStock(int quantity)
        {
            string querry = "EXEC USP_GetListIngredientOutOfStock " + quantity;
			return DataProvider.Instance.ExcuteQuerry(querry);
		}

		public DataTable GetListIngredientExpired()
		{
			string querry = "EXEC USP_GetListIngredientExpired ";
			return DataProvider.Instance.ExcuteQuerry(querry);
		}
	}
}
