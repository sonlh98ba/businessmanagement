using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DAO
{
    class RepurchaseDAO
    {
        private static RepurchaseDAO instance;
        public static RepurchaseDAO Instance
        {
            get { if (instance == null) instance = new RepurchaseDAO(); return RepurchaseDAO.instance; }
            private set { RepurchaseDAO.instance = value; }
        }

        private RepurchaseDAO() { }

        // Xuất bảng Repurchase
        public DataTable GetRepurchaseBills()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT REPURCHASEID as [Mã mua lại], SBID as [Mã HĐ], PRODUCTID as [Mã SP], RPCOUNT as [SL], REASON as [Lý do], REPURCHASEPRICE as [Giá mua lại], REPURCHASEDATE as [Ngày mua lại] FROM Repurchase");
        }

        public DataTable GetRepurchaseMoney(string date)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT REPURCHASEID as [Mã mua lại], REPURCHASEPRICE as [Giá mua lại] FROM Repurchase WHERE REPURCHASEDATE = '" + date + "'");
        }

        public string GetOnlyRepurchaseMoney(string date)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT SUM(REPURCHASEPRICE) FROM Repurchase WHERE REPURCHASEDATE = '" + date + "'").ToString() != ""
                ? DataProvider.Instance.ExecuteScalar("SELECT SUM(REPURCHASEPRICE) FROM Repurchase WHERE REPURCHASEDATE = '" + date + "'").ToString()
                : "0";
        }

        public DataTable GetRepurchaseBillsByDate(string dateStart, string dateEnd)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT REPURCHASEID as [Mã mua lại], SBID as [Mã HĐ], PRODUCTID as [Mã SP], RPCOUNT as [SL], REASON as [Lý do], REPURCHASEPRICE as [Giá mua lại], REPURCHASEDATE as [Ngày mua lại] FROM Repurchase WHERE REPURCHASEDATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "'");
        }

        public void DeleteRepurchaseByProductID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE Repurchase WHERE PRODUCTID = N'" + id + "'");
        }

        public void DeleteRepurchaseBySbID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE Repurchase WHERE SBID = '" + id + "'");
        }

        public bool InsertRepurchase(string sbid, string productid, string repurchasedate)
        {
            string query = "INSERT INTO Repurchase(SBID, PRODUCTID, REPURCHASEDATE) VALUES(N'" + sbid + "', N'" + productid + "', '" + repurchasedate + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteRepurchase(string repurchaseid)
        {
            string query = "DELETE Repurchase WHERE REPURCHASEID = '" + repurchaseid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public string GetMaxId()
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from Repurchase") != 0)
            {
                string query = "SELECT Max(REPURCHASEID) as LastID FROM Repurchase";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        public DataTable GetRepurchase()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT REPURCHASEID as [Mã mua lại], SBID as [Mã HĐ], PRODUCTID as [Mã SP], RPCOUNT as [SL], REASON as [Lý do], REPURCHASEPRICE as [Giá mua lại], REPURCHASEDATE as [Ngày mua lại] FROM Repurchase");
        }

        public bool PayTheBill(string repurchaseid, string rpcount, string reason, string rptotalprice)
        {
            string query = "UPDATE Repurchase SET REPURCHASEPRICE = " + rptotalprice + ", REASON = '" + reason + "', RPCOUNT = " + rpcount + " WHERE REPURCHASEID = '" + repurchaseid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
