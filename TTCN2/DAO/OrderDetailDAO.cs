using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DAO
{
    class OrderDetailDAO
    {
        private static OrderDetailDAO instance;
        public static OrderDetailDAO Instance
        {
            get { if (instance == null) instance = new OrderDetailDAO(); return OrderDetailDAO.instance; }
            private set { OrderDetailDAO.instance = value; }
        }

        private OrderDetailDAO() { }

        public DataTable GetListOdbyOBID(string obid)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT PRODUCTID as [Mã SP], ODDEPOSIT as [Đặt cọc], ODCOUNT as [Số lượng], ODPRICE as [Giá SP], ODNOTE as [Ghi chú] FROM OrderDetail WHERE OBID = '" + obid + "'");
        }

        public string GetTotalPricebyOBID(string obid)
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from OrderDetail WHERE OBID = '" + obid + "'") != 0)
            {
                string query = "select SUM(ODPRICE * ODCOUNT) from OrderDetail where OBID = '" + obid + "'";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        public bool UpdateCountOrderDetail(string odcount, string deposit, string productid, string obid)
        {
            string query = "UPDATE OrderDetail SET ODCOUNT = " + odcount + ", ODDEPOSIT = " + (Convert.ToInt32(odcount) * Convert.ToInt32(deposit)).ToString() + " WHERE PRODUCTID = N'" + productid + "' and OBID = '" + obid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public string GetTotalDepositbyOBID(string obid)
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from OrderDetail WHERE OBID = '" + obid + "'") != 0)
            {
                string query = "select SUM(ODDEPOSIT) from OrderDetail where OBID = '" + obid + "'";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        public bool InsertOrderDetail(string obid, string productid, string odcount, string odprice, string odnote)
        {
            string query = "INSERT INTO OrderDetail(OBID, PRODUCTID, ODDEPOSIT, ODCOUNT, ODPRICE, ODNOTE) VALUES	( '" + obid + "', N'" + productid + "', 0, " + odcount + ", " + odprice + ", N'" + odnote + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void DeleteOrderDetailByProductID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE OrderDetail WHERE PRODUCTID = N'" + id + "'");
        }

        public void DeleteOrderDetailByOBID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE OrderDetail WHERE OBID = '" + id + "'");
        }

        public bool DeleteOrderBills(string obid)
        {
            OrderDetailDAO.Instance.DeleteOrderDetailByOBID(obid);

            string query = "DELETE OrderBills WHERE OBID = '" + obid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool IndenticalCheck(string productid, string obid)
        {
            return (Convert.ToInt32(DataProvider.Instance.ExecuteScalar("Select COUNT(*) FROM OrderDetail WHERE PRODUCTID = N'" + productid + "' and OBID = '" + obid + "'")) > 0);
        }
    }
}
