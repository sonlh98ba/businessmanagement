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
    public partial class PromotionsControl : UserControl
    {
        public PromotionsControl()
        {
            InitializeComponent();
            Loading();
        }

        // Tạo kết nối DataBinding
        void AddPromotionBinding()
        {
            txtPromotionID.DataBindings.Clear();
            txtPromotionID.DataBindings.Add(new Binding("Text", dtgvPromotionsList.DataSource, "Mã CTKM"));

            dtpkStartingDate.DataBindings.Clear();
            dtpkStartingDate.DataBindings.Add(new Binding("Value", dtgvPromotionsList.DataSource, "Ngày bắt đầu"));

            dtpkEndingDate.DataBindings.Clear();
            dtpkEndingDate.DataBindings.Add(new Binding("Value", dtgvPromotionsList.DataSource, "Ngày kết thúc"));

            nmrDiscount.DataBindings.Clear();
            nmrDiscount.DataBindings.Add(new Binding("Value", dtgvPromotionsList.DataSource, "Giảm giá"));

            txtGift.DataBindings.Clear();
            txtGift.DataBindings.Add(new Binding("Text", dtgvPromotionsList.DataSource, "Quà"));
        }

        void ClearData()
        {
            // Cắt kết nối DataBinding
            txtPromotionID.DataBindings.Clear();
            dtpkStartingDate.DataBindings.Clear();
            dtpkEndingDate.DataBindings.Clear();
            nmrDiscount.DataBindings.Clear();
            txtGift.DataBindings.Clear();
            // Dọn sạch thông tin
            txtPromotionID.Text = "";
            dtpkStartingDate.Value = DateTime.Today;
            dtpkEndingDate.Value = DateTime.Today;
            nmrDiscount.Text = "0";
            txtGift.Text = "";
        }

        void Loading()
        {
            DataTable data = PromotionsDAO.Instance.GetPromotionsList();
            dtgvPromotionsList.DataSource = data;
            dtgvPromotionsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPromotionsList.AllowUserToResizeRows = false;
            if (dtgvPromotionsList.RowCount > 0) AddPromotionBinding();
            if (dtgvPromotionsList.RowCount > 0)
            {
                btnEditPromotion.Enabled = true;
                btnDeletePromotion.Enabled = true;
            }
            else
            {
                btnEditPromotion.Enabled = false;
                btnDeletePromotion.Enabled = false;
            }
        }

        private void btnInsertPromotion_Click(object sender, EventArgs e)
        {
            frmSalesManagement.IsBusy = true;
            ClearData();
            grbPromotionInfo.Enabled = true;
            btnInsertPromotion.Enabled = false;
            btnSaveInsert.Enabled = true;
            dtgvPromotionsList.Enabled = false;
            btnCancel.Enabled = true;
            btnDeletePromotion.Enabled = false;
            btnEditPromotion.Enabled = false;
            txtPromotionID.Enabled = true;
            txtPromotionID.Focus();
        }

        private void btnSaveInsert_Click(object sender, EventArgs e)
        {
            string promotionid = txtPromotionID.Text;
            string startingdate = dtpkStartingDate.Value.ToShortDateString();
            string endingdate = dtpkEndingDate.Value.ToShortDateString();
            string discount = nmrDiscount.Value.ToString();
            string gift = txtGift.Text;


            // Kiểm tra trường bắt buộc
            if (promotionid == "")
            {
                MessageBox.Show("Vui lòng nhập mã CTKM", "Thông báo!");
                return;
            }

            //Kiểm tra trùng mã ctkm
                if (PromotionsDAO.Instance.IndenticalCheck(promotionid))
            {
                MessageBox.Show("Mã CTKM đã tồn tại!", "Thông báo!");
                return;
            }

            if (PromotionsDAO.Instance.InsertPromotion(promotionid, startingdate, endingdate, discount, gift))
            {
                MessageBox.Show("Thêm CTKM thành công!");
                Loading();
            }
            else
            {
                MessageBox.Show("Thêm CTKM thất bại!");
            }

            btnSaveInsert.Enabled = false;
            btnInsertPromotion.Enabled = true;
            grbPromotionInfo.Enabled = false;
            dtgvPromotionsList.Enabled = true;
            txtPromotionID.Enabled = false;
            btnCancel.Enabled = false;
            btnDeletePromotion.Enabled = true;
            btnUpdatePromotion.Enabled = false;
            btnEditPromotion.Enabled = true;
            frmSalesManagement.IsBusy = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
            btnCancel.Enabled = false;
            grbPromotionInfo.Enabled = false;
            dtgvPromotionsList.Enabled = true;
            btnInsertPromotion.Enabled = true;
            btnSaveInsert.Enabled = false;
            btnUpdatePromotion.Enabled = false;
            txtPromotionID.Enabled = false;

            if (dtgvPromotionsList.RowCount > 0)
            {
                btnEditPromotion.Enabled = true;
                btnDeletePromotion.Enabled = true;
                AddPromotionBinding();
            }

            frmSalesManagement.IsBusy = false;
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
                MessageBox.Show("Hãy hoàn thành tác vụ trước khi thoát!");
            }
        }

        private void btnDeletePromotion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xoá CTKM: " + txtPromotionID.Text, "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = txtPromotionID.Text;

                if (PromotionsDAO.Instance.DeletePromotion(id))
                {
                    MessageBox.Show("Xoá CTKM thành công!");
                    Loading();
                }
                else
                {
                    MessageBox.Show("Xoá CTKM thất bại!");
                }
            }
        }

        private void btnEditPromotion_Click(object sender, EventArgs e)
        {
            btnEditPromotion.Enabled = false;
            txtPromotionID.Enabled = false;
            grbPromotionInfo.Enabled = true;
            dtgvPromotionsList.Enabled = false;
            btnCancel.Enabled = true;
            btnInsertPromotion.Enabled = false;
            btnDeletePromotion.Enabled = false;
            btnUpdatePromotion.Enabled = true;

            frmSalesManagement.IsBusy = true;
        }

        private void btnUpdatePromotion_Click(object sender, EventArgs e)
        {
            string promotionid = txtPromotionID.Text;
            string startingdate = dtpkStartingDate.Value.ToShortDateString();
            string endingdate = dtpkEndingDate.Value.ToShortDateString();
            string discount = nmrDiscount.Value.ToString();
            string gift = txtGift.Text;

            txtPromotionID.Enabled = true;
            grbPromotionInfo.Enabled = false;
            dtgvPromotionsList.Enabled = true;
            btnCancel.Enabled = false;
            btnInsertPromotion.Enabled = true;
            btnDeletePromotion.Enabled = true;
            btnUpdatePromotion.Enabled = false;
            btnEditPromotion.Enabled = true;

            if (discount == "") discount = "0";

            if (PromotionsDAO.Instance.UpdatePromotion(promotionid, startingdate, endingdate, discount, gift))
            {
                MessageBox.Show("Cập nhật CTKM thành công!");
                Loading();
            }
            else
            {
                MessageBox.Show("Cập nhật CTKM thất bại!");
            }

            frmSalesManagement.IsBusy = false;
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            frmPromotionManager f = new frmPromotionManager();
            f.ShowDialog();
        }
    }
}
