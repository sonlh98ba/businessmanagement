using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTCN2.DAO;
using TTCN2.DTO;
using TTCN2.GUI;

namespace TTCN2
{
    public partial class frmSalesManagement : Form
    {
        public static string USERNAME;
        public string UFULLNAME;
        public string UREGENCY;
        public string URIGHT;
        public static bool IsBusy = false;
        public frmSalesManagement()
        {
            InitializeComponent();
            lblHour.Text = (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
            lblDate.Text = (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "/" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "/" + DateTime.Now.Year;
            pnlDisplay.Controls.Clear();
            HomePage myControl = new HomePage();
            pnlDisplay.Controls.Add(myControl);
            myControl.Dock = DockStyle.Fill;
            USERNAME = frmLogIn.UserName;
            UREGENCY = EmployeesDAO.Instance.GetUserRegencyByUserName(USERNAME);
            URIGHT = EmployeesDAO.Instance.GetUserRightByUserName(USERNAME);
            UFULLNAME = EmployeesDAO.Instance.GetUserFullNameByUserName(USERNAME);
            lblUsername.Text = USERNAME.ToUpper() + " - " + UREGENCY; // Hiển thị username
            lblStatus.Text = "Sẵn sàng" + " - " + UREGENCY + " : " + UFULLNAME.ToUpper();
            tsmiUserManagement.Enabled = Convert.ToInt32(URIGHT) > 0 ? true : false; // Phân quyền
        }

        #region Method
        #endregion

        #region Events
        private void btnSales_Click(object sender, EventArgs e)
        {
            if (!IsBusy)
            {
                pnlDisplay.Controls.Clear();
                SalesControl myControl = new SalesControl();
                pnlDisplay.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/sonlh98ba");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHour.Text = (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
            lblDate.Text = (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "/" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "/" + DateTime.Now.Year;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (!IsBusy)
            {
                pnlDisplay.Controls.Clear();
                BuyControl myControl = new BuyControl();
                pnlDisplay.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
        }

        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            if (!IsBusy)
            {
                pnlDisplay.Controls.Clear();
                CatalogueControl myControl = new CatalogueControl();
                pnlDisplay.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
        }

        private void tsmiTrade_Click(object sender, EventArgs e)
        {
            frmTrade f = new frmTrade();
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(!IsBusy)
            {
                Close();
            }
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            Process.Start("https://huythanhjewelry.vn/search?type=product&q=");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(!IsBusy)
            {
                pnlDisplay.Controls.Clear();
                OrderControl myControl = new OrderControl();
                pnlDisplay.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
        }

        private void btnWarranty_Click(object sender, EventArgs e)
        {
            if (!IsBusy)
            {
                pnlDisplay.Controls.Clear();
                WarrantyControl myControl = new WarrantyControl();
                pnlDisplay.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if(!IsBusy)
            {
                pnlDisplay.Controls.Clear();
                CustomerControl myControl = new CustomerControl();
                pnlDisplay.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
        }

        private void btnWarehousing_Click(object sender, EventArgs e)
        {
            if(!IsBusy)
            {
                pnlDisplay.Controls.Clear();
                WarehousingControl myControl = new WarehousingControl();
                pnlDisplay.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
        }

        private void btnPromotions_Click(object sender, EventArgs e)
        {
            if (!IsBusy)
            {
                pnlDisplay.Controls.Clear();
                PromotionsControl myControl = new PromotionsControl();
                pnlDisplay.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
        }

        private void btnExchangeRate_Click(object sender, EventArgs e)
        {
            if(!IsBusy)
            {
                pnlDisplay.Controls.Clear();
                ExchangeRateControl myControl = new ExchangeRateControl();
                pnlDisplay.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
        }

        private void btnBalanceMoney_Click(object sender, EventArgs e)
        {
            if(!IsBusy)
            {
                pnlDisplay.Controls.Clear();
                BalanceMoneyControl myControl = new BalanceMoneyControl();
                pnlDisplay.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            if(!IsBusy)
            {
                if (MessageBox.Show("Thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                    Application.Exit();
                }
            }
        }

        private void tsmiInfo_Click(object sender, EventArgs e)
        {
            frmInfo f = new frmInfo();
            f.ShowDialog();
        }

        private void tsmiUser_Click(object sender, EventArgs e)
        {
            frmUser f = new frmUser();
            f.ShowDialog();
        }

        private void tsmiReport_Click(object sender, EventArgs e)
        {
            frmPrintPreview f = new frmPrintPreview();
            f.ShowDialog();
        }

        private void tsmiPersonalInfo_Click(object sender, EventArgs e)
        {
            frmPersonalInfomation f = new frmPersonalInfomation();
            f.ShowDialog();
        }
        #endregion
    }
}
