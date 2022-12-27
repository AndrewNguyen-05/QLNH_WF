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
using QLNH_Winform.DTO;
using System.Xml.Linq;
using System.Diagnostics;

namespace QLNH_Winform.Forms
{
    public partial class FormMonAn : Form
    {
        BindingSource foodList = new BindingSource();
        public FormMonAn()
        {
            InitializeComponent();
            LoadListFood();
            LoadCategoryIntoCombobox(cbFoodCategory);
            dtgvFood.DataSource = foodList;
            dtgvFood.Columns["ID"].Visible = false;
            // Tool tip 
            toolTip1.SetToolTip(cbFoodCategory, "Chọn để sửa");
        }

        void AddFoodBinding()
        {

        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = FoodCategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void LoadListFood(string name)
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood(name);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            List<FoodCategory> tmp = FoodCategoryDAO.Instance.GetListCategory();
            if (tmp.Count <= 0)
            {
                FoodCategoryDAO.Instance.InsertEmptyCategory("Danh mục không tên "); 
                tmp = FoodCategoryDAO.Instance.GetListCategory();
            }
            if (FoodDAO.Instance.InsertFood("", tmp[0].ID, 0))
            {
                LoadListFood();
                txbSearchFood.Clear();
                dtgvFood.CurrentCell = dtgvFood.Rows[dtgvFood.Rows.Count - 1].Cells["Name"]; 
                dtgvFood.Rows[dtgvFood.Rows.Count - 1].Selected = true;
            }
            
        }

        private void btnDelFood_Click(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count <= 0) return;
            foreach (DataGridViewCell dgvc in dtgvFood.SelectedCells)
            {
                FoodDAO.Instance.DeleteFood((int)dgvc.OwningRow.Cells[1].Value);
            }
            LoadListFood(txbSearchFood.Text);
        }

        private void dtgvFood_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is null) return;
            DataGridViewRow dgvr = (sender as DataGridView).Rows[e.RowIndex];
            int idFood = (int)dgvr.Cells["ID"].Value;
            string Name = dgvr.Cells["Name"].Value.ToString();
            int id = (int)dgvr.Cells["CategoryID"].Value;
            double price = (double)dgvr.Cells["Price"].Value;

            if (FoodDAO.Instance.UpdateFood(idFood, Name, id, price))
            {
                LoadListFood(txbSearchFood.Text);
            }
        }

        private void txbSearchFood_TextChanged(object sender, EventArgs e)
        {
            LoadListFood(txbSearchFood.Text);
        }

        private void dtgvFood_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedRows.Count > 0)
            {
                if (dtgvFood.SelectedRows.Count == 1)
                {
                    DataGridViewCell dgvc = dtgvFood.SelectedCells[0];
                    int categoryID = (int) dgvc.OwningRow.Cells["CategoryID"].Value;
                    FoodCategory foodCategory = FoodCategoryDAO.Instance.GetCategoryByID(categoryID);
                    int i = 0;
                    for (i = 0; i < cbFoodCategory.Items.Count; i++)
                    {
                        if (foodCategory.ID == (cbFoodCategory.Items[i] as FoodCategory).ID)
                        {
                            cbFoodCategory.SelectedIndex = i;
                            break;
                        }
                    }
                    if (i == cbFoodCategory.Items.Count)
                    {
                        cbFoodCategory.SelectedIndex = -1;
                    }
                }
                else 
                {
                    cbFoodCategory.SelectedIndex = -1;
                }
            }
        }

        private void cbFoodCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell dgvc in dtgvFood.SelectedCells)
                {
                    DataGridViewRow dgvr = dgvc.OwningRow;
                    int idFood = (int)dgvr.Cells["ID"].Value;
                    string Name = dgvr.Cells["Name"].Value.ToString();
                    int id = (cbFoodCategory.SelectedItem as FoodCategory).ID;
                    double price = (double)dgvr.Cells["Price"].Value;
                    FoodDAO.Instance.UpdateFood(idFood, Name, id, price);
                }
            }
            LoadListFood(txbSearchFood.Text);
        }

        private void dtgvFood_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.ColumnIndex == 2)
            {
                e.Value = FoodCategoryDAO.Instance.GetCategoryByID((int)e.Value).Name;
                dgv[e.ColumnIndex, e.RowIndex].ReadOnly = true;
            }
        }
    }
}
