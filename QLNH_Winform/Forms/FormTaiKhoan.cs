using QLNH_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH_Winform.Forms
{
    public partial class FormTaiKhoan : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public FormTaiKhoan(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            MessageBox.Show(acc.UserName.GetType().ToString());
            lblDisplayName.Text = acc.DisplayName;
            txtUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;
        }

        void UpdateAccount()
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
}
