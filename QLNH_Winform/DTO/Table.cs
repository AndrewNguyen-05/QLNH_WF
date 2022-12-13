using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_Winform.DTO
{
    internal class Table
    {
        public Table(string name, string status, int id)
        {
            this.Name = name;
            this.Status = status;
            this.ID = id;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }
        private int id;
        public int ID { get; set; }

        private int name;
        public string Name { get; set; }

        private string status;
        public string Status { get; set; }
    }
}
