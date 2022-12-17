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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dtpkToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpkFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.btnViewBill = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnViewBill);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtgvBill);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtpkToDate);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtpkFromDate);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1143, 636);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Checked = true;
            this.dtpkToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkToDate.Location = new System.Drawing.Point(827, 17);
            this.dtpkToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(302, 36);
            this.dtpkToDate.TabIndex = 0;
            this.dtpkToDate.Value = new System.DateTime(2022, 12, 17, 16, 7, 29, 372);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Checked = true;
            this.dtpkFromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkFromDate.Location = new System.Drawing.Point(18, 17);
            this.dtpkFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(302, 36);
            this.dtpkFromDate.TabIndex = 0;
            this.dtpkFromDate.Value = new System.DateTime(2022, 12, 17, 16, 7, 29, 372);
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(18, 150);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 62;
            this.dtgvBill.RowTemplate.Height = 28;
            this.dtgvBill.Size = new System.Drawing.Size(1111, 483);
            this.dtgvBill.TabIndex = 2;
            // 
            // btnViewBill
            // 
            this.btnViewBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewBill.ForeColor = System.Drawing.Color.White;
            this.btnViewBill.Location = new System.Drawing.Point(457, 43);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(180, 45);
            this.btnViewBill.TabIndex = 3;
            this.btnViewBill.Text = "Xem thống kê";
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 660);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThongKe";
            this.Text = "Thống kê";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkToDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkFromDate;
        private System.Windows.Forms.DataGridView dtgvBill;
        private Guna.UI2.WinForms.Guna2Button btnViewBill;
    }
}