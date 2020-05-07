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
    public partial class frmUserRegistry : Form
    {
        public frmUserRegistry()
        {
            InitializeComponent();
        }

        void SignUp()
        {
            string username = txtUserName.Text;
            string fullname = txtUFullName.Text;
            string uright = cbbURight.Text;

            if (!EmployeesDAO.Instance.IndenticalCheck(username))
            {
                if (EmployeesDAO.Instance.InsertEmployee(username, fullname, uright))
                {
                    MessageBox.Show("Thêm người dùng " + username + " thành công!\nMật khẩu mặc định là 1, vui lòng đổi mật khẩu để bảo mật tài khoản!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!\nVui lòng dùng tên đăng nhập khác!", "Thông báo!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistry_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtUFullName.Text != "" && cbbURight.Text != "")
                SignUp();
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin người dùng!");
        }
    }
}
