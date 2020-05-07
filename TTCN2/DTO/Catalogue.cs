using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCN2.DTO
{
    public class Catalogue
    {
        public Catalogue(string id, string name, string material)
        {
            this.ID = id;
            this.Name = name;
            this.Material = material;
        }
        private string name;
        private string iD;
        private string material;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Material { get => material; set => material = value; }

        public Catalogue(DataRow row)
        {
            this.ID = row["CATALOGUEID"].ToString();
            this.Name= row["CATALOGUENAME"].ToString();
            this.Material = row["MATERIAL"].ToString();
        }
    }
}
