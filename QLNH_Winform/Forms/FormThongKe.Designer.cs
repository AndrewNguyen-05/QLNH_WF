namespace QLNH_Winform.Forms
{
    partial class FormThongKe
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVND = new System.Windows.Forms.Label();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblStaticAs = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbDateSelection = new System.Windows.Forms.ComboBox();
            this.btnViewBill = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2GradientPanel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTotalMoney);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTotal);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblVND);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2GradientPanel3);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtgvBill);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Empty;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1163, 600);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMoney.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.lblTotalMoney.Location = new System.Drawing.Point(972, 545);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(117, 38);
            this.lblTotalMoney.TabIndex = 9;
            this.lblTotalMoney.Text = "0";
            this.lblTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.lblTotal.Location = new System.Drawing.Point(710, 541);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(229, 49);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Tổng doanh thu:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVND
            // 
            this.lblVND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVND.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.lblVND.Location = new System.Drawing.Point(1079, 548);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(62, 38);
            this.lblVND.TabIndex = 10;
            this.lblVND.Text = "VND";
            this.lblVND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.guna2GradientPanel3.Controls.Add(this.lblStaticAs);
            this.guna2GradientPanel3.Controls.Add(this.guna2Panel1);
            this.guna2GradientPanel3.Controls.Add(this.btnViewBill);
            this.guna2GradientPanel3.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel3.Controls.Add(this.guna2GradientPanel1);
            this.guna2GradientPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.Size = new System.Drawing.Size(1163, 98);
            this.guna2GradientPanel3.TabIndex = 7;
            // 
            // lblStaticAs
            // 
            this.lblStaticAs.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaticAs.Location = new System.Drawing.Point(44, 0);
            this.lblStaticAs.Name = "lblStaticAs";
            this.lblStaticAs.Size = new System.Drawing.Size(179, 49);
            this.lblStaticAs.TabIndex = 20;
            this.lblStaticAs.Text = "Thống kê theo:";
            this.lblStaticAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 9;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.cbDateSelection);
            this.guna2Panel1.Location = new System.Drawing.Point(47, 51);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(337, 40);
            this.guna2Panel1.TabIndex = 19;
            // 
            // cbDateSelection
            // 
            this.cbDateSelection.AllowDrop = true;
            this.cbDateSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDateSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDateSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDateSelection.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDateSelection.FormattingEnabled = true;
            this.cbDateSelection.Items.AddRange(new object[] {
            "Ngày",
            "Tuần",
            "Tháng",
            "Năm",
            "Tùy Chọn"});
            this.cbDateSelection.Location = new System.Drawing.Point(1, 1);
            this.cbDateSelection.Name = "cbDateSelection";
            this.cbDateSelection.Size = new System.Drawing.Size(335, 38);
            this.cbDateSelection.TabIndex = 17;
            this.cbDateSelection.SelectedIndexChanged += new System.EventHandler(this.cbDateSelection_SelectedIndexChanged);
            // 
            // btnViewBill
            // 
            this.btnViewBill.Animated = true;
            this.btnViewBill.BackColor = System.Drawing.Color.Transparent;
            this.btnViewBill.BorderColor = System.Drawing.Color.White;
            this.btnViewBill.BorderRadius = 8;
            this.btnViewBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewBill.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnViewBill.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnViewBill.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnViewBill.ForeColor = System.Drawing.Color.White;
            this.btnViewBill.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnViewBill.Location = new System.Drawing.Point(892, 17);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(239, 62);
            this.btnViewBill.TabIndex = 6;
            this.btnViewBill.Text = "Xem thống kê";
            this.btnViewBill.Visible = false;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.AutoRoundedCorners = true;
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel2.BorderRadius = 13;
            this.guna2GradientPanel2.BorderThickness = 1;
            this.guna2GradientPanel2.Controls.Add(this.label2);
            this.guna2GradientPanel2.Controls.Add(this.dtpkToDate);
            this.guna2GradientPanel2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(431, 51);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(442, 28);
            this.guna2GradientPanel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.AutoRoundedCorners = true;
            this.dtpkToDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpkToDate.BorderRadius = 13;
            this.dtpkToDate.BorderThickness = 1;
            this.dtpkToDate.Checked = true;
            this.dtpkToDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.dtpkToDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpkToDate.ForeColor = System.Drawing.Color.White;
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkToDate.Location = new System.Drawing.Point(97, 0);
            this.dtpkToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(345, 28);
            this.dtpkToDate.TabIndex = 1;
            this.dtpkToDate.UseTransparentBackground = true;
            this.dtpkToDate.Value = new System.DateTime(2022, 12, 17, 16, 7, 29, 372);
            this.dtpkToDate.ValueChanged += new System.EventHandler(this.dtpk_ValueChanged);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.AutoRoundedCorners = true;
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.BorderRadius = 13;
            this.guna2GradientPanel1.BorderThickness = 1;
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.dtpkFromDate);
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(431, 17);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(442, 28);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.AutoRoundedCorners = true;
            this.dtpkFromDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpkFromDate.BorderRadius = 13;
            this.dtpkFromDate.BorderThickness = 1;
            this.dtpkFromDate.Checked = true;
            this.dtpkFromDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.dtpkFromDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpkFromDate.ForeColor = System.Drawing.Color.White;
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkFromDate.Location = new System.Drawing.Point(97, 0);
            this.dtpkFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(345, 28);
            this.dtpkFromDate.TabIndex = 0;
            this.dtpkFromDate.UseTransparentBackground = true;
            this.dtpkFromDate.Value = new System.DateTime(2022, 12, 17, 16, 7, 29, 372);
            this.dtpkFromDate.ValueChanged += new System.EventHandler(this.dtpk_ValueChanged);
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AllowUserToDeleteRows = false;
            this.dtgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.dtgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBill.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBill.EnableHeadersVisualStyles = false;
            this.dtgvBill.Location = new System.Drawing.Point(12, 103);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvBill.RowHeadersWidth = 62;
            this.dtgvBill.RowTemplate.Height = 50;
            this.dtgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBill.Size = new System.Drawing.Size(1139, 411);
            this.dtgvBill.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.cbDateSelection;
            // 
            // FormThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1163, 600);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThongKe";
            this.Text = "Thống kê";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkToDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkFromDate;
        private System.Windows.Forms.DataGridView dtgvBill;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnViewBill;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ComboBox cbDateSelection;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblStaticAs;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVND;
    }
}