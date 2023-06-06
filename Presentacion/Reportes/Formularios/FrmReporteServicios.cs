using System;
using System.Windows.Forms;

namespace Presentacion.Reportes.Formularios
{
    public partial class FrmReporteServicios : Form
    {
        public FrmReporteServicios()
        {
            InitializeComponent();
        }

        private void FrmReporteServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetMaestro.Servicios' Puede moverla o quitarla según sea necesario.
            this.serviciosTableAdapter.Fill(this.dataSetMaestro.Servicios);

            this.reportViewer.RefreshReport();
        }
    }
}
