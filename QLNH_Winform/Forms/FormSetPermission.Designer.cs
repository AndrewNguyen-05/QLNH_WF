namespace QLNH_Winform.Forms
{
    partial class FormSetPermission
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dtgvAccPermission = new System.Windows.Forms.DataGridView();
            this.ControlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnNotSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.PermName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Read = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangePermission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeOwner = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // dtgvAccPermission
            // 
            this.dtgvAccPermission.AllowUserToAddRows = false;
            this.dtgvAccPermission.AllowUserToDeleteRows = false;
            this.dtgvAccPermission.AllowUserToResizeColumns = false;
            this.dtgvAccPermission.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvAccPermission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAccPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAccPermission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccPermission.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.dtgvAccPermission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvAccPermission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvAccPermission.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccPermission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvAccPermission.ColumnHeadersHeight = 40;
            this.dtgvAccPermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PermName,
            this.Read,
            this.Modify,
            this.ChangePermission});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccPermission.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvAccPermission.EnableHeadersVisualStyles = false;
            this.dtgvAccPermission.Location = new System.Drawing.Point(12, 50);
            this.dtgvAccPermission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvAccPermission.MultiSelect = false;
            this.dtgvAccPermission.Name = "dtgvAccPermission";
            this.dtgvAccPermission.ReadOnly = true;
            this.dtgvAccPermission.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccPermission.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvAccPermission.RowHeadersVisible = false;
            this.dtgvAccPermission.RowHeadersWidth = 51;
            this.dtgvAccPermission.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvAccPermission.RowTemplate.Height = 40;
            this.dtgvAccPermission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAccPermission.Size = new System.Drawing.Size(967, 416);
            this.dtgvAccPermission.TabIndex = 17;
            this.dtgvAccPermission.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvAccPermission_CellMouseUp);
            this.dtgvAccPermission.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgvAccPermission_CellPainting);
            // 
            // ControlClose
            // 
            this.ControlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlClose.Animated = true;
            this.ControlClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlClose.ForeColor = System.Drawing.Color.Black;
            this.ControlClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.ControlClose.Location = new System.Drawing.Point(934, 3);
            this.ControlClose.Name = "ControlClose";
            this.ControlClose.Size = new System.Drawing.Size(45, 40);
            this.ControlClose.TabIndex = 19;
            this.ControlClose.Click += new System.EventHandler(this.ControlClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderRadius = 8;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnSave.Location = new System.Drawing.Point(623, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 52);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNotSave
            // 
            this.btnNotSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotSave.Animated = true;
            this.btnNotSave.BackColor = System.Drawing.Color.Transparent;
            this.btnNotSave.BorderColor = System.Drawing.Color.White;
            this.btnNotSave.BorderRadius = 8;
            this.btnNotSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNotSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNotSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNotSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnNotSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnNotSave.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNotSave.ForeColor = System.Drawing.Color.White;
            this.btnNotSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnNotSave.Location = new System.Drawing.Point(804, 473);
            this.btnNotSave.Name = "btnNotSave";
            this.btnNotSave.Size = new System.Drawing.Size(175, 52);
            this.btnNotSave.TabIndex = 21;
            this.btnNotSave.Text = "Thoát";
            this.btnNotSave.Click += new System.EventHandler(this.btnNotSave_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmployeeName.Location = new System.Drawing.Point(8, 473);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(317, 46);
            this.lblEmployeeName.TabIndex = 22;
            this.lblEmployeeName.Text = "*Bấm vào quyền để chọn tất cả.\r\n Bấm vào tên quyền để chọn cả hàng\r\n";
            // 
            // PermName
            // 
            this.PermName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PermName.HeaderText = "Quyền";
            this.PermName.MinimumWidth = 6;
            this.PermName.Name = "PermName";
            this.PermName.ReadOnly = true;
            this.PermName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Read
            // 
            this.Read.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Read.HeaderText = "Xem";
            this.Read.MinimumWidth = 6;
            this.Read.Name = "Read";
            this.Read.ReadOnly = true;
            this.Read.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Read.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Modify
            // 
            this.Modify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modify.HeaderText = "Sửa";
            this.Modify.MinimumWidth = 6;
            this.Modify.Name = "Modify";
            this.Modify.ReadOnly = true;
            this.Modify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ChangePermission
            // 
            this.ChangePermission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChangePermission.HeaderText = "Chỉnh quyền";
            this.ChangePermission.MinimumWidth = 6;
            this.ChangePermission.Name = "ChangePermission";
            this.ChangePermission.ReadOnly = true;
            this.ChangePermission.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChangePermission.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ChangeOwner
            // 
            this.ChangeOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeOwner.Animated = true;
            this.ChangeOwner.BackColor = System.Drawing.Color.Transparent;
            this.ChangeOwner.BorderColor = System.Drawing.Color.White;
            this.ChangeOwner.BorderRadius = 8;
            this.ChangeOwner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChangeOwner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChangeOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChangeOwner.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChangeOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChangeOwner.FillColor = System.Drawing.Color.Red;
            this.ChangeOwner.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.ChangeOwner.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChangeOwner.ForeColor = System.Drawing.Color.White;
            this.ChangeOwner.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.ChangeOwner.Location = new System.Drawing.Point(12, 3);
            this.ChangeOwner.Name = "ChangeOwner";
            this.ChangeOwner.Size = new System.Drawing.Size(153, 43);
            this.ChangeOwner.TabIndex = 23;
            this.ChangeOwner.Text = "Chuyển chủ";
            this.ChangeOwner.Visible = false;
            // 
            // FormSetPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 537);
            this.Controls.Add(this.ChangeOwner);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.btnNotSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ControlClose);
            this.Controls.Add(this.dtgvAccPermission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetPermission";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccPermission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.DataGridView dtgvAccPermission;
        private Guna.UI2.WinForms.Guna2ControlBox ControlClose;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnNotSave;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSave;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Read;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangePermission;
        private Guna.UI2.WinForms.Guna2GradientTileButton ChangeOwner;
    }
}