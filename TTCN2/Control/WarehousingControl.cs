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
    public partial class WarehousingControl : UserControl
    {
        public WarehousingControl()
        {
            InitializeComponent();
            Loading();
        }

        void Loading()
        {
            dtpkNow.Value = DateTime.Now;

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

        void ClearData()
        {
            // Cắt kết nối DataBinding
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtGemWeight.DataBindings.Clear();
            txtProductWeight.DataBindings.Clear();
            lblProductInventory.DataBindings.Clear();
            txtProductPrice.DataBindings.Clear();
            pcbProductPic.DataBindings.Clear();

            // Dọn sạch thông tin
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtGemWeight.Text = "0";
            txtProductWeight.Text = "0";
            lblProductInventory.Text = "{Rỗng}";
            txtProductPrice.Text = "0";
            pcbProductPic.ImageLocation = null;
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

            pcbProductPic.DataBindings.Clear();
            pcbProductPic.DataBindings.Add(new Binding("ImageLocation", dtgvProduct.DataSource, "PRODUCTPICTURE"));
            pcbProductPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        void CreateImportingBill()
        {
            string ibid = txtIBID.Text;
            string username = frmSalesManagement.USERNAME;
            string importingdate = dtpkNow.Text;

            if (ImportingBillsDAO.Instance.InsertImportingBills(username, importingdate))
            {
                MessageBox.Show("Thêm đơn nhập hàng thành công!", "Thông báo!");
                txtIBID.Text = ImportingBillsDAO.Instance.GetMaxId();
            }
            else
            {
                MessageBox.Show("Thêm đơn nhập hàng thất bại!", "Thông báo!");
            }
        }

        void ShowCart()
        {
            dtgvCart.DataSource = ImportingBillsDAO.Instance.GetCartByIBID(txtIBID.Text);
            dtgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCart.AllowUserToResizeRows = false;
            txtTotalCount.Text = ImportingDetailDAO.Instance.GetTotalCountbyIBID(txtIBID.Text);
            txtTotalWeight.Text = ImportingDetailDAO.Instance.GetTotalWeightbyIBID(txtIBID.Text);
            txtNote.Text = ImportingDetailDAO.Instance.GetNotebyIBID(txtIBID.Text);
            if (dtgvCart.RowCount > 0) AddCartBinding();
        }

        void AddCartBinding()
        {
            txtProductIDCart.DataBindings.Clear();
            txtProductIDCart.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Mã SP"));

            nmrCount.DataBindings.Clear();
            nmrCount.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Số lượng"));

            txtTotalProductWeight.DataBindings.Clear();
            txtTotalProductWeight.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Tổng TL"));

            txtProductDescribe.DataBindings.Clear();
            txtProductDescribe.DataBindings.Add(new Binding("Text", dtgvCart.DataSource, "Mô tả"));
        }

        void ClearCart()
        {
            // Cắt kết nối DataBinding
            txtProductIDCart.DataBindings.Clear();
            nmrCount.DataBindings.Clear();
            txtTotalProductWeight.DataBindings.Clear();
            txtProductDescribe.DataBindings.Clear();

            // Dọn sạch thông tin
            txtProductIDCart.Text = "";
            nmrCount.Value = 0;
            txtTotalProductWeight.Text = "0";
            txtProductDescribe.Text = "";
            txtNote.Text = "";
            txtTotalCount.Text = "0";
            txtTotalWeight.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (txtIBID.Text == "Tự động")
            {
                Controls.Clear();
                HomePage myControl = new HomePage();
                Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
                frmSalesManagement.IsBusy = false;
            }
            else
            {
                MessageBox.Show("Chưa hoàn thành hoá đơn nhập hàng!\nHãy nhập hàng hoặc huỷ hoá đơn!", "Thông báo!");
            }
        }

        // Click nút trong FlowLayoutPanel
        private void Btn_Click(object sender, EventArgs e)
        {
            ClearData(); // Dọn sạch data đã binding
            string CatalogueID = ((sender as Button).Tag as Catalogue).ID;
            ShowProduct(CatalogueID);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            frmWarehousingBillsList f = new frmWarehousingBillsList();
            f.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateImportingBill();
            ShowCart();
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnImport.Enabled = true;
            fpnlCatalogue.Enabled = true;
            pnlProductInfo.Enabled = true;

            frmSalesManagement.IsBusy = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xoá đơn nhập hàng: " + txtIBID.Text, "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = txtIBID.Text;

                if (ImportingBillsDAO.Instance.DeleteImportingBills(id))
                {
                    MessageBox.Show("Huỷ hoá đơn nhập hàng thành công!");
                    ClearData();
                    ClearCart();
                    dtgvProduct.DataSource = null;
                    dtgvCart.DataSource = null;
                    fpnlCatalogue.Enabled = false;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = false;
                    btnImport.Enabled = false;
                    txtIBID.Text = "Tự động";
                    pnlProductInfo.Enabled = false;

                    frmSalesManagement.IsBusy = false;
                }
                else
                {
                    MessageBox.Show("Xoá hoá đơn nhập hàng thất bại!");
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong danh sách!", "Thông báo!");
                return;
            }

            if (ImportingDetailDAO.Instance.IndenticalCheck(txtProductID.Text, txtIBID.Text))
            {
                MessageBox.Show("Sản phẩm đã tồn tại trong giỏ hàng!\nVui lòng tăng hoặc giảm số lượng tại thông tin giỏ hàng!");
                return;
            }

            string ibid = txtIBID.Text;
            string productid = txtProductID.Text;
            string totalweight = (Convert.ToInt32(txtProductWeight.Text) + Convert.ToInt32(txtGemWeight.Text)).ToString();

            ImportingDetailDAO.Instance.InsertImportingDetail(ibid, productid, "1", totalweight, "");
            ShowCart();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (txtProductIDCart.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong hoá đơn nhập!", "Thông báo!");
                return;
            }

            ImportingDetailDAO.Instance.DeleteImportingDetailByProductID(txtProductIDCart.Text);
            ClearCart();
            ShowCart();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string idcount = nmrCount.Value.ToString();
            string productid = txtProductIDCart.Text;
            string ibid = txtIBID.Text;
            string productdescribe = txtProductDescribe.Text;
            string totalweight = (Convert.ToInt32(txtProduct1Weight.Text) * nmrCount.Value).ToString();

            string note = txtNote.Text;

            ImportingDetailDAO.Instance.UpdateImportingDetail(idcount, totalweight, productdescribe, productid, ibid);
            ImportingBillsDAO.Instance.UpdateImportingNote(note, ibid);
            ShowCart();
        }

        private void txtTotalProductWeight_TextChanged(object sender, EventArgs e)
        {
            if (nmrCount.Value != 0) txtProduct1Weight.Text = (Convert.ToInt32(txtTotalProductWeight.Text) / nmrCount.Value).ToString();
            else txtProduct1Weight.Text = "0";
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn nhập hoá đơn: " + txtIBID.Text + "?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string ibid = txtIBID.Text;
                string totalcount = txtTotalCount.Text;

                if (ImportingBillsDAO.Instance.ImportBill(ibid, totalcount))
                {
                    MessageBox.Show("Nhập hàng thành công!");
                    ClearData();
                    ClearCart();
                    dtgvProduct.DataSource = null;
                    dtgvCart.DataSource = null;
                    fpnlCatalogue.Enabled = false;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = false;
                    btnImport.Enabled = false;
                    txtIBID.Text = "Tự động";
                    pnlProductInfo.Enabled = false;
                    frmSalesManagement.IsBusy = false;
                }
                else
                {
                    MessageBox.Show("Nhập hàng thất bại!");
                }
            }
        }
    }
}
