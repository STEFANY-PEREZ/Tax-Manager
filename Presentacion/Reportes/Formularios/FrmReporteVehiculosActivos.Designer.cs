namespace Presentacion.Reportes.Formularios
{
    partial class FrmReporteVehiculosActivos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetMaestro = new Presentacion.Reportes.DataSet.DataSetMaestro();
            this.dataTableVehiculosActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableVehiculosActivosTableAdapter = new Presentacion.Reportes.DataSet.DataSetMaestroTableAdapters.DataTableVehiculosActivosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVehiculosActivosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableVehiculosActivosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Informe.InformeVehiculosActivos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(684, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetMaestro
            // 
            this.dataSetMaestro.DataSetName = "DataSetMaestro";
            this.dataSetMaestro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableVehiculosActivosBindingSource
            // 
            this.dataTableVehiculosActivosBindingSource.DataMember = "DataTableVehiculosActivos";
            this.dataTableVehiculosActivosBindingSource.DataSource = this.dataSetMaestro;
            // 
            // dataTableVehiculosActivosTableAdapter
            // 
            this.dataTableVehiculosActivosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteVehiculosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "FrmReporteVehiculosActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de vehiculos activos";
            this.Load += new System.EventHandler(this.FrmReporteVehiculosActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVehiculosActivosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet.DataSetMaestro dataSetMaestro;
        private System.Windows.Forms.BindingSource dataTableVehiculosActivosBindingSource;
        private DataSet.DataSetMaestroTableAdapters.DataTableVehiculosActivosTableAdapter dataTableVehiculosActivosTableAdapter;
    }
}