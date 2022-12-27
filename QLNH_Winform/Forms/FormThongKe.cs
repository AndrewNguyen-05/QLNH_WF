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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            cbDateSelection.SelectedIndex = 0;
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        #region Methods

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }    
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        #endregion

        #region Events
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
        private void cbDateSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDateSelection.SelectedIndex == 4)
            {
                dtpkFromDate.Visible = true;
                dtpkToDate.Visible = true;
                guna2GradientPanel1.Visible = true;
                guna2GradientPanel2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                dtpkFromDate.Visible = false;
                dtpkToDate.Visible = false;
                guna2GradientPanel1.Visible = false;
                guna2GradientPanel2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
            //DateTime today = DateTime.Now;
            //today.AddSeconds(-today.Second);
            //today.AddMinutes(-today.Minute);
            //today.AddHours(-today.Hour);
            double tmp = (double)(7 + (DateTime.Today.DayOfWeek - DayOfWeek.Monday)) % 7;
            DateTime firstDayOfWeek = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.AddDays(-tmp).Day);
            DateTime lastDayOfWeek = firstDayOfWeek.AddDays(7).AddMilliseconds(-1);
            DateTime firstDayOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddMilliseconds(-1);
            DateTime firstDayOfYear = new DateTime(DateTime.Today.Year, 1, 1);
            DateTime lastDayOfYear = firstDayOfYear.AddYears(1).AddMilliseconds(-1);
            switch (cbDateSelection.SelectedIndex)
            {
                case 0:
                    LoadListBillByDate(DateTime.Today, DateTime.Today.AddDays(1).AddMilliseconds(-1));
                    break;
                case 1:
                    LoadListBillByDate(firstDayOfWeek, lastDayOfWeek);
                    break;
                case 2:
                    LoadListBillByDate(firstDayOfMonth, lastDayOfMonth);
                    break;
                case 3:
                    LoadListBillByDate(firstDayOfYear, lastDayOfYear);
                    break;
                case 4:
                    LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
                    break;
            }
        }

        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
        #endregion
    }
}
