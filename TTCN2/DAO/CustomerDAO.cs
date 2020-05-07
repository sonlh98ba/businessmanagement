using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCN2.DTO;

namespace TTCN2.DAO
{
    class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }

        private CustomerDAO() { }

        // Xuất danh sách Customer
        public List<Customer> LoadCustomer()
        {
            List<Customer> customerList = new List<Customer>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Customer");

            foreach (DataRow item in data.Rows)
            {
                Customer customers = new Customer(item);
                customerList.Add(customers);
            }

            return customerList;
        }

        public DataTable GetCustomerList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT CUSTOMERPHONE as [SĐT], CUSTOMERNAME as [Tên khách hàng], CUSTOMERDOB as [Ngày sinh], PURCHASED as [Lượt mua], TOTALCONSUMPTION as [Tổng mua], CUSTOMERADDRESS as [Địa chỉ] FROM Customer");
        }

        public bool InsertCustomer(string customerphone, string customername, string customerDOB, string address)
        {
            string query = "INSERT INTO Customer(CUSTOMERPHONE, CUSTOMERNAME, CUSTOMERDOB, PURCHASED, TOTALCONSUMPTION, CUSTOMERADDRESS) VALUES	( N'" + customerphone + "', N'" + customername + "', '" + customerDOB + "'," + 0 + "," + 0 + ", N'" + address + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCustomer(string customerphone, string customername, string customerDOB, string purchased, string totalconsumption, string address)
        {
            string query = "UPDATE Customer SET CUSTOMERNAME = N'" + customername + "', CUSTOMERDOB = '" + customerDOB + "', PURCHASED = " + purchased + ", TOTALCONSUMPTION = " + totalconsumption + ", CUSTOMERADDRESS = N'" + address + "' WHERE CUSTOMERPHONE = N'" + customerphone + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCustomer(string customerphone)
        {
            OrderBillsDAO.Instance.DeleteAllOrderBillsByCustomerPhone(customerphone);
            SellingBillsDAO.Instance.DeleteAllSellingBillsByCustomerPhone(customerphone);

            string query = "DELETE Customer WHERE CUSTOMERPHONE = N'" + customerphone + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool IndenticalCheck(string customerphone)
        {
            return (Convert.ToInt32(DataProvider.Instance.ExecuteScalar("Select COUNT(*) FROM Customer WHERE CUSTOMERPHONE = N'" + customerphone + "'")) > 0);
        }
    }
}
