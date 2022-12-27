using Guna.UI2.WinForms;
using QLNH_Winform.DAO;
using QLNH_Winform.DTO;
using QLNH_Winform;
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
    public partial class FormTaoDon : Form
    {
        int created;
        internal List<OrderFood> FoodOrderData;
        Table TableOrderData;
        string statustext = "";
        public FormTaoDon()
        {
            InitializeComponent();

            FoodOrderData = new List<OrderFood>();
            lsvBill.Tag = null;
            lblBillNumber.Text = "Đơn hàng mới";
            statustext = "tạo";

            LoadForm();
        }
        internal FormTaoDon(int idTable, int idBill)
        {
            InitializeComponent();
            Table table = TableDAO.Instance.getTableByID(idTable);
            TableOrderData = table;
            FoodOrderData = OrderFoodDAO.Instance.GetListMenuByTable(TableOrderData.ID);

            lsvBill.Tag = table;
            lblBillNumber.Text = lblBillNumber.Text + idBill.ToString();
            btnCreate.Text = "Sửa";
            this.Text = "Sửa Đơn";
            statustext = "sửa";

            LoadForm(table);
        }

        void LoadForm(Table tbl = null)
        {
            txbSearchFood.Text = "";
            LoadCategory();
            LoadFoodListByCategoryID(0, "");
            LoadComboboxTable(cbTable, tbl);
            ShowBill();
            checkClikableBtnCreate();

            created = 1;
            if (cbTable.Items.Count < 1)
            {
                lblTable.Text = "Hết bàn";
                lblTable.ForeColor = Color.Red;
            }
        }
        #region Method

        void LoadCategory()
        {
            List<FoodCategory> listCategory = FoodCategoryDAO.Instance.GetListCategory();
            listCategory.Insert(0, new FoodCategory(0, "Tất cả"));
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id, string name)
        {
            flpTable.Controls.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id, name);
            foreach (Food item in listFood)
            {
                Guna2GradientButton btn = new Guna2GradientButton() { Width = 240, Height = 120 };
                btn.Text = item.Name;
                btn.Click += btn_Click;
                btn.Tag = item;
                btn.BorderRadius = 8;
                btn.ForeColor = Color.White;
                btn.FillColor = Color.CadetBlue;
                btn.FillColor2 = Color.Chocolate;
                btn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
                flpTable.Controls.Add(btn);
            }
        }
        void LoadComboboxTable(ComboBox cb, Table initTbl = null)
        {
            int tblID;
            if (initTbl != null)
            {
                tblID = initTbl.ID;
            }
            else
            {
                tblID = -1;
            }
            List<Table> tmp = TableDAO.Instance.LoadFreeTableListWithCurrentTableID(tblID);
            cb.DataSource = tmp;
            cb.DisplayMember = "Name";
            if (initTbl != null)
            {
                foreach (Table tbl in cb.Items)
                {
                    if (tbl.ID == initTbl.ID)
                    {
                        cb.SelectedItem = tbl;
                        return;
                    }
                }
            }
        }
        bool IsOrderChanged()
        {
            //Check if table created
            if (lsvBill.Tag is null)
            {
                return (FoodOrderData.Count > 0);
            }
            Table oldTable = lsvBill.Tag as Table;
            //Check if table changed
            if (oldTable.ID != TableOrderData.ID)
            {
                return true;
            }
            //Check if food changed
            List<OrderFood> tmp = OrderFoodDAO.Instance.GetListMenuByTable(oldTable.ID);
            if (tmp.Count != FoodOrderData.Count)
            {
                return true;
            }
            for (int i = 0; i < tmp.Count; i++)
            {
                if (tmp[i].Count != FoodOrderData[i].Count || tmp[i].FoodId != FoodOrderData[i].FoodId)
                {
                    return true;
                }
            }
            //Check if discount changed
            int oldDiscount = BillDAO.Instance.GetBillbyTableID(oldTable.ID).Discount;
            if ((int)nmDiscount.Value != oldDiscount)
            { 
                return true; 
            }
            return false;
        }
        void checkClikableBtnCreate()
        {
            Table table = TableOrderData;
            if (table is null)
            {
                btnCreate.Enabled = false;
                return;
            }
            if (IsOrderChanged())
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnCreate.Enabled = false;
            }
        }
        void ShowBill()
        {
            lsvBill.Items.Clear();
            double totalPrice = 0;
            foreach (OrderFood item in FoodOrderData)
            {
                ListViewItem lsvitem = new ListViewItem(item.FoodName.ToString());
                lsvitem.SubItems.Add(item.Count.ToString());
                lsvitem.SubItems.Add(item.Price.ToString());
                lsvitem.SubItems.Add(item.TotalPrice.ToString());
                lsvitem.Tag = FoodDAO.Instance.GetFoodByID(item.FoodId);
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvitem);
            }
            lblTotalPrice.Text = (totalPrice * (100 - (int)nmDiscount.Value) / 100).ToString();
        }

        void ChangeFoodSelection(Food food)
        {
            lblCurrentFood.Text = food.Name;
            lblCurrentFood.Tag = food;
            lblDGvalue.Text = food.Price.ToString();
            if (lblCurrentFood.Tag != null)
            {
                int index = FindFoodIndexInOrder(food.ID);
                if (index == -1)
                {
                    nmFoodCount.Value = 0;
                }
                else
                {
                    nmFoodCount.Value = FoodOrderData[index].Count;
                }
                nmFoodCount.Enabled = true;
            }
            //ShowBill((lsvBill.Tag as Table).ID);
        }
        int FindFoodIndexInOrder(int foodId)
        {
            for (int i = 0; i < FoodOrderData.Count; i++)
            {
                OrderFood item = FoodOrderData[i];
                if (item.FoodId == foodId)
                {
                    return i;
                }
            }
            return -1;
        }
        void updateTable(Table oldTable, Table newTable)
        {
            if (oldTable != null && newTable != null && oldTable != newTable)
            {
                TableDAO.Instance.SwitchTable(oldTable.ID, newTable.ID);
            }
            if (newTable == null)
            {
                MessageBox.Show("Không còn bàn trống!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            lsvBill.Tag = newTable;
        }
            #region graveyard
        //void checkClikableBtnCreate()
        //{
        //    Table table = lsvBill.Tag as Table;
        //    if (table is null)
        //    {
        //        btnCreate.Enabled = false;
        //        return;
        //    }
        //    int Billstatus = BillDAO.Instance.GetUncheckBillIDbyTableID(table.ID);
        //    if (Billstatus == -1)
        //    {
        //        btnCreate.Enabled = false;
        //    }
        //    else
        //    {
        //        btnCreate.Enabled = true;
        //    }
        //}
        //void ShowBill(int id)
        //{
        //    lsvBill.Items.Clear();
        //    List<OrderFood> listBillInfo = OrderFoodDAO.Instance.GetListMenuByTable(id);
        //     totalPrice = 0;
        //    foreach (OrderFood item in listBillInfo)
        //    {
        //        ListViewItem lsvitem = new ListViewItem(item.FoodName.ToString());
        //        lsvitem.SubItems.Add(item.Count.ToString());
        //        lsvitem.SubItems.Add(item.Price.ToString());
        //        lsvitem.SubItems.Add(item.TotalPrice.ToString());
        //        lsvitem.Tag = FoodDAO.Instance.GetFoodByID(item.FoodId);
        //        totalPrice += item.TotalPrice;
        //        lsvBill.Items.Add(lsvitem);
        //    }
        //    lblTotalPrice.Text = totalPrice.ToString();
        //}
        #endregion
        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is null) return;
            Food food = ((sender as Guna2Button).Tag as Food);
            ChangeFoodSelection(food);
        }
        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is null) return;
            if ((sender as ListView).SelectedItems.Count < 1) return;
            Food food = ((sender as ListView).SelectedItems[0].Tag as Food);
            ChangeFoodSelection(food);
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            FoodCategory selected = cb.SelectedItem as FoodCategory;
            id = selected.ID;
            LoadFoodListByCategoryID(id, txbSearchFood.Text);
        }
        private void txbSearchFood_TextChanged(object sender, EventArgs e)
        {
            int id = (cbCategory.SelectedItem as FoodCategory).ID;
            string text = txbSearchFood.Text;
            LoadFoodListByCategoryID(id, text);
        }
        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableOrderData = (sender as ComboBox).SelectedItem as Table;
            checkClikableBtnCreate();
        }
        private void nmFoodCount_ValueChanged(object sender, EventArgs e)
        {
            created = 0;
            Table table = TableOrderData;
            Food food = lblCurrentFood.Tag as Food;
            if (table is null)
            {
                MessageBox.Show("Không còn bàn trống!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            int foodID = food.ID;
            int count = (int)nmFoodCount.Value;
            int exists = FindFoodIndexInOrder(foodID); 
            if (exists == -1)
            {
                if (count != 0) FoodOrderData.Add(new OrderFood(food.Name, count, food.Price, food.Price * count, food.ID));
            }
            else
            {
                FoodOrderData[exists].Count = count;
                FoodOrderData[exists].Price = food.Price;
                FoodOrderData[exists].TotalPrice = food.Price * count;
                if (count == 0) FoodOrderData.RemoveAt(exists);
            }
            checkClikableBtnCreate();
            ShowBill();
        }
        private void nmDiscount_ValueChanged(object sender, EventArgs e)
        {
            created = 0;
            checkClikableBtnCreate();
            ShowBill();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            updateTable(lsvBill.Tag as Table, TableOrderData); 
            Table table = lsvBill.Tag as Table;
            int idBill = -1;
            foreach (OrderFood data in FoodOrderData)
            {
                int foodID = data.FoodId;
                int count = data.Count; 
                idBill = BillDAO.Instance.NewGetUncheckBillIDbyTableID(table.ID);
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(table.ID); 
                    idBill = BillDAO.Instance.NewGetUncheckBillIDbyTableID(table.ID);
                    BillInfoDAO.Instance.NewInsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
                }
                else
                {
                    BillInfoDAO.Instance.NewInsertBillInfo(idBill, foodID, count);
                }
            }

            if (idBill != -1)
            {
                BillDAO.Instance.UpdatePrice(idBill, (int)nmDiscount.Value, double.Parse(lblTotalPrice.Text));
            }
            created = 1;
            MessageBox.Show("Đơn hàng đã được " + statustext);
            checkClikableBtnCreate();
            //return to Form Order
            Control MainForm = this.Parent;
            while (MainForm.Name != "FormMainMenu")
            {
                MainForm = MainForm.Parent;
            }
            FormMainMenu fmm = MainForm as FormMainMenu;
            fmm.btnOrder_Click(fmm.btnOrder, new EventArgs());
        }
        private void FormTaoDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (created == 0 && btnCreate.Enabled == true)
            {
                DialogResult tmp = MessageBox.Show("Thông tin chưa được lưu, thoát?", "Thoát", MessageBoxButtons.YesNo);
                if (tmp != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        #region graveyard
        //private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //Table oldTable = lsvBill.Tag as Table;
        //Table newTable = (sender as ComboBox).SelectedItem as Table;
        //updateTable(oldTable, newTable);
        //checkClikableBtnCreate();
        //}
        //private void btnAddFood_Click(object sender, EventArgs e)
        //{
        //    Table table = lsvBill.Tag as Table;
        //    Food food = lblCurrentFood.Tag as Food;
        //    if (table is null)
        //    {
        //        MessageBox.Show("Không còn bàn trống!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    int idBill = BillDAO.Instance.GetUncheckBillIDbyTableID(table.ID);
        //    int foodID = food.ID;
        //    int count = (int)nmFoodCount.Value;
        //    if (idBill == -1)
        //    {
        //        BillDAO.Instance.InsertBill(table.ID);
        //        BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
        //    }
        //    else
        //    {
        //        BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
        //    }
        //    checkClikableBtnCreate();
        //    ShowBill(table.ID);
        //}
        //private void FormTaoDon_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (created == 0 && btnCreate.Enabled == true)
        //    {
        //        DialogResult tmp = MessageBox.Show("Đơn hàng chưa được tạo, thoát?", "Thoát", MessageBoxButtons.YesNo);
        //        if (tmp == DialogResult.Yes)
        //        {
        //            Table table = lsvBill.Tag as Table;
        //            List<OrderFood> listBillInfo = OrderFoodDAO.Instance.GetListMenuByTable(table.ID);
        //            foreach (OrderFood item in listBillInfo)
        //            {
        //                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), item.FoodId, -item.Count);
        //            }

        //        }
        //        else
        //        {
        //            e.Cancel = true;
        //            return;
        //        }
        //    }
        //}
        #endregion

        #endregion

        //private void btnPay_Click(object sender, EventArgs e)
        //{
        //    Table table = lsvBill.Tag as Table;
        //    if (table is null)
        //    {
        //        MessageBox.Show("Vui lòng chọn bàn cần thanh toán!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    int idBill = BillDAO.Instance.GetUncheckBillIDbyTableID(table.ID);
        //    int discount = (int)nmDiscount.Value;
        //    //double totalPrice = Convert.ToDouble(lblTotalPrice.Text.Split(',')[0]);
        //    //double totalPrice = double.Parse(lblTotalPrice.Text, NumberStyles.Currency, new CultureInfo("vi-VN"));
        //    double totalPrice = Convert.ToDouble(lblTotalPrice.Text);
        //    double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

        //    if (idBill != -1)
        //    {
        //        DialogResult res = MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0} ?\nHóa đơn đã được giảm {2}%\nTổng tiền cần thanh toán là: {1} VND", table.Name, finalTotalPrice, discount), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        if (res == DialogResult.OK)
        //        {
        //            BillDAO.Instance.CheckOut(idBill, discount, ()finalTotalPrice);
        //            ShowBill(table.ID);
        //        }
        //    }
        //}

    }
}
