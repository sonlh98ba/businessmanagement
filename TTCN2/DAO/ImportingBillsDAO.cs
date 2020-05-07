using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DAO
{
    class ImportingBillsDAO
    {
        private static ImportingBillsDAO instance;
        public static ImportingBillsDAO Instance
        {
            get { if (instance == null) instance = new ImportingBillsDAO(); return ImportingBillsDAO.instance; }
            private set { ImportingBillsDAO.instance = value; }
        }

        private ImportingBillsDAO() { }

        public string GetMaxId()
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from ImportingBills") != 0)
            {
                string query = "SELECT Max(IBID) as LastID FROM ImportingBills";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        public bool InsertImportingBills(string username, string importingdate)
        {
            string query = "INSERT INTO ImportingBills(USERNAME, IMPORTINGDATE) VALUES	(N'" + username + "', '" + importingdate + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable GetCartByIBID(string ibid)
        {
            return ImportingDetailDAO.Instance.GetListIDbyIBID(ibid);
        }

        public bool DeleteImportingBills(string ibid)
        {
            ImportingDetailDAO.Instance.DeleteImportingDetailByIBID(ibid);

            string query = "DELETE ImportingBills WHERE IBID = '" + ibid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateImportingNote( string note, string ibid)
        {
            string query = "UPDATE ImportingBills SET IBNOTE = N'" + note + "' WHERE IBID = '" + ibid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ImportBill(string ibid, string totalcount)
        {
            string query = "UPDATE ImportingBills SET TOTALCOUNT = " + totalcount + " WHERE IBID = '" + ibid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Xuất bảng Importing
        public DataTable GetImportingBills()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT IBID as [Mã HĐ], USERNAME as [Mã NV], IMPORTINGDATE as [Ngày nhập], TOTALCOUNT as [Tổng SL], IBNOTE as [Ghi chú] FROM ImportingBills");
        }

        public DataTable GetImportingBillsByDate(string dateStart, string dateEnd)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT IBID as [Mã HĐ], USERNAME as [Mã NV], IMPORTINGDATE as [Ngày nhập], TOTALCOUNT as [Tổng SL], IBNOTE as [Ghi chú] FROM ImportingBills WHERE IMPORTINGDATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "'");
        }
    }
}
