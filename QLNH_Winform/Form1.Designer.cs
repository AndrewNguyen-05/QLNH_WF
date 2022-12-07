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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnKhoHang = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnMonAn = new FontAwesome.Sharp.IconButton();
            this.btnBanAn = new FontAwesome.Sharp.IconButton();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.lblCurentChildForm = new System.Windows.Forms.Label();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.ellipseControl1 = new QLNH_Winform.EllipseControl();
            this.pnMenu.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnMenu.Controls.Add(this.btnKhoHang);
            this.pnMenu.Controls.Add(this.btnNhanVien);
            this.pnMenu.Controls.Add(this.btnMonAn);
            this.pnMenu.Controls.Add(this.btnBanAn);
            this.pnMenu.Controls.Add(this.btnThongKe);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(330, 742);
            this.pnMenu.TabIndex = 0;
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhoHang.FlatAppearance.BorderSize = 0;
            this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhoHang.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnKhoHang.IconColor = System.Drawing.Color.White;
            this.btnKhoHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.Location = new System.Drawing.Point(0, 464);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnKhoHang.Size = new System.Drawing.Size(330, 91);
            this.btnKhoHang.TabIndex = 26;
            this.btnKhoHang.Text = "Kho hàng";
            this.btnKhoHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoHang.UseVisualStyleBackColor = true;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnNhanVien.IconColor = System.Drawing.Color.White;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 373);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(330, 91);
            this.btnNhanVien.TabIndex = 22;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnMonAn
            // 
            this.btnMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonAn.FlatAppearance.BorderSize = 0;
            this.btnMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonAn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonAn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMonAn.IconChar = FontAwesome.Sharp.IconChar.Cutlery;
            this.btnMonAn.IconColor = System.Drawing.Color.White;
            this.btnMonAn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonAn.Location = new System.Drawing.Point(0, 282);
            this.btnMonAn.Name = "btnMonAn";
            this.btnMonAn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMonAn.Size = new System.Drawing.Size(330, 91);
            this.btnMonAn.TabIndex = 17;
            this.btnMonAn.Text = "Món ăn";
            this.btnMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonAn.UseVisualStyleBackColor = true;
            this.btnMonAn.Click += new System.EventHandler(this.btnMonAn_Click);
            // 
            // btnBanAn
            // 
            this.btnBanAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanAn.FlatAppearance.BorderSize = 0;
            this.btnBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanAn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanAn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBanAn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnBanAn.IconColor = System.Drawing.Color.White;
            this.btnBanAn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanAn.Location = new System.Drawing.Point(0, 191);
            this.btnBanAn.Name = "btnBanAn";
            this.btnBanAn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBanAn.Size = new System.Drawing.Size(330, 91);
            this.btnBanAn.TabIndex = 11;
            this.btnBanAn.Text = "Bàn ăn";
            this.btnBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanAn.UseVisualStyleBackColor = true;
            this.btnBanAn.Click += new System.EventHandler(this.btnBanAn_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 100);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(330, 91);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnLogo.Controls.Add(this.label1);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.ForeColor = System.Drawing.Color.Blue;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(330, 100);
            this.pnLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "QLNH";
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnTitleBar.Controls.Add(this.btnMinimize);
            this.pnTitleBar.Controls.Add(this.btnExit);
            this.pnTitleBar.Controls.Add(this.btnCurrentChildForm);
            this.pnTitleBar.Controls.Add(this.lblCurentChildForm);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnTitleBar.Location = new System.Drawing.Point(330, 0);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(867, 100);
            this.pnTitleBar.TabIndex = 1;
            this.pnTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(760, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(47, 43);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(795, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCurrentChildForm
            // 
            this.btnCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.btnCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.btnCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCurrentChildForm.Location = new System.Drawing.Point(18, 21);
            this.btnCurrentChildForm.Name = "btnCurrentChildForm";
            this.btnCurrentChildForm.Size = new System.Drawing.Size(60, 53);
            this.btnCurrentChildForm.TabIndex = 3;
            this.btnCurrentChildForm.UseVisualStyleBackColor = true;
            // 
            // lblCurentChildForm
            // 
            this.lblCurentChildForm.AutoSize = true;
            this.lblCurentChildForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurentChildForm.Location = new System.Drawing.Point(72, 35);
            this.lblCurentChildForm.Name = "lblCurentChildForm";
            this.lblCurentChildForm.Size = new System.Drawing.Size(73, 30);
            this.lblCurentChildForm.TabIndex = 2;
            this.lblCurentChildForm.Text = "Home";
            // 
            // pnDesktop
            // 
            this.pnDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesktop.Location = new System.Drawing.Point(330, 100);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(867, 642);
            this.pnDesktop.TabIndex = 2;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 70;
            this.ellipseControl1.TargetControl = this;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 742);
            this.Controls.Add(this.pnDesktop);
            this.Controls.Add(this.pnTitleBar);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnMenu.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnKhoHang;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnMonAn;
        private FontAwesome.Sharp.IconButton btnBanAn;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private System.Windows.Forms.Label lblCurentChildForm;
        private FontAwesome.Sharp.IconButton btnCurrentChildForm;
        private System.Windows.Forms.Panel pnDesktop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private EllipseControl ellipseControl1;
    }
}

