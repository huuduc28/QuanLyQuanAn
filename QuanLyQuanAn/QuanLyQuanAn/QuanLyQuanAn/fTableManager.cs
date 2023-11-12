using Guna.UI2.WinForms;
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
	public partial class fTableManager : Form
	{
		public string userName;
		public int IDTable;
		public fTableManager()
		{
			InitializeComponent();
			LoadTable("Trệt");
			g2pnlFloor.Visible = false;
			g2pnlGround.Visible = true;
		}

		public void LoadTable(string position)
		{
			
			flpGround.Controls.Clear();
			List<Table> tableList = TableDAO.Instance.LoadTableList();
			foreach(Table item in tableList)
			{
				Button btnTable = new Button() {
					Width = TableDAO.TableWidth,
					Height=  TableDAO.TableHeight,
					Margin = new Padding(5, 5, 5, 5)
				};
				btnTable.Text = item.NameTable + Environment.NewLine + item.StatusTable;
				btnTable.Click += btnTable_Click;
				btnTable.Tag = item;
				switch(item.StatusTable)
				{
					case "Trống":
						btnTable.BackColor = Color.WhiteSmoke;
						break;	
					default:
						btnTable.BackColor = Color.LightBlue;
						break;
				}
				if (item.Position == position)
				{
					flpGround.Controls.Add(btnTable);
				}
			}
		}

		private void fTableManager_Load(object sender, EventArgs e)
		{

		}

		void btnTable_Click(object sender, EventArgs e)
		{
			fMenu fmenu = new fMenu();
			ItemFood i = new ItemFood();
			int idTable = ((sender as Button).Tag as Table).IdTable;
			IDTable = idTable;
			fmenu.idTable = idTable;
			fmenu.lv.Tag = (sender as Button).Tag;
			fmenu.ShowBill(idTable);
			fmenu.Show();
			this.Hide();
		}


		private void tabPage1_Click(object sender, EventArgs e)
		{
			 
		}

		private void g2cbtnQuit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void g2cbtnBack_Click(object sender, EventArgs e)
		{
			fLogin f = new fLogin();
			f.Show();
			this.Hide();
		}

		private void g2btnGround_Click(object sender, EventArgs e)
		{
			LoadTable("Trệt");
			g2pnlFloor.Visible = false;
			g2pnlGround.Visible = true;
		}

		private void g2btnFloor_Click(object sender, EventArgs e)
		{
			LoadTable("Lầu");
			g2pnlFloor.Visible = true;
			g2pnlGround.Visible = false;
		}

		private void g2btnAdmin_Click(object sender, EventArgs e)
		{
			fAdmin f = new fAdmin();
			f.Show();
			/*
			if (AccountDAO.Instance.CheckAdmin(userName))
			{
				f.Show();
			}
			else
			{
				MessageBox.Show("Bạn không đủ tư cách để vào đây");
			}*/
		}

		private void flpGround_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
