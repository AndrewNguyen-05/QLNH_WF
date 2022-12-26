using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_Winform.DTO
{
    internal class MenuFood
    {
        public MenuFood(string name, int count, double price, double totalPrice)
        {
            this.FoodName = name;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public MenuFood(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (double)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (double)Convert.ToDouble(row["totalPrice"].ToString());
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private double totalPrice;
        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private string foodName;
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }
    }
}
