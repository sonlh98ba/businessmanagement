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
using TTCN2.DTO;

namespace TTCN2
{
    public partial class CatalogueControl : UserControl
    {
        string ProductPic = "";
        public CatalogueControl()
        {
            InitializeComponent();
            Loading();
        }

        void Loading()
        {
            fpnlCatalogue.Controls.Clear();
            cbbCatalogue.Items.Clear();
            dtgvProductList.DataSource = null;
            lblCountdtgv.Text = "0";

            List<Catalogue> catalogueList = CatalogueDAO.Instance.LoadCatalogue();
            foreach (var item in catalogueList)
            {
                Button btn = new Button();
                btn.Size = new Size(129, 30);
                btn.Text = item.Name;
                btn.Click += Btn_Click;
                btn.Tag = item;

                cbbCatalogue.Items.Add(item.ID);
                fpnlCatalogue.Controls.Add(btn);
            }
        }

        bool CheckTypeData(string productinventory, string productprice, string gemweight, string productweight, string processingfee)
        {
            bool result = true;

            result = (int.TryParse(productinventory, out int a) && int.TryParse(productprice, out a) && int.TryParse(gemweight, out a) && int.TryParse(productweight, out a) && int.TryParse(processingfee, out a));

            return result;
        }

        void ShowProduct(string CatalogueID)
        {
            DataTable data = ProductDAO.Instance.GetProductByCatalogueID(CatalogueID);
            dtgvProductList.DataSource = data;
            dtgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblCountdtgv.Text = dtgvProductList.RowCount.ToString();
            lblTotalProductCount.Text = ProductDAO.Instance.GetTotalProductAmount(); // Đếm tổng sản phẩm
            dtgvProductList.AllowUserToResizeRows = false;
            dtgvProductList.Columns[5].Visible = false;
            if (dtgvProductList.RowCount > 0) AddProductBinding();
        }

        void ClearData()
        {
            // Cắt kết nối DataBinding
            txtProductID.DataBindings.Clear();
            cbbCatalogue.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtProductInventory.DataBindings.Clear();
            txtProductPrice.DataBindings.Clear();
            txtGemWeight.DataBindings.Clear();
            txtProductWeight.DataBindings.Clear();
            txtProcessFee.DataBindings.Clear();
            txtNote.DataBindings.Clear();
            pcbProductPic.DataBindings.Clear();

            // Dọn sạch thông tin
            txtProductID.Text = "";
            cbbCatalogue.Text = "";
            txtProductName.Text = "";
            txtProductInventory.Text = "";
            txtProductPrice.Text = "";
            txtGemWeight.Text = "";
            txtProductWeight.Text = "";
            txtProcessFee.Text = "";
            txtNote.Text = "";
            pcbProductPic.ImageLocation = null;
        }

        // Tạo kết nối DataBinding
        void AddProductBinding()
        {
            txtProductID.DataBindings.Clear();
            txtProductID.DataBindings.Add(new Binding("Text", dtgvProductList.DataSource, "Mã SP"));

            cbbCatalogue.DataBindings.Clear();
            cbbCatalogue.DataBindings.Add(new Binding("Text", dtgvProductList.DataSource, "Mã loại"));

            txtProductName.DataBindings.Clear();
            txtProductName.DataBindings.Add(new Binding("Text", dtgvProductList.DataSource, "Tên SP"));

            txtProductInventory.DataBindings.Clear();
            txtProductInventory.DataBindings.Add(new Binding("Text", dtgvProductList.DataSource, "Tồn kho"));

            txtProductPrice.DataBindings.Clear();
            txtProductPrice.DataBindings.Add(new Binding("Text", dtgvProductList.DataSource, "Giá"));

            txtGemWeight.DataBindings.Clear();
            txtGemWeight.DataBindings.Add(new Binding("Text", dtgvProductList.DataSource, "TL Đá"));

            txtProductWeight.DataBindings.Clear();
            txtProductWeight.DataBindings.Add(new Binding("Text", dtgvProductList.DataSource, "TL SP"));

            txtProcessFee.DataBindings.Clear();
            txtProcessFee.DataBindings.Add(new Binding("Text", dtgvProductList.DataSource, "Phí GC"));

            txtNote.DataBindings.Clear();
            txtNote.DataBindings.Add(new Binding("Text", dtgvProductList.DataSource, "Ghi chú"));

            pcbProductPic.DataBindings.Clear();
            pcbProductPic.DataBindings.Add(new Binding("ImageLocation", dtgvProductList.DataSource, "PRODUCTPICTURE"));
            pcbProductPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Click nút trong FlowLayoutPanel
        private void Btn_Click(object sender, EventArgs e)
        {
            ClearData(); // Dọn sạch data đã binding
            string CatalogueID = ((sender as Button).Tag as Catalogue).ID;
            ShowProduct(CatalogueID);
            if (dtgvProductList.RowCount > 0)
            {
                btnEditProduct.Enabled = true;
                btnDeleteProduct.Enabled = true;
            }
            else
            {
                btnEditProduct.Enabled = false; 
                btnDeleteProduct.Enabled = false;
                cbbCatalogue.SelectedItem = null;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(!frmSalesManagement.IsBusy)
            {
                Controls.Clear();
                HomePage myControl = new HomePage();
                Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Hãy hoàn thành tác vụ đang làm trước khi thoát!");
            }
        }

        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            frmSalesManagement.IsBusy = true;
            ClearData();
            pnlInfo.Enabled = true;
            btnInsertProduct.Enabled = false;
            btnSaveInsert.Enabled = true;
            fpnlCatalogue.Enabled = false;
            dtgvProductList.Enabled = false;
            btnCancel.Enabled = true;
            btnDeleteProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            txtProductID.Focus();
            cbbCatalogue.Items.Clear();

            List<Catalogue> catalogueList = CatalogueDAO.Instance.LoadCatalogue();
            foreach (var item in catalogueList)
            {
                cbbCatalogue.Items.Add(item.ID);
            }
        }

        private void btnSaveInsert_Click(object sender, EventArgs e)
        {
            string productid = txtProductID.Text;
            string catalogueid = cbbCatalogue.Text;
            string productname = txtProductName.Text;

            string productinventory = txtProductInventory.Text;
            if (productinventory == "") productinventory = "0";

            string productprice = txtProductPrice.Text;
            if (productprice == "") productprice = "0";

            string productpicture = ProductPic;

            string gemweight = txtGemWeight.Text;
            if (gemweight == "") gemweight = "0";

            string productweight = txtProductWeight.Text;
            if (productweight == "") productweight = "0";

            string productnote = txtNote.Text;

            string processingfee = txtProcessFee.Text;
            if (processingfee == "") processingfee = "0";

            // Kiểm tra trường bắt buộc
            if (productid == "" || catalogueid == "" || productname == "")
            {
                MessageBox.Show("Phải điền đầy đủ thông tin của các trường bắt buộc!" + Environment.NewLine + "Thông tin bắt buộc có đánh dấu (*)", "Thông báo!");
                return;
            }

            if (CheckTypeData(productinventory, productprice, gemweight, productweight, processingfee))
            {
                // Kiểm tra trùng mã sp
                if (ProductDAO.Instance.IndenticalCheck(productid))
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo!");
                    return;
                }

                if (ProductDAO.Instance.InsertProduct(productid, catalogueid, productname, productinventory, productprice, productpicture, gemweight, productweight, productnote, processingfee))
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    ShowProduct(catalogueid);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại!");
                }

                btnSaveInsert.Enabled = false;
                btnInsertProduct.Enabled = true;
                pnlInfo.Enabled = false;
                fpnlCatalogue.Enabled = true;
                dtgvProductList.Enabled = true;
                txtProductID.Enabled = true;
                btnCancel.Enabled = false;
                btnDeleteProduct.Enabled = true;
                btnUpdateProduct.Enabled = false;
                btnEditProduct.Enabled = true;
                frmSalesManagement.IsBusy = false;
            }
            else
            {
                MessageBox.Show("Kiểu dữ liệu chưa đúng!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmSalesManagement.IsBusy = false;
            ClearData();
            btnCancel.Enabled = false;
            pnlInfo.Enabled = false;
            fpnlCatalogue.Enabled = true;
            dtgvProductList.Enabled = true;
            btnInsertProduct.Enabled = true;
            btnSaveInsert.Enabled = false;
            btnUpdateProduct.Enabled = false;
            txtProductID.Enabled = true;
            ProductPic = "";

            if (dtgvProductList.RowCount > 0)
            {
                btnEditProduct.Enabled = true;
                btnDeleteProduct.Enabled = true;
                AddProductBinding();
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            frmSalesManagement.IsBusy = true;
            btnEditProduct.Enabled = false;
            txtProductID.Enabled = false;
            pnlInfo.Enabled = true;
            fpnlCatalogue.Enabled = false;
            dtgvProductList.Enabled = false;
            btnCancel.Enabled = true;
            btnInsertProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnUpdateProduct.Enabled = true;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            frmSalesManagement.IsBusy = false;
            string productid = txtProductID.Text;
            string catalogueid = cbbCatalogue.Text;
            string productname = txtProductName.Text;

            //Kiểm tra trường bắt buộc
            if (catalogueid == "" || productname == "")
            {
                MessageBox.Show("Phải điền đầy đủ thông tin của các trường bắt buộc!" + Environment.NewLine + "Thông tin bắt buộc có đánh dấu (*)", "Thông báo!");
                return;
            }

            txtProductID.Enabled = true;
            pnlInfo.Enabled = false;
            fpnlCatalogue.Enabled = true;
            dtgvProductList.Enabled = true;
            btnCancel.Enabled = false;
            btnInsertProduct.Enabled = true;
            btnDeleteProduct.Enabled = true;
            btnUpdateProduct.Enabled = false;
            btnEditProduct.Enabled = true;

            string productinventory = txtProductInventory.Text;
            if (productinventory == "") productinventory = "0";

            string productprice = txtProductPrice.Text;
            if (productprice == "") productprice = "0";

            string productpicture = ProductPic;
            if (productpicture == "") productpicture = dtgvProductList.CurrentRow.Cells[5].Value.ToString();

            string gemweight = txtGemWeight.Text;
            if (gemweight == "") gemweight = "0";

            string productweight = txtProductWeight.Text;
            if (productweight == "") productweight = "0";

            string productnote = txtNote.Text;

            string processingfee = txtProcessFee.Text;
            if (processingfee == "") processingfee = "0";

            if (ProductDAO.Instance.UpdateProduct(productid, catalogueid, productname, productinventory, productprice, productpicture, gemweight, productweight, productnote, processingfee))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                ShowProduct(catalogueid);
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại!");
            }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Nguồn ảnh sản phẩm";
            file.InitialDirectory = @"C:\Users\HP\Downloads\icon";
            file.Filter = "All files (*.*)|*.*|exe files (*.exe)|*.exe";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                ProductPic = file.FileName;
                pcbProductPic.ImageLocation = ProductPic;
            }
            else
            {
                ProductPic = "";
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Bạn muốn xoá sản phẩm: " + txtProductName.Text,"Thông báo!",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = txtProductID.Text;

                if (ProductDAO.Instance.DeleteProduct(id))
                {
                    MessageBox.Show("Xoá sản phẩm thành công!");
                    ShowProduct(cbbCatalogue.Text);
                }
                else
                {
                    MessageBox.Show("Xoá sản phẩm thất bại!");
                }
            }
        }

        private void btnCatalogueOptions_Click(object sender, EventArgs e)
        {
            frmCatalogueOptions f = new frmCatalogueOptions();
            f.ShowDialog();
            Loading();
        }

        private void btnCatalogueOptions2_Click(object sender, EventArgs e)
        {
            frmCatalogueOptions f = new frmCatalogueOptions();
            f.ShowDialog();
            Loading();
        }
    }
}
