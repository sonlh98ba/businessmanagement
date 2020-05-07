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
    public partial class frmWarrantyBillsList : Form
    {
        public frmWarrantyBillsList()
        {
            InitializeComponent();
            Loading();
        }

        void Loading()
        {
            dtgvWarrantyBillsList.DataSource = ProductWarrantyDAO.Instance.GetProductWarranty();
            dtgvWarrantyBillsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvWarrantyBillsList.AllowUserToResizeRows = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
