using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DTO
{
    public class Product
    {
        public Product(string productid, string catalogueid, string productname, string productinventory, string productprice, string productpicture, string gemweight, string productweight, string productnote, string processingfee)
        {
            this.ProductID = productid;
            this.CatalogueID = catalogueid;
            this.ProductName = productname;
            this.ProductInventory = productinventory;
            this.ProductPrice = productprice;
            this.ProductPicture = productpicture;
            this.GemWeight = gemweight;
            this.ProductWeight = productweight;
            this.ProductNote = productnote;
            this.ProcessingFee = processingfee;
        }

        private string productID;
        private string catalogueID;
        private string productName;
        private string productInventory;
        private string productPrice;
        private string productPicture;
        private string gemWeight;
        private string productWeight;
        private string productNote;
        private string processingFee;

        public string ProductID { get => productID; set => productID = value; }
        public string CatalogueID { get => catalogueID; set => catalogueID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductInventory { get => productInventory; set => productInventory = value; }
        public string ProductPrice { get => productPrice; set => productPrice = value; }
        public string ProductPicture { get => productPicture; set => productPicture = value; }
        public string GemWeight { get => gemWeight; set => gemWeight = value; }
        public string ProductWeight { get => productWeight; set => productWeight = value; }
        public string ProductNote { get => productNote; set => productNote = value; }
        public string ProcessingFee { get => processingFee; set => processingFee = value; }

        public Product(DataRow row)
        {
            this.ProductID = row["PRODUCTID"].ToString();
            this.CatalogueID = row["CATALOGUEID"].ToString();
            this.ProductName = row["PRODUCTNAME"].ToString();
            this.ProductInventory = row["PRODUCTINVENTORY"].ToString();
            this.ProductPrice = row["PRODUCTPRICE"].ToString();
            this.ProductPicture = row["PRODUCTPICTURE"].ToString();
            this.GemWeight = row["GEMWEIGHT"].ToString();
            this.ProductWeight = row["PRODUCTWEIGHT"].ToString();
            this.ProductNote = row["NOTE"].ToString();
            this.ProcessingFee = row["PROCESSINGFEE"].ToString();
        }
    }
}
