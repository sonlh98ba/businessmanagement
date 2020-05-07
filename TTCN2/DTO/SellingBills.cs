using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DTO
{
    public class SellingBills
    {
        public SellingBills(string sbid, string maineid, string extraeid, string customerphone, DateTime sbdate, string sbbonusfee, string sbbonuscontent, string sbtotalprice)
        {
            this.Sbid = sbid;
            this.Maineid = maineid;
            this.Extraeid = extraeid;
            this.Customerphone = customerphone;
            this.Sbdate = sbdate;
            this.Sbbonusfee = sbbonusfee;
            this.Sbbonuscontent = sbbonuscontent;
            this.Sbtotalprice = sbtotalprice;
        }
        private string sbid;
        private string maineid;
        private string extraeid;
        private string customerphone;
        private DateTime sbdate;
        private string sbbonusfee;
        private string sbbonuscontent;
        private string sbtotalprice;

        public string Sbid { get => sbid; set => sbid = value; }
        public string Maineid { get => maineid; set => maineid = value; }
        public string Extraeid { get => extraeid; set => extraeid = value; }
        public string Customerphone { get => customerphone; set => customerphone = value; }
        public DateTime Sbdate { get => sbdate; set => sbdate = value; }
        public string Sbbonusfee { get => sbbonusfee; set => sbbonusfee = value; }
        public string Sbbonuscontent { get => sbbonuscontent; set => sbbonuscontent = value; }
        public string Sbtotalprice { get => sbtotalprice; set => sbtotalprice = value; }

        public SellingBills(DataRow row)
        {
            this.Sbid = row["SBID"].ToString();
            this.Maineid = row["MAINEID"].ToString();
            this.Extraeid = row["EXTRAEID"].ToString();
            this.Customerphone = row["CUSTOMERPHONE"].ToString();
            this.Sbdate = (DateTime)row["SBDATE"];
            this.Sbbonusfee = row["SBBONUSFEE"].ToString();
            this.Sbbonuscontent = row["SBBONUSCONTENT"].ToString();
            this.Sbtotalprice = row["SBTOTALPRICE"].ToString();
        }
    }
}
