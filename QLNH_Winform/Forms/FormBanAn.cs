using QLNH_Winform.DAO;
using System;
using System.Windows.Forms;

namespace QLNH_Winform.Forms
{
    public partial class FormBanAn : Form
    {
        bool ReadOnly;
        BindingSource tableList = new BindingSource();
        public FormBanAn(bool readOnly)
        {
            InitializeComponent();
            ReadOnly = readOnly;
            checkReadOnly();
            LoadListTable();
            dtgvTable.DataSource = tableList;
            dtgvTable.Columns["ID"].Visible = false;
        }
        void checkReadOnly()
        {
            dtgvTable.ReadOnly = ReadOnly;
            btnAddTable.Enabled = !ReadOnly;
            btnDelTable.Enabled = !ReadOnly;
        }
        void LoadListTable()
        {
            tableList.DataSource = TableDAO.Instance.LoadTableList();
        }
        void LoadListTable(string name)
        {
            tableList.DataSource = TableDAO.Instance.LoadTableList(name);
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (TableDAO.Instance.InsertTable(""))
            {
                LoadListTable();
                dtgvTable.CurrentCell = dtgvTable.Rows[dtgvTable.Rows.Count - 1].Cells["Name"];
            }
        }

        private void btnDelTable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bàn ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            if (dtgvTable.SelectedCells.Count <= 0) return;
            foreach (DataGridViewCell dgvc in dtgvTable.SelectedCells)
            {
                TableDAO.Instance.DeleteTable((int)dgvc.OwningRow.Cells[0].Value);
            }
            LoadListTable(txbSearchTable.Text);
        }

        private void dtgvTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is null) return;
            DataGridViewRow dgvr = (sender as DataGridView).Rows[e.RowIndex];
            int id = (int)dgvr.Cells["ID"].Value;
            string name = dgvr.Cells["Name"].Value.ToString();

            if (TableDAO.Instance.UpdateTable(id, name))
            {
                LoadListTable(txbSearchTable.Text);
            }
        }

        private void txbSearchTable_TextChanged(object sender, EventArgs e)
        {
            LoadListTable(txbSearchTable.Text);
        }

        private void dtgvTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.ColumnIndex == 2)
            {
                dgv[e.ColumnIndex, e.RowIndex].ReadOnly = true;
            }
        }
    }
}
