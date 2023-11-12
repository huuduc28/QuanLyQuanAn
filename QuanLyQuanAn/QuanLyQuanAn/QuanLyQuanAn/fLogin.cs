using QuanLyQuanAn.DAO;
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
	public partial class fLogin : Form
	{

		public fLogin()
		{
			InitializeComponent();
			tbPassword.PasswordChar = '*';
		}

		private void fLogin_Load(object sender, EventArgs e)
		{
			
		}

        private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = tbUserName.Text;
			string password = tbPassword.Text;
			fTableManager f = new fTableManager();
			fMenu fm = new fMenu();
			f.userName = tbUserName.Text;
			fm.userName = tbUserName.Text;

			if(AccountDAO.Instance.Login(username, password))
			{
				f.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Tài khoản đăng nhập không hợp lệ!");
			}

		}


		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void tbPassword_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void tbUserName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
