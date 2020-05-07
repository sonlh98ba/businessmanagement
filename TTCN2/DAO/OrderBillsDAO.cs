using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCN2.DTO;

namespace TTCN2.DAO
{
    class OrderBillsDAO
    {
        private static OrderBillsDAO instance;
        public static OrderBillsDAO Instance
        {
            get { if (instance == null) instance = new OrderBillsDAO(); return OrderBillsDAO.instance; }
            private set { OrderBillsDAO.instance = value; }
        }

        private OrderBillsDAO() { }

        public string GetMaxId()
        {
            if ((int)DataProvider.Instance.ExecuteScalar("Select COUNT(*) from OrderBills") != 0)
            {
                string query = "SELECT Max(OBID) as LastID FROM OrderBills";
                string result = DataProvider.Instance.ExecuteScalar(query).ToString();
                return result;
            }
            else
            {
                return "0";
            }
        }

        // Xuất bảng OrderBills
        public DataTable GetOrderBills()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT OBID as [Mã ĐĐH], OBEID as [Mã NV], CUSTOMERPHONE as [SĐT khách], ORDERDATE as [Ngày ĐH], RECEIVEDATE as [Ngày nhận], OBMONEY as [Tiền cọc] FROM OrderBills");
        }

        public DataTable GetOrderMoney(string date)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT OBID as [Mã ĐĐH], OBMONEY as [Tiền cọc] FROM OrderBills WHERE ORDERDATE = '" + date + "'");
        }

        public string GetOnlyOrderMoney(string date)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT SUM(OBMONEY) FROM OrderBills WHERE ORDERDATE = '" + date + "'").ToString() != ""
                ? DataProvider.Instance.ExecuteScalar("SELECT SUM(OBMONEY) FROM OrderBills WHERE ORDERDATE = '" + date + "'").ToString()
                : "0";
        }

        public DataTable GetOrderBillsByOrderDate(string dateStart, string dateEnd)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT OBID as [Mã ĐĐH], OBEID as [Mã NV], CUSTOMERPHONE as [SĐT khách], ORDERDATE as [Ngày ĐH], RECEIVEDATE as [Ngày nhận], OBMONEY as [Tiền cọc] FROM OrderBills WHERE ORDERDATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "'");
        }

        public DataTable GetOrderBillsByReceiveDate(string dateStart, string dateEnd)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT OBID as [Mã ĐĐH], OBEID as [Mã NV], CUSTOMERPHONE as [SĐT khách], ORDERDATE as [Ngày ĐH], RECEIVEDATE as [Ngày nhận], OBMONEY as [Tiền cọc] FROM OrderBills WHERE RECEIVEDATE BETWEEN '" + dateStart + "' AND '" + dateEnd + "'");
        }

        // Xuất danh sách OrderBills
        public List<OrderBills> LoadOrderBills()
        {
            List<OrderBills> orderBillsList = new List<OrderBills>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM OrderBills WHERE RECEIVEDATE IS NOT NULL");

            foreach (DataRow item in data.Rows)
            {
                OrderBills orderbills = new OrderBills(item);
                orderBillsList.Add(orderbills);
            }

            return orderBillsList;
        }

        public DataTable GetCartByOBID(string obid)
        {
            return OrderDetailDAO.Instance.GetListOdbyOBID(obid);
        }

        // Xuất danh sách OrderBills
        public List<OrderBills> LoadOrderBillsByCustomerPhone(string customerphone)
        {
            List<OrderBills> orderBillsList = new List<OrderBills>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM OrderBills WHERE CUSTOMERPHONE = N'" + customerphone + "'");

            foreach (DataRow item in data.Rows)
            {
                OrderBills orderbills = new OrderBills(item);
                orderBillsList.Add(orderbills);
            }

            return orderBillsList;
        }

        public bool InsertOrderBills(string maineid, string customerphone, string orderdate)
        {
            string query = "INSERT INTO OrderBills(OBEID, CUSTOMERPHONE, ORDERDATE, OBMONEY) VALUES	(N'" + maineid + "', N'" + customerphone + "','" + orderdate + "',0)";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteOrderBills(string obid)
        {
            OrderDetailDAO.Instance.DeleteOrderDetailByOBID(obid);

            string query = "DELETE OrderBills WHERE OBID = '" + obid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAllOrderBillsByCustomerPhone(string customerphone)
        {
            bool result = true;
            List<OrderBills> list = new List<OrderBills>();
            list = LoadOrderBillsByCustomerPhone(customerphone);
            foreach (var item in list)
            {
                result = result && DeleteOrderBills(item.OBID);
            }
            return result;
        }

        public bool PayTheDeposit(string obid, string receivedate, string obmoney)
        {
            string query = "UPDATE OrderBills SET RECEIVEDATE = '" + receivedate + "', OBMONEY = " + obmoney + " WHERE OBID = '" + obid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
