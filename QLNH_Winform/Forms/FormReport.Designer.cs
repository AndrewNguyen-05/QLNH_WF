namespace QLNH_Winform.Forms
{
    partial class FormReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLNHDataSet = new QLNH_Winform.QLNHDataSet();
            this.uSPGetTableListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_GetTableListTableAdapter = new QLNH_Winform.QLNHDataSetTableAdapters.USP_GetTableListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetTableListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpViewer
            // 
            this.rpViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPGetTableListBindingSource;
            this.rpViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rpViewer.LocalReport.ReportEmbeddedResource = "QLNH_Winform.rptHoaDon.rdlc";
            this.rpViewer.Location = new System.Drawing.Point(0, 0);
            this.rpViewer.Name = "rpViewer";
            this.rpViewer.ServerReport.BearerToken = null;
            this.rpViewer.Size = new System.Drawing.Size(830, 456);
            this.rpViewer.TabIndex = 0;
            // 
            // qLNHDataSet
            // 
            this.qLNHDataSet.DataSetName = "QLNHDataSet";
            this.qLNHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPGetTableListBindingSource
            // 
            this.uSPGetTableListBindingSource.DataMember = "USP_GetTableList";
            this.uSPGetTableListBindingSource.DataSource = this.qLNHDataSet;
            // 
            // uSP_GetTableListTableAdapter
            // 
            this.uSP_GetTableListTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 456);
            this.Controls.Add(this.rpViewer);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetTableListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpViewer;
        private QLNHDataSet qLNHDataSet;
        private System.Windows.Forms.BindingSource uSPGetTableListBindingSource;
        private QLNHDataSetTableAdapters.USP_GetTableListTableAdapter uSP_GetTableListTableAdapter;
    }
}