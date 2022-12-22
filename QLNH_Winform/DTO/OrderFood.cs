using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_Winform.DTO
{
    internal class OrderFood
    {
        public OrderFood(string name, int count, float price, float totalPrice, int foodID)
        {
            this.FoodName = name;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
            this.foodId = foodID;
        }

        public OrderFood(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
            this.foodId = (int)row["id"];
        }
        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private float totalPrice;
        public float TotalPrice
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
        private int foodId;
        public int FoodId
        {
            get { return foodId; }
            set { foodId = value; }
        }
    }
}
