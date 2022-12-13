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
    }
}
