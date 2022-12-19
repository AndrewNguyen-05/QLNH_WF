namespace QLNH_Winform.Forms
{
    partial class FormBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanAn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbSearchTable = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelTable = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.btnAddTable = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSearchTable
            // 
            this.txbSearchTable.Animated = true;
            this.txbSearchTable.AutoRoundedCorners = true;
            this.txbSearchTable.BackColor = System.Drawing.Color.Transparent;
            this.txbSearchTable.BorderColor = System.Drawing.Color.DimGray;
            this.txbSearchTable.BorderRadius = 33;
            this.txbSearchTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearchTable.DefaultText = "";
            this.txbSearchTable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearchTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearchTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchTable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchTable.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchTable.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchTable.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbSearchTable.IconLeft")));
            this.txbSearchTable.Location = new System.Drawing.Point(15, 27);
            this.txbSearchTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbSearchTable.Name = "txbSearchTable";
            this.txbSearchTable.PasswordChar = '\0';
            this.txbSearchTable.PlaceholderText = "Tìm kiếm";
            this.txbSearchTable.SelectedText = "";
            this.txbSearchTable.Size = new System.Drawing.Size(714, 68);
            this.txbSearchTable.TabIndex = 4;
            this.txbSearchTable.TextChanged += new System.EventHandler(this.txbSearchTable_TextChanged);
            // 
            // btnDelTable
            // 
            this.btnDelTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelTable.Animated = true;
            this.btnDelTable.AutoRoundedCorners = true;
            this.btnDelTable.BackColor = System.Drawing.Color.Transparent;
            this.btnDelTable.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelTable.BorderRadius = 33;
            this.btnDelTable.BorderThickness = 1;
            this.btnDelTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelTable.FillColor = System.Drawing.Color.White;
            this.btnDelTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelTable.ForeColor = System.Drawing.Color.DimGray;
            this.btnDelTable.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTable.Image")));
            this.btnDelTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDelTable.Location = new System.Drawing.Point(538, 27);
            this.btnDelTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelTable.Name = "btnDelTable";
            this.btnDelTable.Size = new System.Drawing.Size(214, 68);
            this.btnDelTable.TabIndex = 8;
            this.btnDelTable.Text = "Xóa";
            this.btnDelTable.Click += new System.EventHandler(this.btnDelTable_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.dtgvTable);
            this.guna2GradientPanel1.Controls.Add(this.btnAddTable);
            this.guna2GradientPanel1.Controls.Add(this.btnDelTable);
            this.guna2GradientPanel1.Controls.Add(this.txbSearchTable);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(146)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(108)))), ((int)(((byte)(143)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(800, 449);
            this.guna2GradientPanel1.TabIndex = 9;
            // 
            // dtgvTable
            // 
            this.dtgvTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.dtgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTable.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTable.EnableHeadersVisualStyles = false;
            this.dtgvTable.Location = new System.Drawing.Point(0, 106);
            this.dtgvTable.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTable.Size = new System.Drawing.Size(800, 343);
            this.dtgvTable.TabIndex = 10;
            this.dtgvTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvTable_CellFormatting);
            this.dtgvTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTable_CellValueChanged);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTable.Animated = true;
            this.btnAddTable.AutoRoundedCorners = true;
            this.btnAddTable.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTable.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddTable.BorderRadius = 33;
            this.btnAddTable.BorderThickness = 1;
            this.btnAddTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTable.FillColor = System.Drawing.Color.White;
            this.btnAddTable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddTable.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddTable.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTable.Image")));
            this.btnAddTable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddTable.Location = new System.Drawing.Point(316, 27);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(214, 68);
            this.btnAddTable.TabIndex = 9;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // FormBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBanAn";
            this.Text = "Bàn ăn";
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txbSearchTable;
        private Guna.UI2.WinForms.Guna2Button btnDelTable;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnAddTable;
        private System.Windows.Forms.DataGridView dtgvTable;
    }
}