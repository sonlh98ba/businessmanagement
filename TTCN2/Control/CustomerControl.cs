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
using TTCN2.DAO;

namespace TTCN2
{
    public partial class CustomerControl : UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
            Loading();
        }

        void Loading()
        {
            LoadListCustomer();
            if (dtgvCustomerList.SelectedRows != null)
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        void AddDataBinding()
        {
            txtCustomerPhone.DataBindings.Clear();
            txtCustomerPhone.DataBindings.Add(new Binding("Text", dtgvCustomerList.DataSource, "SĐT"));

            txtCustomerName.DataBindings.Clear();
            txtCustomerName.DataBindings.Add(new Binding("Text", dtgvCustomerList.DataSource, "Tên khách hàng"));

            dtpkCustomerDOB.DataBindings.Clear();
            dtpkCustomerDOB.DataBindings.Add(new Binding("Value", dtgvCustomerList.DataSource, "Ngày sinh"));

            nmrPurchased.DataBindings.Clear();
            nmrPurchased.DataBindings.Add(new Binding("Value", dtgvCustomerList.DataSource, "Lượt mua"));

            txtTotalConsumption.DataBindings.Clear();
            txtTotalConsumption.DataBindings.Add(new Binding("Text", dtgvCustomerList.DataSource, "Tổng mua"));

            txtCustomerAddress.DataBindings.Clear();
            txtCustomerAddress.DataBindings.Add(new Binding("Text", dtgvCustomerList.DataSource, "Địa chỉ"));
        }

        void ClearData()
        {
            // Cắt kết nối DataBinding
            txtCustomerPhone.DataBindings.Clear();
            txtCustomerName.DataBindings.Clear();
            dtpkCustomerDOB.DataBindings.Clear();
            nmrPurchased.DataBindings.Clear();
            txtTotalConsumption.DataBindings.Clear();
            txtCustomerAddress.DataBindings.Clear();
            
            // Dọn sạch thông tin
            txtCustomerPhone.Text = "";
            txtCustomerName.Text = "";
            nmrPurchased.Value = 0;
            txtTotalConsumption.Text = "";
            txtCustomerAddress.Text = "";
        }

        void LoadListCustomer()
        {
            DataTable data = CustomerDAO.Instance.GetCustomerList();
            dtgvCustomerList.DataSource = data;
            if (dtgvCustomerList.RowCount > 0) AddDataBinding();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmCustomerRegistry f = new frmCustomerRegistry();
            f.ShowDialog();
            LoadListCustomer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmSalesManagement.IsBusy = true;
            btnEdit.Enabled = false;
            txtCustomerPhone.Enabled = false;
            grbCustomerInfo.Enabled = true;
            dtgvCustomerList.Enabled = false;
            btnCancel.Enabled = true;
            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string customerphone = txtCustomerPhone.Text;
            string customername = txtCustomerName.Text;

            //Kiểm tra trường bắt buộc
            if (customername == "")
            {
                MessageBox.Show("Vui lòng điển tên khách hàng!", "Thông báo!");
                return;
            }

            txtCustomerPhone.Enabled = true;
            grbCustomerInfo.Enabled = false;
            dtgvCustomerList.Enabled = true;
            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = false;
            btnEdit.Enabled = true;

            string customerDOB = dtpkCustomerDOB.Text;

            string purchased = nmrPurchased.Text;

            string totalconsumption = txtTotalConsumption.Text;
            if (totalconsumption == "") totalconsumption = "0";

            string address = txtCustomerAddress.Text;

            if (CustomerDAO.Instance.UpdateCustomer(customerphone, customername, customerDOB, purchased, totalconsumption, address))
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
                LoadListCustomer();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thất bại!");
            }

            frmSalesManagement.IsBusy = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmSalesManagement.IsBusy = false;
            ClearData();
            btnCancel.Enabled = false;
            grbCustomerInfo.Enabled = false;
            dtgvCustomerList.Enabled = true;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            txtCustomerPhone.Enabled = true;

            if (dtgvCustomerList.RowCount > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                AddDataBinding();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xoá khách hàng: " + txtCustomerName.Text, "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string customerphone = txtCustomerPhone.Text;

                if (CustomerDAO.Instance.DeleteCustomer(customerphone))
                {
                    MessageBox.Show("Xoá khách hàng thành công!");
                    LoadListCustomer();
                }
                else
                {
                    MessageBox.Show("Xoá khách hàng thất bại!");
                }
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
                MessageBox.Show("Hãy hoàn thành tác vụ trước khi thoát!");
            }
        }
    }
}
