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

namespace TTCN2.GUI
{
    public partial class frmCustomerRegistry : Form
    {
        public frmCustomerRegistry()
        {
            InitializeComponent();
        }

        void SignUp()
        {
            string customerphone = txtCustomerPhone.Text;
            string customername = txtCustomerName.Text;
            string customerDOB = dtpkCustomerBirthday.Text;
            string address = txtCustomerAddress.Text;
            if (!CustomerDAO.Instance.IndenticalCheck(customerphone))
            {
                if (CustomerDAO.Instance.InsertCustomer(customerphone, customername, customerDOB, address))
                {
                    MessageBox.Show("Thêm khách hàng " + customername + " thành công!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Số điện thoại khách hàng đã tồn tại!\nVui lòng dùng số điện thoại khác!","Thông báo!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistry_Click(object sender, EventArgs e)
        {
            if (txtCustomerAddress.Text != "" && txtCustomerName.Text != "" && txtCustomerPhone.Text != "")
                SignUp();
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!");
        }
    }
}
