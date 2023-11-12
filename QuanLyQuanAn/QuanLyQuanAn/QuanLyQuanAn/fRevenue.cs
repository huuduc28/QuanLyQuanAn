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
    public partial class fRevenue : Form
    {
        public fRevenue()
        {
            InitializeComponent();
            chartLoad();
        }
        private void chartLoad()
        {
            string querry = "SELECT * FROM Revenue";
            DataTable dt = DataProvider.Instance.ExcuteQuerry(querry);

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series["NameMonth"].Points.AddXY(dt.Rows[i]["NameMonth"], dt.Rows[i]["revenue"]);
            }


        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
