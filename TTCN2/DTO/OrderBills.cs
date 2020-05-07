using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DTO
{
    class OrderBills
    {
        public OrderBills(string obid, string obeid, string customerPhone, DateTime orderDate, DateTime receiveDate,int obMoney)
        {
            this.OBID = obid;
            this.Obeid = obeid;
            this.CustomerPhone = customerPhone;
            this.OrderDate = orderDate;
            this.ReceiveDate = receiveDate;
            this.ObMoney = obMoney;
        }
        private string obid;
        private string obeid;
        private string customerPhone;
        private DateTime orderDate;
        private DateTime receiveDate;
        private int obMoney;

        public string OBID { get => obid; set => obid = value; }
        public string Obeid { get => obeid; set => obeid = value; }
        public string CustomerPhone { get => customerPhone; set => customerPhone = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public DateTime ReceiveDate { get => receiveDate; set => receiveDate = value; }
        public int ObMoney { get => obMoney; set => obMoney = value; }

        public OrderBills(DataRow row)
        {
            this.OBID = row["OBID"].ToString();
            this.Obeid = row["OBEID"].ToString();
            this.CustomerPhone = row["CUSTOMERPHONE"].ToString();
            this.OrderDate = (DateTime)row["ORDERDATE"];
            this.ReceiveDate = (DateTime)row["RECEIVEDATE"];
            this.ObMoney = (int)row["OBMONEY"];
        }
    }
}
