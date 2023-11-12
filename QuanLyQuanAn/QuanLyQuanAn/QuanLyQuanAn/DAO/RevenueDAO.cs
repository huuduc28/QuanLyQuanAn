using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    internal class RevenueDAO
    {
        private static RevenueDAO instance;
        public static RevenueDAO Instance
        {
            get { if (instance == null) instance = new RevenueDAO(); return RevenueDAO.instance; }
            private set { RevenueDAO.instance = value; }
        }
        private RevenueDAO() { }

        public void LoadRevenue()
        {
            string querry = "SELECT * FROM Revenue";
            DataProvider.Instance.ExcuteQuerry(querry);
        }
    }
}
