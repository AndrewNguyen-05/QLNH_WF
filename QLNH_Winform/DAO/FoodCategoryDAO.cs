using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH_Winform.DTO;

namespace QLNH_Winform.DAO
{
    public class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;
        public static FoodCategoryDAO Instance
        {
            get { if (instance == null) instance = new FoodCategoryDAO(); return FoodCategoryDAO.instance; }
            private set { FoodCategoryDAO.instance = value; }
        }
        private FoodCategoryDAO()
        {

        }

        public List<FoodCategory> GetListCategory()
        {
            List<FoodCategory> list = new List<FoodCategory>();
            string query = " SELECT * FROM foodcategory WHERE isHidden = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows) 
            {
                FoodCategory category = new FoodCategory(item);
                list.Add(category);
            }
            return list;
        }
        public List<FoodCategory> GetListCategory(string name)
        {
            List<FoodCategory> list = new List<FoodCategory>();
            string query = string.Format("SELECT * FROM foodcategory WHERE isHidden = 0 AND name like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                FoodCategory category = new FoodCategory(item);
                list.Add(category);
            }
            return list;
        }
        public FoodCategory GetCategoryByID(int id)
        {
            FoodCategory category = null;
            string query = " SELECT * FROM foodcategory WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new FoodCategory(item);
                return category;
            }
            return category;
        }

        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT FoodCategory (name) VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("UPDATE FoodCategory SET name = N'{1}' WHERE id = {0}", id, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCategory(int id)
        {

            string query = string.Format("UPDATE FoodCategory SET isHidden = 1 WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
