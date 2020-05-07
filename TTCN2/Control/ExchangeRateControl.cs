using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using TTCN2.DAO;

namespace TTCN2
{
    public partial class ExchangeRateControl : UserControl
    {
        public ExchangeRateControl()
        {
            InitializeComponent();
            Loading();
        }

        void Loading()
        {
            DataTable data = ExchangeRateDAO.Instance.GetExchangeRateList();
            dtgvExchangeRate.DataSource = data;
            dtgvExchangeRate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvExchangeRate.AllowUserToResizeRows = false;
        }

        private void llblLinkVCB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.vietcombank.com.vn/ExchangeRates/");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            HomePage myControl = new HomePage();
            Controls.Add(myControl);
            myControl.Dock = DockStyle.Fill;
        }
    }
}
