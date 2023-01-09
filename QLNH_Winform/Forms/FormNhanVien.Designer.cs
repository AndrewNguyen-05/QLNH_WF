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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnResetPassword = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddStaff = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvListAccount = new System.Windows.Forms.DataGridView();
            this.guna2GradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.guna2GradientPanel1.Controls.Add(this.lblEmployeeName);
            this.guna2GradientPanel1.Controls.Add(this.btnResetPassword);
            this.guna2GradientPanel1.Controls.Add(this.btnDelTable);
            this.guna2GradientPanel1.Controls.Add(this.btnAddStaff);
            this.guna2GradientPanel1.Controls.Add(this.txtUserName);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1337, 103);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmployeeName.Location = new System.Drawing.Point(16, 36);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(294, 32);
            this.lblEmployeeName.TabIndex = 15;
            this.lblEmployeeName.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPassword.Animated = true;
            this.btnResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnResetPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnResetPassword.BorderRadius = 8;
            this.btnResetPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetPassword.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnResetPassword.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnResetPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnResetPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.Image")));
            this.btnResetPassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnResetPassword.Location = new System.Drawing.Point(971, 23);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(284, 54);
            this.btnResetPassword.TabIndex = 14;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseTransparentBackground = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnDelTable
            // 
            this.btnDelTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelTable.Animated = true;
            this.btnDelTable.BackColor = System.Drawing.Color.Transparent;
            this.btnDelTable.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelTable.BorderRadius = 8;
            this.btnDelTable.BorderThickness = 1;
            this.btnDelTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelTable.FillColor = System.Drawing.Color.White;
            this.btnDelTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnDelTable.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTable.Image")));
            this.btnDelTable.Location = new System.Drawing.Point(1263, 23);
            this.btnDelTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelTable.Name = "btnDelTable";
            this.btnDelTable.Size = new System.Drawing.Size(59, 54);
            this.btnDelTable.TabIndex = 13;
            this.btnDelTable.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStaff.Animated = true;
            this.btnAddStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnAddStaff.BorderRadius = 8;
            this.btnAddStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStaff.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnAddStaff.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnAddStaff.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnAddStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStaff.Image")));
            this.btnAddStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddStaff.Location = new System.Drawing.Point(772, 23);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(191, 54);
            this.btnAddStaff.TabIndex = 12;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.UseTransparentBackground = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Animated = true;
            this.txtUserName.BorderColor = System.Drawing.Color.DimGray;
            this.txtUserName.BorderRadius = 8;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUserName.IconLeft")));
            this.txtUserName.Location = new System.Drawing.Point(379, 23);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtUserName.PlaceholderText = "Nhập tên tài khoản mới";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(384, 54);
            this.txtUserName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.dtgvListAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 730);
            this.panel1.TabIndex = 1;
            // 
            // dtgvListAccount
            // 
            this.dtgvListAccount.AllowUserToAddRows = false;
            this.dtgvListAccount.AllowUserToDeleteRows = false;
            this.dtgvListAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvListAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvListAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvListAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.dtgvListAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvListAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvListAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListAccount.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListAccount.EnableHeadersVisualStyles = false;
            this.dtgvListAccount.Location = new System.Drawing.Point(15, 0);
            this.dtgvListAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvListAccount.Name = "dtgvListAccount";
            this.dtgvListAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvListAccount.RowHeadersWidth = 51;
            this.dtgvListAccount.RowTemplate.Height = 50;
            this.dtgvListAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListAccount.Size = new System.Drawing.Size(1308, 726);
            this.dtgvListAccount.TabIndex = 11;
            this.dtgvListAccount.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgvListAccount_CellBeginEdit);
            this.dtgvListAccount.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvListAccount_CellMouseDoubleClick);
            this.dtgvListAccount.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListAccount_CellValueChanged);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1337, 833);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormNhanVien";
            this.Text = "Nhân viên";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvListAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddStaff;
        private Guna.UI2.WinForms.Guna2GradientButton btnResetPassword;
        private Guna.UI2.WinForms.Guna2Button btnDelTable;
        private System.Windows.Forms.Label lblEmployeeName;
    }
}