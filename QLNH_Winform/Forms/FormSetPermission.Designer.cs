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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dtgvAccPermission = new System.Windows.Forms.DataGridView();
            this.ControlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnNotSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.PermName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmployeeName = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvAccPermission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dtgvAccPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAccPermission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccPermission.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.dtgvAccPermission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvAccPermission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvAccPermission.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccPermission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dtgvAccPermission.ColumnHeadersHeight = 40;
            this.dtgvAccPermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PermName,
            this.Add,
            this.Delete,
            this.Modify});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccPermission.DefaultCellStyle = dataGridViewCellStyle31;
            this.dtgvAccPermission.EnableHeadersVisualStyles = false;
            this.dtgvAccPermission.Location = new System.Drawing.Point(12, 50);
            this.dtgvAccPermission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvAccPermission.MultiSelect = false;
            this.dtgvAccPermission.Name = "dtgvAccPermission";
            this.dtgvAccPermission.ReadOnly = true;
            this.dtgvAccPermission.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAccPermission.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
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
            // PermName
            // 
            this.PermName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PermName.HeaderText = "Quyền";
            this.PermName.MinimumWidth = 6;
            this.PermName.Name = "PermName";
            this.PermName.ReadOnly = true;
            this.PermName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Add.HeaderText = "Thêm";
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.HeaderText = "Xóa";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // FormSetPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 537);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PermName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modify;
        private System.Windows.Forms.Label lblEmployeeName;
    }
}