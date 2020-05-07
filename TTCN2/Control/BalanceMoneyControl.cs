using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCN2.DAO;

namespace TTCN2
{
    public partial class BalanceMoneyControl : UserControl
    {
        string date = DateTime.Now.Date.ToString();
        string totalSell = "0";
        string totalRepurchase = "0";
        string totalWarranty = "0";
        string totalOrder = "0";
        public BalanceMoneyControl()
        {
            InitializeComponent();
            Loading();
        }

        void Loading()
        {
            txtBalanceStart.Text = frmLogIn.StartBalance.ToString();
            txtUserName.Text = frmSalesManagement.USERNAME;
            txtUFullname.Text = EmployeesDAO.Instance.GetUserFullNameByUserName(txtUserName.Text);
            LoadSellingBillList();
            LoadRepurchaseList();
            LoadWarrantyBillList();
            LoadOrderBillList();
            LoadImportingBillList();
            txtBalanceEnd.Text = (Convert.ToInt32(txtBalanceStart.Text) + Convert.ToInt32(totalSell) - Convert.ToInt32(totalRepurchase) + Convert.ToInt32(totalWarranty) + Convert.ToInt32(totalOrder)).ToString();
        }

        void LoadSellingBillList()
        {
            dtgvSellingBillListDay.DataSource = SellingBillsDAO.Instance.GetSellingBillsMoney(date);
            totalSell = SellingBillsDAO.Instance.GetOnlySellingMoney(date);
            lblTotalSalesMoney.Text = totalSell + " Đ";
            dtgvSellingBillListDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSellingBillListDay.AllowUserToResizeRows = false;
        }

        void LoadRepurchaseList()
        {
            dtgvRepurchaseListDay.DataSource = RepurchaseDAO.Instance.GetRepurchaseMoney(date);
            totalRepurchase = RepurchaseDAO.Instance.GetOnlyRepurchaseMoney(date);
            lblTotalRepurchaseMoney.Text = totalRepurchase + " Đ";
            dtgvRepurchaseListDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRepurchaseListDay.AllowUserToResizeRows = false;
        }

        void LoadWarrantyBillList()
        {
            dtgvWarrantyBillListDay.DataSource = ProductWarrantyDAO.Instance.GetProductWarrantyMoney(date);
            totalWarranty = ProductWarrantyDAO.Instance.GetOnlyWarrantyMoney(date);
            lblTotalWarrantyMoney.Text = totalWarranty + " Đ";
            dtgvWarrantyBillListDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvWarrantyBillListDay.AllowUserToResizeRows = false;
        }

        void LoadOrderBillList()
        {
            dtgvOrderListDay.DataSource = OrderBillsDAO.Instance.GetOrderMoney(date);
            totalOrder = OrderBillsDAO.Instance.GetOnlyOrderMoney(date);
            lblTotalOrderDeposit.Text = totalOrder + " Đ";
            dtgvOrderListDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvOrderListDay.AllowUserToResizeRows = false;
        }

        void LoadImportingBillList()
        {
            dtgvImportingBillListDay.DataSource = ImportingBillsDAO.Instance.GetImportingBills();
            dtgvImportingBillListDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvImportingBillListDay.AllowUserToResizeRows = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            HomePage myControl = new HomePage();
            Controls.Add(myControl);
            myControl.Dock = DockStyle.Fill;
        }
    }
}
