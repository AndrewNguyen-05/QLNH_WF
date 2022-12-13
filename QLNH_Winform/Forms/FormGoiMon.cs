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
    public partial class FormGoiMon : Form
    {
        public FormGoiMon()
        {
            InitializeComponent();
            LoadTable();
        }
        #region Method
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;

                btn.Click += Btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Lime;
                        break;
                    case "Có người":
                        btn.BackColor = Color.Aqua;
                        break;
                }

                flpTable.Controls.Add(btn);

            }
        }

        

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<MenuFood> listBillInfo = MenuFoodDAO.Instance.GetListMenuByTable(id);

            foreach (MenuFood item in listBillInfo)
            {
                ListViewItem lsvitem = new ListViewItem(item.FoodName.ToString());
                lsvitem.SubItems.Add(item.Count.ToString());
                lsvitem.SubItems.Add(item.Price.ToString());
                lsvitem.SubItems.Add(item.TotalPrice.ToString());

                lsvBill.Items.Add(lsvitem);
            }
        }
        #endregion
        
        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
        }
        #endregion
    }
}
