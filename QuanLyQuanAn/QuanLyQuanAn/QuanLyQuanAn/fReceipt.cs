using QuanLyQuanAn.DAO;
using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
	public partial class fReceipt : Form
	{
		List<Menuf> _menuList;
		string _date, _phoneNumber;
		int _idTable, _idBill, _totalPrice, _discount, _finalTotalPrice;

		public fReceipt(int idTable, int idBill, string phoneNumber, int totalPrice, int discount, int finalTotalPrice)
		{
			InitializeComponent();
			_idTable = idTable;
			_idBill = idBill;
			_phoneNumber = phoneNumber;
			_totalPrice = totalPrice;
			_discount = discount;
			_finalTotalPrice = finalTotalPrice;
		}

		private void lbTotalPrice_Click(object sender, EventArgs e)
		{

		}

		private void fReceipt_Load(object sender, EventArgs e)
		{
			List<Menuf> receipt = MenuDAO.Instance.GetReceiptByIdBill(_idBill);
			foreach (Menuf item in receipt)
			{
				ListViewItem lsvItem = new ListViewItem(item.NameFood);
				lsvItem.SubItems.Add(item.Quantity.ToString());
				lsvItem.SubItems.Add(item.Price.ToString());
				lsvItem.SubItems.Add(item.TotalPrice.ToString());
				lvReceipt.Items.Add(lsvItem);
			}

			string query = "SELECT DateIn FROM BILL WHERE IdBill = " + _idBill;
			if (CustomerDAO.Instance.CheckCustomerExist(_phoneNumber) > 0)
			{
				lbNameCustomer.Text = "Khách Hàng: " + CustomerDAO.Instance.GetNameCustomerByPhoneNumber(_phoneNumber);
			}
			lbDate.Text = "Ngày lập: " + BillDAO.Instance.GetDateByIdBill(_idBill);
			lbTable.Text = "Số bàn: " + _idTable;
			lbTotalPrice.Text = "Tổng tiền: " + _totalPrice.ToString("c");
			lbDiscount.Text = "Giảm giá: " + _discount + "%";
			lbFinalTotalPrice.Text = "Thành tiền: " + _finalTotalPrice.ToString("c");
		}
	}
}
