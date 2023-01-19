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
        bool ReadOnly;
        public FormNhanVien(bool readOnly)
        {
            InitializeComponent();
            ReadOnly = readOnly;
            LoadNhanVien();
            checkReadOnly();
        }

        void checkReadOnly()
        {
            dtgvListAccount.ReadOnly = ReadOnly;
            btnAddStaff.Enabled = !ReadOnly;
            btnDelStaff.Enabled = !ReadOnly;
            btnResetPassword.Enabled = !ReadOnly;
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
        /*
         * account permission bit: (add delete modify)
         * 0 1 2: GoiMon
         * 3 4 5: MonAn
         * 6 7 8: BanAn
         * 9 10 11: TaiKhoan
         * 12 13 14: NhanVien
         * 15 16 17: ThongKe
         * 18: Owner
         * 19: LoggedIn
         */
        string showPerm(int code)
        {
            string s = "";
            if (((code >> 18) & 1 )!= 0)
            {
                return "Owner";
            }
            int[] cnt = { 0, 0, 0, 0 };
            int flg = 0;
            //GoiMon
            string[] ls = { "GM", "MA", "BA", "TKh", "NV", "ThKe" };
            for (int i = 0; i < 6; i++)
            {
                string tmp = "";
                if (((code >> 0) & 1) != 0)
                {
                    tmp += "R";
                    cnt[1]++;
                }
                if (((code >> 1) & 1) != 0)
                {
                    tmp += "W";
                    cnt[2]++;
                }
                if (((code >> 2) & 1) != 0)
                {
                    tmp += "C";
                    cnt[3]++;
                }
                if (tmp != "")
                {
                    if (flg == 1) s += " | ";
                    s += ls[i] + "_" + tmp;
                    flg = 1;
                }
                code = code >> 3;
            }
            if (cnt[3] == 6)
            {
                s = "All_RWC";
            }
            //else if (cnt[2] == 6)
            //{
            //    s = "All_RW";
            //}
            //else if (cnt[1] == 6)
            //{
            //    s = "All_R";
            //}
            else if (flg == 0)
            {
                s = "None";
            }
            return s;
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
            //DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
            //dgvc.HeaderText = "Quyền";
            //dgvc.Name = "Perm";
            //dtgvListAccount.Columns.Add(dgvc);
            for (int i = 0; i < dtgvListAccount.Rows.Count; i++)
            {
                int code = int.Parse(dtgvListAccount.Rows[i].Cells["Type"].Value.ToString());
                dtgvListAccount.Rows[i].Cells["Perm"].Value = showPerm(code).ToString(); 
            }
            dtgvListAccount.Columns["Perm"].ReadOnly = true;
            dtgvListAccount.Columns["Perm"].HeaderText = "Quyền (Nháy đúp để chỉnh sửa)";
            dtgvListAccount.Columns["Type"].Visible = false;
        }

        void AddAcount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.GetAccountByUserName(userName) != null)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (AccountDAO.Instance.GetAccountByUserName(userName) != null && userName != editingUserName)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                MessageBox.Show("Đặt lại mật khẩu thành công! Mật khẩu mặc định là ST1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int type = (int)dgvr.Cells["Type"].Value;
            if (((type >> 18) & 1) != 0 && ((loginAcc.Type >> 18) & 1) == 0)
            {
                MessageBox.Show("Không thể sửa thông tin chủ");
                e.Cancel = true;
                return;
            }
            if (e.ColumnIndex == dgvr.Cells["Perm"].ColumnIndex) return;
            editingUserName = dgvr.Cells["UserName"].Value.ToString();
        }
        private void dtgvListAccount_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is null) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow dgvr = (sender as DataGridView).Rows[e.RowIndex];
            if (e.ColumnIndex == dgvr.Cells["Perm"].ColumnIndex) return;

            string userName = dgvr.Cells["UserName"].Value.ToString();
            string displayName = dgvr.Cells["DisplayName"].Value.ToString();
            int type = (int)dgvr.Cells["Type"].Value;
            if (loginAcc.UserName.Equals(editingUserName))
            {
                EditAcount(userName, editingUserName, displayName, type);
                loginAcc = AccountDAO.Instance.GetAccountByUserName(userName);
                if (updateAccount != null)
                {
                    updateAccount(this, new AccountEvent(loginAcc));
                }
            }
            else
            {
                EditAcount(userName, editingUserName, displayName, type);
            }
            LoadAccount();
        }
        private void dtgvListAccount_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dtgvListAccount.Columns["Perm"].Index && e.RowIndex >= 0 && !ReadOnly)
            {
                string usrName = dtgvListAccount.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                int type = (int)dtgvListAccount.Rows[e.RowIndex].Cells["Type"].Value;
                if (usrName == loginAcc.UserName)
                {
                    MessageBox.Show("Không thể chỉnh quyền bản thân");
                    return;
                }
                if (((type >> 18) & 1) != 0)
                {
                    MessageBox.Show("Không thể chỉnh quyền chủ");
                    return;
                }
                FormSetPermission fsp = new FormSetPermission(AccountDAO.Instance.GetAccountByUserName(usrName), ref loginAcc);
                fsp.editorAccount = loginAcc;
                fsp.ShowDialog();
                editingUserName = dtgvListAccount.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                dtgvListAccount.Rows[e.RowIndex].Cells["Type"].Value = fsp.modifyingAccount.Type;
            }
            else
            {
                string usrName = dtgvListAccount.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                if (usrName == loginAcc.UserName)
                {
                    MessageBox.Show("Vui lòng sửa thông tin bản thân ở phần Tài Khoản");
                    return;
                }
            }
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dc in dtgvListAccount.SelectedRows)
            {
                string userName = dc.Cells["UserName"].Value.ToString();
                if (loginAcc.UserName.Equals(userName))
                {
                    MessageBox.Show("Không thể xóa tài khoản đang đăng nhập hiện tại");
                    return;
                }
                if (((((int)dc.Cells["Type"].Value) >> 18) & 1) != 0)
                {
                    MessageBox.Show("Không thể xóa chủ");
                    return;
                }
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            foreach (DataGridViewRow dc in dtgvListAccount.SelectedRows)
            {
                string userName = dc.Cells["UserName"].Value.ToString();
                DeleteAcount(userName);
            }
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dtgvListAccount.SelectedRows)
            {
                string userName = dr.Cells["UserName"].Value.ToString();
                int type = (int)dr.Cells["Type"].Value;
                if (((type >> 18) & 1) != 0 && ((loginAcc.Type >> 18) & 1) == 0)
                {
                    MessageBox.Show("Không thể đặt lại mật khẩu chủ");
                    return;
                }
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
