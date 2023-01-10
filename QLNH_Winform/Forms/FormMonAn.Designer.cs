namespace QLNH_Winform.Forms
{
    partial class FormMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonAn));
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnEditCategory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txbSearchFood = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddFood = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvFood
            // 
            this.dtgvFood.AllowUserToAddRows = false;
            this.dtgvFood.AllowUserToDeleteRows = false;
            this.dtgvFood.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvFood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.BackgroundColor = System.Drawing.Color.White;
            this.dtgvFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvFood.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvFood.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFood.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvFood.EnableHeadersVisualStyles = false;
            this.dtgvFood.Location = new System.Drawing.Point(15, 142);
            this.dtgvFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFood.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 50;
            this.dtgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvFood.Size = new System.Drawing.Size(1424, 428);
            this.dtgvFood.TabIndex = 1;
            this.dtgvFood.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvFood_CellFormatting);
            this.dtgvFood.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFood_CellValueChanged);
            this.dtgvFood.SelectionChanged += new System.EventHandler(this.dtgvFood_SelectionChanged);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.guna2GradientPanel2.Controls.Add(this.btnEditCategory);
            this.guna2GradientPanel2.Controls.Add(this.txbSearchFood);
            this.guna2GradientPanel2.Controls.Add(this.dtgvFood);
            this.guna2GradientPanel2.Controls.Add(this.btnDelFood);
            this.guna2GradientPanel2.Controls.Add(this.btnAddFood);
            this.guna2GradientPanel2.Controls.Add(this.guna2Panel1);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1455, 583);
            this.guna2GradientPanel2.TabIndex = 9;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCategory.Animated = true;
            this.btnEditCategory.BackColor = System.Drawing.Color.White;
            this.btnEditCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnEditCategory.BorderRadius = 8;
            this.btnEditCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditCategory.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnEditCategory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnEditCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditCategory.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnEditCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCategory.Image")));
            this.btnEditCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEditCategory.Location = new System.Drawing.Point(1131, 15);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(287, 54);
            this.btnEditCategory.TabIndex = 16;
            this.btnEditCategory.Text = "Sửa loại";
            // 
            // txbSearchFood
            // 
            this.txbSearchFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchFood.Animated = true;
            this.txbSearchFood.BackColor = System.Drawing.Color.Transparent;
            this.txbSearchFood.BorderColor = System.Drawing.Color.DimGray;
            this.txbSearchFood.BorderRadius = 8;
            this.txbSearchFood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearchFood.DefaultText = "";
            this.txbSearchFood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearchFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearchFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchFood.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearchFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchFood.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchFood.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearchFood.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbSearchFood.IconLeft")));
            this.txbSearchFood.Location = new System.Drawing.Point(495, 79);
            this.txbSearchFood.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txbSearchFood.Name = "txbSearchFood";
            this.txbSearchFood.PasswordChar = '\0';
            this.txbSearchFood.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbSearchFood.PlaceholderText = "Tìm kiếm";
            this.txbSearchFood.SelectedText = "";
            this.txbSearchFood.Size = new System.Drawing.Size(625, 54);
            this.txbSearchFood.TabIndex = 14;
            this.txbSearchFood.TextChanged += new System.EventHandler(this.txbSearchFood_TextChanged);
            // 
            // btnDelFood
            // 
            this.btnDelFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelFood.Animated = true;
            this.btnDelFood.BackColor = System.Drawing.Color.Transparent;
            this.btnDelFood.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelFood.BorderRadius = 8;
            this.btnDelFood.BorderThickness = 1;
            this.btnDelFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelFood.FillColor = System.Drawing.Color.White;
            this.btnDelFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnDelFood.Image = ((System.Drawing.Image)(resources.GetObject("btnDelFood.Image")));
            this.btnDelFood.Location = new System.Drawing.Point(1359, 79);
            this.btnDelFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelFood.Name = "btnDelFood";
            this.btnDelFood.Size = new System.Drawing.Size(59, 54);
            this.btnDelFood.TabIndex = 13;
            this.btnDelFood.Click += new System.EventHandler(this.btnDelFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFood.Animated = true;
            this.btnAddFood.BackColor = System.Drawing.Color.White;
            this.btnAddFood.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btnAddFood.BorderRadius = 8;
            this.btnAddFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFood.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFood.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnAddFood.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnAddFood.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnAddFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFood.Image")));
            this.btnAddFood.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddFood.Location = new System.Drawing.Point(1131, 79);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(220, 54);
            this.btnAddFood.TabIndex = 12;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.BorderRadius = 9;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.cbFoodCategory);
            this.guna2Panel1.Location = new System.Drawing.Point(783, 22);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(337, 40);
            this.guna2Panel1.TabIndex = 18;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.AllowDrop = true;
            this.cbFoodCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFoodCategory.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(1, 1);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(335, 38);
            this.cbFoodCategory.TabIndex = 17;
            this.cbFoodCategory.SelectionChangeCommitted += new System.EventHandler(this.cbFoodCategory_SelectionChangeCommitted);
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.Size = new System.Drawing.Size(1455, 583);
            this.guna2GradientPanel3.TabIndex = 10;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Sửa danh mục";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.cbFoodCategory;
            // 
            // FormMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1455, 583);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMonAn";
            this.Text = "Món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvFood;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddFood;
        private Guna.UI2.WinForms.Guna2Button btnDelFood;
        private Guna.UI2.WinForms.Guna2TextBox txbSearchFood;
        internal Guna.UI2.WinForms.Guna2GradientButton btnEditCategory;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}