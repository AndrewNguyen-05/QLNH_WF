using QLNH_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_Winform.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }
        private FoodDAO()
        {

        }
        public Food GetFoodByID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM Food WHERE isHidden = 0 AND id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                return food;
            }
            return null;
        }
        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query;
            if (id == 0) query = "SELECT * FROM Food WHERE isHidden = 0";
            else query = "SELECT * FROM Food WHERE isHidden = 0 AND idCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public List<Food> GetFoodByCategoryID(int id, string name)
        {
            List<Food> list = new List<Food>();
            string query;
            if (id == 0) return GetListFood(name);
            else query = string.Format("SELECT * FROM Food WHERE isHidden = 0 AND idCategory = {0} AND name like N'%{1}%'", id, name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM Food WHERE isHidden = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public List<Food> GetListFood(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("SELECT * FROM Food WHERE isHidden = 0 AND name like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public bool InsertFood(string name, int id, float price)
        {
            string query = string.Format("INSERT Food ( name, idCategory, price) VALUES (N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateFood(int idFood, string name, int id, float price)
        {
            string query = string.Format("UPDATE Food SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteFood(int idFood)
        {
            string query = string.Format("UPDATE Food SET isHidden = 1 WHERE id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
