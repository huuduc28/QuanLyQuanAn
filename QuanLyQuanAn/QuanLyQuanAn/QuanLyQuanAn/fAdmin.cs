using QuanLyQuanAn.DAO;
using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel.Application;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using DataTable = System.Data.DataTable;
namespace QuanLyQuanAn
{
	public partial class fAdmin : Form
	{
		public fAdmin()
		{
			InitializeComponent();


			LoadAccountList();
			LoadCustomerList();
			LoadSupplierList();
			LoadFoodList();
			LoadStorage();

            UpdateStorage();
            g2dtpDateIn.Value = DateTime.Now;
			g2dtpDateOut.Value = DateTime.Now;
			LoadListBilLByDate(g2dtpDateIn.Value, g2dtpDateOut.Value);

		}



		private void fAdmin_Load(object sender, EventArgs e)
		{
			UpdateStorage();
		}

		void LoadAccountList()
		{
			string querry = "SELECT UserName as N'Tài khoản', DisplayName as N'Tên hiển thị', TypeAccount as N'Chức vụ' FROM dbo.Account";

			dgvAccount.DataSource = DataProvider.Instance.ExcuteQuerry(querry);
		}

		void LoadCustomerList()
		{
			string querry = "SELECT NameCustomer AS N'Tên Khách Hàng', PhoneNumber AS N'Số Điện thoại', Point AS N'Điểm' FROM dbo.Customer";
			dgvCustomer.DataSource = DataProvider.Instance.ExcuteQuerry(querry);
		}

		void LoadSupplierList()
		{
			dgvSupplier.DataSource = SupplierDAO.Instance.GetTableListSupplier();
			dgvSupplier.Columns[0].Visible = false;
		}


		void LoadFoodList()
		{
			string querry = "SELECT * FROM FOOD";
			dgvFood.DataSource = DataProvider.Instance.ExcuteQuerry(querry);
		}

		void LoadStorage()
		{
			string querry = "EXEC USP_GetListIngredientInStorage";
			dgvStorage.DataSource = DataProvider.Instance.ExcuteQuerry(querry);

        }
		void UpdateStorage()
		{
			string querry = "EXEC USP_UpdateStorage";
			DataProvider.Instance.ExcuteQuerry(querry);

		}
		void UpdateStoregeByDate(int i)
		{
             string querry = "EXEC USP_UpdateStorage @IdIngredient = '" + i;
             DataProvider.Instance.ExcuteQuerry(querry);
            
        }


        private void btnAddAcount_Click(object sender, EventArgs e)
		{
			string userName = g2tbUserName.Text;
			string displayName = g2tbDisplayName.Text;
			string password = g2tbPassword.Text;
			string typeAccount = g2cbTypeAccount.Text;

			AccountDAO.Instance.InsertAccount(userName, displayName, password, typeAccount);
			LoadAccountList();
		}

		private void btnDeleteAccount_Click(object sender, EventArgs e)
		{
			string userName = g2tbUserName.Text;

			AccountDAO.Instance.DeleteAccount(userName);
			LoadAccountList();
			g2tbUserName.Text = "";
			g2tbDisplayName.Text = "";
			g2cbTypeAccount.Text = "";
			g2tbPassword.Text = "";
		}


		private void btnEditAccount_Click(object sender, EventArgs e)
		{
			string userName = g2tbUserName.Text;
			string typeAccount = g2cbTypeAccount.Text;
			string displayName = g2tbDisplayName.Text;
			string password = g2tbPassword.Text;
			AccountDAO.Instance.EditAccount(userName, displayName, typeAccount);

			LoadAccountList();
			g2tbUserName.Text = "";
			g2tbDisplayName.Text = "";
			g2cbTypeAccount.Text = "";
			g2tbPassword.Text = "";
		}

		private void g2btnRefresh_Click(object sender, EventArgs e)
		{
			g2tbUserName.Text = "";
			g2tbDisplayName.Text = "";
			g2cbTypeAccount.Text = "";
			g2tbPassword.Text = "";
		}


		void LoadListBilLByDate(DateTime dateIn, DateTime dateOut)
		{
			dgvBill.DataSource = BillDAO.Instance.GetBillListByDate(dateIn, dateOut);
			int totalPrice = 0;
			for (int i = 0; i < dgvBill.Rows.Count; i++)
			{
				totalPrice += Convert.ToInt32(dgvBill.Rows[i].Cells[5].Value);

			}
			CultureInfo culture = new CultureInfo("vi-VN");
			Thread.CurrentThread.CurrentCulture = culture;
			g2tbTotalPriceAll.Text = totalPrice.ToString("c");
		}

	
	

		private void g2btnStatistics_Click(object sender, EventArgs e)
		{
			LoadListBilLByDate(g2dtpDateIn.Value, g2dtpDateOut.Value);
		}


		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}



		private void guna2Button3_Click(object sender, EventArgs e)
		{

		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			fAddIngredient f = new fAddIngredient();
			f.Show();
		}


		private void g2dtpDateOut_ValueChanged(object sender, EventArgs e)
		{

		}



		private void g2btnPlusPoint_Click(object sender, EventArgs e)
		{
			string querry = "UPDATE dbo.Customer SET Point = Point + " + (int)g2nudPoint.Value + " WHERE PhoneNumber = '" + g2tbPhoneNumberCustomer.Text + "'"; ;
			dgvCustomer.DataSource = DataProvider.Instance.ExcuteQuerry(querry);
			g2nudPoint.Text = "0";
			LoadCustomerList();
		}

	


		private void g2tbTotalPrice_TextChanged(object sender, EventArgs e)
		{

		}

		private void g2cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvAccount.SelectedRows.Count > 0)
			{
				string userName = dgvAccount.SelectedRows[0].Cells[0].Value + "";
				string displayName = dgvAccount.SelectedRows[0].Cells[1].Value + "";
				string typeAccount = dgvAccount.SelectedRows[0].Cells[2].Value + "";

				g2tbUserName.Text = userName;
				g2tbDisplayName.Text = displayName;
				g2cbTypeAccount.Text = typeAccount;
			}
		}

		private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvCustomer.SelectedRows.Count > 0)
			{
				string nameCustomer = dgvCustomer.SelectedRows[0].Cells[0].Value + "";
				string phoneNumber = dgvCustomer.SelectedRows[0].Cells[1].Value + "";

				g2tbNameCustomer.Text = nameCustomer;
				g2tbPhoneNumberCustomer.Text = phoneNumber;
				g2tbSavePhoneNumber.Text = phoneNumber;
			}
		}

		private void g2btnAddCustomer_Click(object sender, EventArgs e)
		{
			string phoneNumber = g2tbPhoneNumberCustomer.Text;
			string name = g2tbNameCustomer.Text;
			int point = Convert.ToInt32(g2nudPoint.Value);

			if (CustomerDAO.Instance.CheckCustomerExist(phoneNumber) > 0)
			{
				MessageBox.Show("Số điện thoại đã có người đăng ký. Vui lòng sử dụng số điện thoại khác!");
			}
			else if(phoneNumber.Length != 10)
			{
				MessageBox.Show("Số điện thoại phải đủ 10 số");
			}
			else
			{
				CustomerDAO.Instance.InsertCustomer(phoneNumber, name, point);
				LoadCustomerList();
				g2tbNameCustomer.Text = "";
				g2tbPhoneNumberCustomer.Text = "";
			}
		}

		private void g2btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			string phoneNumber = g2tbPhoneNumberCustomer.Text;
			string name = g2tbNameCustomer.Text;
			if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng " + name + " không?", "Thông báo"
					, MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				CustomerDAO.Instance.DeleteCustomer(phoneNumber);
				LoadCustomerList();
				g2tbNameCustomer.Text = "";
				g2tbPhoneNumberCustomer.Text = "";
			}
		}

		private void g2btnEditCustomer_Click(object sender, EventArgs e)
		{
			string oldPhoneNumber = g2tbSavePhoneNumber.Text;
			string newPhoneNumber = g2tbPhoneNumberCustomer.Text;
			string newName = g2tbNameCustomer.Text;

			if (MessageBox.Show("Bạn có chắc muốn thay đổi khách hàng này không?", "Thông báo"
					, MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				if (CustomerDAO.Instance.CheckCustomerExist(newPhoneNumber) > 0 && oldPhoneNumber != newPhoneNumber)
				{
					MessageBox.Show("Số điện thoại đã có người đăng ký. Vui lòng sử dụng số điện thoại khác!");
				}
				else if (newPhoneNumber.Length != 10)
				{
					MessageBox.Show("Số điện thoại phải đủ 10 số");
				}
				else
				{
					CustomerDAO.Instance.EditCustomer(oldPhoneNumber, newPhoneNumber, newName);
					LoadCustomerList();
					g2tbNameCustomer.Text = "";
					g2tbPhoneNumberCustomer.Text = "";

				}
			}
		}

		private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvSupplier.SelectedRows.Count > 0)
			{
				string idSupplier = dgvSupplier.SelectedRows[0].Cells[0].Value + "";
				string nameSupplier = dgvSupplier.SelectedRows[0].Cells[1].Value + "";
				string phoneNumber = dgvSupplier.SelectedRows[0].Cells[2].Value + "";

				g2tbNameSupplier.Text = nameSupplier;
				g2tbPhoneNumberSupplier.Text = phoneNumber;
				g2tbSavePhoneNumberSupplier.Text = phoneNumber;
				g2tbIdSupplier.Text = idSupplier;
			}
		}

		private void g2btnAddSupplier_Click(object sender, EventArgs e)
		{
			string phoneNumber = g2tbPhoneNumberSupplier.Text;
			string name = g2tbNameSupplier.Text;
			if (SupplierDAO.Instance.CheckPhoneNumberSupplierExist(phoneNumber) > 0)
			{
				MessageBox.Show("Số điện thoại đã có người đăng ký. Vui lòng sử dụng số điện thoại khác!");
			}
			else if (phoneNumber.Length != 10)
			{
				MessageBox.Show("Số điện thoại phải đủ 10 số");
			}
			else
			{
				SupplierDAO.Instance.InsertSupplier(phoneNumber, name);
				LoadSupplierList();
			}
		}

		private void g2btnDeleteSupplier_Click(object sender, EventArgs e)
		{
			int idSupplier = Convert.ToInt32(g2tbIdSupplier.Text);
			if (MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này không?", "Thông báo"
					, MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				SupplierDAO.Instance.DeleteSupplier(idSupplier);
				LoadSupplierList();
			}
		}

		private void g2btnEditSupplier_Click(object sender, EventArgs e)
		{
			int idSupplier = Convert.ToInt32(g2tbIdSupplier.Text);
			string oldPhoneNumber = g2tbSavePhoneNumberSupplier.Text;
			string newPhoneNumber = g2tbPhoneNumberSupplier.Text;
			string newName = g2tbNameSupplier.Text;

			if (MessageBox.Show("Bạn có chắc muốn thay đổi nhà cung cấp này không?", "Thông báo"
					, MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				if (SupplierDAO.Instance.CheckPhoneNumberSupplierExist(newPhoneNumber) > 0 && oldPhoneNumber != newPhoneNumber)
				{
					MessageBox.Show("Số điện thoại đã có người đăng ký. Vui lòng sử dụng số điện thoại khác!");
				}
				else if (newPhoneNumber.Length != 10)
				{
					MessageBox.Show("Số điện thoại phải đủ 10 số");
				}
				else
				{
					SupplierDAO.Instance.EditSupplier(idSupplier, newPhoneNumber, newName);
					LoadSupplierList();
					g2tbNameSupplier.Text = "";
					g2tbPhoneNumberSupplier.Text = "";

				}
			}
		}

		private void tabPage3_Click(object sender, EventArgs e)
		{

		}

		

		private void g2btnOpenAddIngredient_Click_1(object sender, EventArgs e)
		{
            fAddIngredient f = new fAddIngredient();
            f.Show();
        }

		private void dgvStorage_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            if (dgvStorage.SelectedRows.Count > 0)
            {
                string idStorage = dgvStorage.SelectedRows[0].Cells[0].Value + "";
                string nameStorage = dgvStorage.SelectedRows[0].Cells[1].Value + "";
                string mutiStorage = dgvStorage.SelectedRows[0].Cells[2].Value + "";

                g2tbIdStogare.Text = idStorage;
                g2tNameStogare.Text = nameStorage;
                g2tSLStogare.Text = mutiStorage;

            }
        }

		private void guna2Button9_Click(object sender, EventArgs e)
		{
            string idingredient = g2tbIdStogare.Text;
			string quantity = g2tSLStogare.Text;
			if(idingredient != "" && quantity != "")
			{
				StorageDAO.Instance.EditStorage(idingredient, quantity);
			}
            LoadStorage();
            g2tbIdStogare.Text = "";
            g2tNameStogare.Text = "";
            g2tSLStogare.Text = "";
			UpdateStorage();
        }

		private void guna2Panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void guna2Button8_Click(object sender, EventArgs e)
		{
            string idingredien = g2tbIdStogare.Text;
			StorageDAO.Instance.DeleteStorage(idingredien);
            LoadStorage();
            g2tbIdStogare.Text = "";
            g2tNameStogare.Text = "";
            g2tSLStogare.Text = "";
        }

		private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvFood.SelectedRows.Count > 0)
			{
				string idFood = dgvFood.SelectedRows[0].Cells[0].Value + "";
                string nameFood = dgvFood.SelectedRows[0].Cells[1].Value + "";
				string price = dgvFood.SelectedRows[0].Cells[3].Value + "";

				g2tbIdFood.Text = idFood;
				g2tbNameFood.Text = nameFood;
				g2tbPrice.Text = price;

			}
		}

		private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void guna2Button11_Click(object sender, EventArgs e)
		{
			fRevenue f = new fRevenue();
			f.Show();
		}

		private void guna2Button12_Click(object sender, EventArgs e)
		{
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("IdTable");
            DataColumn col2 = new DataColumn("NameTable");
            DataColumn col3 = new DataColumn("DateIn");
            DataColumn col4 = new DataColumn("DateOut");
            DataColumn col5 = new DataColumn("TotalPrice");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);

            foreach (DataGridViewRow dtgrv in dgvBill.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = dtgrv.Cells[0].Value;
                dataRow[1] = dtgrv.Cells[1].Value;
                dataRow[2] = dtgrv.Cells[2].Value;
                dataRow[3] = dtgrv.Cells[3].Value;
                dataRow[4] = dtgrv.Cells[5].Value;

                dataTable.Rows.Add(dataRow);
            }
            ExportFile(dataTable, "Doanh Thu", "Tổng Doanh thu quán");
            MessageBox.Show("Thành công");
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Hóa Đơn";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tên Bàn";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Ngày vào";
            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Ngày ra";

            cl4.ColumnWidth = 25.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Thành tiền";

            cl5.ColumnWidth = 25.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void g2bChooseImg_Click(object sender, EventArgs e)
		{
            openFileImg.ShowDialog();
            string file = openFileImg.FileName;
            if (string.IsNullOrEmpty(file))
                return;
				Image myImage = Image.FromFile(file);
            g2tbPath.Text = openFileImg.FileName;
            picFood.Image = myImage;
        }

		private void g2bAddFood_Click(object sender, EventArgs e)
		{
            MemoryStream stream = new MemoryStream();
            picFood.Image.Save(stream, ImageFormat.Png);
            string Category = g2cbCategory.Text;

            int idfc = 1;

            if (Category == "Mì cay")
            {
                idfc = 1;
            }
            else if (Category == "Nước uống")
            {
                idfc = 2;
            }
            else if (Category == "Ăn vặt")
            {
                idfc = 3;
            }
            else if (Category == "Lẩu")
            {
                idfc = 4;
            }
            string nameFood = g2tbNameFood.Text;
            double price = Convert.ToDouble(g2tbPrice.Text);
            Array imgFood = stream.ToArray();
            FoodDAO.Instance.InsertFood(nameFood, idfc, price, imgFood);
            MessageBox.Show("Thành công");
            LoadFoodList();
        }

		private void g2bDelete_Click(object sender, EventArgs e)
		{

			int idFood = Convert.ToInt32(g2tbIdFood.Text);
            FoodDAO.Instance.deleteFood(idFood);
			LoadFoodList();

		}

		private void g2btnEditFood_Click(object sender, EventArgs e)
		{
			int idFood = Convert.ToInt32(g2tbIdFood.Text);
			double price = Convert.ToDouble(g2tbPrice.Text);
			FoodDAO.Instance.EditFood(idFood, price);
			LoadFoodList();
		}

		private void guna2Button6_Click(object sender, EventArgs e)
		{
			int quantity = Convert.ToInt32(g2nud.Value);
			dgvStorage.DataSource = StorageDAO.Instance.GetListIngredientOutOfStock(quantity);
		}

		private void guna2CircleButton1_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void g2btnOutOfStock_Click(object sender, EventArgs e)
		{
			int quantity = Convert.ToInt32(g2nud.Value);
			dgvStorage.DataSource = StorageDAO.Instance.GetListIngredientOutOfStock(quantity);
		}

		private void g2btnExpired_Click(object sender, EventArgs e)
		{
			dgvStorage.DataSource = StorageDAO.Instance.GetListIngredientExpired();
		}


		private void guna2Button3_Click_1(object sender, EventArgs e)
		{
			g2tbNameCustomer.Text = "";
			g2tbPhoneNumberCustomer.Text = "";
		}

		private void guna2Button5_Click(object sender, EventArgs e)
		{
			g2tbNameSupplier.Text = "";
			g2tbPhoneNumberSupplier.Text = "";
		}

		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			g2tbNameFood.Text = "";
			g2cbCategory.Text = "";
			g2tbPrice.Text = "";
		}

		
	}
}
