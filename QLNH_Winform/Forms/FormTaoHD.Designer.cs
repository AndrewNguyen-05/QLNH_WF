namespace QLNH_Winform.Forms
{
    partial class FormTaoHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoHD));
            this.pnBill = new System.Windows.Forms.Panel();
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvBill = new System.Windows.Forms.ListView();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.pnBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBill
            // 
            this.pnBill.Controls.Add(this.lblBillTitle);
            this.pnBill.Controls.Add(this.lblDiscountValue);
            this.pnBill.Controls.Add(this.lblTable);
            this.pnBill.Controls.Add(this.lblID);
            this.pnBill.Controls.Add(this.lblTotalPrice);
            this.pnBill.Controls.Add(this.label3);
            this.pnBill.Controls.Add(this.label2);
            this.pnBill.Controls.Add(this.label1);
            this.pnBill.Controls.Add(this.lsvBill);
            this.pnBill.Controls.Add(this.guna2HtmlLabel7);
            this.pnBill.Controls.Add(this.guna2HtmlLabel6);
            this.pnBill.Controls.Add(this.btnGenerateBill);
            this.pnBill.Controls.Add(this.pictureBox1);
            this.pnBill.Location = new System.Drawing.Point(0, 0);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(1255, 1260);
            this.pnBill.TabIndex = 0;
            // 
            // colTotal
            // 
            this.colTotal.Text = "THÀNH TIỀN";
            this.colTotal.Width = 282;
            // 
            // colCount
            // 
            this.colCount.Text = "SỐ LƯỢNG";
            this.colCount.Width = 207;
            // 
            // colName
            // 
            this.colName.Text = "TÊN MÓN ĂN";
            this.colName.Width = 220;
            // 
            // colPrice
            // 
            this.colPrice.Text = "ĐƠN GIÁ";
            this.colPrice.Width = 191;
            // 
            // lsvBill
            // 
            this.lsvBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.lsvBill.Location = new System.Drawing.Point(37, 354);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lsvBill.MultiSelect = false;
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Scrollable = false;
            this.lsvBill.Size = new System.Drawing.Size(1181, 886);
            this.lsvBill.TabIndex = 42;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(1144, 279);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(93, 49);
            this.guna2HtmlLabel7.TabIndex = 41;
            this.guna2HtmlLabel7.Text = "VND";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(625, 279);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(55, 49);
            this.guna2HtmlLabel6.TabIndex = 40;
            this.guna2HtmlLabel6.Text = "%";
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateBill.Image")));
            this.btnGenerateBill.Location = new System.Drawing.Point(1115, 64);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(81, 66);
            this.btnGenerateBill.TabIndex = 36;
            this.btnGenerateBill.UseVisualStyleBackColor = true;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(753, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 43);
            this.label1.TabIndex = 43;
            this.label1.Text = "Số hóa đơn:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 35);
            this.label2.TabIndex = 43;
            this.label2.Text = "Giảm giá:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(746, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 52);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tổng tiền:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(957, 276);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(178, 43);
            this.lblTotalPrice.TabIndex = 43;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTable
            // 
            this.lblTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTable.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(339, 195);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(189, 36);
            this.lblTable.TabIndex = 44;
            this.lblTable.Text = "Bàn: ";
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiscountValue.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountValue.Location = new System.Drawing.Point(508, 271);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(102, 52);
            this.lblDiscountValue.TabIndex = 45;
            this.lblDiscountValue.Text = "0";
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblID.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(994, 195);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 43);
            this.lblID.TabIndex = 43;
            this.lblID.Text = "0";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTitle.Location = new System.Drawing.Point(360, 12);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(707, 118);
            this.lblBillTitle.TabIndex = 46;
            this.lblBillTitle.Text = "HÓA ĐƠN BÁN HÀNG";
            this.lblBillTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTaoHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1275, 1260);
            this.Controls.Add(this.pnBill);
            this.Name = "FormTaoHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất hóa đơn";
            this.Load += new System.EventHandler(this.FormXuatHD_Load);
            this.pnBill.ResumeLayout(false);
            this.pnBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBill;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Label lblID;
    }
}