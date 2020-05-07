using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTCN2.DTO;

namespace TTCN2.DAO
{
    public class CatalogueDAO
    {
        private static CatalogueDAO instance;
        public static CatalogueDAO Instance
        {
            get { if (instance == null) instance = new CatalogueDAO(); return CatalogueDAO.instance; }
            private set { CatalogueDAO.instance = value; }
        }

        private CatalogueDAO() { }

        // Xuất danh sách Catalogue
        public List<Catalogue> LoadCatalogue()
        {
            List<Catalogue> catalogueList = new List<Catalogue>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Catalogue");

            foreach (DataRow item in data.Rows)
            {
                Catalogue catalogue = new Catalogue(item);
                catalogueList.Add(catalogue);
            }

            return catalogueList;
        }

        // Xuất bảng Catalogue
        public DataTable GetCatalogue()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT CATALOGUEID as [Mã loại], CATALOGUENAME as [Tên loại], MATERIAL as [Chất liệu] FROM Catalogue");
        }

        public bool UpdateCatalogue(string catalogueid, string cataloguename, string material)
        {
            string query = "UPDATE Catalogue SET CATALOGUEID = N'" + catalogueid + "', CATALOGUENAME = N'" + cataloguename + "', MATERIAL = N'" + material + "' WHERE CATALOGUEID = N'" + catalogueid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool InsertCatalogue(string catalogueid, string cataloguename, string material)
        {
            string query = "INSERT INTO Catalogue(CATALOGUEID, CATALOGUENAME, MATERIAL) VALUES	( N'" + catalogueid + "', N'" + cataloguename + "', N'" + material + "'" + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCatalogue(string catalogueid)
        {
            ProductDAO.Instance.DeleteProductByCatalogueID(catalogueid);

            string query = "DELETE Catalogue WHERE CatalogueID = N'" + catalogueid + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool IndenticalCheck(string catalogueid)
        {
            return (Convert.ToInt32(DataProvider.Instance.ExecuteScalar("Select COUNT(*) FROM Catalogue WHERE CATALOGUEID = N'" + catalogueid + "'")) > 0);
        }
    }
}
