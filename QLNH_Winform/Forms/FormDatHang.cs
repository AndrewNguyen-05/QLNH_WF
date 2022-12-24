﻿using QLNH_Winform.DAO;
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
    public partial class FormDatHang : Form
    {
        public FormDatHang()
        {
            InitializeComponent();
            LoadDonHang();
        }
        void LoadDonHang()
        {
            dtgvPrcsBill.DataSource = BillDAO.Instance.GetListBillUnprocessed();
            dtgvPrcsBill.Columns["DateCheckIn"].Visible = false;
            dtgvPrcsBill.Columns["DateCheckOut"].Visible = false;
            dtgvPrcsBill.Columns["idTable"].HeaderText = "Mã bàn";
            dtgvPrcsBill.Columns["isServed"].HeaderText = "Đã phục vụ";
            dtgvPrcsBill.Columns["status"].HeaderText = "Đã thanh toán";
            dtgvPrcsBill.Columns["discount"].HeaderText = "Giảm giá (%)";
            dtgvPrcsBill.Columns["totalPrice"].HeaderText = "Tổng tiền";
            //for (int i = 0; i < dtgvPrcsBill.Rows.Count; i++)
            //{
            //    int idTable = (int)dtgvPrcsBill.Rows[i].Cells["idTable"].Value;
            //    dtgvPrcsBill.Rows[i].Cells["idTable"] = new DataGridViewTextBoxCell();
            //    dtgvPrcsBill.Rows[i].Cells["idTable"].Value = TableDAO.Instance.getTableByID(idTable).Name;
            //}
        }
        private void FormDonHang_Shown(object sender, EventArgs e)
        {
            LoadDonHang();
        }

        void UpdateStatus(int id, int status, int isServed)
        {
            BillDAO.Instance.updateBillStatus(id, status, isServed);
        }
        private void btnServeBill_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dtgvPrcsBill.SelectedRows)
            {
                int id = (int)dgvr.Cells["id"].Value;
                int status = (int)dgvr.Cells["status"].Value;
                int isServed = (int)dgvr.Cells["isServed"].Value;
                UpdateStatus(id, status, (isServed + 1) % 2);
            }
            LoadDonHang();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dtgvPrcsBill.SelectedRows[0];
            int idBill = (int)selectedRow.Cells["id"].Value;
            int discount = (int)selectedRow.Cells["discount"].Value;
            double totalPrice = (double)selectedRow.Cells["totalPrice"].Value;

            if (idBill != -1)
            {
                DialogResult res = MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn số {0} ?\nHóa đơn đã được giảm {2}%\nTổng tiền cần thanh toán là: {1} VND", idBill, totalPrice, discount), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, totalPrice);
                }
            }
            LoadDonHang();
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dtgvPrcsBill.SelectedRows[0];
            BillDAO.Instance.DeleteBill((int)selectedRow.Cells["id"].Value);
            LoadDonHang();
        }
        private void dtgvPrcsBill_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvPrcsBill.SelectedRows.Count == 1)
            {
                btnEditOrder.Enabled = true;
                btnServeBill.Enabled = true;  
                btnCheckout.Enabled = true;
                btnDeleteBill.Enabled = true;
            }
            else
            {
                btnEditOrder.Enabled = false;
                btnServeBill.Enabled = false;
                btnCheckout.Enabled = false;
                btnDeleteBill.Enabled = false;
            }    

        }

        private void dtgvPrcsBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dtgv = sender as DataGridView;
            if (dtgv == null) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewCell currentCell = dtgv[e.ColumnIndex, e.RowIndex];
                string columnName = currentCell.OwningColumn.Name;
                if (columnName == "isServed" || columnName == "status")
                {
                    if (currentCell.Value is null)
                    {
                        currentCell.Style.BackColor = Color.Pink;
                    }
                    else if ((int)currentCell.Value != 0)
                    {
                        currentCell.Style.BackColor = Color.Lime;
                    }
                    else
                    {
                        currentCell.Style.BackColor = Color.Pink;
                    }
                }
            }
        }
    }
}