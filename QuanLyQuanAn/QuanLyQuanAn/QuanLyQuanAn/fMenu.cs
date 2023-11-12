using Guna.UI2.WinForms;
using QuanLyQuanAn.DAO;
using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace QuanLyQuanAn
{
	public partial class fMenu : Form
	{
		public string userName;
		public ListView lv = new ListView();
		public int idTable;
		
		Bitmap bmp;


		public fMenu()
		{
			InitializeComponent();
        }

		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{

		}




		public void ShowBill(int idTable)
		{
			lvBill.Items.Clear();
			List<Menuf> menuList = MenuDAO.Instance.GetListMenuByIdTable(idTable);
			float totalPriceAll = 0;

			foreach (Menuf item in menuList)
			{
				ListViewItem lsvItem = new ListViewItem(item.NameFood);
				lsvItem.SubItems.Add(item.Quantity.ToString());
				lsvItem.SubItems.Add(item.Price.ToString());
				lsvItem.SubItems.Add(item.TotalPrice.ToString());
				lsvItem.SubItems.Add(item.Note.ToString());
				totalPriceAll += item.TotalPrice;
				lvBill.Items.Add(lsvItem);
			}
			CultureInfo culture = new CultureInfo("vi-VN");
			Thread.CurrentThread.CurrentCulture = culture;
			g2tbTotalPrice.Text = totalPriceAll.ToString("c");
		}

		




		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			fTableManager f = new fTableManager();
			f.Show();
			this.Hide();
		}




		private void g2btnCheckOut_Click(object sender, EventArgs e)
		{
			Table table = lv.Tag as Table;
			int idBill = BillDAO.Instance.GetUncheckIdBillByIdTable(table.IdTable);
			int discount = (int)g2nudDiscount.Value;

			double totalPrice = Convert.ToDouble(g2tbTotalPrice.Text.Split(',')[0]);
			double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

			

			if (idBill != -1)
			{
				if(MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + table.NameTable, "Thông báo"
					, MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
				{

					if(g2tbPhoneNumber.Text == "")
					{
						BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
						ShowBill(table.IdTable);
						fReceipt r = new fReceipt(idTable, idBill, g2tbPhoneNumber.Text, (int)totalPrice, discount, (int)finalTotalPrice);
						r.Show();
					}
					else if(CustomerDAO.Instance.CheckCustomerExist(g2tbPhoneNumber.Text) <= 0) {
						MessageBox.Show("Khách Hàng Không Tồn Tại");
					}
					else
					{
						BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
						CustomerDAO.Instance.PlusPointToCustomer(g2tbPhoneNumber.Text, (float)finalTotalPrice);
						ShowBill(table.IdTable);
						fReceipt r = new fReceipt(idTable, idBill, g2tbPhoneNumber.Text, (int)totalPrice, discount, (int)finalTotalPrice);
						r.Show();

					}
				}
			}


		}



		public void AddItemFood(int IdCategory)
		{
			flpFoodList.Controls.Clear();
			List<Food> foodList = FoodDAO.Instance.GetListFood();

			foreach (Food item in foodList)
			{
				ItemFood itemFood = new ItemFood();
				itemFood.IdTable = idTable.ToString();
				itemFood.IdFood = item.IdFood.ToString();
				itemFood.NameFood = item.NameFood;
				itemFood.PicFood = item.ImageFood;
				itemFood.Click += itemFood.btnPicFood_Click;
				if (item.IdFC == IdCategory || IdCategory == 0)
				{
					flpFoodList.Controls.Add(itemFood);
				}
			}
		}


		private void g2tbTotalPrice_TextChanged(object sender, EventArgs e)
		{

		}

		private void fMenu_Load(object sender, EventArgs e)
		{
			AddItemFood(0);
			g2pnlAllFood.Visible = true;
			g2pnlSpicyNoodle.Visible = false;
			g2pnlWater.Visible = false;
			g2pnlFastFood.Visible = false;
			g2pnlHotPot.Visible = false;

		}

		private void flpFoodList_Paint(object sender, PaintEventArgs e)
		{

		}

		private void g2btnAllFood_Click(object sender, EventArgs e)
		{
			AddItemFood(0);
			g2pnlAllFood.Visible = true;
			g2pnlSpicyNoodle.Visible = false;
			g2pnlWater.Visible = false;
			g2pnlFastFood.Visible = false;
			g2pnlHotPot.Visible = false;
		}

		private void g2btnSpicyNoodle_Click(object sender, EventArgs e)
		{
			AddItemFood(1);
			g2pnlAllFood.Visible = false;
			g2pnlSpicyNoodle.Visible = true;
			g2pnlWater.Visible = false;
			g2pnlFastFood.Visible = false;
			g2pnlHotPot.Visible = false;
		}

		private void g2btnWater_Click(object sender, EventArgs e)
		{
			AddItemFood(2);
			g2pnlAllFood.Visible = false;
			g2pnlSpicyNoodle.Visible = false;
			g2pnlWater.Visible = true;
			g2pnlFastFood.Visible = false;
			g2pnlHotPot.Visible = false;
		}

		private void g2btnFastFood_Click(object sender, EventArgs e)
		{
			AddItemFood(3);
			g2pnlAllFood.Visible = false;
			g2pnlSpicyNoodle.Visible = false;
			g2pnlWater.Visible = false;
			g2pnlFastFood.Visible = true;
			g2pnlHotPot.Visible = false;
		}

		private void g2btnHotPot_Click(object sender, EventArgs e)
		{
			AddItemFood(4);
			g2pnlAllFood.Visible = false;
			g2pnlSpicyNoodle.Visible = false;
			g2pnlWater.Visible = false;
			g2pnlFastFood.Visible = false;
			g2pnlHotPot.Visible = true;
		}

		private void g2btnLoadBill_Click(object sender, EventArgs e)
		{
			ShowBill(idTable);
		}

		private void lvBill_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void g2tbPhoneNumber_TextChanged(object sender, EventArgs e)
		{

		}

		private void g2btnLoadBill_TextChanged(object sender, EventArgs e)
		{

		}


	}
}
