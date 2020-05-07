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
    public partial class frmWarehousingBillsList : Form
    {
        public frmWarehousingBillsList()
        {
            InitializeComponent();
            Loading(); 
        }

        void Loading()
        {
            dtgvWarehousingBillsList.DataSource = ImportingBillsDAO.Instance.GetImportingBills();
            dtgvWarehousingBillsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvWarehousingBillsList.AllowUserToResizeRows = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
