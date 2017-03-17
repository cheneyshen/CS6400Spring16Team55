namespace P3
{
    partial class Report2Form
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
            this.report2_procBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.team55_dbDataSet = new P3.team55_dbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.report2_procTableAdapter = new P3.team55_dbDataSetTableAdapters.report2_procTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.report2_procBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team55_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // report2_procBindingSource
            // 
            this.report2_procBindingSource.DataMember = "report2_proc";
            this.report2_procBindingSource.DataSource = this.team55_dbDataSet;
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
            reportDataSource1.Value = this.report2_procBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "P3.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(689, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // report2_procTableAdapter
            // 
            this.report2_procTableAdapter.ClearBeforeFill = true;
            // 
            // Report2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 473);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report2Form";
            this.Text = "Rental customers - last month";
            this.Load += new System.EventHandler(this.Report2Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report2_procBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team55_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private team55_dbDataSet team55_dbDataSet;
        private System.Windows.Forms.BindingSource report2_procBindingSource;
        private team55_dbDataSetTableAdapters.report2_procTableAdapter report2_procTableAdapter;
    }
}