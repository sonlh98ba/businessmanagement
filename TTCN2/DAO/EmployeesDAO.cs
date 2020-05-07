using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCN2.DTO;

namespace TTCN2.DAO
{
    public class EmployeesDAO
    {
        private static EmployeesDAO instance;
        public static EmployeesDAO Instance
        {
            get { if (instance == null) instance = new EmployeesDAO(); return EmployeesDAO.instance; }
            private set { EmployeesDAO.instance = value; }
        }

        private EmployeesDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM Employees WHERE USERNAME = N'" + userName + "' AND PASSWORD = N'" + passWord + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        // Xuất danh sách Employees
        public List<Employees> LoadEmployees()
        {
            List<Employees> employeesList = new List<Employees>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Employees");

            foreach (DataRow item in data.Rows)
            {
                Employees employees = new Employees(item);
                employeesList.Add(employees);
            }

            return employeesList;
        }

        // Xuất thông tin Employees
        public Employees LoadEmployeesInfo(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Employees WHERE USERNAME = N'" + username + "'");

            Employees employees = new Employees(data.Rows[0]);

            return employees;
        }

        public DataTable GetUserList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT USERNAME as [Tên đăng nhập], UFULLNAME as [Tên nhân viên],  UDOB, UADDRESS, UGENDER, UPHONE, UREGENCY, USALARY, URIGHT FROM Employees");
        }

        public string GetUserRegencyByUserName(string username)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT UREGENCY FROM Employees WHERE USERNAME = N'" + username +"'").ToString();
        }

        public string GetUserFullNameByUserName(string username)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT UFULLNAME FROM Employees WHERE USERNAME = N'" + username + "'").ToString();
        }

        public string GetUserRightByUserName(string username)
        {
            return DataProvider.Instance.ExecuteScalar("SELECT URIGHT FROM Employees WHERE USERNAME = N'" + username + "'").ToString();
        }

        public bool UpdateEmployee(string username, string password, string fullname, string dob, string address, string gender, string phone)
        {
            string query = "UPDATE Employees SET PASSWORD = N'" + password + "', UFULLNAME = N'" + fullname + "', UDOB = '" + dob + "', UADDRESS = N'" + address + "', UGENDER = " + gender + ", UPHONE = N'" + phone + "' WHERE USERNAME = N'" + username + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string username)
        {
            string query = "UPDATE Employees SET PASSWORD = N'1' WHERE USERNAME = N'" + username + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateUser(string username, string fullname, string uright, string dob, string address, string gender, string phone, string regency, string salary)
        {
            string query = "UPDATE Employees SET UFULLNAME = N'" + fullname + "', URIGHT = " + uright + ", UDOB = '" + dob + "', UADDRESS = N'" + address + "', UGENDER = " + gender + ", UPHONE = N'" + phone + "', UREGENCY = N'" + regency + "', USALARY = '" + salary + "' WHERE USERNAME = N'" + username + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InsertEmployee(string username, string fullname, string uright)
        {
            string query = "INSERT INTO Employees(USERNAME, PASSWORD, UFULLNAME, URIGHT, UDOB, UADDRESS, UGENDER, UPHONE, UREGENCY, USALARY) VALUES	( N'" + username + "', N'1', N'" + fullname + "'," + uright + ",'" + DateTime.Now.ToString() + "', N'Chưa rõ', 1, N'Chưa rõ', N'Nhân viên', 0)";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool IndenticalCheck(string username)
        {
            return (Convert.ToInt32(DataProvider.Instance.ExecuteScalar("Select COUNT(*) FROM Employees WHERE USERNAME = N'" + username + "'")) > 0);
        }
    }
}
