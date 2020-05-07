using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DAO
{
    class ProductWarrantyDAO
    {
        private static ProductWarrantyDAO instance;
        public static ProductWarrantyDAO Instance
        {
            get { if (instance == null) instance = new ProductWarrantyDAO(); return ProductWarrantyDAO.instance; }
            private set { ProductWarrantyDAO.instance = value; }
        }

        private ProductWarrantyDAO() { }

        public string GetMaxId()
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from ProductWarranty") != 0)
            {
                string query = "SELECT Max(PWID) as LastID FROM ProductWarranty";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        // Xuất bảng ProductWarranty
        public DataTable GetProductWarranty()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT PWID as [Mã ĐBH], SBID as [Mã HĐ], PRODUCTID as [Mã SP], PWCOUNT as [Số lần BH], PWTOTALPRICE as [Phí BH], PWDATE as [Ngày BH] FROM ProductWarranty");
        }

        public DataTable GetProductWarrantyMoney(string date)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT PWID as [Mã ĐBH], PWTOTALPRICE as [Phí BH] FROM ProductWarranty WHERE PWDATE = '" + date + "'");
        }

        public string GetOnlyWarrantyMoney(string date)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT SUM(PWTOTALPRICE) FROM ProductWarranty WHERE PWDATE = '" + date + "'").ToString() != ""
                ? DataProvider.Instance.ExecuteScalar("SELECT SUM(PWTOTALPRICE) FROM ProductWarranty WHERE PWDATE = '" + date + "'").ToString()
                : "0";
        }

        public string GetOnlyWarrantyMoneyMonth(string startdate, string enddate)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT SUM(PWTOTALPRICE) FROM ProductWarranty WHERE PWDATE BETWEEN '" + startdate + "' AND '" + enddate + "'").ToString() != ""
                ? DataProvider.Instance.ExecuteScalar("SELECT SUM(PWTOTALPRICE) FROM ProductWarranty WHERE PWDATE BETWEEN '" + startdate + "' AND '" + enddate + "'").ToString()
                : "0";
        }

        public DataTable GetProductWarrantyByDate(string dateStart, string dateEnd)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT PWID as [Mã ĐBH], SBID as [Mã HĐ], PRODUCTID as [Mã SP], PWCOUNT as [Số lần BH], PWTOTALPRICE as [Phí BH], PWDATE as [Ngày BH] FROM ProductWarranty WHERE PWDATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "'");
        }

        public void DeleteProductWarrantyByProductID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE ProductWarranty WHERE PRODUCTID = N'" + id + "'");
        }

        public void DeleteProductWarrantyBySbID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE ProductWarranty WHERE SBID = '" + id + "'");
        }

        public bool HaveAPWByPIDAndSBID(string productid, string sbid)
        {
            return Convert.ToBoolean(DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM ProductWarranty WHERE PRODUCTID = N'" + productid + "' and SBID = '" + sbid + "'"));
        }

        public int WarrantiedCount(string productid, string sbid)
        {
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar("SELECT SUM(PWCOUNT) FROM ProductWarranty WHERE PRODUCTID = N'" + productid + "' and SBID = '" + sbid + "'"));
        }

        public bool InsertWarranty(string sbid, string productid,string pwnow)
        {
            string query = "INSERT INTO ProductWarranty(SBID, PRODUCTID, PWDATE) VALUES	('" + sbid + "', N'" + productid + "','" + pwnow + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteWarranty(string pwid)
        {
            string query = "DELETE ProductWarranty WHERE PWID = '" + pwid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool PayTheBill(string pwid, string pwcount, string pwtotalprice)
        {
            string query = "UPDATE ProductWarranty SET PWTOTALPRICE = " + pwtotalprice + ", PWCOUNT = " + pwcount + " WHERE PWID = '" + pwid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
