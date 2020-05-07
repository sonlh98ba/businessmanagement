using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCN2.DTO;
using TTCN2.DAO;
using TTCN2.GUI;

namespace TTCN2
{
    public partial class SalesControl : UserControl
    {
        public SalesControl()
        {
            InitializeComponent();
            Loading();
        }

        void Loading()
        {
            dtpkNow.Value = DateTime.Now;
            LoadListOrdered();
            LoadListCustomer();
            LoadListEmployee();

            fpnlCatalogue.Controls.Clear();
            dtgvProduct.DataSource = null;

            List<Catalogue> catalogueList = CatalogueDAO.Instance.LoadCatalogue();
            foreach (var item in catalogueList)
            {
                Button btn = new Button();
                btn.Size = new Size(129, 30);
                btn.Text = item.Name;
                btn.Click += Btn_Click;
                btn.Tag = item;

                fpnlCatalogue.Controls.Add(btn);
            }
        }

        void ShowProduct(string CatalogueID)
        {
            DataTable data = ProductDAO.Instance.GetProductByCatalogueID(CatalogueID);
            dtgvProduct.DataSource = data;
            dtgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvProduct.AllowUserToResizeRows = false;
            dtgvProduct.Columns[1].Visible = false;
            dtgvProduct.Columns[3].Visible = false;
            dtgvProduct.Columns[5].Visible = false;
            dtgvProduct.Columns[6].Visible = false;
            dtgvProduct.Columns[7].Visible = false;
            dtgvProduct.Columns[8].Visible = false;
            dtgvProduct.Columns[9].Visible = false;
            dtgvProduct.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dtgvProduct.RowCount > 0) AddProductBinding();
        }

        void ClearData()
        {
            // Cắt kết nối DataBinding
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtGemWeight.DataBindings.Clear();
            txtProductWeight.DataBindings.Clear();
            lblProductInventory.DataBindings.Clear();
            txtProductPrice.DataBindings.Clear();
            txtProcessFee.DataBindings.Clear();
            pcbProductPic.DataBindings.Clear();

            // Dọn sạch thông tin
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtGemWeight.Text = "0";
            txtProductWeight.Text = "0";
            lblProductInventory.Text = "{Rỗng}";
            txtProductPrice.Text = "0";
            txtProcessFee.Text = "0";
            pcbProductPic.ImageLocation = null;
        }

        void ClearCart()
        {
            // Cắt kết nối DataBinding
            txtProductIDCart.DataBindings.Clear();
            nmrCount.DataBindings.Clear();
            txtPrice1Cart.DataBindings.Clear();
            txtTotalPricebyProduct.DataBindings.Clear();
            txtTotalDeposit.DataBindings.Clear();

            // Dọn sạch thông tin
            txtProductIDCart.Text = "";
            nmrCount.Value = 0;
            txtPrice1Cart.Text = "0";
            txtTotalPricebyProduct.Text = "0";
            txtTotalDeposit.Text = "0";
            txtTotalDepositCart.Text = "0";
            txtTotalPrice.Text = "0";
            txtBonusFee.Text = "0";
            txtFinalPay.Text = "0";
        }

        // Tạo kết nối DataBinding
        void AddProductBinding()
        {
            txtProductID.DataBindings.Clear();
            txtProductID.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "Mã SP"));

            txtProductName.DataBindings.Clear();
            txtProductName.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "Tên SP"));

            txtGemWeight.DataBindings.Clear();
            txtGemWeight.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "TL Đá"));

            txtProductWeight.DataBindings.Clear();
            txtProductWeight.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "TL SP"));

            lblProductInventory.DataBindings.Clear();
            lblProductInventory.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "Tồn kho"));

            txtProductPrice.DataBindings.Clear();
            txtProductPrice.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "Giá"));

            txtProcessFee.DataBindings.Clear();
            txtProcessFee.DataBindings.Add(new Binding("Text", dtgvProduct.DataSource, "Phí GC"));

            pcbProductPic.DataBindings.Clear();
            pcbProductPic.DataBindings.Add(new Binding("ImageLocation", dtgvProduct.DataSource, "PRODUCTPICTURE"));
            pcbProductPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        void AddCartBinding()
        {
            txtProductIDCart.DataBindings.Clear();
            txtProductIDCart.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Mã SP"));

            nmrCount.DataBindings.Clear();
            nmrCount.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Số lượng"));

            txtPrice1Cart.DataBindings.Clear();
            txtPrice1Cart.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Thành tiền"));

            txtTotalPricebyProduct.DataBindings.Clear();
            txtTotalPricebyProduct.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Tổng tiền"));

            txtTotalDeposit.DataBindings.Clear();
            txtTotalDeposit.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Tổng cọc"));
        }

        void LoadListOrdered()
        {
            cbbOrderedBill.Items.Clear();
            List<OrderBills> orderedBillsList = OrderBillsDAO.Instance.LoadOrderBills();
            foreach (var item in orderedBillsList)
            {
                cbbOrderedBill.Items.Add(item.OBID);
            }
        }

        void LoadListCustomer()
        {
            cbbCustomer.Items.Clear();
            List<Customer> customerList = CustomerDAO.Instance.LoadCustomer();
            foreach (var item in customerList)
            {
                cbbCustomer.Items.Add(item.CustomerPhone);
            }
        }

        void LoadListEmployee()
        {
            cbbExraEmployee.Items.Clear();
            List<Employees> employeesList = EmployeesDAO.Instance.LoadEmployees();
            foreach (var item in employeesList)
            {
                if (item.UserName != frmSalesManagement.USERNAME) cbbExraEmployee.Items.Add(item.UserName);
            }
        }

        void LoadListPromotions(string productid)
        {
            cbbPromotionsList.Items.Clear();
            List<PromotionDetail> promotionsList = PromotionsDAO.Instance.LoadPromotions(productid);
            foreach (var item in promotionsList)
            {
                cbbPromotionsList.Items.Add(item.PromotionID);
            }
        }

        void UpdateDiscount()
        {
            if (cbbPromotionsList.Text != "")
            {
                txtDiscountByPromotion.Text = (Convert.ToDouble(txtProductPrice.Text) * PromotionsDAO.Instance.GetDiscountByPromotionsID(cbbPromotionsList.SelectedItem.ToString()) / 100).ToString();
            }
            else
            {
                txtDiscountByPromotion.Text = "0";
            }
        }

        void UpdatePayment()
        {
            if (txtProductID.Text != "")
            {
                txtPaymentCurrency.Text = (Convert.ToDouble(txtProductPrice.Text) + Convert.ToDouble(txtProcessFee.Text) - Convert.ToDouble(txtDiscountByPromotion.Text)).ToString();
                txtPaymentForeignCurrency.Text = (Math.Round(Convert.ToDouble(txtPaymentCurrency.Text) / Convert.ToInt32(txtExchangeRate.Text), 2)).ToString();
            }
            else
            {
                txtPaymentCurrency.Text = "0";
                txtPaymentForeignCurrency.Text = "0";
            }
        }

        void CreateSellingBill()
        {
            string maineid = frmSalesManagement.USERNAME;
            string extraeid = cbbExraEmployee.Text;
            string customerphone = cbbCustomer.Text;
            string sbdate = dtpkNow.Text;

            if (SellingBillsDAO.Instance.InsertSellingBills(maineid, extraeid, customerphone, sbdate))
            {
                MessageBox.Show("Thêm hoá đơn thành công!","Thông báo!");
                txtSbID.Text = SellingBillsDAO.Instance.GetMaxId();
            }
            else
            {
                MessageBox.Show("Thêm hoá đơn thất bại!","Thông báo!");
            }
        }

        void ShowCart()
        {
            dtgvCart.DataSource = SellingBillsDAO.Instance.GetCartBySbID(txtSbID.Text);
            dtgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCart.AllowUserToResizeRows = false;
            dtgvCart.Columns["Mã HĐ"].Visible = false;
            dtgvCart.Columns["Tổng cọc"].Visible = false;
            txtTotalPrice.Text = SellingDetailDAO.Instance.GetTotalPricebySbID(txtSbID.Text);
            txtTotalDepositCart.Text = SellingDetailDAO.Instance.GetTotalDepositbySbID(txtSbID.Text);
            if (int.TryParse(txtBonusFee.Text, out int a) == false) txtBonusFee.Text = "0";
            txtFinalPay.Text = (Convert.ToInt32(txtTotalPrice.Text) - Convert.ToInt32(txtTotalDepositCart.Text) + Convert.ToInt32(txtBonusFee.Text)).ToString();
            if (dtgvCart.RowCount > 0) AddCartBinding();
        }

        // Click nút trong FlowLayoutPanel
        private void Btn_Click(object sender, EventArgs e)
        {
            ClearData(); // Dọn sạch data đã binding
            string CatalogueID = ((sender as Button).Tag as Catalogue).ID;
            ShowProduct(CatalogueID);
            UpdatePayment();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (txtSbID.Text == "Tự động")
            {
                Controls.Clear();
                HomePage myControl = new HomePage();
                Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
                frmSalesManagement.IsBusy = false;
            }
            else
            {
                MessageBox.Show("Chưa hoàn thành hoá đơn bán!\nHãy thanh toán hoặc huỷ hoá đơn!","Thông báo!");
            }
        }

        private void ckbOrdered_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOrdered.Checked)
            {
                cbbOrderedBill.Enabled = true;
            }
            else
            {
                cbbOrderedBill.Enabled = false;
                cbbOrderedBill.SelectedItem = null;
            }
        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {
            txtProductPriceUSD.Text = (Math.Round(Convert.ToDouble(txtProductPrice.Text) / Convert.ToInt32(txtExchangeRate.Text), 2)).ToString();
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            cbbPromotionsList.Items.Clear();
            UpdatePayment();

            if (txtProductID.Text != "")
            {
                LoadListPromotions(txtProductID.Text);
                UpdateDiscount();
            }
        }

        private void cbbPromotionsList_TextChanged(object sender, EventArgs e)
        {
            UpdateDiscount();
            UpdatePayment();
        }

        private void btnListSellingBill_Click(object sender, EventArgs e)
        {
            frmSellingBillsList f = new frmSellingBillsList();
            f.ShowDialog();
        }

        private void btnCustomerRegistry_Click(object sender, EventArgs e)
        {
            frmCustomerRegistry f = new frmCustomerRegistry();
            f.ShowDialog();
            LoadListCustomer();
        }

        private void btnAddSellingBill_Click(object sender, EventArgs e)
        {
            if (cbbExraEmployee.Text == "" || cbbCustomer.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên phụ và khách hàng!", "Thông báo");
                return;
            }
            if (cbbExraEmployee.Text == frmSalesManagement.USERNAME)
            {
                MessageBox.Show("Nhân viên phụ trùng nhân viên chính!", "Thông báo");
                return;
            }

            CreateSellingBill();
            ShowCart();
            btnAddSellingBill.Enabled = false;
            btnDeleteSellingBill.Enabled = true;
            btnPaySellingBill.Enabled = true;
            fpnlCatalogue.Enabled = true;
            pnlProductInfo.Enabled = true;

            frmSalesManagement.IsBusy = true;
        }

        private void btnDeleteSellingBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xoá hoá đơn: " + txtSbID.Text, "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = txtSbID.Text;

                if (SellingBillsDAO.Instance.DeleteSellingBills(id))
                {
                    MessageBox.Show("Xoá hoá đơn thành công!");
                    ClearData();
                    ClearCart();
                    dtgvProduct.DataSource = null;
                    dtgvCart.DataSource = null;
                    fpnlCatalogue.Enabled = false;
                    btnAddSellingBill.Enabled = true;
                    btnDeleteSellingBill.Enabled = false;
                    btnPaySellingBill.Enabled = false;
                    txtSbID.Text = "Tự động";
                    pnlProductInfo.Enabled = false;

                    frmSalesManagement.IsBusy = false;
                }
                else
                {
                    MessageBox.Show("Xoá hoá đơn thất bại!");
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong danh sách!","Thông báo!");
                return;
            }

            if (SellingDetailDAO.Instance.IndenticalCheck(txtProductID.Text,txtSbID.Text))
            {
                MessageBox.Show("Sản phẩm đã tồn tại trong giỏ hàng!\nVui lòng tăng hoặc giảm số lượng tại thông tin giỏ hàng!");
                return;
            }

            string sbid = txtSbID.Text;
            string productid = txtProductID.Text;
            string productprice = txtPaymentCurrency.Text;
            string promotionid = cbbPromotionsList.Text;
            if (promotionid == "") promotionid = "null";
            else promotionid = "N'" + cbbPromotionsList.Text + "'";

            SellingDetailDAO.Instance.InsertSellingDetail(sbid, productid, "1", productprice, productprice, promotionid, "0");
            ShowCart();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (txtProductIDCart.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ hàng!", "Thông báo!");
                return;
            }

            SellingDetailDAO.Instance.DeleteSellingDetailByProductID(txtProductIDCart.Text);
            ClearCart();
            ShowCart();
        }

        private void txtBonusFee_TextChanged(object sender, EventArgs e)
        {
            if (dtgvCart.DataSource != null && dtgvCart.RowCount > 0) ShowCart();
        }

        private void btnEditNmrCount_Click(object sender, EventArgs e)
        {
            string sdcount = nmrCount.Value.ToString();
            string productid = txtProductIDCart.Text;
            string sbid = txtSbID.Text;
            string productprice = txtPrice1Cart.Text;

            SellingDetailDAO.Instance.UpdateCountSellingDetail(sdcount, productprice, productid, sbid);
            ShowCart();
        }

        private void btnPaySellingBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thanh toán hoá đơn: " + txtSbID.Text + "?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sbid = txtSbID.Text;
                string sbbonusfee = txtBonusFee.Text;
                string sbbonuscontent = txtBonusContent.Text;
                string sbtotalprice = txtFinalPay.Text;

                if (SellingBillsDAO.Instance.PayTheBill(sbid, sbbonusfee, sbbonuscontent, sbtotalprice))
                {
                    MessageBox.Show("Thanh toán hoá đơn thành công!");
                    dtgvProduct.DataSource = null;
                    dtgvCart.DataSource = null;
                    ClearData();
                    ClearCart();
                    fpnlCatalogue.Enabled = false;
                    btnAddSellingBill.Enabled = true;
                    btnDeleteSellingBill.Enabled = false;
                    btnPaySellingBill.Enabled = false;
                    txtSbID.Text = "Tự động";
                    pnlProductInfo.Enabled = false;

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
