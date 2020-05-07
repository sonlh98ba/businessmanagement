using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DTO
{
    public class Employees
    {
        public Employees(string userName, string passWord, string uFullName, DateTime uDOB, string uAddress, bool uGender, string uPhone, string uRegency, int uSalary, int uRight)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.UFullName = uFullName;
            this.UDOB = uDOB;
            this.UAddress = uAddress;
            this.UGender = uGender;
            this.UPhone = uPhone;
            this.URegency = uRegency;
            this.USalary = uSalary;
            this.URight = uRight;
        }
        private string userName;
        private string passWord;
        private string uFullName;
        private DateTime uDOB;
        private string uAddress;
        private bool uGender;
        private string uPhone;
        private string uRegency;
        private int uSalary;
        private int uRight;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string UFullName { get => uFullName; set => uFullName = value; }
        public DateTime UDOB { get => uDOB; set => uDOB = value; }
        public string UAddress { get => uAddress; set => uAddress = value; }
        public bool UGender { get => uGender; set => uGender = value; }
        public string UPhone { get => uPhone; set => uPhone = value; }
        public string URegency { get => uRegency; set => uRegency = value; }
        public int USalary { get => uSalary; set => uSalary = value; }
        public int URight { get => uRight; set => uRight = value; }

        public Employees(DataRow row)
        {
            this.UserName = row["USERNAME"].ToString();
            this.PassWord = row["PASSWORD"].ToString();
            this.UFullName = row["UFULLNAME"].ToString();
            this.UDOB = (DateTime)row["UDOB"];
            this.UAddress = row["UADDRESS"].ToString();
            this.UGender = (bool)row["UGENDER"];
            this.UPhone = row["UPHONE"].ToString();
            this.URegency = row["UREGENCY"].ToString();
            this.USalary = (int)row["USALARY"];
            this.URight = (int)row["URIGHT"];
        }
    }
}
