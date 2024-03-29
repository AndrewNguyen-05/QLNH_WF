﻿namespace QLNH_Winform
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnMonAn = new FontAwesome.Sharp.IconButton();
            this.btnBanAn = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.lblCurentChildForm = new System.Windows.Forms.Label();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnControl = new System.Windows.Forms.Panel();
            this.ControlMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnTitleBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnArrow = new Guna.UI2.WinForms.Guna2Button();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.btnGeneral = new Guna.UI2.WinForms.Guna2Button();
            this.btnCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.pnMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.lblAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnControl.SuspendLayout();
            this.pnTitleBar.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "You";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "For";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLNH_Winform.Properties.Resources.Logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnTaiKhoan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.btnTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaiKhoan.IconSize = 35;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 451);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(287, 73);
            this.btnTaiKhoan.TabIndex = 34;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnThongKe.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.IconSize = 35;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 378);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(287, 73);
            this.btnThongKe.TabIndex = 33;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnNhanVien.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.IconSize = 35;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 305);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(287, 73);
            this.btnNhanVien.TabIndex = 31;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnMonAn
            // 
            this.btnMonAn.FlatAppearance.BorderSize = 0;
            this.btnMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonAn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMonAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnMonAn.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            this.btnMonAn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.btnMonAn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonAn.IconSize = 35;
            this.btnMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonAn.Location = new System.Drawing.Point(0, 232);
            this.btnMonAn.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnMonAn.Name = "btnMonAn";
            this.btnMonAn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMonAn.Size = new System.Drawing.Size(287, 73);
            this.btnMonAn.TabIndex = 30;
            this.btnMonAn.Text = "Món ăn";
            this.btnMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonAn.UseVisualStyleBackColor = true;
            this.btnMonAn.Click += new System.EventHandler(this.btnMonAn_Click);
            // 
            // btnBanAn
            // 
            this.btnBanAn.FlatAppearance.BorderSize = 0;
            this.btnBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanAn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBanAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnBanAn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnBanAn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.btnBanAn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBanAn.IconSize = 35;
            this.btnBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanAn.Location = new System.Drawing.Point(0, 159);
            this.btnBanAn.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnBanAn.Name = "btnBanAn";
            this.btnBanAn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBanAn.Size = new System.Drawing.Size(287, 73);
            this.btnBanAn.TabIndex = 29;
            this.btnBanAn.Text = "Bàn ăn";
            this.btnBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanAn.UseVisualStyleBackColor = true;
            this.btnBanAn.Click += new System.EventHandler(this.btnBanAn_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.Cutlery;
            this.btnOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.IconSize = 35;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 86);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(287, 73);
            this.btnOrder.TabIndex = 27;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblCurentChildForm
            // 
            this.lblCurentChildForm.AutoSize = true;
            this.lblCurentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.lblCurentChildForm.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCurentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.lblCurentChildForm.Location = new System.Drawing.Point(204, 35);
            this.lblCurentChildForm.Name = "lblCurentChildForm";
            this.lblCurentChildForm.Size = new System.Drawing.Size(62, 22);
            this.lblCurentChildForm.TabIndex = 2;
            this.lblCurentChildForm.Text = "Home";
            // 
            // pnDesktop
            // 
            this.pnDesktop.AutoSize = true;
            this.pnDesktop.BackColor = System.Drawing.Color.White;
            this.pnDesktop.Location = new System.Drawing.Point(287, 86);
            this.pnDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(1150, 711);
            this.pnDesktop.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.Transparent;
            this.pnControl.Controls.Add(this.ControlMinimize);
            this.pnControl.Controls.Add(this.ControlClose);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1150, 40);
            this.pnControl.TabIndex = 4;
            this.pnControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // ControlMinimize
            // 
            this.ControlMinimize.Animated = true;
            this.ControlMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlMinimize.FillColor = System.Drawing.Color.Transparent;
            this.ControlMinimize.ForeColor = System.Drawing.Color.Black;
            this.ControlMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.ControlMinimize.Location = new System.Drawing.Point(1060, 0);
            this.ControlMinimize.Name = "ControlMinimize";
            this.ControlMinimize.Size = new System.Drawing.Size(45, 40);
            this.ControlMinimize.TabIndex = 6;
            // 
            // ControlClose
            // 
            this.ControlClose.Animated = true;
            this.ControlClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlClose.ForeColor = System.Drawing.Color.Black;
            this.ControlClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.ControlClose.Location = new System.Drawing.Point(1105, 0);
            this.ControlClose.Name = "ControlClose";
            this.ControlClose.Size = new System.Drawing.Size(45, 40);
            this.ControlClose.TabIndex = 5;
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.White;
            this.pnTitleBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.pnTitleBar.BorderThickness = 1;
            this.pnTitleBar.Controls.Add(this.btnArrow);
            this.pnTitleBar.Controls.Add(this.lblGeneral);
            this.pnTitleBar.Controls.Add(this.btnGeneral);
            this.pnTitleBar.Controls.Add(this.lblCurentChildForm);
            this.pnTitleBar.Controls.Add(this.pnControl);
            this.pnTitleBar.Controls.Add(this.btnCurrentChildForm);
            this.pnTitleBar.Location = new System.Drawing.Point(287, 0);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(1150, 86);
            this.pnTitleBar.TabIndex = 3;
            this.pnTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // btnArrow
            // 
            this.btnArrow.BackColor = System.Drawing.Color.Transparent;
            this.btnArrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnArrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnArrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnArrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnArrow.FillColor = System.Drawing.Color.Transparent;
            this.btnArrow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnArrow.ForeColor = System.Drawing.Color.White;
            this.btnArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnArrow.Image")));
            this.btnArrow.Location = new System.Drawing.Point(147, 21);
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.PressedColor = System.Drawing.Color.Transparent;
            this.btnArrow.Size = new System.Drawing.Size(51, 45);
            this.btnArrow.TabIndex = 7;
            this.btnArrow.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnArrow.UseTransparentBackground = true;
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneral.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.lblGeneral.Location = new System.Drawing.Point(76, 35);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(83, 22);
            this.lblGeneral.TabIndex = 6;
            this.lblGeneral.Text = "QUẢN LÝ";
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.Transparent;
            this.btnGeneral.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneral.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneral.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneral.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeneral.FillColor = System.Drawing.Color.Transparent;
            this.btnGeneral.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGeneral.ForeColor = System.Drawing.Color.White;
            this.btnGeneral.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneral.Image")));
            this.btnGeneral.Location = new System.Drawing.Point(19, 21);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.PressedColor = System.Drawing.Color.Transparent;
            this.btnGeneral.Size = new System.Drawing.Size(51, 45);
            this.btnGeneral.TabIndex = 5;
            this.btnGeneral.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnGeneral.UseTransparentBackground = true;
            // 
            // btnCurrentChildForm
            // 
            this.btnCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.btnCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.btnCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCurrentChildForm.IconSize = 40;
            this.btnCurrentChildForm.Location = new System.Drawing.Point(1085, 21);
            this.btnCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurrentChildForm.Name = "btnCurrentChildForm";
            this.btnCurrentChildForm.Size = new System.Drawing.Size(53, 47);
            this.btnCurrentChildForm.TabIndex = 3;
            this.btnCurrentChildForm.UseVisualStyleBackColor = false;
            this.btnCurrentChildForm.Visible = false;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Controls.Add(this.btnOrder);
            this.pnMenu.Controls.Add(this.btnBanAn);
            this.pnMenu.Controls.Add(this.btnMonAn);
            this.pnMenu.Controls.Add(this.btnNhanVien);
            this.pnMenu.Controls.Add(this.btnThongKe);
            this.pnMenu.Controls.Add(this.btnTaiKhoan);
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(287, 608);
            this.pnMenu.TabIndex = 0;
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.label2);
            this.pnLogo.Controls.Add(this.label1);
            this.pnLogo.Controls.Add(this.pictureBox1);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(287, 86);
            this.pnLogo.TabIndex = 0;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblAccount
            // 
            this.lblAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAccount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAccount.Location = new System.Drawing.Point(12, 635);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(253, 153);
            this.lblAccount.TabIndex = 5;
            this.lblAccount.Text = "currentAccount";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FormMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1437, 797);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnTitleBar);
            this.Controls.Add(this.pnDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            this.pnMenu.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurentChildForm;
        private FontAwesome.Sharp.IconButton btnCurrentChildForm;
        private System.Windows.Forms.Panel pnDesktop;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnMonAn;
        private FontAwesome.Sharp.IconButton btnBanAn;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnTaiKhoan;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Panel pnControl;
        private Guna.UI2.WinForms.Guna2GradientPanel pnTitleBar;
        private Guna.UI2.WinForms.Guna2ControlBox ControlMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox ControlClose;
        private Guna.UI2.WinForms.Guna2Button btnGeneral;
        private Guna.UI2.WinForms.Guna2Button btnArrow;
        private System.Windows.Forms.Label lblGeneral;
        internal FontAwesome.Sharp.IconButton btnOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnMenu;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Label lblAccount;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
    }
}

