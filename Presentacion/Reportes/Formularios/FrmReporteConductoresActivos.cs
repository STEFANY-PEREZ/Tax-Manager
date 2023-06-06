using System;
using System.Windows.Forms;

namespace Presentacion.Reportes.Formularios
{
    public partial class FrmReporteConductoresActivos : Form
    {
        public FrmReporteConductoresActivos()
        {
            InitializeComponent();
        }

        private void FrmReporteConductoresActivos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetMaestro.DataTableConductoresActivos' Puede moverla o quitarla según sea necesario.
            this.dataTableConductoresActivosTableAdapter.Fill(this.dataSetMaestro.DataTableConductoresActivos);

            this.reportViewer.RefreshReport();
        }
    }
}
