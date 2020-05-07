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
    public partial class frmCatalogueOptions : Form
    {
        public frmCatalogueOptions()
        {
            InitializeComponent();
            Loading();
        }

        void Loading()
        {
            DataTable data = CatalogueDAO.Instance.GetCatalogue();
            dtgvCatalogueList.DataSource = data;
            dtgvCatalogueList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCatalogueList.AllowUserToResizeRows = false;

            dtgvCatalogueList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvCatalogueList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lblCatalogueCount.Text = dtgvCatalogueList.RowCount.ToString();
            if (dtgvCatalogueList.SelectedRows != null)
            {
                AddProductBinding();
                btnDeleteCatalogue.Enabled = true;
                btnEditCatalogue.Enabled = true;
            }
        }

        // Tạo kết nối DataBinding
        void AddProductBinding()
        {
            txtCatalogueID.DataBindings.Clear();
            txtCatalogueID.DataBindings.Add(new Binding("Text", dtgvCatalogueList.DataSource, "Mã loại"));

            txtCatalogueName.DataBindings.Clear();
            txtCatalogueName.DataBindings.Add(new Binding("Text", dtgvCatalogueList.DataSource, "Tên loại"));

            txtMaterial.DataBindings.Clear();
            txtMaterial.DataBindings.Add(new Binding("Text", dtgvCatalogueList.DataSource, "Chất liệu"));
        }

        void ClearData()
        {
            // Cắt kết nối DataBinding
            txtCatalogueID.DataBindings.Clear();
            txtCatalogueName.DataBindings.Clear();
            txtMaterial.DataBindings.Clear();

            // Dọn sạch thông tin
            txtCatalogueID.Text = "";
            txtCatalogueName.Text = "";
            txtMaterial.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertCatalogue_Click(object sender, EventArgs e)
        {
            ClearData();
            grbCatalogueInfo.Enabled = true;
            btnInsertCatalogue.Enabled = false;
            btnSaveInsert.Enabled = true;
            dtgvCatalogueList.Enabled = false;
            btnCancel.Enabled = true;
            btnDeleteCatalogue.Enabled = false;
            btnEditCatalogue.Enabled = false;
            txtCatalogueID.Enabled = true;
            txtCatalogueID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
            btnCancel.Enabled = false;
            grbCatalogueInfo.Enabled = false;
            dtgvCatalogueList.Enabled = true;
            btnInsertCatalogue.Enabled = true;
            btnSaveInsert.Enabled = false;
            btnUpdateCatalogue.Enabled = false;
            txtCatalogueID.Enabled = true;

            if (dtgvCatalogueList.RowCount > 0)
            {
                btnEditCatalogue.Enabled = true;
                btnDeleteCatalogue.Enabled = true;
                AddProductBinding();
            }
        }

        private void btnEditCatalogue_Click(object sender, EventArgs e)
        {
            btnEditCatalogue.Enabled = false;
            txtCatalogueID.Enabled = false;
            grbCatalogueInfo.Enabled = true;
            dtgvCatalogueList.Enabled = false;
            btnCancel.Enabled = true;
            btnInsertCatalogue.Enabled = false;
            btnDeleteCatalogue.Enabled = false;
            btnUpdateCatalogue.Enabled = true;
        }

        private void btnUpdateCatalogue_Click(object sender, EventArgs e)
        {
            string catalogueid = txtCatalogueID.Text;
            string cataloguename = txtCatalogueName.Text;
            string material = txtMaterial.Text;

            // Kiểm tra trường bắt buộc
            if (catalogueid == "" || cataloguename == "" || material == "")
            {
                MessageBox.Show("Phải điền đầy đủ thông tin!", "Thông báo!");
                return;
            }

            txtCatalogueID.Enabled = false;
            grbCatalogueInfo.Enabled = false;
            dtgvCatalogueList.Enabled = true;
            btnCancel.Enabled = false;
            btnInsertCatalogue.Enabled = true;
            btnDeleteCatalogue.Enabled = true;
            btnUpdateCatalogue.Enabled = false;
            btnEditCatalogue.Enabled = true;

            if (CatalogueDAO.Instance.UpdateCatalogue(catalogueid, cataloguename, material))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                Loading();
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại!");
            }
        }

        private void btnSaveInsert_Click(object sender, EventArgs e)
        {
            string catalogueid = txtCatalogueID.Text;
            string cataloguename = txtCatalogueName.Text;
            string material = txtMaterial.Text;

            // Kiểm tra trường bắt buộc
            if (cataloguename == "" || catalogueid == "" || material == "")
            {
                MessageBox.Show("Phải điền đầy đủ thông tin!", "Thông báo!");
                return;
            }

            // Kiểm tra trùng mã loại
            if (CatalogueDAO.Instance.IndenticalCheck(catalogueid))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo!");
                return;
            }

            if (CatalogueDAO.Instance.InsertCatalogue(catalogueid, cataloguename, material))
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                Loading();
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại!");
            }

            btnSaveInsert.Enabled = false;
            btnInsertCatalogue.Enabled = true;
            grbCatalogueInfo.Enabled = false;
            dtgvCatalogueList.Enabled = true;
            txtCatalogueID.Enabled = true;
            btnCancel.Enabled = false;
            btnDeleteCatalogue.Enabled = true;
            btnUpdateCatalogue.Enabled = false;
            btnEditCatalogue.Enabled = true;
        }

        private void btnDeleteCatalogue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xoá loại sản phẩm: " + txtCatalogueName.Text, "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = txtCatalogueID.Text;

                if (CatalogueDAO.Instance.DeleteCatalogue(id))
                {
                    MessageBox.Show("Xoá loại sản phẩm thành công!");
                    Loading();
                }
                else
                {
                    MessageBox.Show("Xoá loại sản phẩm thất bại!");
                }
            }
        }
    }
}
