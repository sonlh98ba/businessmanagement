using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCN2.DTO;

namespace TTCN2.DAO
{
    public class SellingBillsDAO
    {
        private static SellingBillsDAO instance;
        public static SellingBillsDAO Instance
        {
            get { if (instance == null) instance = new SellingBillsDAO(); return SellingBillsDAO.instance; }
            private set { SellingBillsDAO.instance = value; }
        }

        private SellingBillsDAO() { }

        // Xuất danh sách SellingBills
        public List<SellingBills> LoadSellingBills()
        {
            List<SellingBills> sellingBillsList = new List<SellingBills>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM SellingBills");

            foreach (DataRow item in data.Rows)
            {
                SellingBills orderbills = new SellingBills(item);
                sellingBillsList.Add(orderbills);
            }

            return sellingBillsList;
        }

        public List<SellingBills> LoadSellingBillsByCustomerPhone(string customerphone)
        {
            List<SellingBills> sellingBillsList = new List<SellingBills>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM SellingBills WHERE CUSTOMERPHONE = N'" + customerphone + "'");

            foreach (DataRow item in data.Rows)
            {
                SellingBills orderbills = new SellingBills(item);
                sellingBillsList.Add(orderbills);
            }

            return sellingBillsList;
        }

        // Xuất bảng SellingBills
        public DataTable GetSellingBills()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT SBID as [Mã HĐ], MAINEID as [Mã NV chính], EXTRAEID as [Mã NV phụ], CUSTOMERPHONE as [SĐT khách], SBDATE as [Ngày mua], SBTOTALPRICE as [Tổng tiền] FROM SellingBills WHERE SBTOTALPRICE != 0");
        }

        public DataTable GetSellingBillsMoney(string date)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT SBID as [Mã HĐ], SBTOTALPRICE as [Tổng tiền] FROM SellingBills WHERE SBTOTALPRICE != 0 AND SBDATE = '" + date + "'");
        }

        public string GetOnlySellingMoney(string date)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT SUM(SBTOTALPRICE) FROM SellingBills WHERE SBTOTALPRICE != 0 AND SBDATE = '" + date + "'").ToString() != ""
                ? DataProvider.Instance.ExecuteScalar("SELECT SUM(SBTOTALPRICE) FROM SellingBills WHERE SBTOTALPRICE != 0 AND SBDATE = '" + date + "'").ToString()
                : "0";
        }

        public string GetOnlySellingMoneyMonth(string startdate, string enddate)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT SUM(SBTOTALPRICE) FROM SellingBills WHERE SBTOTALPRICE != 0 AND SBDATE BETWEEN '" + startdate + "' AND '" + enddate + "'").ToString() != ""
                ? DataProvider.Instance.ExecuteScalar("SELECT SUM(SBTOTALPRICE) FROM SellingBills WHERE SBTOTALPRICE != 0 AND SBDATE BETWEEN '" + startdate + "' AND '" + enddate + "'").ToString()
                : "0";
        }

        public DataTable GetSellingBillsByDate(string dateStart, string dateEnd)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT SBID as [Mã HĐ], MAINEID as [Mã NV chính], EXTRAEID as [Mã NV phụ], CUSTOMERPHONE as [SĐT khách], SBDATE as [Ngày mua], SBTOTALPRICE as [Tổng tiền] FROM SellingBills WHERE SBTOTALPRICE != 0 AND SBDATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "'");
        }

        public DataTable GetCartBySbID(string sbid)
        {
            return SellingDetailDAO.Instance.GetListSdbySbID(sbid);
        }

        public string GetMaxId()
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from SellingBills") != 0)
            {
                string query = "SELECT Max(SBID) as LastID FROM SellingBills";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        public bool InsertSellingBills(string maineid, string extraeid, string customerphone, string sbdate)
        {
            string query = "INSERT INTO SellingBills(MAINEID, EXTRAEID, CUSTOMERPHONE, SBDATE) VALUES	(N'" + maineid + "', N'" + extraeid + "', N'" + customerphone + "','" + sbdate + "'" + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteSellingBills(string sbid)
        {
            ProductWarrantyDAO.Instance.DeleteProductWarrantyBySbID(sbid);
            RepurchaseDAO.Instance.DeleteRepurchaseBySbID(sbid);
            SellingDetailDAO.Instance.DeleteSellingDetailBySbID(sbid);

            string query = "DELETE SellingBills WHERE SBID = '" + sbid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool PayTheBill(string sbid, string sbbonusfee, string sbbonuscontent, string sbtotalprice)
        {
            string query = "UPDATE SellingBills SET SBBONUSFEE = " + sbbonusfee + ", SBBONUSCONTENT = N'" + sbbonuscontent + "' , SBTOTALPRICE = " + sbtotalprice + " WHERE SBID = '" + sbid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool HaveASellingBill(string id)
        {
            return Convert.ToBoolean(DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM SellingBills WHERE SBID = '" + id + "'"));
        }

        public bool DeleteAllSellingBillsByCustomerPhone(string customerphone)
        {
            bool result = true;
            List<SellingBills> list = new List<SellingBills>();
            list = LoadSellingBillsByCustomerPhone(customerphone);
            foreach (var item in list)
            {
                DeleteSellingBills(item.Sbid);
                result = result && DeleteSellingBills(item.Sbid);
            }
            return result;
        }
    }
}
