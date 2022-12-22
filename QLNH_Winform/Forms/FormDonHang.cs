using QLNH_Winform.DAO;
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
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
            LoadDonHang();
        }
        void LoadDonHang()
        {
            dtgvPrcsBill.DataSource = BillDAO.Instance.GetListBill();
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

        private void FormDonHang_Shown(object sender, EventArgs e)
        {
            LoadDonHang();
        }
    }
}
