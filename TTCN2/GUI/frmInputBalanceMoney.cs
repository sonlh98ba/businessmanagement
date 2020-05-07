using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCN2.GUI
{
    public partial class frmInputBalanceMoney : Form
    {
        public frmInputBalanceMoney()
        {
            InitializeComponent();
            txtStartBalance.Focus();
            txtStartBalance.SelectAll();
        }

        private void btnOpenSafe_Click(object sender, EventArgs e)
        {
            //
            // Hành động mở két
            //
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStartBalance.Text, out int a) && Convert.ToInt32(txtStartBalance.Text) >= 0)
            {
                frmLogIn.StartBalance = Convert.ToInt32(txtStartBalance.Text);
                frmLogIn.IsActivate = true;
                frmSalesManagement fSM = new frmSalesManagement();
                Hide();
                fSM.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng!");
            }
        }
    }
}
