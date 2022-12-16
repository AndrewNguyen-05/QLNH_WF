using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNH_Winform.DTO;

namespace QLNH_Winform.DAO
{
    internal class TableDAO
    {
        private static TableDAO instance;

        internal static TableDAO Instance
        {
            get
            {
                if (instance == null) instance = new TableDAO();
                return TableDAO.instance;
            }
            set => instance = value;
        }

        public static int TableWidth = 120;
        public static int TableHeight = 120;

        private TableDAO() { }

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_SwitchTable @idTable1 , @idTable2", new object[] { id1, id2 });
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
        public List<Table> LoadTableList(string name)
        {
            List<Table> tableList = new List<Table>();

            string query = string.Format("SELECT * FROM TableFood WHERE isHidden = 0 AND name like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public bool InsertTable(string name)
        {
            string query = string.Format("INSERT TableFood (name) VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTable(int id, string name)
        {
            string query = string.Format("UPDATE TableFood SET name = N'{1}' WHERE id = {0}", id, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteTable(int id)
        {
            string query = string.Format("UPDATE TableFood SET isHidden = 1 WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
