using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
	internal class StoreDAO
	{
		private static StoreDAO instance;

		public static StoreDAO Instance
		{
			get { if (instance == null) instance = new StoreDAO(); return StoreDAO.instance; }
			private set { StoreDAO.instance = value; }
		}

		private StoreDAO() { }
	}
}
