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
    public partial class FormXuatHD : Form
    {
        Bill bills;
        List<BillInfo> lists;
        public FormXuatHD()
        {
            InitializeComponent();
        }

        private void FormXuatHD_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                //new Microsoft.Reporting.WinForms.ReportParameter("pOrderID", bills.ID.ToString());
            };
            
            //this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
