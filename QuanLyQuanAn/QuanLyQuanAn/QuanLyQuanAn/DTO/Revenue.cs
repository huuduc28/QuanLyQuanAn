using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
    internal class Revenue
    {
        public Revenue(int nameMonth, int nameYear, float revenue)
        {
            this.nameMonth = nameMonth;
            this.nameYear = nameYear;
            this.revenue = revenue;
        }

        public Revenue(DataRow row)
        {
            this.nameMonth = (int)row["NameMonth"];
            this.nameYear = (int)row["NameYear"];
            this.revenue = (int)row["revenue"];
        }

        private int nameMonth;
        private int nameYear;
        private float revenue;

        public int NameMonth
        {
            get { return nameMonth; }
            set { nameMonth = value; }
        }

        public int NameYear
        {
            get { return nameYear; }
            set { nameYear = value; }
        }

        public float Revenues
        {
            get { return revenue; }
            set { revenue = value; }
        }
    }
}
