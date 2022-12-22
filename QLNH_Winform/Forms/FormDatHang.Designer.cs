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
            this.lbInfo = new System.Windows.Forms.Label();
            this.dtgvPrcsBill = new System.Windows.Forms.DataGridView();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnServeBill = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrcsBill)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(12, 9);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(189, 16);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "Danh sách đơn hàng đang xử lí";
            // 
            // dtgvPrcsBill
            // 
            this.dtgvPrcsBill.AllowUserToAddRows = false;
            this.dtgvPrcsBill.AllowUserToDeleteRows = false;
            this.dtgvPrcsBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvPrcsBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrcsBill.Location = new System.Drawing.Point(12, 28);
            this.dtgvPrcsBill.MultiSelect = false;
            this.dtgvPrcsBill.Name = "dtgvPrcsBill";
            this.dtgvPrcsBill.ReadOnly = true;
            this.dtgvPrcsBill.RowHeadersWidth = 51;
            this.dtgvPrcsBill.RowTemplate.Height = 24;
            this.dtgvPrcsBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPrcsBill.Size = new System.Drawing.Size(492, 538);
            this.dtgvPrcsBill.TabIndex = 1;
            this.dtgvPrcsBill.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvPrcsBill_CellFormatting);
            this.dtgvPrcsBill.SelectionChanged += new System.EventHandler(this.dtgvPrcsBill_SelectionChanged);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewOrder.Location = new System.Drawing.Point(584, 36);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(160, 61);
            this.btnNewOrder.TabIndex = 3;
            this.btnNewOrder.Text = "Đơn mới";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            // 
            // btnServeBill
            // 
            this.btnServeBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServeBill.Location = new System.Drawing.Point(584, 298);
            this.btnServeBill.Name = "btnServeBill";
            this.btnServeBill.Size = new System.Drawing.Size(160, 48);
            this.btnServeBill.TabIndex = 4;
            this.btnServeBill.Text = "Phục vụ";
            this.btnServeBill.UseVisualStyleBackColor = true;
            this.btnServeBill.Click += new System.EventHandler(this.btnServeBill_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.Location = new System.Drawing.Point(510, 518);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(384, 48);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Thanh toán";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBill.Location = new System.Drawing.Point(717, 244);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(160, 48);
            this.btnDeleteBill.TabIndex = 6;
            this.btnDeleteBill.Text = "Hủy đơn";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditOrder.Location = new System.Drawing.Point(540, 157);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(160, 48);
            this.btnEditOrder.TabIndex = 7;
            this.btnEditOrder.Text = "Chỉnh sửa";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            // 
            // FormDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 578);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnServeBill);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.dtgvPrcsBill);
            this.Controls.Add(this.lbInfo);
            this.Name = "FormDatHang";
            this.Text = "Đặt Hàng";
            this.Shown += new System.EventHandler(this.FormDonHang_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrcsBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnServeBill;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnDeleteBill;
        internal System.Windows.Forms.Button btnNewOrder;
        internal System.Windows.Forms.Button btnEditOrder;
        internal System.Windows.Forms.DataGridView dtgvPrcsBill;
    }
}