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
    public partial class FormDanhMuc : Form
    {
        BindingSource categoryList = new BindingSource();
        public FormDanhMuc()
        {
            InitializeComponent();
            LoadListCategory();
            dtgvCategory.DataSource = categoryList;
            dtgvCategory.Columns["ID"].Visible = false;
        }

        void LoadListCategory()
        {
            categoryList.DataSource = FoodCategoryDAO.Instance.GetListCategory();
        }
        void LoadListCategory(string name)
        {
            categoryList.DataSource = FoodCategoryDAO.Instance.GetListCategory(name);

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (FoodCategoryDAO.Instance.InsertCategory(""))
            {
                LoadListCategory();
                dtgvCategory.CurrentCell = dtgvCategory.Rows[dtgvCategory.Rows.Count - 1].Cells["Name"];
            }

        }

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục món?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            if (dtgvCategory.SelectedCells.Count <= 0) return;
            foreach (DataGridViewCell dgvc in dtgvCategory.SelectedCells)
            {
                FoodCategoryDAO.Instance.DeleteCategory((int)dgvc.OwningRow.Cells[0].Value);
            }
            LoadListCategory(txbSearchCategory.Text);
        }

        private void dtgvCategory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is null) return;
            DataGridViewRow dgvr = (sender as DataGridView).Rows[e.RowIndex];
            int id = (int)dgvr.Cells["ID"].Value;
            string name = dgvr.Cells["Name"].Value.ToString();

            if (FoodCategoryDAO.Instance.UpdateCategory(id, name))
            {
                LoadListCategory(txbSearchCategory.Text);
            }

        }

        private void txbSearchCategory_TextChanged(object sender, EventArgs e)
        {
            LoadListCategory(txbSearchCategory.Text);
        }
    }
}
