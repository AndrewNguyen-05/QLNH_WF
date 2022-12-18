namespace QLNH_Winform.Forms
{
    partial class FormNhanVien
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
            this.btnResetPassword = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnShowListAcc = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnDeleteStaff = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnAddStaff = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvListAccount = new System.Windows.Forms.DataGridView();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.nmPermission = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnResetPassword);
            this.guna2GradientPanel1.Controls.Add(this.btnShowListAcc);
            this.guna2GradientPanel1.Controls.Add(this.btnEdit);
            this.guna2GradientPanel1.Controls.Add(this.btnDeleteStaff);
            this.guna2GradientPanel1.Controls.Add(this.btnAddStaff);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1128, 161);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetPassword.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(980, 35);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(136, 85);
            this.btnResetPassword.TabIndex = 1;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnShowListAcc
            // 
            this.btnShowListAcc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowListAcc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowListAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowListAcc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowListAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowListAcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowListAcc.ForeColor = System.Drawing.Color.White;
            this.btnShowListAcc.Location = new System.Drawing.Point(741, 35);
            this.btnShowListAcc.Name = "btnShowListAcc";
            this.btnShowListAcc.Size = new System.Drawing.Size(136, 85);
            this.btnShowListAcc.TabIndex = 0;
            this.btnShowListAcc.Text = "Xem";
            this.btnShowListAcc.Click += new System.EventHandler(this.btnShowListAcc_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(500, 35);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 85);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteStaff.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Location = new System.Drawing.Point(269, 35);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(136, 85);
            this.btnDeleteStaff.TabIndex = 0;
            this.btnDeleteStaff.Text = "Xóa";
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStaff.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(48, 35);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(136, 85);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvListAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 473);
            this.panel1.TabIndex = 1;
            // 
            // dtgvListAccount
            // 
            this.dtgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvListAccount.Location = new System.Drawing.Point(0, 0);
            this.dtgvListAccount.Name = "dtgvListAccount";
            this.dtgvListAccount.RowHeadersWidth = 62;
            this.dtgvListAccount.RowTemplate.Height = 28;
            this.dtgvListAccount.Size = new System.Drawing.Size(1128, 473);
            this.dtgvListAccount.TabIndex = 0;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.nmPermission);
            this.guna2GradientPanel2.Controls.Add(this.txtUserName);
            this.guna2GradientPanel2.Controls.Add(this.txtDisplayName);
            this.guna2GradientPanel2.Controls.Add(this.label3);
            this.guna2GradientPanel2.Controls.Add(this.label2);
            this.guna2GradientPanel2.Controls.Add(this.label1);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(612, 161);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(516, 473);
            this.guna2GradientPanel2.TabIndex = 2;
            // 
            // nmPermission
            // 
            this.nmPermission.BackColor = System.Drawing.Color.Transparent;
            this.nmPermission.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmPermission.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmPermission.Location = new System.Drawing.Point(228, 251);
            this.nmPermission.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmPermission.Name = "nmPermission";
            this.nmPermission.Size = new System.Drawing.Size(100, 36);
            this.nmPermission.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(228, 46);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(225, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(228, 160);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(225, 26);
            this.txtDisplayName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quyền tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hiển thị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 634);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNhanVien";
            this.Text = "Nhân viên";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnShowListAcc;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnEdit;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnDeleteStaff;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvListAccount;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmPermission;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnResetPassword;
    }
}