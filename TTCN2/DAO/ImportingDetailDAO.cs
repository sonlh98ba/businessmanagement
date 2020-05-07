using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DAO
{
    class ImportingDetailDAO
    {
        private static ImportingDetailDAO instance;
        public static ImportingDetailDAO Instance
        {
            get { if (instance == null) instance = new ImportingDetailDAO(); return ImportingDetailDAO.instance; }
            private set { ImportingDetailDAO.instance = value; }
        }

        private ImportingDetailDAO() { }

        public void DeleteImportingDetailByProductID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE ImportingDetail WHERE PRODUCTID = N'"+ id +"'");
        }

        public string GetTotalCountbyIBID(string ibid)
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from ImportingDetail WHERE IBID = '" + ibid + "'") != 0)
            {
                string query = "select SUM(PRODUCTCOUNT) from ImportingDetail where IBID = '" + ibid + "'";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        public string GetTotalWeightbyIBID(string ibid)
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from ImportingDetail WHERE IBID = '" + ibid + "'") != 0)
            {
                string query = "select SUM(TOTALWEIGHT) from ImportingDetail where IBID = '" + ibid + "'";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        public string GetNotebyIBID(string ibid)
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from ImportingBills WHERE IBID = '" + ibid + "'") != 0)
            {
                string query = "select IBNOTE from ImportingBills where IBID = '" + ibid + "'";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        public void DeleteImportingDetailByIBID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE ImportingDetail WHERE IBID = '" + id + "'");
        }

        public DataTable GetListIDbyIBID(string ibid)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT PRODUCTID as [Mã SP], PRODUCTCOUNT as [Số lượng], TOTALWEIGHT as [Tổng TL], PRODUCTDESCRIBE as [Mô tả] FROM ImportingDetail WHERE IBID = '" + ibid + "'");
        }

        public bool InsertImportingDetail(string ibid, string productid, string productcount, string totalweight, string productdescribe)
        {
            string query = "INSERT INTO ImportingDetail(IBID, PRODUCTID, PRODUCTCOUNT, TOTALWEIGHT, PRODUCTDESCRIBE) VALUES	( '" + ibid + "', N'" + productid + "'," + productcount + ", " + totalweight + ", '" + productdescribe + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateImportingDetail(string totalcount, string totalweight, string productdescribe, string productid, string ibid)
        {
            string query = "UPDATE ImportingDetail SET PRODUCTCOUNT = " + totalcount + ", TOTALWEIGHT = " + totalweight + ", PRODUCTDESCRIBE = '" + productdescribe + "' WHERE PRODUCTID = N'" + productid + "' and IBID = '" + ibid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool IndenticalCheck(string productid, string ibid)
        {
            return (Convert.ToInt32(DataProvider.Instance.ExecuteScalar("Select COUNT(*) FROM ImportingDetail WHERE PRODUCTID = N'" + productid + "' and IBID = '" + ibid + "'")) > 0);
        }
    }
}
