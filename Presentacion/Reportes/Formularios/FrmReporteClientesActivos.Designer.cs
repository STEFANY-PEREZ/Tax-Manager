namespace Presentacion.Reportes.Formularios
{
    partial class FrmReporteClientesActivos
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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetMaestroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMaestro = new Presentacion.Reportes.DataSet.DataSetMaestro();
            this.dataTableClientesActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableClientesActivosTableAdapter = new Presentacion.Reportes.DataSet.DataSetMaestroTableAdapters.DataTableClientesActivosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClientesActivosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableClientesActivosBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Informe.InformeClientesActivos.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(684, 561);
            this.reportViewer.TabIndex = 0;
            // 
            // dataSetMaestro
            // 
            this.dataSetMaestro.DataSetName = "DataSetMaestro";
            this.dataSetMaestro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableClientesActivosBindingSource
            // 
            this.dataTableClientesActivosBindingSource.DataMember = "DataTableClientesActivos";
            this.dataTableClientesActivosBindingSource.DataSource = this.dataSetMaestro;
            // 
            // dataTableClientesActivosTableAdapter
            // 
            this.dataTableClientesActivosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteClientesActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.reportViewer);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "FrmReporteClientesActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de clientes activos";
            this.Load += new System.EventHandler(this.FrmReporteClientesActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClientesActivosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource dataSetMaestroBindingSource;
        private DataSet.DataSetMaestro dataSetMaestro;
        private System.Windows.Forms.BindingSource dataTableClientesActivosBindingSource;
        private DataSet.DataSetMaestroTableAdapters.DataTableClientesActivosTableAdapter dataTableClientesActivosTableAdapter;
    }
}