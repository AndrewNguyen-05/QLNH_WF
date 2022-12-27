namespace QLNH_Winform.Forms
{
    partial class FormDatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvPrcsBill = new System.Windows.Forms.DataGridView();
            this.btnNewOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEditOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDeleteBill = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnServeBill = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVND = new System.Windows.Forms.Label();
            this.lblBillNumber = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrcsBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPrcsBill
            // 
            this.dtgvPrcsBill.AllowUserToAddRows = false;
            this.dtgvPrcsBill.AllowUserToDeleteRows = false;
            this.dtgvPrcsBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvPrcsBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvPrcsBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvPrcsBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvPrcsBill.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPrcsBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvPrcsBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvPrcsBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPrcsBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvPrcsBill.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPrcsBill.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvPrcsBill.EnableHeadersVisualStyles = false;
            this.dtgvPrcsBill.Location = new System.Drawing.Point(12, 74);
            this.dtgvPrcsBill.MultiSelect = false;
            this.dtgvPrcsBill.Name = "dtgvPrcsBill";
            this.dtgvPrcsBill.ReadOnly = true;
            this.dtgvPrcsBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPrcsBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvPrcsBill.RowHeadersVisible = false;
            this.dtgvPrcsBill.RowHeadersWidth = 51;
            this.dtgvPrcsBill.RowTemplate.Height = 50;
            this.dtgvPrcsBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPrcsBill.Size = new System.Drawing.Size(572, 580);
            this.dtgvPrcsBill.TabIndex = 1;
            this.dtgvPrcsBill.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvPrcsBill_CellFormatting);
            this.dtgvPrcsBill.SelectionChanged += new System.EventHandler(this.dtgvPrcsBill_SelectionChanged);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BorderRadius = 12;
            this.btnNewOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnNewOrder.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnNewOrder.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnNewOrder.Location = new System.Drawing.Point(12, 12);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(136, 56);
            this.btnNewOrder.TabIndex = 8;
            this.btnNewOrder.Text = "Đơn mới";
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BorderRadius = 12;
            this.btnEditOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnEditOrder.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnEditOrder.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrder.ForeColor = System.Drawing.Color.White;
            this.btnEditOrder.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnEditOrder.Location = new System.Drawing.Point(154, 12);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(136, 56);
            this.btnEditOrder.TabIndex = 9;
            this.btnEditOrder.Text = "Chỉnh sửa";
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BorderRadius = 12;
            this.btnDeleteBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteBill.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnDeleteBill.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnDeleteBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBill.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBill.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnDeleteBill.Location = new System.Drawing.Point(438, 12);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(136, 56);
            this.btnDeleteBill.TabIndex = 10;
            this.btnDeleteBill.Text = "Hủy đơn";
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnServeBill
            // 
            this.btnServeBill.BorderRadius = 12;
            this.btnServeBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServeBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServeBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServeBill.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServeBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServeBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnServeBill.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnServeBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServeBill.ForeColor = System.Drawing.Color.White;
            this.btnServeBill.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnServeBill.Location = new System.Drawing.Point(296, 12);
            this.btnServeBill.Name = "btnServeBill";
            this.btnServeBill.Size = new System.Drawing.Size(136, 56);
            this.btnServeBill.TabIndex = 11;
            this.btnServeBill.Text = "Phục vụ";
            this.btnServeBill.Click += new System.EventHandler(this.btnServeBill_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BorderRadius = 12;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnCheckout.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnCheckout.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnCheckout.Location = new System.Drawing.Point(595, 598);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(545, 56);
            this.btnCheckout.TabIndex = 12;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.Color.White;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCount,
            this.colPrice,
            this.colTotal});
            this.lsvBill.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(595, 74);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvBill.MultiSelect = false;
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(545, 407);
            this.lsvBill.TabIndex = 13;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "TÊN MÓN ĂN";
            this.colName.Width = 220;
            // 
            // colCount
            // 
            this.colCount.Text = "SỐ LƯỢNG";
            this.colCount.Width = 100;
            // 
            // colPrice
            // 
            this.colPrice.Text = "ĐƠN GIÁ";
            this.colPrice.Width = 100;
            // 
            // colTotal
            // 
            this.colTotal.Text = "THÀNH TIỀN";
            this.colTotal.Width = 120;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(1081, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 38);
            this.label4.TabIndex = 18;
            this.label4.Text = "%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(865, 543);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(219, 38);
            this.lblTotalPrice.TabIndex = 19;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiscount.Location = new System.Drawing.Point(591, 485);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(113, 49);
            this.lblDiscount.TabIndex = 16;
            this.lblDiscount.Text = "Giảm giá :";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotal.Location = new System.Drawing.Point(590, 538);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(124, 49);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Tổng tiền :";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVND
            // 
            this.lblVND.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.lblVND.Location = new System.Drawing.Point(1070, 543);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(62, 38);
            this.lblVND.TabIndex = 20;
            this.lblVND.Text = "VND";
            this.lblVND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBillNumber.Location = new System.Drawing.Point(595, 27);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.Size = new System.Drawing.Size(539, 41);
            this.lblBillNumber.TabIndex = 21;
            this.lblBillNumber.Text = "Đơn hàng số: ";
            this.lblBillNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiscountValue.ForeColor = System.Drawing.Color.Black;
            this.lblDiscountValue.Location = new System.Drawing.Point(865, 490);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(219, 38);
            this.lblDiscountValue.TabIndex = 22;
            this.lblDiscountValue.Text = "0";
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1146, 666);
            this.Controls.Add(this.lblDiscountValue);
            this.Controls.Add(this.lblBillNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblVND);
            this.Controls.Add(this.lsvBill);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnServeBill);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.dtgvPrcsBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatHang";
            this.Text = "Đặt Hàng";
            this.Shown += new System.EventHandler(this.FormDonHang_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrcsBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridView dtgvPrcsBill;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteBill;
        private Guna.UI2.WinForms.Guna2GradientButton btnServeBill;
        private Guna.UI2.WinForms.Guna2GradientButton btnCheckout;
        internal Guna.UI2.WinForms.Guna2GradientButton btnNewOrder;
        internal Guna.UI2.WinForms.Guna2GradientButton btnEditOrder;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.Label lblBillNumber;
        private System.Windows.Forms.Label lblDiscountValue;
    }
}