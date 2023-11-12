using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
	internal class Storage
	{
        public Storage(string idIngredient, int quantity, string measure, String Datein)
        {
            this.idIngredient = idIngredient;
            this.quantity = quantity;
            this.measure = measure;
            this.Datein = Datein;
        }
        private string idIngredient;
        private int quantity;
        private string measure;
        private String datein;
        public Storage(DataRow row)
        {
            this.idIngredient = row["IdIngredient"].ToString();
            this.quantity = (int)row["Quantity"];
            this.measure = (row["Measure"].ToString());
            this.datein = (row["Datein"].ToString());
        }
        public string IdIngredient
        {
            get { return idIngredient; }
            set { idIngredient = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Measure
        {
            get { return measure; }
            set { measure = value; }
        }

        public string Datein
        {
            get { return datein; }
            set { datein = value; }
        }
    }
}
