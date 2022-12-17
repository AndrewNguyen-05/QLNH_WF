using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH_Winform.DTO
{
    public class Account
    {
        public Account(string userName, string displayName, int type, string passWord = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Typee = type;
            this.Password = passWord;
        }
        
        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Typee = (int)row["type"];
            this.UserName = row["passWord"].ToString();
        }

        private int type;
        public int Typee
        {
            get { return type; }
            set { type = value; }
        }

        private string passWord;
        public string Password
        {
            get { return passWord; }
            set { passWord = value; }
        }

        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

    }
}
