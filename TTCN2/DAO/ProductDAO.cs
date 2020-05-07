using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCN2.DTO;

namespace TTCN2.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }

        private ProductDAO() { }

        // Xuất danh sách Catalogue
        public List<Product> LoadProductByCatalogueID(string catalogueid)
        {
            List<Product> productList = new List<Product>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Product WHERE CATALOGUEID = N'"+ catalogueid + "'");

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                productList.Add(product);
            }

            return productList;
        }

        public DataTable GetProductByCatalogueID(string CatalogueID)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT PRODUCTID as [Mã SP], CATALOGUEID as [Mã loại],PRODUCTNAME as [Tên SP], PRODUCTINVENTORY as [Tồn kho], PRODUCTPRICE as [Giá], PRODUCTPICTURE, GEMWEIGHT as [TL Đá], PRODUCTWEIGHT as [TL SP], NOTE as [Ghi chú], PROCESSINGFEE as [Phí GC] FROM Product WHERE CATALOGUEID = N'" + CatalogueID + "'");
        }

        public bool InsertProduct(string productid, string catalogueid, string productname, string productinventory, string productprice, string productpicture, string gemweight, string productweight, string productnote, string processingfee)
        {
            string query = "INSERT INTO Product(PRODUCTID, CATALOGUEID, PRODUCTNAME, PRODUCTINVENTORY, PRODUCTPRICE, PRODUCTPICTURE, GEMWEIGHT, PRODUCTWEIGHT, NOTE, PROCESSINGFEE) VALUES	( N'" + productid + "', N'" + catalogueid + "', N'" + productname + "', " + productinventory + ", " + productprice + ", '" + productpicture + "', " + gemweight + ", " + productweight + ", N'" + productnote + "', " + processingfee + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateProduct(string productid, string catalogueid, string productname, string productinventory, string productprice, string productpicture, string gemweight, string productweight, string productnote, string processingfee)
        {
            string query = "UPDATE Product SET CATALOGUEID = N'" + catalogueid + "', PRODUCTNAME = N'" + productname + "', PRODUCTINVENTORY = " + productinventory + ", PRODUCTPRICE = " + productprice + ", PRODUCTPICTURE = '" + productpicture + "', GEMWEIGHT = " + gemweight + ", PRODUCTWEIGHT = " + productweight + ", NOTE = N'" + productnote + "', PROCESSINGFEE = " + processingfee + " WHERE PRODUCTID = N'" + productid +"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteProduct(string productid)
        {
            ProductWarrantyDAO.Instance.DeleteProductWarrantyByProductID(productid);
            ImportingDetailDAO.Instance.DeleteImportingDetailByProductID(productid);
            OrderDetailDAO.Instance.DeleteOrderDetailByProductID(productid);
            SellingDetailDAO.Instance.DeleteSellingDetailByProductID(productid);
            RepurchaseDAO.Instance.DeleteRepurchaseByProductID(productid);
            PromotionDetailDAO.Instance.DeletePromotionDetailByProductID(productid);

            string query = "DELETE PRODUCT WHERE PRODUCTID = N'"+ productid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void DeleteProductByCatalogueID(string catalogueid)
        {
            List<Product> catalogueList = LoadProductByCatalogueID(catalogueid);
            foreach (var item in catalogueList)
            {
                DeleteProduct(item.ProductID);
            }
        }

        // Đếm tổng SP
        public string GetTotalProductAmount()
        {
            return DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM PRODUCT").ToString();
        }

        public bool IndenticalCheck(string productid)
        {
            return (Convert.ToInt32(DataProvider.Instance.ExecuteScalar("Select COUNT(*) FROM PRODUCT WHERE PRODUCTID = N'" + productid + "'")) > 0);
        }
    }
}
