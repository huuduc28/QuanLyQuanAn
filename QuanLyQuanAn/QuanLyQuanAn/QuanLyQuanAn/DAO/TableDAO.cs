using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class TableDAO
	{
		private static TableDAO instance;

		public static TableDAO Instance
		{
			get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
			private set { TableDAO.instance = value; }
		}

		private TableDAO() { }

		public static int TableWidth = 130;
		public static int TableHeight = 80;

		public List<Table> LoadTableList()
		{
			List<Table> tableList = new List<Table>();
			DataTable data = DataProvider.Instance.ExcuteQuerry("USP_GetTableList");

			foreach(DataRow item in data.Rows)
			{
				Table table = new Table(item);
				tableList.Add(table);
			}


			return tableList;
		}
	}
}
