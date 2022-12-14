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

namespace QLNH_Winform.Forms
{
    public partial class FormMonAn : Form
    {
        BindingSource foodList = new BindingSource();
        public FormMonAn()
        {
            InitializeComponent();
            LoadListFood();
            dtgvFood.DataSource = foodList;
            dtgvFood.Columns["ID"].Visible = false;
        }

        void AddFoodBinding()
        {

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
            if (tmp.Count <= 0) return;
            if (FoodDAO.Instance.InsertFood("", tmp[0].ID, 0))
            {
                LoadListFood();
                txbSearchFood.Clear();
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
            int idFood = (int)dgvr.Cells[1].Value;
            string Name = dgvr.Cells[0].Value.ToString();
            int id = (int)dgvr.Cells[2].Value;
            float price = (float)dgvr.Cells[3].Value;

            if (FoodDAO.Instance.UpdateFood(idFood, Name, id, price))
            {
                LoadListFood(txbSearchFood.Text);
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
        }

        private void txbSearchFood_TextChanged(object sender, EventArgs e)
        {
            LoadListFood(txbSearchFood.Text);
        }
    }
}
