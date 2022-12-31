using QLNH_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNH_Winform.DAO
{
    internal class BillInfoDAO
    {
        private static BillInfoDAO instance;

        internal static BillInfoDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
            set => instance = value;
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE idBill = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }


        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
            if (GetListBillInfo(idBill).Count < 1)
            {
                DataProvider.Instance.ExcuteScalar("DELETE Bill WHERE id = " + idBill);
            }
        }
        public void NewInsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_NewInsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
            if (GetListBillInfo(idBill).Count < 1)
            {
                DataProvider.Instance.ExcuteScalar("DELETE Bill WHERE id = " + idBill);
            }
        }

        public DataTable GetDetailBillByID(int id)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetDetailBillByID @idBill", new object[] {id});
        }

        public List<BillInfo> LoadDetailBillByID(int id)
        {
            List<BillInfo> billInfos = new List<BillInfo>();

            DataTable data =  DataProvider.Instance.ExecuteQuery("EXEC USP_GetDetailBillByID @idBill", new object[] { 41 });
            
            //string query = "SELECT f.Name AS [Tên món], f.price AS [Giá], fc.name [Danh mục], bf.count [Số lượng]\r\nFROM Food f JOIN BillInfo bf ON f.id = bf.idFood\r\n\t\t\tJOIN FoodCategory fc ON fc.id = f.idCategory\r\n\t\t\tJOIN Bill b ON bf.idBill = b.id\r\nWHERE b.status = 1 AND b.id = " + 40;
            //DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillInfo billInfo = new BillInfo(item);
                billInfos.Add(billInfo);
            }

            return billInfos;
        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
