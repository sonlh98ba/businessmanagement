using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DAO
{
    class SellingDetailDAO
    {
        private static SellingDetailDAO instance;
        public static SellingDetailDAO Instance
        {
            get { if (instance == null) instance = new SellingDetailDAO(); return SellingDetailDAO.instance; }
            private set { SellingDetailDAO.instance = value; }
        }

        private SellingDetailDAO() { }

        public DataTable GetListSdbySbID(string sbid)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT SBID as [Mã HĐ], PRODUCTID as [Mã SP], SDCOUNT as [Số lượng], PROMOTIONID as [CTKM], PRODUCTPRICE as [Thành tiền], SDTOTALPRICE as [Tổng tiền], SDTOTALDEPOSIT as [Tổng cọc] FROM SellingDetail WHERE SBID = '" + sbid + "'");
        }

        public string GetTotalPricebySbID(string sbid)
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from SellingDetail WHERE SBID = '" + sbid + "'") != 0)
            {
                string query = "select SUM(SDTOTALPRICE) from SellingDetail where SBID = '" + sbid + "'";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        public string GetTotalDepositbySbID(string sbid)
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from SellingDetail WHERE SBID = '" + sbid + "'") != 0)
            {
                string query = "select SUM(SDTOTALDEPOSIT) from SellingDetail where SBID = '" + sbid + "'";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        public bool InsertSellingDetail(string sbid, string productid, string sdcount, string productprice, string sdtotalprice, string promotionid, string totaldeposit)
        {
            string query = "INSERT INTO SellingDetail(SBID, PRODUCTID, SDCOUNT, PRODUCTPRICE, SDTOTALPRICE, PROMOTIONID, SDTOTALDEPOSIT) VALUES	( '" + sbid + "', N'" + productid + "', " + sdcount + ", " + productprice + ", " + sdtotalprice + "," + promotionid + "," + totaldeposit + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void DeleteSellingDetailByProductID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE SellingDetail WHERE PRODUCTID = N'" + id + "'");
        }

        public void DeleteSellingDetailBySbID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE SellingDetail WHERE SBID = '" + id + "'");
        }

        public void DeleteSellingDetailBySbIDAndProductID(string sbid, string productid)
        {
            DataProvider.Instance.ExecuteQuery("DELETE SellingDetail WHERE SBID = '" + sbid + "' AND PRODUCTID =N'" + productid + "'");
        }

        public bool UpdateCountSellingDetail(string sdcount,string productprice, string productid, string sbid)
        {
            string query = "UPDATE SellingDetail SET SDCOUNT = " + sdcount + ", SDTOTALPRICE = " + (Convert.ToInt32(sdcount) * Convert.ToInt32(productprice)).ToString() + " WHERE PRODUCTID = N'" + productid + "' and SBID = '" + sbid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void DeleteSellingDetailByPromotionID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE SellingDetail WHERE PROMOTIONID = N'" + id + "'");
        }

        public bool IndenticalCheck(string productid, string sbid)
        {
            return (Convert.ToInt32(DataProvider.Instance.ExecuteScalar("Select COUNT(*) FROM SellingDetail WHERE PRODUCTID = N'" + productid + "' and SBID = '" + sbid +"'")) > 0);
        }
    }
}
