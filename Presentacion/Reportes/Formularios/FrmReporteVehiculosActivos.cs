using System;
using System.Windows.Forms;

namespace Presentacion.Reportes.Formularios
{
    public partial class FrmReporteVehiculosActivos : Form
    {
        public FrmReporteVehiculosActivos()
        {
            InitializeComponent();
        }

        private void FrmReporteVehiculosActivos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetMaestro.DataTableVehiculosActivos' Puede moverla o quitarla según sea necesario.
            this.dataTableVehiculosActivosTableAdapter.Fill(this.dataSetMaestro.DataTableVehiculosActivos);

            this.reportViewer1.RefreshReport();
        }
    }
}
