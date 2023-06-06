using Entidad;
using Logica.Servicios;
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
    }
}
