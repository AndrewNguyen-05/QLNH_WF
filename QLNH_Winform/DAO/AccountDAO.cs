using QLNH_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNH_Winform.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set => instance = value;
        }
        private AccountDAO() { }



        public bool Login(string username, string password)
        {
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(passwordBytes);

            string hasPass = "";
            foreach(byte b in hasData)
            {
                hasPass += b.ToString();
            }    


            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, hasPass });
            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newpass)
        {
            int result  = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] {userName, displayName, pass, newpass});
            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, Type FROM Account");
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM account WHERE userName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool InsertAccount(string userName, string displayName, int type)
        {
            string query = string.Format("INSERT Account ( UserName, DisplayName, Type , password ) VALUES (N'{0}', N'{1}', {2}, N'{3}')", userName, displayName, type, "4229125024382100611251781583929172146215");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = string.Format("UPDATE Account SET DisplayName = N'{1}', Type = {2} WHERE UserName = N'{0}'", userName, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string userName, string oldUserName, string displayName, int type)
        {
            string query = string.Format("UPDATE Account SET UserName = N'{0}', DisplayName = N'{1}', Type = {2} WHERE UserName = N'{3}'", userName, displayName, type, oldUserName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount(string userName)
        {
            string query = string.Format("DELETE Account WHERE UserName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ResetPassWord(string userName)
        {
            string query = string.Format("UPDATE Account SET password = N'4229125024382100611251781583929172146215' WHERE UserName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }    
    }
}
