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
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.btnDelFood = new System.Windows.Forms.Button();
            this.txbSearchFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(12, 12);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(97, 49);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // dtgvFood
            // 
            this.dtgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(12, 67);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(840, 411);
            this.dtgvFood.TabIndex = 1;
            this.dtgvFood.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvFood_CellFormatting);
            this.dtgvFood.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFood_CellValueChanged);
            this.dtgvFood.SelectionChanged += new System.EventHandler(this.dtgvFood_SelectionChanged);
            // 
            // btnDelFood
            // 
            this.btnDelFood.Location = new System.Drawing.Point(115, 12);
            this.btnDelFood.Name = "btnDelFood";
            this.btnDelFood.Size = new System.Drawing.Size(89, 49);
            this.btnDelFood.TabIndex = 2;
            this.btnDelFood.Text = "Xóa";
            this.btnDelFood.UseVisualStyleBackColor = true;
            this.btnDelFood.Click += new System.EventHandler(this.btnDelFood_Click);
            // 
            // txbSearchFood
            // 
            this.txbSearchFood.Location = new System.Drawing.Point(605, 25);
            this.txbSearchFood.Name = "txbSearchFood";
            this.txbSearchFood.Size = new System.Drawing.Size(247, 22);
            this.txbSearchFood.TabIndex = 3;
            this.txbSearchFood.TextChanged += new System.EventHandler(this.txbSearchFood_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(340, 23);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(180, 24);
            this.cbFoodCategory.TabIndex = 5;
            this.cbFoodCategory.SelectionChangeCommitted += new System.EventHandler(this.cbFoodCategory_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sửa danh mục";
            // 
            // FormMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFoodCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSearchFood);
            this.Controls.Add(this.btnDelFood);
            this.Controls.Add(this.dtgvFood);
            this.Controls.Add(this.btnAddFood);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMonAn";
            this.Text = "Món ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Button btnDelFood;
        private System.Windows.Forms.TextBox txbSearchFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label2;
    }
}