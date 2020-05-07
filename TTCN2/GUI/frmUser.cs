using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCN2.DAO;
using TTCN2.GUI;

namespace TTCN2
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();

            LoadUserList();
        }

        void LoadUserList()
        {
            dtgvUser.DataSource = EmployeesDAO.Instance.GetUserList();
            dtgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvUser.Columns[2].Visible = false;
            dtgvUser.Columns[3].Visible = false;
            dtgvUser.Columns[4].Visible = false;
            dtgvUser.Columns[5].Visible = false;
            dtgvUser.Columns[6].Visible = false;
            dtgvUser.Columns[7].Visible = false;
            dtgvUser.Columns[8].Visible = false;
            dtgvUser.AllowUserToResizeRows = false;
            AddEmployeeBinding();
        }

        void ClearData()
        {
            // Cắt kết nối DataBinding
            txtUserName.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            cbbAccountType.DataBindings.Clear();
            txtDOB.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            ckbGender.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtRegency.DataBindings.Clear();
            txtSalary.DataBindings.Clear();

            // Dọn sạch thông tin
            txtUserName.Text = "";
            txtFullName.Text = "";
            cbbAccountType.Text = "";
            txtDOB.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtRegency.Text = "";
            txtSalary.Text = "";
        }

        // Tạo kết nối DataBinding
        void AddEmployeeBinding()
        {
            txtUserName.DataBindings.Clear();
            txtUserName.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Tên đăng nhập"));

            txtFullName.DataBindings.Clear();
            txtFullName.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Tên nhân viên"));

            cbbAccountType.DataBindings.Clear();
            cbbAccountType.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "URIGHT"));

            txtDOB.DataBindings.Clear();
            txtDOB.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "UDOB"));

            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "UADDRESS"));

            ckbGender.DataBindings.Clear();
            ckbGender.DataBindings.Add(new Binding("Checked", dtgvUser.DataSource, "UGENDER"));

            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "UPHONE"));

            txtRegency.DataBindings.Clear();
            txtRegency.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "UREGENCY"));

            txtSalary.DataBindings.Clear();
            txtSalary.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "USALARY"));
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (pnlExtraInfo.Visible == true) pnlExtraInfo.Visible = false;
                else pnlExtraInfo.Visible = true;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đặt lại mật khẩu cho tài khoản " + txtUserName.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (EmployeesDAO.Instance.ResetPassword(txtUserName.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!\nMật khẩu tài khoản " + txtUserName.Text + " hiện tại là 1", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            txtUserName.Enabled = false;
            pnlMainInfo.Enabled = true;
            pnlExtraInfo.Enabled = true;
            dtgvUser.Enabled = false;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveEdit.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
            btnCancel.Enabled = false;
            pnlMainInfo.Enabled = false;
            pnlExtraInfo.Enabled = false;
            dtgvUser.Enabled = true;
            btnAdd.Enabled = true;
            btnSaveEdit.Enabled = false;
            txtUserName.Enabled = true;

            if (dtgvUser.RowCount > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                AddEmployeeBinding();
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string fullname = txtFullName.Text;

            //Kiểm tra trường bắt buộc
            if (fullname == "")
            {
                MessageBox.Show("Vui lòng điển tên nhân viên!", "Thông báo!");
                return;
            }

            txtUserName.Enabled = true;
            pnlMainInfo.Enabled = false;
            pnlExtraInfo.Enabled = false;
            dtgvUser.Enabled = true;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveEdit.Enabled = false;
            btnEdit.Enabled = true;

            string uright = cbbAccountType.Text;

            string dob = txtDOB.Text;

            string address = txtAddress.Text;

            string gender = ckbGender.Checked ? "1" : "0";

            string phone = txtPhone.Text;

            string regency = txtRegency.Text;

            string salary = txtSalary.Text;


            if (EmployeesDAO.Instance.UpdateUser(username, fullname, uright, dob, address, gender, phone, regency, salary))
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                LoadUserList();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUserRegistry f = new frmUserRegistry();
            f.ShowDialog();
            LoadUserList();
        }
    }
}
