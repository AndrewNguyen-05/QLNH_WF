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
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnDelTable = new System.Windows.Forms.Button();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.txbSearchTable = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(12, 12);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 53);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnDelTable
            // 
            this.btnDelTable.Location = new System.Drawing.Point(94, 13);
            this.btnDelTable.Name = "btnDelTable";
            this.btnDelTable.Size = new System.Drawing.Size(78, 52);
            this.btnDelTable.TabIndex = 1;
            this.btnDelTable.Text = "Xóa";
            this.btnDelTable.UseVisualStyleBackColor = true;
            this.btnDelTable.Click += new System.EventHandler(this.btnDelTable_Click);
            // 
            // dtgvTable
            // 
            this.dtgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(12, 72);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(687, 276);
            this.dtgvTable.TabIndex = 2;
            this.dtgvTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvTable_CellFormatting);
            this.dtgvTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTable_CellValueChanged);
            // 
            // txbSearchTable
            // 
            this.txbSearchTable.Location = new System.Drawing.Point(361, 43);
            this.txbSearchTable.Name = "txbSearchTable";
            this.txbSearchTable.Size = new System.Drawing.Size(267, 22);
            this.txbSearchTable.TabIndex = 3;
            this.txbSearchTable.TextChanged += new System.EventHandler(this.txbSearchTable_TextChanged);
            // 
            // FormBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.txbSearchTable);
            this.Controls.Add(this.dtgvTable);
            this.Controls.Add(this.btnDelTable);
            this.Controls.Add(this.btnAddTable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBanAn";
            this.Text = "Bàn ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnDelTable;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.TextBox txbSearchTable;
    }
}