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
            this.pnDish = new System.Windows.Forms.Panel();
            this.lblDishName = new System.Windows.Forms.Label();
            this.picDish = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.ellipseControl1 = new QLNH_Winform.EllipseControl();
            this.pnDish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDish)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDish
            // 
            this.pnDish.BackColor = System.Drawing.SystemColors.Window;
            this.pnDish.Controls.Add(this.btnAddDish);
            this.pnDish.Controls.Add(this.picDish);
            this.pnDish.Controls.Add(this.lblPrice);
            this.pnDish.Controls.Add(this.lblDishName);
            this.pnDish.Location = new System.Drawing.Point(53, 104);
            this.pnDish.Name = "pnDish";
            this.pnDish.Size = new System.Drawing.Size(274, 374);
            this.pnDish.TabIndex = 0;
            // 
            // lblDishName
            // 
            this.lblDishName.AutoSize = true;
            this.lblDishName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDishName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.lblDishName.Location = new System.Drawing.Point(3, 15);
            this.lblDishName.Name = "lblDishName";
            this.lblDishName.Size = new System.Drawing.Size(156, 34);
            this.lblDishName.TabIndex = 0;
            this.lblDishName.Text = "Gà xối mỡ";
            // 
            // picDish
            // 
            this.picDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.picDish.Location = new System.Drawing.Point(3, 64);
            this.picDish.Name = "picDish";
            this.picDish.Size = new System.Drawing.Size(268, 166);
            this.picDish.TabIndex = 1;
            this.picDish.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.lblPrice.Location = new System.Drawing.Point(29, 309);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 39);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "3$";
            // 
            // btnAddDish
            // 
            this.btnAddDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(216)))));
            this.btnAddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDish.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDish.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddDish.Location = new System.Drawing.Point(108, 309);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(151, 46);
            this.btnAddDish.TabIndex = 2;
            this.btnAddDish.Text = "Thêm";
            this.btnAddDish.UseVisualStyleBackColor = false;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 30;
            this.ellipseControl1.TargetControl = this.pnDish;
            // 
            // FormMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(972, 613);
            this.Controls.Add(this.pnDish);
            this.Name = "FormMonAn";
            this.Text = "Món ăn";
            this.pnDish.ResumeLayout(false);
            this.pnDish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDish;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.PictureBox picDish;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDishName;
        private EllipseControl ellipseControl1;
    }
}