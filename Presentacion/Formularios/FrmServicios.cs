using Entidad;
using Logica.Servicios;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmServicios : Form
    {
        ServiciosServicio ServiciosServicio = new ServiciosServicio();
        Conductor conductorElegido = new Conductor();
        Cliente clienteElegido = new Cliente();
        Servicio Servicio = new Servicio();
        int id = 0;
        public FrmServicios()
        {
            InitializeComponent();
        }

        private void ConsultarConductor()
        {
            try
            {
                FrmListarConductores listarConductores = new FrmListarConductores();

                var result = listarConductores.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string Nombre = listarConductores.Conductor.Persona.Nombre.Trim();
                    string Apellido = listarConductores.Conductor.Persona.Apellido.Trim();

                    string nombreCompletoCliente = string.Join(" ", Nombre, Apellido).Trim();

                    conductorElegido.Id = listarConductores.Conductor.Id;
                    txtNombreCompletoConductor.Text = nombreCompletoCliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarCliente()
        {
            try
            {
                FrmListarClientes listarClientes = new FrmListarClientes();

                var result = listarClientes.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string Nombre = listarClientes.Cliente.Persona.Nombre.Trim();
                    string Apellido = listarClientes.Cliente.Persona.Apellido.Trim();

                    string nombreCompletoCliente = string.Join(" ", Nombre, Apellido).Trim();

                    clienteElegido.Id = listarClientes.Cliente.Id;
                    txtNombreCompletoCliente.Text = nombreCompletoCliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Crear()
        {
            try
            {
                if (id == 0)
                {
                    DialogResult result = MessageBox.Show("¿Desea crear este nuevo servicio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (!ValidarCamposVacios())
                        {
                            return;
                        }

                        Capturar();

                        string mensaje;
                        bool resultado = ServiciosServicio.Crear(Servicio);

                        if (resultado)
                        {
                            MessageBox.Show($"Servicio creado exitosamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarFormulario();
                            ListarServicios();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void LimpiarFormulario()
        {
            txtDirDestino.Clear();
            txtDirOrigen.Clear();
            txtTarifa.Clear();
            txtNombreCompletoCliente.Clear();
            txtNombreCompletoConductor.Clear();
        }

        private void Capturar()
        {
            Servicio.Conductor = new Conductor
            {
                Id = conductorElegido.Id
            };

            Servicio.Cliente = new Cliente
            {
                Id = clienteElegido.Id
            };

            // Asigno los valores a los atributos del vehiculo
            Servicio.Id = Convert.ToInt32(txtIdServicio.Text);
            Servicio.DireccionDestino = txtDirDestino.Text;
            Servicio.DireccionOrigen = txtDirOrigen.Text;
            Servicio.Tarifa = Convert.ToDecimal(txtTarifa.Text);
        }

        private bool ValidarCamposVacios()
        {
            TextBox[] textBoxes = { txtDirOrigen, txtDirDestino, txtTarifa };

            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"El campo '{textBox.Name.Substring(3)}' está vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ListarServicios()
        {
            try
            {
                tabla.Rows.Clear();

                List<Servicio> servicios = ServiciosServicio.Listar();

                foreach (Servicio servicio in servicios)
                {
                    tabla.Rows.Add(new object[]
                    {
                servicio.Id,
                servicio.Cliente.Id,
                servicio.Conductor.Id,
                servicio.DireccionOrigen,
                servicio.DireccionDestino,
                servicio.Tarifa,
                servicio.Estado,
                servicio.FechaCreacion
                    });
                }

                tabla.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignarCliente_Click(object sender, EventArgs e)
        {
            ConsultarCliente();
        }

        private void btnAsignarConductor_Click(object sender, EventArgs e)
        {
            ConsultarConductor();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarDataGridView(tabla, txtFiltro, btnBuscar);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            ListarServicios();
        }

        private void FiltrarDataGridView(DataGridView dataGridView, TextBox textBox, Button buscarButton)
        {
            buscarButton.Click += (sender, e) =>
            {
                string filtro = textBox.Text; // Obtener el texto del TextBox

                // Iterar sobre las filas del DataGridView y ocultar aquellas que no cumplan con el filtro
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    bool coincide = false;

                    // Iterar sobre las celdas de cada fila y verificar si alguna coincide con el filtro
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            coincide = true;
                            break;
                        }
                    }

                    // Mostrar u ocultar la fila según si coincide con el filtro
                    row.Visible = coincide;
                }
            };
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Crear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabla.Enabled = true;
            btnLimpiar.Enabled = true;
            btnReporte.Enabled = true;
            LimpiarFormulario();
            btnGuardar.Text = "Guardar";
            id = 0;
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            ListarServicios();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            GenerarReporte(new Reportes.Formularios.FrmReporteServicios());
        }

        private void GenerarReporte(Form formulario)
        {
            if (tabla.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontraron registros de vehiculos para generar el reporte.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                formulario.ShowDialog();
            }
        }
        
        public Servicio ServicioSeleccionado { get; private set; }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (ServicioSeleccionado != null)
            {
                // Llama al método para generar la factura con el servicio seleccionado
                GenerarFacturaPDF(ServicioSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un servicio antes de generar la factura.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void GenerarFacturaPDF(Servicio servicioSeleccionado)
        {
            try
            {
                if (servicioSeleccionado != null)
                {
                    string pdfPath = $"C:/Users/NosRey/Documents/Visual Studio 2022/pdf/Factura_{servicioSeleccionado.Id}.pdf";

                    using (PdfDocument document = new PdfDocument())
                    {
                        PdfPage page = document.AddPage();

                        XGraphics gfx = XGraphics.FromPdfPage(page);

                        XFont fontTitulo = new XFont("Arial", 16, XFontStyle.Bold);
                        XFont fontNormal = new XFont("Arial", 12, XFontStyle.Regular);

                        XPoint point = new XPoint(30, 30);

                        float columnWidth = 300;

                        DibujarCelda(gfx, "TAX-SERVICES", point, fontTitulo, XBrushes.Black, columnWidth);
                        point.Y += 30;

                        DibujarCelda(gfx, "Factura para Servicio", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"ID Servicio: {servicioSeleccionado.Id}", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"Cliente: {servicioSeleccionado.Cliente.Id}", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"Conductor: {servicioSeleccionado.Conductor.Id}", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"Dirección Origen: {servicioSeleccionado.DireccionOrigen}", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"Dirección Destino: {servicioSeleccionado.DireccionDestino}", point, fontNormal, XBrushes.Black, columnWidth);
                        point.Y += 20;

                        DibujarCelda(gfx, $"Tarifa: {servicioSeleccionado.Tarifa:C}", point, fontNormal, XBrushes.Black, columnWidth);

                        document.Save(pdfPath);

                        MessageBox.Show($"Factura generada con éxito. Ruta: {pdfPath}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún servicio para generar la factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DibujarCelda(XGraphics gfx, string texto, XPoint point, XFont font, XBrush brush, float width)
        {
            gfx.DrawRectangle(XBrushes.Transparent, point.X, point.Y, width, 20);
            gfx.DrawString(texto, font, brush, new XRect(point.X, point.Y, width, 20), XStringFormats.TopLeft);

            point.X += width;
        }
        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén el índice de la fila seleccionada
                int selectedRowIndex = e.RowIndex;

                // Obtén los datos de la fila seleccionada y asigna a ServicioSeleccionado
                int idServicio = Convert.ToInt32(tabla.Rows[selectedRowIndex].Cells["col_id_servicio"].Value);
                int idCliente = Convert.ToInt32(tabla.Rows[selectedRowIndex].Cells["Id_cliente"].Value);
                int idConductor = Convert.ToInt32(tabla.Rows[selectedRowIndex].Cells["id_conductor"].Value);
                string direccionOrigen = tabla.Rows[selectedRowIndex].Cells["col_direccion_origen"].Value.ToString();
                string direccionDestino = tabla.Rows[selectedRowIndex].Cells["col_direccion_destino"].Value.ToString();
                decimal tarifa = Convert.ToDecimal(tabla.Rows[selectedRowIndex].Cells["col_tarifa"].Value);

                ServicioSeleccionado = new Servicio
                {
                    Id = idServicio,
                    Cliente = new Cliente { Id = idCliente },
                    Conductor = new Conductor { Id = idConductor },
                    DireccionOrigen = direccionOrigen,
                    DireccionDestino = direccionDestino,
                    Tarifa = tarifa,
                };
            }

        }
    }
}
