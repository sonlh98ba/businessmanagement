using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DTO
{
    class Customer
    {
        public Customer(string customerPhone, string customerName, DateTime customerDOB, decimal purchased, int totalConsumption, string customerAddress)
        {
            this.CustomerPhone = customerPhone;
            this.CustomerName = customerName;
            this.CustomerDOB = customerDOB;
            this.Purchased = purchased;
            this.TotalConsumption = totalConsumption;
            this.CustomerAddress = customerAddress;
        }
        private string customerName;
        private string customerPhone;
        private DateTime customerDOB;
        private decimal purchased;
        private int totalConsumption;
        private string customerAddress;

        public string CustomerPhone { get => customerPhone; set => customerPhone = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public DateTime CustomerDOB { get => customerDOB; set => customerDOB = value; }
        public decimal Purchased { get => purchased; set => purchased = value; }
        public int TotalConsumption { get => totalConsumption; set => totalConsumption = value; }
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }


        public Customer(DataRow row)
        {
            this.CustomerPhone = row["CUSTOMERPHONE"].ToString();
            this.CustomerName = row["CUSTOMERNAME"].ToString();
            this.CustomerDOB = (DateTime)row["CUSTOMERDOB"];
            this.Purchased = (decimal)row["PURCHASED"];
            this.TotalConsumption = (int)row["TOTALCONSUMPTION"];
            this.CustomerAddress = row["CUSTOMERADDRESS"].ToString();
        }
    }
}
