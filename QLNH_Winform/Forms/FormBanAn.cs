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
    public partial class FormBanAn : Form
    {
        public FormBanAn()
        {
            InitializeComponent();
        }

        private void dataGridTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(249, 118, 176);
            }
        }

        private void dataGridTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(34, 33, 74);
            }
        }
    }
}
