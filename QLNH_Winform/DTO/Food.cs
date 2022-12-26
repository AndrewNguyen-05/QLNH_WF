using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_Winform.DTO
{
    public class Food
    {
        public Food(int id, string name, int categoryID, double price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idcategory"];
            this.Price = (double)Convert.ToDouble(row["price"].ToString());
        }
        private string name;
        private int id;
        private int categoryID;
        private double price;

        [DisplayName("Tên Món")]
        public string Name { get => name; set => name = value; }
        public int ID { get => id; set => id = value; }
        [DisplayName("Danh Mục")]
        public int CategoryID { get => categoryID; set => categoryID = value; }
        [DisplayName("Giá Tiền")]
        public double Price { get => price; set => price = value; }
    }
}
