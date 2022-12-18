using QLNH_Winform.DAO;
using QLNH_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNH_Winform.Forms
{
    public partial class FormNhanVien : Form
    {
        BindingSource accountList = new BindingSource();

        public Account loginAcc;
        string editingUserName;

        public FormNhanVien()
        {
            InitializeComponent();
            LoadNhanVien();
        }

        #region Methods
        void LoadNhanVien()
        {
            dtgvListAccount.DataSource = accountList;
            LoadAccount();
            AddAccountBinding();
        }

        void AddAccountBinding()
        {
            //txtUserName.DataBindings.Add(new Binding("Text", dtgvListAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            //txtDisplayName.DataBindings.Add(new Binding("Text", dtgvListAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            //nmPermission.DataBindings.Add(new Binding("Value", dtgvListAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddAcount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.GetAccountByUserName(userName) != null)
            {
                MessageBox.Show("Tên tài khoản bị trùng, vui lòng chọn tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAccount();
        }

        void EditAcount(string userName, string editingUserName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, editingUserName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAccount();
        }

        void DeleteAcount(string userName)
        {
            if(loginAcc.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng không xóa tài khoản chính chủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAccount();
        }

        void ResetPassword(string userName)
        {
            if (AccountDAO.Instance.ResetPassWord(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Events
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            AddAcount(userName, "None", 0);
        }
        private void dtgvListAccount_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (sender is null) return;
            DataGridViewRow dgvr = (sender as DataGridView).Rows[e.RowIndex];
            editingUserName = dgvr.Cells["UserName"].Value.ToString();
        }
        private void dtgvListAccount_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is null) return;
            DataGridViewRow dgvr = (sender as DataGridView).Rows[e.RowIndex];
            string userName = dgvr.Cells["UserName"].Value.ToString();
            string displayName = dgvr.Cells["DisplayName"].Value.ToString();
            int type = (int)dgvr.Cells["Type"].Value;
            if (type != 0 && type != 1)
            {
                MessageBox.Show("Tài khoản chỉ có hai loại: 0 - Nhan Vien, 1 - Admin");
                LoadAccount();
                return;
            }
            if (loginAcc.UserName.Equals(editingUserName))
            {
                EditAcount(userName, editingUserName, displayName, type);
                if (updateAccount != null)
                {
                    updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
            }
            else
            {
                EditAcount(userName, editingUserName, displayName, type);
            }
            LoadAccount();
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell dc in dtgvListAccount.SelectedCells)
            {
                string userName = dc.OwningRow.Cells["UserName"].Value.ToString();
                if (loginAcc.UserName.Equals(userName))
                {
                    DeleteAcount(userName); return;
                }
            }
            foreach (DataGridViewCell dc in dtgvListAccount.SelectedCells)
            {
                string userName = dc.OwningRow.Cells["UserName"].Value.ToString();
                DeleteAcount(userName);
            }
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell dc in dtgvListAccount.SelectedCells)
            {
                string userName = dc.OwningRow.Cells["UserName"].Value.ToString();
                ResetPassword(userName);
                if (updateAccount != null && loginAcc.UserName.Equals(userName))
                {
                    updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
            }
        }
        #endregion
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
    }
}
