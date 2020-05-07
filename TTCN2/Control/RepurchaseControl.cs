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
using TTCN2.GUI;

namespace TTCN2
{
    public partial class BuyControl : UserControl
    {
        string sbid;
        public BuyControl()
        {
            InitializeComponent();
        }

        void AddProductBinding()
        {
            txtProductID.DataBindings.Clear();
            txtProductID.DataBindings.Add(new Binding("Text", dtgvSellingBill.DataSource, "Mã SP"));

            txtProductPrice.DataBindings.Clear();
            txtProductPrice.DataBindings.Add(new Binding("Text", dtgvSellingBill.DataSource, "Thành tiền"));

            txtProductCount.DataBindings.Clear();
            txtProductCount.DataBindings.Add(new Binding("Text", dtgvSellingBill.DataSource, "Số lượng"));
        }

        void ClearData()
        {
            // Cắt kết nối DataBinding
            txtProductID.DataBindings.Clear();
            txtProductPrice.DataBindings.Clear();
            txtProductCount.DataBindings.Clear();

            // Dọn sạch thông tin
            txtProductID.Text = "";
            txtProductPrice.Text = "0";
            txtProductCount.Text = "0";
            txtProductIDInfo.Text = "";
            txtRepurchaseIDInfo.Text = "";
            txtSBIDInfo.Text = "";
            txtReasonInfo.Text = "";
            nmrProductCount.Text = "0";
            txtPrice.Text = "0";
        }

        void CreateRepurchase()
        {
            string productid = txtProductID.Text;
            string rnow = DateTime.Now.Date.ToString();

            if (RepurchaseDAO.Instance.InsertRepurchase(sbid, productid,rnow))
            {
                MessageBox.Show("Thêm hoá đơn thành công!", "Thông báo!");
                txtRepurchaseID.Text = RepurchaseDAO.Instance.GetMaxId();

                frmSalesManagement.IsBusy = true;
            }
            else
            {
                MessageBox.Show("Thêm hoá đơn thất bại!", "Thông báo!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (txtRepurchaseID.Text == "Tự động")
            {
                Controls.Clear();
                HomePage myControl = new HomePage();
                Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
                frmSalesManagement.IsBusy = false;
            }
            else
            {
                MessageBox.Show("Chưa hoàn thành hoá đơn mua lại!\nHãy thanh toán hoặc huỷ hoá đơn!", "Thông báo!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearData();
            if (txtSBID.Text != "")
            {
                sbid = txtSBID.Text;
                if (SellingBillsDAO.Instance.HaveASellingBill(sbid))
                {
                    dtgvSellingBill.Enabled = true;
                    pnlListProduct.Enabled = true;
                    dtgvSellingBill.DataSource = SellingDetailDAO.Instance.GetListSdbySbID(sbid);
                    dtgvSellingBill.Columns["Mã HĐ"].Visible = false;
                    dtgvSellingBill.Columns["Tổng cọc"].Visible = false;
                    AddProductBinding();
                }
                else
                {
                    MessageBox.Show("Mã hoá đơn bán không tồn tại!", "Thông báo!");
                    txtSBID.Focus();
                    txtSBID.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã hoá đơn bán!", "Thông báo!");
            }
        }

        private void btnAddRepurchaseBill_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi tạo hoá đơn!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn muốn tạo hoá đơn mua lại với sản phẩm " + txtProductID.Text + "?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CreateRepurchase();
                btnAddRepurchaseBill.Enabled = false;
                btnDeleteRepurchaseBill.Enabled = true;
                btnPayRepurchaseBill.Enabled = true;
                grbRepurchaseInfo.Enabled = true;

                dtgvSellingBill.Enabled = false;
                txtProductIDInfo.Text = txtProductID.Text;
                txtSBIDInfo.Text = txtSBID.Text;
                txtRepurchaseIDInfo.Text = txtRepurchaseID.Text;
                nmrProductCount.Maximum = Convert.ToInt32(txtProductCount.Text);
            }
        }

        private void btnDeleteRepurchaseBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xoá hoá đơn: " + txtRepurchaseID.Text, "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = txtRepurchaseID.Text;

                if (RepurchaseDAO.Instance.DeleteRepurchase(id))
                {
                    MessageBox.Show("Xoá hoá đơn thành công!");
                    ClearData();
                    dtgvSellingBill.DataSource = null;
                    btnAddRepurchaseBill.Enabled = true;
                    btnDeleteRepurchaseBill.Enabled = false;
                    btnPayRepurchaseBill.Enabled = false;
                    grbRepurchaseInfo.Enabled = false;
                    txtRepurchaseID.Text = "Tự động";
                    txtSBID.Text = "";

                    frmSalesManagement.IsBusy = false;
                }
                else
                {
                    MessageBox.Show("Xoá hoá đơn thất bại!");
                }
            }
        }

        private void btnListRepurchase_Click(object sender, EventArgs e)
        {
            frmRepurchaseBillsList f = new frmRepurchaseBillsList();
            f.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtPrice.Enabled = true;
            txtPrice.Focus();
            txtPrice.SelectAll();
        }

        private void btnPayRepurchaseBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thanh toán hoá đơn: " + txtRepurchaseID.Text + "?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string repurchaseid = txtRepurchaseID.Text;
                string rpcount = nmrProductCount.Text;
                string reason = txtReasonInfo.Text;
                string rptotalprice = txtPrice.Text;

                if (RepurchaseDAO.Instance.PayTheBill(repurchaseid, rpcount, reason, rptotalprice))
                {
                    if (nmrProductCount.Text == txtProductCount.Text)
                    {
                        // Xoá chi tiết hoá đơn bán
                        string sbid = txtSBID.Text;
                        string productid = txtProductID.Text;
                        SellingDetailDAO.Instance.DeleteSellingDetailBySbIDAndProductID(sbid,productid);
                    }
                    else
                    {
                        // Giảm lượng sp trong hoá đơn bán
                        string sbid = txtSBID.Text;
                        string productid = txtProductID.Text;
                        string productprice = txtProductPrice.Text;
                        string endcount = (Convert.ToInt32(txtProductCount.Text) - Convert.ToInt32(nmrProductCount.Text)).ToString();
                        SellingDetailDAO.Instance.UpdateCountSellingDetail(endcount, productprice, productid, sbid);
                    }
                    MessageBox.Show("Thanh toán hoá đơn thành công!");
                    ClearData();
                    dtgvSellingBill.DataSource = null;
                    btnAddRepurchaseBill.Enabled = true;
                    btnDeleteRepurchaseBill.Enabled = false;
                    btnPayRepurchaseBill.Enabled = false;
                    grbRepurchaseInfo.Enabled = false;
                    txtRepurchaseID.Text = "Tự động";
                    txtSBID.Text = "";
                    txtPrice.Enabled = false;
                    frmSalesManagement.IsBusy = false;
                }
                else
                {
                    MessageBox.Show("Thanh toán hoá đơn thất bại!");
                }
            }
        }
    }
}
