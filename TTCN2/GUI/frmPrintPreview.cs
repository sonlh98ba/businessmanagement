using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCN2.DAO;

namespace TTCN2.GUI
{
    public partial class frmPrintPreview : Form
    {
        public frmPrintPreview()
        {
            InitializeComponent();
            lblMonth.Text = DateTime.Now.Month.ToString();
            lblToday.Text = "Ngày " + DateTime.Now.Day.ToString() + " Tháng " + DateTime.Now.Month.ToString() + " Năm " + DateTime.Now.Year.ToString();
            lblQuarter.Text = (Convert.ToInt32(DateTime.Now.Month) / 3 + 1).ToString();
            lblSales.Text = (Convert.ToInt32(SellingBillsDAO.Instance.GetOnlySellingMoneyMonth(DateTime.Now.Year.ToString() + "-" + lblMonth.Text + "-1", DateTime.Now.Year.ToString() + "-" + lblMonth.Text + "-30")) + Convert.ToInt32(ProductWarrantyDAO.Instance.GetOnlyWarrantyMoneyMonth(DateTime.Now.Year.ToString() + "-" + lblMonth.Text + "-1", DateTime.Now.Year.ToString() + "-" + lblMonth.Text + "-30"))).ToString();
            lblEndSales.Text = (Convert.ToInt32(lblSales.Text) - Convert.ToInt32(lblDecreaseSales.Text)).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
