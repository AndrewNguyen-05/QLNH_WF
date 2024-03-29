﻿namespace QLNH_Winform.Forms
{
    partial class FormTaoDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoDon));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nmDiscount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nmFoodCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvBill = new System.Windows.Forms.ListView();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTable = new System.Windows.Forms.Label();
            this.btnCreate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVND = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentFood = new System.Windows.Forms.Label();
            this.txbSearchFood = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblBillNumber = new System.Windows.Forms.Label();
            this.lblDG = new System.Windows.Forms.Label();
            this.lblDGvalue = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDeleteFood = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.guna2GradientPanel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colTotal
            // 
            this.colTotal.Text = "THÀNH TIỀN";
            this.colTotal.Width = 120;
            // 
            // colPrice
            // 
            this.colPrice.Text = "ĐƠN GIÁ";
            this.colPrice.Width = 100;
            // 
            // colCount
            // 
            this.colCount.Text = "SỐ LƯỢNG";
            this.colCount.Width = 100;
            // 
            // nmDiscount
            // 
            this.nmDiscount.BackColor = System.Drawing.Color.Transparent;
            this.nmDiscount.BorderColor = System.Drawing.Color.DimGray;
            this.nmDiscount.BorderRadius = 8;
            this.nmDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmDiscount.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.nmDiscount.Location = new System.Drawing.Point(459, 472);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(5);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(93, 36);
            this.nmDiscount.TabIndex = 15;
            this.nmDiscount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.nmDiscount.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.nmDiscount.ValueChanged += new System.EventHandler(this.nmDiscount_ValueChanged);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.BackColor = System.Drawing.Color.Transparent;
            this.nmFoodCount.BorderColor = System.Drawing.Color.DimGray;
            this.nmFoodCount.BorderRadius = 8;
            this.nmFoodCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmFoodCount.Enabled = false;
            this.nmFoodCount.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFoodCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.nmFoodCount.Location = new System.Drawing.Point(137, 610);
            this.nmFoodCount.Margin = new System.Windows.Forms.Padding(5);
            this.nmFoodCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(150, 42);
            this.nmFoodCount.TabIndex = 13;
            this.nmFoodCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.nmFoodCount.ValueChanged += new System.EventHandler(this.nmFoodCount_ValueChanged);
            // 
            // colName
            // 
            this.colName.Text = "TÊN MÓN ĂN";
            this.colName.Width = 220;
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
            this.lsvBill.Location = new System.Drawing.Point(34, 46);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvBill.MultiSelect = false;
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(545, 407);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.guna2GradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel4.BorderRadius = 3;
            this.guna2GradientPanel4.Controls.Add(this.lblTable);
            this.guna2GradientPanel4.Controls.Add(this.nmDiscount);
            this.guna2GradientPanel4.Controls.Add(this.lsvBill);
            this.guna2GradientPanel4.Controls.Add(this.btnCreate);
            this.guna2GradientPanel4.Controls.Add(this.label4);
            this.guna2GradientPanel4.Controls.Add(this.lblTotalPrice);
            this.guna2GradientPanel4.Controls.Add(this.lblDiscount);
            this.guna2GradientPanel4.Controls.Add(this.lblTotal);
            this.guna2GradientPanel4.Controls.Add(this.lblVND);
            this.guna2GradientPanel4.Controls.Add(this.guna2Panel2);
            this.guna2GradientPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GradientPanel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel4.Location = new System.Drawing.Point(557, 45);
            this.guna2GradientPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(610, 635);
            this.guna2GradientPanel4.TabIndex = 6;
            // 
            // lblTable
            // 
            this.lblTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTable.Location = new System.Drawing.Point(33, 5);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(113, 35);
            this.lblTable.TabIndex = 19;
            this.lblTable.Text = "Bàn:";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreate
            // 
            this.btnCreate.Animated = true;
            this.btnCreate.BorderRadius = 8;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnCreate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnCreate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnCreate.Location = new System.Drawing.Point(37, 559);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(545, 60);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "TẠO";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(560, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(296, 513);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(219, 38);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiscount.Location = new System.Drawing.Point(35, 465);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(113, 49);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Giảm giá :";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.lblTotal.Location = new System.Drawing.Point(32, 508);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(168, 49);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Tổng tiền :";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVND
            // 
            this.lblVND.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.lblVND.Location = new System.Drawing.Point(505, 513);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(77, 38);
            this.lblVND.TabIndex = 4;
            this.lblVND.Text = "VND";
            this.lblVND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.cbTable);
            this.guna2Panel2.Location = new System.Drawing.Point(257, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(322, 37);
            this.guna2Panel2.TabIndex = 20;
            // 
            // cbTable
            // 
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTable.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.cbTable.IntegralHeight = false;
            this.cbTable.ItemHeight = 32;
            this.cbTable.Location = new System.Drawing.Point(1, 1);
            this.cbTable.MaxDropDownItems = 10;
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(320, 40);
            this.cbTable.TabIndex = 12;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.flpTable.Location = new System.Drawing.Point(15, 91);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(539, 407);
            this.flpTable.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 41);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số lượng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentFood
            // 
            this.lblCurrentFood.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCurrentFood.ForeColor = System.Drawing.Color.Blue;
            this.lblCurrentFood.Location = new System.Drawing.Point(15, 517);
            this.lblCurrentFood.Name = "lblCurrentFood";
            this.lblCurrentFood.Size = new System.Drawing.Size(539, 41);
            this.lblCurrentFood.TabIndex = 17;
            this.lblCurrentFood.Text = " ";
            this.lblCurrentFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbSearchFood
            // 
            this.txbSearchFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchFood.Animated = true;
            this.txbSearchFood.BackColor = System.Drawing.Color.Transparent;
            this.txbSearchFood.BorderColor = System.Drawing.Color.DimGray;
            this.txbSearchFood.BorderRadius = 8;
            this.txbSearchFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearchFood.DefaultText = "";
            this.txbSearchFood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearchFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearchFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchFood.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchFood.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchFood.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchFood.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbSearchFood.IconLeft")));
            this.txbSearchFood.Location = new System.Drawing.Point(279, 47);
            this.txbSearchFood.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txbSearchFood.Name = "txbSearchFood";
            this.txbSearchFood.PasswordChar = '\0';
            this.txbSearchFood.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbSearchFood.PlaceholderText = "Tìm kiếm";
            this.txbSearchFood.SelectedText = "";
            this.txbSearchFood.Size = new System.Drawing.Size(275, 37);
            this.txbSearchFood.TabIndex = 18;
            this.txbSearchFood.TextChanged += new System.EventHandler(this.txbSearchFood_TextChanged);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Location = new System.Drawing.Point(12, 64);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(755, 69);
            this.guna2GradientPanel2.TabIndex = 2;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.guna2GradientPanel1.Controls.Add(this.lblBillNumber);
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1167, 45);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBillNumber.Location = new System.Drawing.Point(15, 4);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.Size = new System.Drawing.Size(539, 40);
            this.lblBillNumber.TabIndex = 19;
            this.lblBillNumber.Text = "Đơn hàng số: ";
            this.lblBillNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDG
            // 
            this.lblDG.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDG.Location = new System.Drawing.Point(18, 564);
            this.lblDG.Name = "lblDG";
            this.lblDG.Size = new System.Drawing.Size(113, 41);
            this.lblDG.TabIndex = 19;
            this.lblDG.Text = "Đơn giá:";
            this.lblDG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDGvalue
            // 
            this.lblDGvalue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDGvalue.Location = new System.Drawing.Point(137, 564);
            this.lblDGvalue.Name = "lblDGvalue";
            this.lblDGvalue.Size = new System.Drawing.Size(113, 41);
            this.lblDGvalue.TabIndex = 20;
            this.lblDGvalue.Text = "0";
            this.lblDGvalue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.cbTable;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.White;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.cbCategory.IntegralHeight = false;
            this.cbCategory.ItemHeight = 32;
            this.cbCategory.Location = new System.Drawing.Point(1, 1);
            this.cbCategory.MaxDropDownItems = 10;
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(254, 40);
            this.cbCategory.TabIndex = 11;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.cbCategory;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.cbCategory);
            this.guna2Panel1.Location = new System.Drawing.Point(15, 47);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(256, 37);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BorderRadius = 12;
            this.btnDeleteFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteFood.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnDeleteFood.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnDeleteFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFood.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnDeleteFood.Location = new System.Drawing.Point(354, 596);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(136, 56);
            this.btnDeleteFood.TabIndex = 21;
            this.btnDeleteFood.Text = "Xóa món";
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // FormTaoDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1167, 680);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.lblDGvalue);
            this.Controls.Add(this.lblDG);
            this.Controls.Add(this.txbSearchFood);
            this.Controls.Add(this.lblCurrentFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.guna2GradientPanel4);
            this.Controls.Add(this.nmFoodCount);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaoDon";
            this.Text = "Tạo Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTaoDon_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.guna2GradientPanel4.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colCount;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmDiscount;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmFoodCount;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ListView lsvBill;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentFood;
        private Guna.UI2.WinForms.Guna2TextBox txbSearchFood;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblBillNumber;
        private System.Windows.Forms.Label lblDG;
        private System.Windows.Forms.Label lblDGvalue;
        private System.Windows.Forms.ComboBox cbTable;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        internal Guna.UI2.WinForms.Guna2GradientButton btnDeleteFood;
    }
}