using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
	internal class Table
	{
		public Table(int id, string name, string status, string position)
		{
			this.idTable = id;
			this.nameTable = name;
			this.statusTable = status;
			this.position = position;

		}

		public Table(DataRow row)
		{
			this.idTable = (int)row["idTable"];
			this.nameTable = row["nameTable"].ToString();
			this.statusTable = row["statusTable"].ToString();
			this.position = row["position"].ToString();
		}


		private int idTable;
		private string nameTable;
		private string statusTable;
		private string position;

		public int IdTable
		{
			get { return idTable; }
			set { idTable = value; }
		}

		public string NameTable
		{
			get { return nameTable; }
			set { nameTable = value; }
		}

		public string StatusTable
		{
			get { return statusTable; }
			set { statusTable = value; }
		}

		public string Position
		{
			get { return position; }
			set { position = value; }
		}
	}
}
