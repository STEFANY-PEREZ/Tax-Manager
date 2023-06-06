namespace Presentacion.Reportes.Formularios
{
    partial class FrmReporteUsuariosActivos
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
            this.dataSetMaestro = new Presentacion.Reportes.DataSet.DataSetMaestro();
            this.dataTableUsuariosActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableUsuariosActivosTableAdapter = new Presentacion.Reportes.DataSet.DataSetMaestroTableAdapters.DataTableUsuariosActivosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableUsuariosActivosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableUsuariosActivosBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Presentacion.Reportes.Informe.InformeUsuariosActivos.rdlc";
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
            // dataTableUsuariosActivosBindingSource
            // 
            this.dataTableUsuariosActivosBindingSource.DataMember = "DataTableUsuariosActivos";
            this.dataTableUsuariosActivosBindingSource.DataSource = this.dataSetMaestro;
            // 
            // dataTableUsuariosActivosTableAdapter
            // 
            this.dataTableUsuariosActivosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteUsuariosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.reportViewer);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "FrmReporteUsuariosActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de usuarios activos";
            this.Load += new System.EventHandler(this.FrmReporteUsuariosActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableUsuariosActivosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private DataSet.DataSetMaestro dataSetMaestro;
        private System.Windows.Forms.BindingSource dataTableUsuariosActivosBindingSource;
        private DataSet.DataSetMaestroTableAdapters.DataTableUsuariosActivosTableAdapter dataTableUsuariosActivosTableAdapter;
    }
}