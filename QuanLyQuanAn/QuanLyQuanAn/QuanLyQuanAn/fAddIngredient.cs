using QuanLyQuanAn.DAO;
using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class fAddIngredient : Form
    {
        public fAddIngredient()
        {
            InitializeComponent();
            LoadIngredient();

            ShowBill_Ingredient();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadIngredient()
        {
            string querry = "EXEC USP_GetListIngredient";

            dgvIngredientList.DataSource = DataProvider.Instance.ExcuteQuerry(querry);
			dgvIngredientList.Columns[3].Visible = false;
			dgvIngredientList.Columns[4].Visible = false;
		}

        void LoadIngredientByIdSupplier(int idSupplier)
        {
			string querry = "EXEC USP_GetListIngredientByIdSupplier " + idSupplier;

			dgvIngredientList.DataSource = DataProvider.Instance.ExcuteQuerry(querry);
		}

		void LoadSupplierByIdIngredient(int idIngredient)
		{
			string querry = "EXEC USP_GetListSupplierByIdIngredient " + idIngredient;

			dgvIngredientList.DataSource = DataProvider.Instance.ExcuteQuerry(querry);
		}

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void dgvIngredientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIngredientList.SelectedRows.Count > 0)
            {
                string nameIngredient = dgvIngredientList.SelectedRows[0].Cells[0].Value + "";
				string nameSupplier = dgvIngredientList.SelectedRows[0].Cells[2].Value + "";
				string idIngredient = dgvIngredientList.SelectedRows[0].Cells[3].Value + "";
				string idSupplier = dgvIngredientList.SelectedRows[0].Cells[4].Value + "";

				g2tbNameIngredient.Text = nameIngredient;
                g2tbNameSupplier.Text = nameSupplier;
                g2tbIdIngredient.Text = idIngredient;
                g2tbIdSupplier.Text = idSupplier;
            }
        }

        private void btnAddAcount_Click(object sender, EventArgs e)
        {

            int idB_I = Bill_IngredientDAO.Instance.GetMaxIdB_I();
            int idIngredient = Convert.ToInt32(g2tbIdIngredient.Text);
			int idSupplier = Convert.ToInt32(g2tbIdSupplier.Text);
            int quantity = Convert.ToInt32(g2nudQuantity.Value);

			if (idB_I == -1)
            {
                Bill_IngredientDAO.Instance.InsertBill_Ingredient();
				idB_I = Bill_IngredientDAO.Instance.GetMaxIdB_I();
                BillDetail_IngredientDAO.Instance.InsertBillDetail_Ingredient(idB_I, idIngredient, idSupplier, quantity);
            }
            else if(idB_I > 0 && Bill_IngredientDAO.Instance.GetStatusBill(idB_I) == 1)
            {
				Bill_IngredientDAO.Instance.InsertBill_Ingredient();
				idB_I = Bill_IngredientDAO.Instance.GetMaxIdB_I();
				BillDetail_IngredientDAO.Instance.InsertBillDetail_Ingredient(idB_I, idIngredient, idSupplier, quantity);
			}
			else if (idB_I > 0 && Bill_IngredientDAO.Instance.GetStatusBill(idB_I) == 0)
			{
				idB_I = Bill_IngredientDAO.Instance.GetMaxIdB_I();
				BillDetail_IngredientDAO.Instance.InsertBillDetail_Ingredient(idB_I, idIngredient, idSupplier, quantity);
			}

            ShowBill_Ingredient();
            g2nudQuantity.Value = 0;
		}


        void ShowBill_Ingredient()
        {
			lvBill.Items.Clear();
            int idB_I = Bill_IngredientDAO.Instance.GetMaxIdB_IChecked();
            List<BillDetail_Ingredient> menuList = BillDetail_IngredientDAO.Instance.GetListBillDetail_Ingredient(idB_I);
			float totalPriceAll = 0;

			foreach (BillDetail_Ingredient item in menuList)    
			{
				ListViewItem lsvItem = new ListViewItem(item.NameIngredient);
				lsvItem.SubItems.Add(item.NameSupplier);
				lsvItem.SubItems.Add(item.Quantity.ToString());
				lsvItem.SubItems.Add(item.Price.ToString());
				lsvItem.SubItems.Add(item.TotalPrice.ToString("c"));
				totalPriceAll += item.TotalPrice;
				lvBill.Items.Add(lsvItem);
			}

            g2tbAllTotalPrice.Text = totalPriceAll.ToString("c");
		}

        private void g2tbNameIngredient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(g2tbIdIngredient.Text != "")
            {
                int id = Convert.ToInt32(g2tbIdIngredient.Text);
                LoadSupplierByIdIngredient(id);
            }
        }

        private void dgvIngredientList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadIngredient();
        }

        private void g2tbNameSupplier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			if (g2tbIdSupplier.Text != "")
			{
				int id = Convert.ToInt32(g2tbIdSupplier.Text);
				LoadIngredientByIdSupplier(id);
			}
		}

        private void g2btnBill_Ingredient_Click(object sender, EventArgs e)
        {
			if (MessageBox.Show("Bạn có chắc nhập đơn hàng này không " , "Thông báo"
					, MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
				int idB_I = Bill_IngredientDAO.Instance.GetMaxIdB_I();
			    double totalPrice = Convert.ToDouble(g2tbAllTotalPrice.Text.Split(',')[0]);
			    Bill_IngredientDAO.Instance.UpdateBill_Ingredient(idB_I, (float)totalPrice);
			    ShowBill_Ingredient();
            }
		}

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
