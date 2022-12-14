using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_Winform.DTO
{
    public class FoodCategory
    {
        private int iD;
        private string name;
        public FoodCategory(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public FoodCategory(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
