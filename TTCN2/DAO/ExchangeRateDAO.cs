using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DAO
{
    class ExchangeRateDAO
    {
        private static ExchangeRateDAO instance;
        public static ExchangeRateDAO Instance
        {
            get { if (instance == null) instance = new ExchangeRateDAO(); return ExchangeRateDAO.instance; }
            private set { ExchangeRateDAO.instance = value; }
        }

        private ExchangeRateDAO() { }

        public DataTable GetExchangeRateList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT CID as [Mã NT], CNAME as [Tên ngoại tệ], BUY111 as [Mua tiền mặt], BUY112 as [Mua chuyển khoản], SELL as [Bán] FROM Currency");
        }

    }
}
