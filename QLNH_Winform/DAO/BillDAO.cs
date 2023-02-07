using QLNH_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNH_Winform.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;

        internal static BillDAO Instance
        {
            get
            {
                if (instance == null) BillDAO.instance = new BillDAO();
                return instance;
            }
            set => instance = value;
        }

        private BillDAO() { }

        //Thành công: bill.ID
        //Thất bại: -1
        public int GetUncheckBillIDbyTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idTable = " + id + " AND (status = 0 or isServed = 0)");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public Bill GetBillbyTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idTable = " + id + " AND (status = 0 OR isServed = 0)");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill;
            }
            return null;
        }

        public Bill GetBillbyBillID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE id = " + id + " AND (status = 0 OR isServed = 0)");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill;
            }
            return null;
        }

        public void CheckOut(int id, int discount, double totalPrice)
        {
            string query = "UPDATE Bill SET DateCheckOut = GETDATE(), status = 1, " + "discount = " + discount + ", totalPrice = " + totalPrice +" WHERE id = " + id.ToString();
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        public double GetTotalPriceByDate(DateTime checkIn, DateTime checkOut)
        {
            DataTable tmp = DataProvider.Instance.ExecuteQuery("EXEC USP_GetTotalMoneyByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
            try
            {
                return (double)tmp.Rows[0]["totalMoney"];
            }
            catch
            {
                return 0;
            }
        }
        public int GetMaxIDBill()
        { 
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 0;
            }
        }

        public DataTable GetListProcessingBill()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListProcessingBill", new object[] { });
        }

        public void updateBillStatus(int id, int status, int isServed)
        {
            string query = string.Format("UPDATE Bill SET status = {1}, isServed = {2} WHERE id = {0}", id, status, isServed); 
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void UpdatePrice(int id, int discount, double totalPrice)
        {
            string query = "UPDATE Bill SET " + "discount = " + discount + ", totalPrice = " + totalPrice + " WHERE id = " + id.ToString();
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void DeleteBill(int id)
        {
            string query = "DELETE BillInfo WHERE idBill = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
            query = "DELETE Bill WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        //public void updateBillStatus(int id, int idTable)
        //{
        //    string query = string.Format("UPDATE Bill SET idTable = {1} WHERE id = {0}", id, idTable);
        //    DataProvider.Instance.ExecuteNonQuery(query);
        //}
        public Bill GetUnCheckBillwithID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE id ='" + id + "'");
            if (data.Rows.Count == 0)
            {
                return null;
            }
            Bill bill = new Bill(data.Rows[0]);

            return bill;
        }
    }
}
