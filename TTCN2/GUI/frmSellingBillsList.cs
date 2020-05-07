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
    public partial class frmSellingBillsList : Form
    {
        public frmSellingBillsList()
        {
            InitializeComponent();
            Loading();
        }

        void Loading()
        {
            dtgvSellingBillsList.DataSource = SellingBillsDAO.Instance.GetSellingBills();
            dtgvSellingBillsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSellingBillsList.AllowUserToResizeRows = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
