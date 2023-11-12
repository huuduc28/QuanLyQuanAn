using QuanLyQuanAn.DAO;
using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
	public partial class ItemFood : UserControl
	{

		int quantity = 0;

		public ItemFood()
		{
			InitializeComponent();
			g2tbQuantity.Text = quantity.ToString();

		}

		public string IdTable
		{
			get { return idTable.Text; }
			set { idTable.Text = value; }
		}

		public string IdFood
		{
			get { return idFood.Text; }
			set { idFood.Text = value; }
		}


		public string NameFood
		{
			get { return label1.Text; }
			set { label1.Text = value; }
		}

		public Image PicFood
		{
			get { return btnPicFood.BackgroundImage; }
			set { btnPicFood.BackgroundImage = value; }
		}


		void label1_Click(object sender, EventArgs e)
		{

		}

	
		public void btnPicFood_Click(object sender, EventArgs e)
		{
			fMenu f = new fMenu();
			int quantity = Convert.ToInt32(g2tbQuantity.Text);
			string note = g2tbNote.Text;
			int idBill = BillDAO.Instance.GetUncheckIdBillByIdTable(Convert.ToInt32(idTable.Text));


			if (idBill == -1)
			{
				BillDAO.Instance.InsertBill(Convert.ToInt32(idTable.Text));
				BillDetailDAO.Instance.InsertBillDetail(BillDAO.Instance.GetMaxIdBill(), Convert.ToInt32(idFood.Text), quantity, note);
			}
			else
			{
				BillDetailDAO.Instance.InsertBillDetail(idBill, Convert.ToInt32(idFood.Text), quantity, note);
			}

			quantity = 0;
			g2tbQuantity.Text = quantity.ToString();
			g2tbQuantity.FillColor = Color.White;
			g2tbNote.Text = "";
			f.ShowBill(Convert.ToInt32(idTable.Text));
		}


		private void ItemFood_Load(object sender, EventArgs e)

		{

		}

		private void ItemFood_Click(object sender, EventArgs e)
		{

		}

		private void idFood_Click(object sender, EventArgs e)
		{

		}

		private void btnPicFood_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void guna2ImageButton1_Click(object sender, EventArgs e)
		{

		}

		private void g2btnPlus_Click(object sender, EventArgs e)
		{
			quantity = Convert.ToInt32(g2tbQuantity.Text) + 1;
			g2tbQuantity.Text = quantity.ToString();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			quantity = Convert.ToInt32(g2tbQuantity.Text) - 1;
			g2tbQuantity.Text = quantity.ToString();
		}

		private void g2tbQuantity_TextChanged(object sender, EventArgs e)
		{
			if(quantity == 0)
			{
				g2tbQuantity.FillColor = Color.White;
			}
			else if(quantity > 0)
			{
				g2tbQuantity.FillColor = Color.LightGreen;
			}
			else
			{
				g2tbQuantity.FillColor = Color.Red;
			}
		}
	}
}
