using QLNH_Winform.DAO;
using QLNH_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH_Winform.Forms
{
    public partial class FormTaoHD : Form
    {
        BindingSource billinfos = new BindingSource();
        public int idBill;
        public string tableName;
        public int discountVal;
        public double totalPrice;
        public FormTaoHD()
        {
            InitializeComponent();
            
        }
        public FormTaoHD(int id) : this()
        {
            idBill = id;
        }
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        public int DiscountVal
        {
            get { return discountVal; }
            set { discountVal = value; }
        }

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        private void FormXuatHD_Load(object sender, EventArgs e)
        {
            lblID.Text = idBill.ToString();
            lblTable.Text = tableName;
            lblDiscountValue.Text = discountVal.ToString();
            lblTotalPrice.Text = totalPrice.ToString();
            ShowBill(idBill);
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            double totalPrice = 0;
            List<OrderFood> tmp = OrderFoodDAO.Instance.GetListMenuByBill(id);
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
        }

        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            pnBill = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
        }

       
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.pnBill.Width / 2), this.pnBill.Location.Y);
        }

        private void btnGenerateBill_Click_1(object sender, EventArgs e)
        {
            Print(this.pnBill);
        }
    }
}
