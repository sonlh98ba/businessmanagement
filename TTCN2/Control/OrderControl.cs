using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCN2.GUI;
using TTCN2.DTO;
using TTCN2.DAO;

namespace TTCN2
{
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            Loading();
        }

        void Loading()
        {
            dtpkReceivedate.Value = DateTime.Now;
            LoadListCustomer();

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

        void LoadListCustomer()
        {
            cbbCustomer.Items.Clear();
            List<Customer> customerList = CustomerDAO.Instance.LoadCustomer();
            foreach (var item in customerList)
            {
                cbbCustomer.Items.Add(item.CustomerPhone);
            }
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

        void AddCartBinding()
        {
            txtProductIDCart.DataBindings.Clear();
            txtProductIDCart.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Mã SP"));

            nmrCount.DataBindings.Clear();
            nmrCount.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Số lượng"));

            txtPrice1Cart.DataBindings.Clear();
            txtPrice1Cart.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Giá SP"));

            txtTotalDepositCart.DataBindings.Clear();
            txtTotalDepositCart.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Đặt cọc"));
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

        void CreateOrderBill()
        {
            string obid = txtOBID.Text;
            string maineid = frmSalesManagement.USERNAME;
            string customerphone = cbbCustomer.Text;
            string sbnow = DateTime.Now.Date.ToString();

            if (OrderBillsDAO.Instance.InsertOrderBills(maineid, customerphone, sbnow))
            {
                MessageBox.Show("Thêm đơn đặt hàng thành công!", "Thông báo!");
                txtOBID.Text = OrderBillsDAO.Instance.GetMaxId();
                frmSalesManagement.IsBusy = true;
            }
            else
            {
                MessageBox.Show("Thêm đơn đặt hàng thất bại!", "Thông báo!");
            }
        }

        void ShowCart()
        {
            dtgvCart.DataSource = OrderBillsDAO.Instance.GetCartByOBID(txtOBID.Text);
            dtgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCart.AllowUserToResizeRows = false;
            txtTotalPrice.Text = OrderDetailDAO.Instance.GetTotalPricebyOBID(txtOBID.Text);
            txtTotalDeposit.Text = OrderDetailDAO.Instance.GetTotalDepositbyOBID(txtOBID.Text);
            if (dtgvCart.RowCount > 0) AddCartBinding();
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

        void ClearCart()
        {
            // Cắt kết nối DataBinding
            txtProductIDCart.DataBindings.Clear();
            nmrCount.DataBindings.Clear();
            txtPrice1Cart.DataBindings.Clear();
            txtTotalDepositCart.DataBindings.Clear();

            // Dọn sạch thông tin
            txtProductIDCart.Text = "";
            nmrCount.Value = 0;
            txtPrice1Cart.Text = "0";
            txtTotalDeposit.Text = "0";
            txtTotalDepositCart.Text = "0";
            txtTotalPrice.Text = "0";
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
            if (txtOBID.Text == "Tự động")
            {
                Controls.Clear();
                HomePage myControl = new HomePage();
                Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
                frmSalesManagement.IsBusy = false;
            }
            else
            {
                MessageBox.Show("Chưa hoàn thành đơn đặt hàng!\nHãy hoàn thành hoặc huỷ đơn!", "Thông báo!");
            }
        }

        private void btnCustomerRegistry_Click(object sender, EventArgs e)
        {
            frmCustomerRegistry f = new frmCustomerRegistry();
            f.ShowDialog();
            LoadListCustomer();
        }

        private void btnAddOrderBill_Click(object sender, EventArgs e)
        {
            if (cbbCustomer.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "Thông báo");
                return;
            }

            CreateOrderBill();
            ShowCart();
            btnAddOrderBill.Enabled = false;
            btnCancelOrderBill.Enabled = true;
            btnPayDeposit.Enabled = true;
            fpnlCatalogue.Enabled = true;
            pnlProductInfo.Enabled = true;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong danh sách!", "Thông báo!");
                return;
            }

            if (OrderDetailDAO.Instance.IndenticalCheck(txtProductID.Text, txtOBID.Text))
            {
                MessageBox.Show("Sản phẩm đã tồn tại trong giỏ hàng!\nVui lòng tăng hoặc giảm số lượng tại thông tin giỏ hàng!");
                return;
            }

            string obid = txtOBID.Text;
            string productid = txtProductID.Text;
            string productprice = txtProductPrice.Text;

            OrderDetailDAO.Instance.InsertOrderDetail(obid, productid, "0", productprice, "");
            ShowCart();
        }

        private void btnEditNmrCount_Click(object sender, EventArgs e)
        {
            string odcount = nmrCount.Value.ToString();
            string productid = txtProductIDCart.Text;
            string obid = txtOBID.Text;
            string deposit = txtDepositOneCart.Text;

            OrderDetailDAO.Instance.UpdateCountOrderDetail(odcount, deposit, productid, obid);
            ShowCart();
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

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (txtProductIDCart.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ hàng!", "Thông báo!");
                return;
            }

            OrderDetailDAO.Instance.DeleteOrderDetailByProductID(txtProductIDCart.Text);
            ClearCart();
            ShowCart();
        }

        private void btnCancelOrderBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn huỷ đơn đặt hàng: " + txtOBID.Text, "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = txtOBID.Text;

                if (OrderBillsDAO.Instance.DeleteOrderBills(id))
                {
                    MessageBox.Show("Huỷ đơn đặt hàng thành công!");
                    ClearData();
                    ClearCart();
                    dtgvProduct.DataSource = null;
                    dtgvCart.DataSource = null;
                    fpnlCatalogue.Enabled = false;
                    btnAddOrderBill.Enabled = true;
                    btnCancelOrderBill.Enabled = false;
                    btnPayDeposit.Enabled = false;
                    txtOBID.Text = "Tự động";
                    pnlProductInfo.Enabled = false;

                    frmSalesManagement.IsBusy = false;
                }
                else
                {
                    MessageBox.Show("Xoá hoá đơn thất bại!");
                }
            }
        }

        private void btnPayDeposit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thanh toán đặt cọc: " + txtOBID.Text + "?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string obid = txtOBID.Text;
                string receivedate = dtpkReceivedate.Text;
                string obmoney = txtTotalDeposit.Text;

                if (OrderBillsDAO.Instance.PayTheDeposit(obid, receivedate, obmoney))
                {
                    MessageBox.Show("Thanh toán đặt cọc đơn đặt hàng thành công!");
                    ClearData();
                    ClearCart();
                    dtgvProduct.DataSource = null;
                    dtgvCart.DataSource = null;
                    fpnlCatalogue.Enabled = false;
                    btnAddOrderBill.Enabled = true;
                    btnCancelOrderBill.Enabled = false;
                    btnPayDeposit.Enabled = false;
                    txtOBID.Text = "Tự động";
                    pnlProductInfo.Enabled = false;

                    frmSalesManagement.IsBusy = false;
                }
                else
                {
                    MessageBox.Show("Thanh toán đặt cọc đơn đặt hàng thất bại!");
                }
            }
        }

        private void btnListOrderBill_Click(object sender, EventArgs e)
        {
            frmOrderBillsList f = new frmOrderBillsList();
            f.ShowDialog();
        }
    }
}
