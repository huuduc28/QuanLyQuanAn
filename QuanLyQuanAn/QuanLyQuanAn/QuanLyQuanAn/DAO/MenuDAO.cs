using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn.DAO
{
	internal class MenuDAO
	{
		private static MenuDAO instance;

		public static MenuDAO Instance
		{
			get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
			private set { MenuDAO.instance = value; }
		}

		private MenuDAO() { }

		public List<Menuf> GetListMenuByIdTable(int idTable)
		{
			List<Menuf> menuList = new List<Menuf>();

			string querry = "SELECT f.NameFood, bd.Quantity, f.Price, f.Price*bd.Quantity AS totalPrice, Note FROM dbo.BillDetail AS bd, dbo.Bill AS b, dbo.Food AS f WHERE bd.IdBill = b.IdBill AND bd.IdFood = f.IdFood AND b.StatusBill = 0 AND IdTable = " + idTable;

			DataTable data = DataProvider.Instance.ExcuteQuerry(querry);

			foreach (DataRow item in data.Rows)
			{
				Menuf menu = new Menuf(item);
				menuList.Add(menu);
			}

			return menuList;

		}

		public List<Menuf> GetReceiptByIdBill(int idBill)
		{
			List<Menuf> receipt = new List<Menuf>();

			string querry = "SELECT f.NameFood, bd.Quantity, f.Price, f.Price*bd.Quantity AS totalPrice, Note \r\nFROM dbo.BillDetail AS bd, dbo.Bill AS b, dbo.Food AS f \r\nWHERE bd.IdBill = b.IdBill AND bd.IdFood = f.IdFood AND b.StatusBill = 1 AND b.IdBill = " + idBill;

			DataTable data = DataProvider.Instance.ExcuteQuerry(querry);

			foreach (DataRow item in data.Rows)
			{
				Menuf menu = new Menuf(item);
				receipt.Add(menu);
			}

			return receipt;

		}
	}
}
