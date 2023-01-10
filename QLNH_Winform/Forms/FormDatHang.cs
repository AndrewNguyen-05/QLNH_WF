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
    public partial class FormDatHang : Form
    {
        public bool ReadOnly;
        public FormDatHang(bool readOnly)
        {
            InitializeComponent();
            ReadOnly = readOnly;
            LoadDonHang();
            checkSelection();
        }
        void LoadDonHang()
        {
            dtgvPrcsBill.DataSource = BillDAO.Instance.GetListProcessingBill();
            dtgvPrcsBill.Columns["id"].HeaderText = "Mã đơn";
            dtgvPrcsBill.Columns["tableName"].HeaderText = "Tên bàn";
            dtgvPrcsBill.Columns["isServed"].Visible = false;
            dtgvPrcsBill.Columns["status"].Visible = false;
            dtgvPrcsBill.Columns["discount"].Visible = false;
            dtgvPrcsBill.Columns["totalPrice"].HeaderText = "Tổng tiền";
            dtgvPrcsBill.Columns["idTable"].Visible = false;
            for (int i = 0; i < dtgvPrcsBill.Rows.Count; i++)
            {
                DataGridViewCell currentCell = dtgvPrcsBill.Rows[i].Cells["Trạng Thái"];
                if ((int)currentCell.OwningRow.Cells["isServed"].Value == 1)
                {
                    currentCell.Value = "Đã phục vụ/";
                }
                else
                {
                    currentCell.Value = "Chưa phục vụ/";
                }
                if ((int)currentCell.OwningRow.Cells["status"].Value == 1)
                {
                    currentCell.Value += "Đã thanh toán";
                }
                else
                {
                    currentCell.Value += "Chưa thanh toán";
                }
            }
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
        void ShowBill(DataGridViewRow dgvr)
        {
            lsvBill.Items.Clear();
            double totalPrice = 0;
            List<OrderFood> tmp = OrderFoodDAO.Instance.GetListMenuByBill((int)dgvr.Cells["id"].Value);
            foreach (OrderFood item in tmp)
            {
                ListViewItem lsvitem = new ListViewItem(item.FoodName.ToString());
                lsvitem.SubItems.Add(item.Count.ToString());
                lsvitem.SubItems.Add(item.Price.ToString());
                lsvitem.SubItems.Add(item.TotalPrice.ToString());
                lsvitem.Tag = FoodDAO.Instance.GetFoodByID(item.FoodId);
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvitem);
            }
            lblBillNumber.Text = "Đơn hàng số: " + dgvr.Cells["id"].Value.ToString();
            lblDiscountValue.Text = dgvr.Cells["discount"].Value.ToString();
            lblTotalPrice.Text = (totalPrice * (100 - (int)dgvr.Cells["discount"].Value) / 100).ToString();
        }
        void checkSelection()
        {
            btnNewOrder.Enabled = !ReadOnly;
            if (dtgvPrcsBill.SelectedRows.Count == 1 && (!ReadOnly))
            {
                btnEditOrder.Enabled = ((int)(dtgvPrcsBill.SelectedRows[0].Cells["status"].Value)) == 0;
                btnServeBill.Enabled = true;
                btnCheckout.Enabled = ((int)(dtgvPrcsBill.SelectedRows[0].Cells["status"].Value)) == 0;
                btnDeleteBill.Enabled = ((int)(dtgvPrcsBill.SelectedRows[0].Cells["status"].Value)) == 0;
                ShowBill(dtgvPrcsBill.SelectedRows[0]);
            }
            else
            {
                btnEditOrder.Enabled = false;
                btnServeBill.Enabled = false;
                btnCheckout.Enabled = false;
                btnDeleteBill.Enabled = false;
            }

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
            string tableName = selectedRow.Cells["tableName"].Value.ToString();
            int discount = (int)selectedRow.Cells["discount"].Value;
            double totalPrice = (double)selectedRow.Cells["totalPrice"].Value;

            if (idBill != -1)
            {
                DialogResult res = MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn số {0} ?\nHóa đơn đã được giảm {2}%\nTổng tiền cần thanh toán là: {1} VND", idBill, totalPrice, discount), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    FormTaoHD fXuatHD = new FormTaoHD(idBill);
                    fXuatHD.discountVal = discount;
                    fXuatHD.totalPrice = totalPrice;
                    fXuatHD.tableName = tableName;
                    fXuatHD.ShowDialog();
                    BillDAO.Instance.CheckOut(idBill, discount, totalPrice);
                }
            }
            LoadDonHang();
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            DataGridViewRow selectedRow = dtgvPrcsBill.SelectedRows[0];
            BillDAO.Instance.DeleteBill((int)selectedRow.Cells["id"].Value);
            LoadDonHang();
        }
        private void dtgvPrcsBill_SelectionChanged(object sender, EventArgs e)
        {
            checkSelection();
        }

        private void dtgvPrcsBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dtgv = sender as DataGridView;
            if (dtgv == null) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewCell currentCell = dtgv[e.ColumnIndex, e.RowIndex];
                string columnName = currentCell.OwningColumn.Name;
                if (columnName == "Trạng Thái")
                {
                }
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dtgvPrcsBill.SelectedRows[0];
            int idBill = (int)selectedRow.Cells["id"].Value;
            string tableName = selectedRow.Cells["tableName"].Value.ToString();
            int discount = (int)selectedRow.Cells["discount"].Value;
            double totalPrice = (double)selectedRow.Cells["totalPrice"].Value;
            FormTaoHD fXuatHD = new FormTaoHD(idBill);
            fXuatHD.discountVal = discount;
            fXuatHD.totalPrice = totalPrice;
            fXuatHD.tableName = tableName;
            fXuatHD.ShowDialog();
        }
    }
}
