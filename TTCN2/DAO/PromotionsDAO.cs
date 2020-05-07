using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCN2.DTO;

namespace TTCN2.DAO
{
    class PromotionsDAO
    {
        private static PromotionsDAO instance;
        public static PromotionsDAO Instance
        {
            get { if (instance == null) instance = new PromotionsDAO(); return PromotionsDAO.instance; }
            private set { PromotionsDAO.instance = value; }
        }

        private PromotionsDAO() { }

        // Xuất danh sách Promotions
        public List<PromotionDetail> LoadPromotions(string productid)
        {
            List<PromotionDetail> promotionsList = new List<PromotionDetail>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PromotionDetail WHERE PRODUCTID = N'" + productid + "'");

            foreach (DataRow item in data.Rows)
            {
                PromotionDetail promotions = new PromotionDetail(item);
                promotionsList.Add(promotions);
            }

            return promotionsList;
        }

        public int GetDiscountByPromotionsID(string promotionsid)
        {
            int result = 0;
            string query = "SELECT DISCOUNT FROM Promotions WHERE PROMOTIONID = N'" + promotionsid + "'";

            result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }

        public DataTable GetPromotionsList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT PROMOTIONID as [Mã CTKM], STARTINGDATE as [Ngày bắt đầu], ENDINGDATE as [Ngày kết thúc], DISCOUNT as [Giảm giá], GIFT as [Quà] FROM Promotions");
        }

        public bool InsertPromotion(string promotionid, string startingdate, string endingdate, string discount, string gift)
        {
            string query = "INSERT INTO Promotions(PROMOTIONID, STARTINGDATE, ENDINGDATE, DISCOUNT, GIFT) VALUES	( N'" + promotionid + "', '" + startingdate + "', '" + endingdate + "', " + discount + ", N'" + gift + "')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdatePromotion(string promotionid, string startingdate, string endingdate, string discount, string gift)
        {
            string query = "UPDATE Promotions SET STARTINGDATE = '" + startingdate + "', ENDINGDATE = '" + endingdate + "', DISCOUNT = " + discount + ", GIFT = N'" + gift + "' WHERE PROMOTIONID = N'" + promotionid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeletePromotion(string promotionid)
        {
            ProductWarrantyDAO.Instance.DeleteProductWarrantyByProductID(promotionid);
            ImportingDetailDAO.Instance.DeleteImportingDetailByProductID(promotionid);
            OrderDetailDAO.Instance.DeleteOrderDetailByProductID(promotionid);
            SellingDetailDAO.Instance.DeleteSellingDetailByProductID(promotionid);
            RepurchaseDAO.Instance.DeleteRepurchaseByProductID(promotionid);
            PromotionDetailDAO.Instance.DeletePromotionDetailByProductID(promotionid);

            string query = "DELETE Promotions WHERE PROMOTIONID = N'" + promotionid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool IndenticalCheck(string promotionid)
        {
            return (Convert.ToInt32(DataProvider.Instance.ExecuteScalar("Select COUNT(*) FROM Promotions WHERE PROMOTIONID = N'" + promotionid + "'")) > 0);
        }
    }
}
