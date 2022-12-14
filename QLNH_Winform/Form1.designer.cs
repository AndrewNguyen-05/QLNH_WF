namespace QLNH_Winform
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.btnKhoHang = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnMonAn = new FontAwesome.Sharp.IconButton();
            this.btnBanAn = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.lblCurentChildForm = new System.Windows.Forms.Label();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnMenu.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnMenu.Controls.Add(this.btnThongKe);
            this.pnMenu.Controls.Add(this.btnKhoHang);
            this.pnMenu.Controls.Add(this.btnNhanVien);
            this.pnMenu.Controls.Add(this.btnMonAn);
            this.pnMenu.Controls.Add(this.btnBanAn);
            this.pnMenu.Controls.Add(this.btnOrder);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(287, 797);
            this.pnMenu.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 156);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(293, 73);
            this.btnThongKe.TabIndex = 33;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnKhoHang
            // 
            this.btnKhoHang.FlatAppearance.BorderSize = 0;
            this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhoHang.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnKhoHang.IconColor = System.Drawing.Color.White;
            this.btnKhoHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.Location = new System.Drawing.Point(0, 541);
            this.btnKhoHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoHang.Name = "btnKhoHang";
            this.btnKhoHang.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnKhoHang.Size = new System.Drawing.Size(293, 73);
            this.btnKhoHang.TabIndex = 32;
            this.btnKhoHang.Text = "Kho hàng";
            this.btnKhoHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoHang.UseVisualStyleBackColor = true;
            this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnNhanVien.IconColor = System.Drawing.Color.White;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 464);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(293, 73);
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
            this.btnMonAn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonAn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMonAn.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            this.btnMonAn.IconColor = System.Drawing.Color.White;
            this.btnMonAn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonAn.Location = new System.Drawing.Point(3, 310);
            this.btnMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonAn.Name = "btnMonAn";
            this.btnMonAn.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnMonAn.Size = new System.Drawing.Size(293, 73);
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
            this.btnBanAn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanAn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBanAn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnBanAn.IconColor = System.Drawing.Color.White;
            this.btnBanAn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanAn.Location = new System.Drawing.Point(-6, 233);
            this.btnBanAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBanAn.Name = "btnBanAn";
            this.btnBanAn.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnBanAn.Size = new System.Drawing.Size(293, 73);
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
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.Cutlery;
            this.btnOrder.IconColor = System.Drawing.Color.White;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 387);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(293, 73);
            this.btnOrder.TabIndex = 27;
            this.btnOrder.Text = "Gọi món";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnLogo.Controls.Add(this.label1);
            this.pnLogo.ForeColor = System.Drawing.Color.Blue;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(287, 124);
            this.pnLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(40, 26);
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
            this.pnTitleBar.Location = new System.Drawing.Point(287, 0);
            this.pnTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(1150, 107);
            this.pnTitleBar.TabIndex = 1;
            this.pnTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1054, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 34);
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
            this.btnExit.Location = new System.Drawing.Point(1086, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 34);
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
            this.btnCurrentChildForm.Location = new System.Drawing.Point(6, 35);
            this.btnCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurrentChildForm.Name = "btnCurrentChildForm";
            this.btnCurrentChildForm.Size = new System.Drawing.Size(53, 61);
            this.btnCurrentChildForm.TabIndex = 3;
            this.btnCurrentChildForm.UseVisualStyleBackColor = true;
            // 
            // lblCurentChildForm
            // 
            this.lblCurentChildForm.AutoSize = true;
            this.lblCurentChildForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurentChildForm.Location = new System.Drawing.Point(55, 55);
            this.lblCurentChildForm.Name = "lblCurentChildForm";
            this.lblCurentChildForm.Size = new System.Drawing.Size(73, 30);
            this.lblCurentChildForm.TabIndex = 2;
            this.lblCurentChildForm.Text = "Home";
            // 
            // pnDesktop
            // 
            this.pnDesktop.AutoSize = true;
            this.pnDesktop.BackColor = System.Drawing.Color.White;
            this.pnDesktop.Location = new System.Drawing.Point(287, 107);
            this.pnDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(1150, 688);
            this.pnDesktop.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 70;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FormMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1437, 797);
            this.Controls.Add(this.pnDesktop);
            this.Controls.Add(this.pnTitleBar);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainMenu_FormClosed);
            this.pnMenu.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurentChildForm;
        private FontAwesome.Sharp.IconButton btnCurrentChildForm;
        private System.Windows.Forms.Panel pnDesktop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private FontAwesome.Sharp.IconButton btnKhoHang;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnMonAn;
        private FontAwesome.Sharp.IconButton btnBanAn;
        private FontAwesome.Sharp.IconButton btnOrder;
        private FontAwesome.Sharp.IconButton btnThongKe;
    }
}

