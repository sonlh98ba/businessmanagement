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
using TTCN2.GUI;

namespace TTCN2
{
    public partial class frmLogIn : Form
    {
        public static string UserName;  // Biến truyền thông tin để phân quyền
        public static bool IsActivate = false;
        public static int StartBalance;

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            if (Login(userName,passWord))
            {
                UserName = userName;
                if (!frmLogIn.IsActivate)
                {
                    frmInputBalanceMoney fIBM = new frmInputBalanceMoney();
                    Hide();
                    fIBM.ShowDialog();
                    Show();
                }
                else
                {
                    frmSalesManagement fSM = new frmSalesManagement();
                    Hide();
                    fSM.ShowDialog();
                    Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
        }

        bool Login(string userName, string passWord)
        {
            return EmployeesDAO.Instance.Login(userName,passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
