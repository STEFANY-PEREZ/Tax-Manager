using System;
using System.Windows.Forms;

namespace Presentacion.Reportes.Formularios
{
    public partial class FrmReporteUsuariosActivos : Form
    {
        public FrmReporteUsuariosActivos()
        {
            InitializeComponent();
        }

        private void FrmReporteUsuariosActivos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetMaestro.DataTableUsuariosActivos' Puede moverla o quitarla según sea necesario.
            this.dataTableUsuariosActivosTableAdapter.Fill(this.dataSetMaestro.DataTableUsuariosActivos);

            this.reportViewer.RefreshReport();
        }
    }
}
