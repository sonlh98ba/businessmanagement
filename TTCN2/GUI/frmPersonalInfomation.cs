using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCN2.DTO;
using TTCN2.DAO;

namespace TTCN2.GUI
{
    public partial class frmPersonalInfomation : Form
    {
        string username = frmSalesManagement.USERNAME;
        Employees user;
        public frmPersonalInfomation()
        {
            InitializeComponent();
            txtUserName.Text = frmSalesManagement.USERNAME;
            LoadUserInformation();
        }

        void LoadUserInformation()
        {
            user = EmployeesDAO.Instance.LoadEmployeesInfo(username);
            txtPassword.Text = user.PassWord;
            txtFullName.Text = user.UFullName;
            dtpkDOB.Value = user.UDOB;
            txtAddress.Text = user.UAddress;
            txtPhone.Text = user.UPhone;
            ckbGender.Checked = user.UGender ? true : false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            pnlUserInformation.Enabled = true;
            btnChange.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string fullname = txtFullName.Text;
            string dob = dtpkDOB.Text;
            string address = txtAddress.Text;
            string gender;
            string phone = txtPhone.Text;

            gender = ckbGender.Checked ? "1" : "0";

            //Kiểm tra trường bắt buộc
            if (password == "" || fullname == "" || dob == "" || address == "" || gender == "" || phone == "")
            {
                MessageBox.Show("Vui lòng điển đầy đủ thông tin!", "Thông báo!");
                return;
            }

            if (EmployeesDAO.Instance.UpdateEmployee(username, password, fullname, dob, address, gender, phone))
            {
                MessageBox.Show("Cập nhật thông tin cá nhân thành công!");
                btnChange.Enabled = true;
                btnUpdate.Enabled = false;
                pnlUserInformation.Enabled = false;
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin cá nhân thất bại!");
            }
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
