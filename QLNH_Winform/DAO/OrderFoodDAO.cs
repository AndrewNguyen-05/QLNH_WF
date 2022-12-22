using QLNH_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_Winform.DAO
{
    internal class OrderFoodDAO
    {
        private static OrderFoodDAO instance;

        internal static OrderFoodDAO Instance
        {
            get
            {
                if (instance == null) instance = new OrderFoodDAO();
                return OrderFoodDAO.instance;
            }
            set => instance = value;
        }
        private OrderFoodDAO() { }

        public List<OrderFood> GetListMenuByTable(int id)
        {
            List<OrderFood> listMenu = new List<OrderFood>();

            string query = "SELECT f.name, bi.count, f.price, f.price * bi.count AS totalPrice, f.id\r\nFROM BillInfo bi, Bill b, Food f\r\nWHERE bi.idBill = b.id AND bi.idFood = f.id AND (b.status = 0 or b.isServed = 0) AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                OrderFood menu = new OrderFood(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
        public List<OrderFood> GetListMenuByBill(int id)
        {
            List<OrderFood> listMenu = new List<OrderFood>();

            string query = "SELECT f.name, bi.count, f.price, f.price * bi.count AS totalPrice, f.id\r\nFROM BillInfo bi, Bill b, Food f\r\nWHERE bi.idBill = b.id AND bi.idFood = f.id AND (b.status = 0 or b.isServed = 0) AND b.id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                OrderFood menu = new OrderFood(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
