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
    public partial class FormKhoHang : Form
    {
        public FormKhoHang()
        {
            InitializeComponent();
        }

        private void dataGridTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(249, 118, 176);
                dataGridTable.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(23, 22, 37);
            }
        }

        private void dataGridTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridTable.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(34, 33, 74);
                dataGridTable.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow tmp = new DataGridViewRow();
            tmp.Height = 30;
            dataGridTable.Rows.Add(tmp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridTable.Rows.Remove
            for (int i = dataGridTable.RowCount - 1; i >= 0; i--)
            {
                if ((dataGridTable.Rows[i].Cells[7].Value is null) == false)
                {
                    if (dataGridTable.Rows[i].Cells[7].Value.ToString() == "*")
                    {
                        dataGridTable.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void dataGridTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgt = sender as DataGridView;
            if (e.RowIndex < 0 || e.RowIndex > dgt.RowCount - 1)
            {
                return;
            }
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex <= 0) return;
                DataGridViewRow tmp = dgt.Rows[e.RowIndex];
                dgt.Rows.RemoveAt(e.RowIndex);
                dgt.Rows.Insert(e.RowIndex - 1, tmp);
            }
            else if (e.ColumnIndex == 6)
            {
                if (e.RowIndex >= dgt.RowCount - 1) return;
                DataGridViewRow tmp = dgt.Rows[e.RowIndex + 1];
                dgt.Rows.RemoveAt(e.RowIndex + 1);
                dgt.Rows.Insert(e.RowIndex, tmp);
            }
        }

        private void dataGridTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (dataGridTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is null)
                {
                    dataGridTable[e.ColumnIndex, e.RowIndex].Value = "*";
                }
                else if (dataGridTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "")
                {
                    dataGridTable[e.ColumnIndex, e.RowIndex].Value = "*";
                }
                else
                {
                    dataGridTable[e.ColumnIndex, e.RowIndex].Value = "";
                }
            }
        }
    }
}
