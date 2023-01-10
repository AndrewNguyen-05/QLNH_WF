using QLNH_Winform.DAO;
using QLNH_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNH_Winform.Forms
{
    public partial class FormTaiKhoan : Form
    {
        private Account loginAccount;
        bool ReadOnly;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public FormTaiKhoan(Account acc, bool readOnly)
        {
            InitializeComponent();
            ReadOnly = readOnly;
            checkReadOnly();
            LoginAccount = acc;
            this.UpdateAccount += FormTaiKhoan_UpdateAccount;
        }
        void checkReadOnly()
        {
            txtUserName.Enabled = !ReadOnly;
            txtDisplayName.Enabled = !ReadOnly;
            txtPassWord.Enabled = !ReadOnly;
            txtNewPassWord.Enabled = !ReadOnly;
            txtConfirmPW.Enabled = !ReadOnly;
            btnUpdate.Enabled = !ReadOnly;
        }
        private void FormTaiKhoan_UpdateAccount(object sender, AccountEvent e)
        {
            lblDisplayName.Text = e.Acc.DisplayName;
        }

        void ChangeAccount(Account acc)
        {
            lblDisplayName.Text = acc.DisplayName;
            txtUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;
        }
        void UpdateAccountNotify(string userName, string oldUserName, string displayName, string pass, string newpass)
        {
            if (AccountDAO.Instance.GetAccountByUserName(userName) != null && userName != oldUserName)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AccountDAO.Instance.UpdateAccount(userName, oldUserName, displayName, pass, newpass))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                if (updateAccount != null)
                {
                    updateAccount(this, new AccountEvent(loginAccount));
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đúng mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UpdateAccountInfo()
        {
            string displayName = txtDisplayName.Text;
            string password = txtPassWord.Text;
            string newpass = txtNewPassWord.Text;
            string confirmpass = txtConfirmPW.Text;
            string username = txtUserName.Text;
            if (!newpass.Equals(confirmpass))
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng với mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (newpass == "")
                {
                    UpdateAccountNotify(username, loginAccount.UserName, displayName, password, password);
                }
                else
                {
                    UpdateAccountNotify(username, loginAccount.UserName, displayName, password, newpass);
                }
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove {  updateAccount -= value; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void lblDisplayName_Click(object sender, EventArgs e)
        {

        }
    }

    public class AccountEvent : EventArgs
    {
        private Account acc;
        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
