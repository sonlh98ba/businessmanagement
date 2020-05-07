using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DAO
{
    class PromotionDetailDAO
    {
        private static PromotionDetailDAO instance;
        public static PromotionDetailDAO Instance
        {
            get { if (instance == null) instance = new PromotionDetailDAO(); return PromotionDetailDAO.instance; }
            private set { PromotionDetailDAO.instance = value; }
        }

        private PromotionDetailDAO() { }

        public void DeletePromotionDetailByProductID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE PromotionDetail WHERE PRODUCTID = N'" + id + "'");
        }

        public void DeletePromotionDetailByPromotionID(string id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE PromotionDetail WHERE PROMOTIONID = N'" + id + "'");
        }
    }
}
