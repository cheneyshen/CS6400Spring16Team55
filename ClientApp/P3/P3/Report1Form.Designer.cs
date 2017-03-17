namespace P3
{
    partial class Report1Form
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
            this.report1_procBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.team55_dbDataSet = new P3.team55_dbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.report1_procTableAdapter = new P3.team55_dbDataSetTableAdapters.report1_procTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.report1_procBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team55_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // report1_procBindingSource
            // 
            this.report1_procBindingSource.DataMember = "report1_proc";
            this.report1_procBindingSource.DataSource = this.team55_dbDataSet;
            // 
            // team55_dbDataSet
            // 
            this.team55_dbDataSet.DataSetName = "team55_dbDataSet";
            this.team55_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.report1_procBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "P3.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(689, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // report1_procTableAdapter
            // 
            this.report1_procTableAdapter.ClearBeforeFill = true;
            // 
            // Report1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 473);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report1Form";
            this.Text = "Item Inventory";
            this.Load += new System.EventHandler(this.Report1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report1_procBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team55_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource report1_procBindingSource;
        private team55_dbDataSet team55_dbDataSet;
        private team55_dbDataSetTableAdapters.report1_procTableAdapter report1_procTableAdapter;
    }
}