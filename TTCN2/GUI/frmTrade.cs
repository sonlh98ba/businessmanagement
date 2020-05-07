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

namespace TTCN2
{
    public partial class frmTrade : Form
    {
        public frmTrade()
        {
            InitializeComponent();
            Loading();
        }

        void Loading()
        {
            dtpkSellingDate1.Value = DateTime.Today;
            dtpkSellingDate2.Value = DateTime.Today;
            dtpkRepurchaseDate1.Value = DateTime.Today;
            dtpkRepurchaseDate2.Value = DateTime.Today;
            dtpkWarrantyDate1.Value = DateTime.Today;
            dtpkWarrantyDate2.Value = DateTime.Today;
            dtpkOrderDate1.Value = DateTime.Today;
            dtpkOrderDate2.Value = DateTime.Today;
            dtpkImportingDate1.Value = DateTime.Today;
            dtpkImportingDate2.Value = DateTime.Today;
            LoadSellingBillList();
            LoadRepurchaseList();
            LoadWarrantyBillList();
            LoadOrderBillList();
            LoadImportingBillList();
        }

        void LoadSellingBillList()
        {
            dtgvSellingBillList.DataSource = SellingBillsDAO.Instance.GetSellingBills();
            dtgvSellingBillList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSellingBillList.AllowUserToResizeRows = false;
        }

        void LoadRepurchaseList()
        {
            dtgvRepurchaseList.DataSource = RepurchaseDAO.Instance.GetRepurchaseBills();
            dtgvRepurchaseList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRepurchaseList.AllowUserToResizeRows = false;
        }

        void LoadWarrantyBillList()
        {
            dtgvWarrantyBillList.DataSource = ProductWarrantyDAO.Instance.GetProductWarranty();
            dtgvWarrantyBillList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvWarrantyBillList.AllowUserToResizeRows = false;
        }

        void LoadOrderBillList()
        {
            dtgvOrderList.DataSource = OrderBillsDAO.Instance.GetOrderBills();
            dtgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvOrderList.AllowUserToResizeRows = false;
        }

        void LoadImportingBillList()
        {
            dtgvImportingBillList.DataSource = ImportingBillsDAO.Instance.GetImportingBills();
            dtgvImportingBillList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvImportingBillList.AllowUserToResizeRows = false;
        }

        private void btnExportSales_Click(object sender, EventArgs e)
        {
            ReportToExcel excel = new ReportToExcel();

            DataTable dt = (DataTable)dtgvSellingBillList.DataSource;
            excel.ExportSales(dt, "Bán hàng", "DANH SÁCH HÀNG BÁN");
        }

        private void btnExportWarranty_Click(object sender, EventArgs e)
        {
            ReportToExcel excel = new ReportToExcel();

            DataTable dt = (DataTable)dtgvWarrantyBillList.DataSource;
            excel.ExportWarranty(dt, "Bảo hành", "DANH SÁCH BẢO HÀNH");
        }

        private void btnExportOrder_Click(object sender, EventArgs e)
        {
            ReportToExcel excel = new ReportToExcel();

            DataTable dt = (DataTable)dtgvOrderList.DataSource;
            excel.ExportOrder(dt, "Đặt hàng", "DANH SÁCH ĐƠN ĐẶT HÀNG");
        }

        private void btnExportImporting_Click(object sender, EventArgs e)
        {
            ReportToExcel excel = new ReportToExcel();

            DataTable dt = (DataTable)dtgvImportingBillList.DataSource;
            excel.ExportImporting(dt, "Nhập hàng", "DANH SÁCH NHẬP HÀNG");
        }

        private void btnExportRepurchase_Click(object sender, EventArgs e)
        {
            ReportToExcel excel = new ReportToExcel();

            DataTable dt = (DataTable)dtgvRepurchaseList.DataSource;
            excel.ExportRepuchase(dt, "Mua lại", "DANH SÁCH HÀNG MUA LẠI");
        }

        private void btnSalesFilter_Click(object sender, EventArgs e)
        {
            string dateStart = dtpkSellingDate1.Text;
            string dateEnd = dtpkSellingDate2.Text;
            dtgvSellingBillList.DataSource = SellingBillsDAO.Instance.GetSellingBillsByDate(dateStart,dateEnd);
        }

        private void btnRepurchaseFilter_Click(object sender, EventArgs e)
        {
            string dateStart = dtpkRepurchaseDate1.Text;
            string dateEnd = dtpkRepurchaseDate2.Text;
            dtgvRepurchaseList.DataSource = RepurchaseDAO.Instance.GetRepurchaseBillsByDate(dateStart,dateEnd);
        }

        private void btnWarrantyFilter_Click(object sender, EventArgs e)
        {
            string dateStart = dtpkWarrantyDate1.Text;
            string dateEnd = dtpkWarrantyDate2.Text;
            dtgvWarrantyBillList.DataSource = ProductWarrantyDAO.Instance.GetProductWarrantyByDate(dateStart,dateEnd);
        }

        private void btnOrderFilter_Click(object sender, EventArgs e)
        {
            string dateStart = dtpkOrderDate1.Text;
            string dateEnd = dtpkOrderDate2.Text;
            if (rdbFilterByOrder.Checked)
            {
                dtgvOrderList.DataSource = OrderBillsDAO.Instance.GetOrderBillsByOrderDate(dateStart,dateEnd);
            }
            else
            {
                dtgvOrderList.DataSource = OrderBillsDAO.Instance.GetOrderBillsByReceiveDate(dateStart, dateEnd);
            }
        }

        private void btnImportingFilter_Click(object sender, EventArgs e)
        {
            string dateStart = dtpkImportingDate1.Text;
            string dateEnd = dtpkImportingDate2.Text;
            dtgvImportingBillList.DataSource = ImportingBillsDAO.Instance.GetImportingBillsByDate(dateStart,dateEnd);
        }
    }
}
