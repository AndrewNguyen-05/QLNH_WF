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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoiMon));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.nmDiscount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbSwitchTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nmFoodCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbFood = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSwitchTable = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddFood = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVND = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC GỌI MÓN";
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.guna2GradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel4.BorderRadius = 3;
            this.guna2GradientPanel4.Controls.Add(this.nmDiscount);
            this.guna2GradientPanel4.Controls.Add(this.cbSwitchTable);
            this.guna2GradientPanel4.Controls.Add(this.nmFoodCount);
            this.guna2GradientPanel4.Controls.Add(this.cbFood);
            this.guna2GradientPanel4.Controls.Add(this.cbCategory);
            this.guna2GradientPanel4.Controls.Add(this.btnSwitchTable);
            this.guna2GradientPanel4.Controls.Add(this.btnAddFood);
            this.guna2GradientPanel4.Controls.Add(this.lsvBill);
            this.guna2GradientPanel4.Controls.Add(this.btnPay);
            this.guna2GradientPanel4.Controls.Add(this.label4);
            this.guna2GradientPanel4.Controls.Add(this.lblTotalPrice);
            this.guna2GradientPanel4.Controls.Add(this.lblDiscount);
            this.guna2GradientPanel4.Controls.Add(this.lblTotal);
            this.guna2GradientPanel4.Controls.Add(this.lblVND);
            this.guna2GradientPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GradientPanel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel4.Location = new System.Drawing.Point(575, 45);
            this.guna2GradientPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(610, 682);
            this.guna2GradientPanel4.TabIndex = 3;
            // 
            // nmDiscount
            // 
            this.nmDiscount.BackColor = System.Drawing.Color.Transparent;
            this.nmDiscount.BorderColor = System.Drawing.Color.DimGray;
            this.nmDiscount.BorderRadius = 8;
            this.nmDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmDiscount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.nmDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.nmDiscount.Location = new System.Drawing.Point(454, 457);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(5);
            this.nmDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(93, 36);
            this.nmDiscount.TabIndex = 15;
            this.nmDiscount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.nmDiscount.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.BackColor = System.Drawing.Color.Transparent;
            this.cbSwitchTable.BorderColor = System.Drawing.Color.DimGray;
            this.cbSwitchTable.BorderRadius = 8;
            this.cbSwitchTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSwitchTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwitchTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwitchTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwitchTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbSwitchTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.cbSwitchTable.ItemHeight = 30;
            this.cbSwitchTable.Location = new System.Drawing.Point(36, 457);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(252, 36);
            this.cbSwitchTable.TabIndex = 14;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.BackColor = System.Drawing.Color.Transparent;
            this.nmFoodCount.BorderColor = System.Drawing.Color.DimGray;
            this.nmFoodCount.BorderRadius = 8;
            this.nmFoodCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmFoodCount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.nmFoodCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.nmFoodCount.Location = new System.Drawing.Point(264, 5);
            this.nmFoodCount.Margin = new System.Windows.Forms.Padding(5);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(93, 36);
            this.nmFoodCount.TabIndex = 13;
            this.nmFoodCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.nmFoodCount.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFood
            // 
            this.cbFood.BackColor = System.Drawing.Color.Transparent;
            this.cbFood.BorderColor = System.Drawing.Color.DimGray;
            this.cbFood.BorderRadius = 8;
            this.cbFood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFood.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.cbFood.ItemHeight = 30;
            this.cbFood.Location = new System.Drawing.Point(37, 51);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(320, 36);
            this.cbFood.TabIndex = 12;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BorderColor = System.Drawing.Color.DimGray;
            this.cbCategory.BorderRadius = 8;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.Font = new System.Drawing.Font("Cambria", 12F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.Location = new System.Drawing.Point(37, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(219, 36);
            this.cbCategory.TabIndex = 11;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Animated = true;
            this.btnSwitchTable.BorderColor = System.Drawing.Color.DimGray;
            this.btnSwitchTable.BorderRadius = 8;
            this.btnSwitchTable.BorderThickness = 1;
            this.btnSwitchTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwitchTable.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwitchTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwitchTable.FillColor = System.Drawing.Color.Transparent;
            this.btnSwitchTable.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSwitchTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnSwitchTable.ForeColor = System.Drawing.Color.DimGray;
            this.btnSwitchTable.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchTable.Image")));
            this.btnSwitchTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSwitchTable.Location = new System.Drawing.Point(35, 510);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(252, 36);
            this.btnSwitchTable.TabIndex = 8;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Animated = true;
            this.btnAddFood.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddFood.BorderRadius = 8;
            this.btnAddFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFood.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnAddFood.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnAddFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnAddFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFood.Image")));
            this.btnAddFood.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddFood.Location = new System.Drawing.Point(427, 5);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(154, 83);
            this.btnAddFood.TabIndex = 8;
            this.btnAddFood.Text = "Đặt món";
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.Color.White;
            this.lsvBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCount,
            this.colPrice,
            this.colTotal});
            this.lsvBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(36, 111);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(545, 323);
            this.lsvBill.TabIndex = 0;
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
            this.colPrice.Text = "GIÁ TIỀN";
            this.colPrice.Width = 100;
            // 
            // colTotal
            // 
            this.colTotal.Text = "THÀNH TIỀN";
            this.colTotal.Width = 120;
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.BorderRadius = 8;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnPay.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnPay.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnPay.Location = new System.Drawing.Point(36, 586);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(545, 60);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "THANH TOÁN";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(555, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(416, 508);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(117, 38);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiscount.Location = new System.Drawing.Point(324, 451);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(113, 49);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Giảm giá :";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotal.Location = new System.Drawing.Point(323, 504);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(124, 49);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Tổng tiền :";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVND
            // 
            this.lblVND.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.lblVND.Location = new System.Drawing.Point(517, 509);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(62, 38);
            this.lblVND.TabIndex = 4;
            this.lblVND.Text = "VND";
            this.lblVND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.flpTable.Location = new System.Drawing.Point(12, 45);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(549, 671);
            this.flpTable.TabIndex = 1;
            // 
            // FormGoiMon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1185, 727);
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
        private System.Windows.Forms.Label lblTotal;
        private Guna.UI2.WinForms.Guna2GradientButton btnPay;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotal;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton btnSwitchTable;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddFood;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbFood;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmFoodCount;
        private Guna.UI2.WinForms.Guna2ComboBox cbSwitchTable;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmDiscount;
    }
}