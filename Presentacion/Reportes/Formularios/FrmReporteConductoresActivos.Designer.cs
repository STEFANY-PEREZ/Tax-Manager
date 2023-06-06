namespace Presentacion.Reportes.Formularios
{
    partial class FrmReporteConductoresActivos
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
            this.dataTableConductoresActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMaestro = new Presentacion.Reportes.DataSet.DataSetMaestro();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableConductoresActivosTableAdapter = new Presentacion.Reportes.DataSet.DataSetMaestroTableAdapters.DataTableConductoresActivosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableConductoresActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableConductoresActivosBindingSource
            // 
            this.dataTableConductoresActivosBindingSource.DataMember = "DataTableConductoresActivos";
            this.dataTableConductoresActivosBindingSource.DataSource = this.dataSetMaestro;
            // 
            // dataSetMaestro
            // 
            this.dataSetMaestro.DataSetName = "DataSetMaestro";
            this.dataSetMaestro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableConductoresActivosBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Informe.InformeConductoresActivos.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(684, 561);
            this.reportViewer.TabIndex = 0;
            // 
            // dataTableConductoresActivosTableAdapter
            // 
            this.dataTableConductoresActivosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteConductoresActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.reportViewer);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "FrmReporteConductoresActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de conductores activos";
            this.Load += new System.EventHandler(this.FrmReporteConductoresActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableConductoresActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private DataSet.DataSetMaestro dataSetMaestro;
        private System.Windows.Forms.BindingSource dataTableConductoresActivosBindingSource;
        private DataSet.DataSetMaestroTableAdapters.DataTableConductoresActivosTableAdapter dataTableConductoresActivosTableAdapter;
    }
}