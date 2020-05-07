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
    public partial class WarrantyControl : UserControl
    {
        public WarrantyControl()
        {
            InitializeComponent();
        }

        string sbid;

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
            txtPWIDInfo.Text = "";
            txtSBIDInfo.Text = "";
            nmrProductCount.Text = "0";
            txtPrice.Text = "0";
        }

        int CountWarrantyByPIDAndSBID(string productid, string sbid)
        {
            if (ProductWarrantyDAO.Instance.HaveAPWByPIDAndSBID(productid,sbid))
            {
                return ProductWarrantyDAO.Instance.WarrantiedCount(productid,sbid);
            }
            else
            {
                return 0;
            }
        }

        void CreateWarranty()
        {
            string productid = txtProductID.Text;
            string pwnow = DateTime.Now.Date.ToString();

            if (ProductWarrantyDAO.Instance.InsertWarranty(sbid,productid,pwnow))
            {
                MessageBox.Show("Thêm hoá đơn thành công!", "Thông báo!");
                txtPWID.Text = ProductWarrantyDAO.Instance.GetMaxId();

                frmSalesManagement.IsBusy = true;
            }
            else
            {
                MessageBox.Show("Thêm hoá đơn thất bại!", "Thông báo!");
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
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã hoá đơn bán!","Thông báo!");
            }
        }

        private void txtProductCount_TextChanged(object sender, EventArgs e)
        {
            txtFreeWarrantyCount.Text = (Convert.ToInt32(txtProductCount.Text) * 5 - CountWarrantyByPIDAndSBID(txtProductID.Text,sbid)).ToString();

            if (Convert.ToInt32(txtFreeWarrantyCount.Text) < 0) txtFreeWarrantyCount.Text = "0";
        }

        private void btnAddWarrantyBill_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi tạo hoá đơn!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn muốn tạo hoá đơn bảo hành với sản phẩm " + txtProductID.Text + "?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CreateWarranty();
                btnAddWarrantyBill.Enabled = false;
                btnDeleteWarrantyBill.Enabled = true;
                btnPayWarrantyBill.Enabled = true;
                grbWarrantyInfo.Enabled = true;

                dtgvSellingBill.Enabled = false;
                txtProductIDInfo.Text = txtProductID.Text;
                txtSBIDInfo.Text = txtSBID.Text;
                txtPWIDInfo.Text = txtPWID.Text;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nmrProductCount.Text) > Convert.ToInt32(txtProductCount.Text)) nmrProductCount.Text = txtProductCount.Text;
            if (Convert.ToInt32(nmrProductCount.Text) - Convert.ToInt32(txtFreeWarrantyCount.Text) > 0)
            {
                txtPrice.Enabled = true;
                txtPrice.Focus();
                txtPrice.SelectAll();
            }
            else
            {
                txtPrice.Enabled = false;
                txtPrice.Text = "0";
            }
        }

        private void btnDeleteWarrantyBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xoá hoá đơn: " + txtPWID.Text, "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = txtPWID.Text;

                if (ProductWarrantyDAO.Instance.DeleteWarranty(id))
                {
                    MessageBox.Show("Xoá hoá đơn thành công!");
                    ClearData();
                    dtgvSellingBill.DataSource = null;
                    btnAddWarrantyBill.Enabled = true;
                    btnDeleteWarrantyBill.Enabled = false;
                    btnPayWarrantyBill.Enabled = false;
                    grbWarrantyInfo.Enabled = false;
                    txtPWID.Text = "Tự động";
                    txtSBID.Text = "";

                    frmSalesManagement.IsBusy = false;
                }
                else
                {
                    MessageBox.Show("Xoá hoá đơn thất bại!");
                }
            }
        }

        private void btnPayWarrantyBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thanh toán hoá đơn: " + txtPWID.Text + "?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string pwid = txtPWID.Text;
                string pwcount = nmrProductCount.Text;
                string pwtotalprice = txtPrice.Text;

                if (ProductWarrantyDAO.Instance.PayTheBill(pwid, pwcount, pwtotalprice))
                {
                    MessageBox.Show("Thanh toán hoá đơn thành công!");
                    ClearData();
                    dtgvSellingBill.DataSource = null;
                    btnAddWarrantyBill.Enabled = true;
                    btnDeleteWarrantyBill.Enabled = false;
                    btnPayWarrantyBill.Enabled = false;
                    grbWarrantyInfo.Enabled = false;
                    txtPWID.Text = "Tự động";
                    txtSBID.Text = "";
                    frmSalesManagement.IsBusy = false;
                }
                else
                {
                    MessageBox.Show("Thanh toán hoá đơn thất bại!");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (txtPWID.Text == "Tự động")
            {
                Controls.Clear();
                HomePage myControl = new HomePage();
                Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
                frmSalesManagement.IsBusy = false;
            }
            else
            {
                MessageBox.Show("Chưa hoàn thành hoá đơn bảo hành!\nHãy thanh toán hoặc huỷ hoá đơn!", "Thông báo!");
            }
        }

        private void btnListWarranty_Click(object sender, EventArgs e)
        {
            frmWarrantyBillsList f = new frmWarrantyBillsList();
            f.ShowDialog();
        }
    }
}
