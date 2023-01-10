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
using System.Windows.Forms;

namespace QLNH_Winform.Forms
{
    public partial class FormSetPermission : Form
    {
        public Account modifyingAccount;
        public Account editorAccount;
        DataGridViewRow createListPermRow(string s, bool a, bool d, bool m)
        {
            DataGridViewRow listPermRow = new DataGridViewRow();
            listPermRow.Cells.Add(new DataGridViewTextBoxCell());
            listPermRow.Cells.Add(new DataGridViewTextBoxCell());
            listPermRow.Cells.Add(new DataGridViewTextBoxCell());
            listPermRow.Cells.Add(new DataGridViewTextBoxCell());
            listPermRow.Cells[0].Value = s;
            listPermRow.Cells[1].Value = a;
            listPermRow.Cells[2].Value = d;
            listPermRow.Cells[3].Value = m;
            listPermRow.Height = 40;
            return listPermRow;
        }
        public FormSetPermission(Account modifying, ref Account editor)
        {
            InitializeComponent();
            //show setting
            modifyingAccount = modifying;
            loadData(modifying.Type);
        }

        void loadData(int code)
        {
            dtgvAccPermission.Rows.Clear();
            string[] ls = { "Gọi Món",
                            "Món Ăn",
                            "Bàn Ăn",
                            "Tài Khoản",
                            "Nhân Viên",
                            "Thống Kê" };
            for (int i = 0; i < 6; i++)
            {
                bool a = false, d = false, m = false;
                if (((code >> 0) & 1) != 0)
                {
                    a = true;
                }
                if (((code >> 1) & 1) != 0)
                {
                    d = true;
                }
                if (((code >> 2) & 1) != 0)
                {
                    m = true;
                }
                dtgvAccPermission.Rows.Add(createListPermRow(ls[i], a, d, m));
                code = code >> 3;
            }
        }
        void reloadPerm()
        {
            editorAccount = AccountDAO.Instance.GetAccountByUserName(editorAccount.UserName);
        }
        bool isAllowToChange(int row)
        {
            bool allowToEdit = ((editorAccount.Type >> (row * 3 + 2)) & 1) != 0;
            bool notSamePerm = ((modifyingAccount.Type >> (row * 3 + 2)) & 1) == 0;
            bool isOwner = (((editorAccount.Type >> 18) & 1) != 0);
            return (allowToEdit && notSamePerm) || isOwner;
        }
        private void dtgvAccPermission_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (1 <= e.ColumnIndex && e.ColumnIndex <= 3 && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);
                ControlPaint.DrawCheckBox(e.Graphics, e.CellBounds.X + 20, e.CellBounds.Y + 1,
                    e.CellBounds.Width - 2, e.CellBounds.Height - 2,
                    (e.FormattedValue.ToString() == true.ToString() ? ButtonState.Checked : ButtonState.Normal) 
                  | (isAllowToChange(e.RowIndex)? ButtonState.Normal : ButtonState.Inactive));
                e.Handled = true;
            }
        }
        private void dtgvAccPermission_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            reloadPerm();
            if (!isAllowToChange(e.RowIndex)) return;
            DataGridView dgv = (DataGridView)sender;
            if (1 <= e.ColumnIndex && e.ColumnIndex <= 3 && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if ((bool)cell.Value == false)
                {
                    for (int i = e.ColumnIndex - 1; i > 0; i--)
                    {
                        DataGridViewCell tmp = dgv.Rows[e.RowIndex].Cells[i];
                        tmp.Value = true;
                    }
                }    
                bool flg = false;
                for (int i = e.ColumnIndex + 1; i <= 3; i++)
                {
                    DataGridViewCell tmp = dgv.Rows[e.RowIndex].Cells[i];
                    flg = flg || (bool)tmp.Value;
                }
                cell.Value = ((!(bool)cell.Value) || flg);
            }
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex < 0)
                {
                    bool flg = false;
                    for (int i = 0; i < 6; i++)
                    {
                        DataGridViewCell c1 = dgv.Rows[i].Cells[1];
                        DataGridViewCell c2 = dgv.Rows[i].Cells[2];
                        DataGridViewCell c3 = dgv.Rows[i].Cells[3];
                        if (!((bool)c1.Value && (bool)c2.Value && (bool)c3.Value))
                        {
                            flg = true;
                        }
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        dgv.Rows[i].Cells[1].Value = flg;
                        dgv.Rows[i].Cells[2].Value = flg;
                        dgv.Rows[i].Cells[3].Value = flg;
                    }
                    return;
                }
                else
                {
                    DataGridViewCell c1 = dgv.Rows[e.RowIndex].Cells[1];
                    DataGridViewCell c2 = dgv.Rows[e.RowIndex].Cells[2];
                    DataGridViewCell c3 = dgv.Rows[e.RowIndex].Cells[3];
                    if ((bool)c1.Value && (bool)c2.Value && (bool)c3.Value)
                    {
                        dgv.Rows[e.RowIndex].Cells[1].Value = false;
                        dgv.Rows[e.RowIndex].Cells[2].Value = false;
                        dgv.Rows[e.RowIndex].Cells[3].Value = false;
                    }
                    else
                    {
                        dgv.Rows[e.RowIndex].Cells[1].Value = true;
                        dgv.Rows[e.RowIndex].Cells[2].Value = true;
                        dgv.Rows[e.RowIndex].Cells[3].Value = true;
                    }
                }
            }
        }
        private void ControlClose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int x = 1;
            modifyingAccount.Type = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if ((bool)dtgvAccPermission[j, i].Value)
                    {
                        modifyingAccount.Type |= x;
                    }
                    x <<= 1;
                }
            }

            this.Close();
        }

        private void btnNotSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
