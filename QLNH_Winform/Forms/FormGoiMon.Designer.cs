namespace QLNH_Winform.Forms
{
    partial class FormGoiMon
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.nmDiscount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nmFoodCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddFood = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSwitchTable = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1185, 45);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Location = new System.Drawing.Point(12, 64);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(755, 69);
            this.guna2GradientPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESTAURANT ORDERS";
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.guna2GradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel4.BorderRadius = 3;
            this.guna2GradientPanel4.BorderThickness = 2;
            this.guna2GradientPanel4.Controls.Add(this.nmDiscount);
            this.guna2GradientPanel4.Controls.Add(this.nmFoodCount);
            this.guna2GradientPanel4.Controls.Add(this.btnSwitchTable);
            this.guna2GradientPanel4.Controls.Add(this.btnAddFood);
            this.guna2GradientPanel4.Controls.Add(this.cbFood);
            this.guna2GradientPanel4.Controls.Add(this.cbSwitchTable);
            this.guna2GradientPanel4.Controls.Add(this.cbCategory);
            this.guna2GradientPanel4.Controls.Add(this.lsvBill);
            this.guna2GradientPanel4.Controls.Add(this.btnPay);
            this.guna2GradientPanel4.Controls.Add(this.label4);
            this.guna2GradientPanel4.Controls.Add(this.label2);
            this.guna2GradientPanel4.Controls.Add(this.lblTotalPrice);
            this.guna2GradientPanel4.Controls.Add(this.lblDiscount);
            this.guna2GradientPanel4.Controls.Add(this.label3);
            this.guna2GradientPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GradientPanel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel4.Location = new System.Drawing.Point(575, 45);
            this.guna2GradientPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(610, 741);
            this.guna2GradientPanel4.TabIndex = 3;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nmDiscount.BackColor = System.Drawing.Color.Transparent;
            this.nmDiscount.BorderRadius = 6;
            this.nmDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmDiscount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.nmDiscount.Location = new System.Drawing.Point(429, 506);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(5);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(99, 44);
            this.nmDiscount.TabIndex = 10;
            this.nmDiscount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nmDiscount.UpDownButtonForeColor = System.Drawing.Color.Indigo;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nmFoodCount.BackColor = System.Drawing.Color.Transparent;
            this.nmFoodCount.BorderRadius = 6;
            this.nmFoodCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmFoodCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFoodCount.Location = new System.Drawing.Point(278, 70);
            this.nmFoodCount.Margin = new System.Windows.Forms.Padding(5);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(93, 31);
            this.nmFoodCount.TabIndex = 10;
            this.nmFoodCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nmFoodCount.UpDownButtonForeColor = System.Drawing.Color.Indigo;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFood
            // 
            this.cbFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFood.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(36, 121);
            this.cbFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(220, 46);
            this.cbFood.TabIndex = 7;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSwitchTable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(53, 552);
            this.cbSwitchTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(220, 46);
            this.cbSwitchTable.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(36, 70);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(220, 46);
            this.cbCategory.TabIndex = 6;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lsvBill
            // 
            this.lsvBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCount,
            this.colPrice,
            this.colTotal});
            this.lsvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.ForeColor = System.Drawing.Color.Indigo;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(36, 178);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(545, 295);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Tên món ăn";
            this.colName.Width = 220;
            // 
            // colCount
            // 
            this.colCount.Text = "Số lượng";
            this.colCount.Width = 100;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Giá tiền";
            this.colPrice.Width = 100;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Thành tiền";
            this.colTotal.Width = 120;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPay.Animated = true;
            this.btnPay.AutoRoundedCorners = true;
            this.btnPay.BorderRadius = 29;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.Tomato;
            this.btnPay.FillColor2 = System.Drawing.Color.MediumPurple;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(36, 616);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(545, 60);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(536, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "VND";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(424, 560);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(106, 38);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(307, 506);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(113, 49);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Giảm giá :";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng tiền :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.White;
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpTable.Location = new System.Drawing.Point(0, 45);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(537, 741);
            this.flpTable.TabIndex = 1;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFood.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddFood.BorderRadius = 6;
            this.btnAddFood.BorderThickness = 2;
            this.btnAddFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFood.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFood.FillColor = System.Drawing.Color.Transparent;
            this.btnAddFood.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.Brown;
            this.btnAddFood.Location = new System.Drawing.Point(379, 70);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(202, 90);
            this.btnAddFood.TabIndex = 8;
            this.btnAddFood.Text = "Thêm món ăn";
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSwitchTable.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnSwitchTable.BorderRadius = 6;
            this.btnSwitchTable.BorderThickness = 2;
            this.btnSwitchTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwitchTable.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwitchTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwitchTable.FillColor = System.Drawing.Color.Transparent;
            this.btnSwitchTable.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSwitchTable.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchTable.ForeColor = System.Drawing.Color.Brown;
            this.btnSwitchTable.Location = new System.Drawing.Point(53, 487);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(202, 48);
            this.btnSwitchTable.TabIndex = 8;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // FormGoiMon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1185, 786);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.guna2GradientPanel4);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "FormGoiMon";
            this.Text = "Đặt món ăn";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnPay;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotal;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmFoodCount;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private Guna.UI2.WinForms.Guna2GradientButton btnSwitchTable;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddFood;
    }
}