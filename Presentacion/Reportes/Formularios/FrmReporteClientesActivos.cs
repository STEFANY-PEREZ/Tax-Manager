using System.Windows.Forms;

namespace Presentacion.Reportes.Formularios
{
    public partial class FrmReporteClientesActivos : Form
    {
        public FrmReporteClientesActivos()
        {
            InitializeComponent();
        }

        private void FrmReporteClientesActivos_Load(object sender, System.EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetMaestro.DataTableClientesActivos' Puede moverla o quitarla según sea necesario.
            this.dataTableClientesActivosTableAdapter.Fill(this.dataSetMaestro.DataTableClientesActivos);

            this.reportViewer.RefreshReport();
        }
    }
}
