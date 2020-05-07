using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DTO
{
    public class PromotionDetail
    {
        public PromotionDetail(string promotionID, string productID)
        {
            this.PromotionID = promotionID;
            this.ProductID = productID;
        }
        private string promotionID;
        private string productID;
        
        public string PromotionID { get => promotionID; set => promotionID = value; }
        public string ProductID { get => productID; set => productID = value; }

        public PromotionDetail(DataRow row)
        {
            this.PromotionID = row["PROMOTIONID"].ToString();
            this.ProductID = row["PRODUCTID"].ToString();
        }
    }
}
