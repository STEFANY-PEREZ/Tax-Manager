using Entidad;
using Logica.Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmVehiculos : Form
    {
        private VehiculoServicio VehiculoServicio = new VehiculoServicio();
        private TipoVehiculoServicio TipoVehiculoServicio = new TipoVehiculoServicio();

        Conductor conductorElegido = new Conductor();
        Vehiculo Vehiculo = new Vehiculo();
        int id = 0;

        public FrmVehiculos()
        {
            InitializeComponent();
            ListarVehiculos();
        }

        //Funciones
        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            ListarTipoVehiculo();
        }

        private void ListarTipoVehiculo()
        {
            try
            {
                List<TipoVehiculo> tipoVehiculo = TipoVehiculoServicio.Listar();

                tipoVehiculo.Insert(0, new TipoVehiculo { Id = 0, Nombre = "Seleccionar" });

                boxTipo.DataSource = tipoVehiculo;
                boxTipo.DisplayMember = "Nombre";
                boxTipo.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Crear_Actualizar()
        {
            try
            {
                if (id == 0)
                {
                    DialogResult result = MessageBox.Show("¿Desea crear este nuevo vehiculo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (!ValidarCamposVacios())
                        {
                            return;
                        }

                        Capturar();

                        string mensaje;
                        bool resultado = VehiculoServicio.Crear(Vehiculo, out mensaje);

                        if (resultado)
                        {
                            MessageBox.Show($"Vehiculo con placa '{Vehiculo.Placa}' creado exitosamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarFormulario();
                            ListarVehiculos();
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Desea confirmar esta actualización?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (!ValidarCamposVacios())
                        {
                            return;
                        }

                        Capturar();

                        string mensaje;
                        bool resultado = VehiculoServicio.Actualizar(Vehiculo, out mensaje);

                        if (resultado)
                        {
                            MessageBox.Show($"Vehiculo '{Vehiculo.Placa}' actualizado exitosamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarFormulario();
                            RestablecerColoresTextBox();
                            ListarVehiculos();
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposVacios()
        {
            TextBox[] textBoxes = { txtMarca, txtModelo, txtPlaca };

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

        private void Capturar()
        {
            TipoVehiculo tipoVehiculo = (TipoVehiculo)boxTipo.SelectedItem;

            Vehiculo.TipoVehiculo = new TipoVehiculo
            {
                Id = tipoVehiculo.Id
            };

            Vehiculo.Conductor = new Conductor
            {
                Id = conductorElegido.Id
            };

            // Asigno los valores a los atributos del vehiculo
            Vehiculo.Id = Convert.ToInt32(txtIdVehiculo.Text);
            Vehiculo.Marca = txtMarca.Text;
            Vehiculo.Modelo = txtModelo.Text;
            Vehiculo.Año = (int)numericAño.Value;
            Vehiculo.Cupo = (int)numericCupo.Value;
            Vehiculo.Placa = txtPlaca.Text;
            Vehiculo.TipoVehiculo.Nombre = boxTipo.Text;

        }

        private void Eliminar()
        {
            try
            {
                if (tabla.Rows.Count < 1)
                {
                    MessageBox.Show("No existen registros para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idVehiculo = Convert.ToInt32(txtIdVehiculo.Text);

                if (idVehiculo != 0)
                {
                    DialogResult dialogo = MessageBox.Show($"¿Está seguro que desea eliminar el vehiculo'?",
                        "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogo == DialogResult.Yes)
                    {
                        Vehiculo vehiculoEliminar = new Vehiculo()
                        {
                            Id = idVehiculo
                        };

                        string mensaje;
                        bool eliminado = VehiculoServicio.Eliminar(vehiculoEliminar.Id, out mensaje);

                        if (eliminado)
                        {
                            tabla.Enabled = true;
                            btnLimpiar.Enabled = true;
                            btnEliminar.Enabled = true;
                            LimpiarFormulario();
                            RestablecerColoresTextBox();
                            ListarVehiculos();
                            lblTitutloFormulario.Text = "Crear vehiculo:";
                            btnGuardar.Text = "Guardar";
                            id = 0;
                            MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarVehiculos()
        {
            try
            {
                tabla.Rows.Clear();

                List<Vehiculo> vehiculos = VehiculoServicio.Listar();

                foreach (Vehiculo vehiculo in vehiculos)
                {
                    tabla.Rows.Add(new object[]
                    {
                        vehiculo.Id,
                        vehiculo.Conductor.Id,
                        vehiculo.Marca,
                        vehiculo.Modelo,
                        vehiculo.Placa,
                        vehiculo.Año,
                        vehiculo.Tipo,
                        vehiculo.Cupo
                        
                    });
                }

                tabla.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            txtNombreCompletoCliente.Clear();
        }

        private void SeleccionarRegistroTabla()
        {
            try
            {
                if (tabla.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tabla.CurrentRow.Cells["col_id_vehiculo"].Value == null)
                {
                    MessageBox.Show("El registro seleccionado no contiene un ID de vehículo válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                id = Convert.ToInt32(tabla.CurrentRow.Cells["col_id_vehiculo"].Value);

                Conductor conductor = new Conductor
                {
                    Id = Convert.ToInt32(tabla.CurrentRow.Cells["col_id_conductor"].Value),
                    Persona = new Persona
                    {
                        Id = Convert.ToInt32(tabla.CurrentRow.Cells["col_id_persona"].Value),
                        Nombre = tabla.CurrentRow.Cells["col_nombre"].Value?.ToString(),
                        Apellido = tabla.CurrentRow.Cells["col_apellido"].Value?.ToString(),
                        NumeroDocumento = tabla.CurrentRow.Cells["col_numero_documento"].Value?.ToString(),
                        TipoDocumento = new TipoDocumento
                        {
                            Id = Convert.ToInt32(tabla.CurrentRow.Cells["col_id_tipo_documento"].Value),
                            Nombre = tabla.CurrentRow.Cells["col_tipo_documento"].Value?.ToString()
                        },
                        Telefono = tabla.CurrentRow.Cells["col_telefono"].Value?.ToString(),
                        Direccion = tabla.CurrentRow.Cells["col_direccion"].Value?.ToString()
                    }
                };
                
                Vehiculo = new Vehiculo
                {
                    Id = this.id,
                    Marca = tabla.CurrentRow.Cells["col_marca"].Value?.ToString(),
                    Modelo = tabla.CurrentRow.Cells["col_modelo"].Value?.ToString(),
                    Placa = tabla.CurrentRow.Cells["col_placa"].Value?.ToString(),
                    Año = Convert.ToInt32(tabla.CurrentRow.Cells["col_año"].Value),
                    Cupo = Convert.ToInt32(tabla.CurrentRow.Cells["col_cupo"].Value),
                    Tipo = tabla.CurrentRow.Cells["col_tipovehiculo"].Value?.ToString(),
                    Conductor = conductor
                };

                txtIdVehiculo.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerRegistro()
        {
            if (tabla.Rows.Count < 1)
            {
                MessageBox.Show("No existen registros para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnGuardar.Text = "Actualizar";
            btnLimpiar.Enabled = false;

            SeleccionarRegistroTabla();

            lblTitutloFormulario.Text = "Actualizar cliente:";

            if (Vehiculo.Conductor != null)
            {
                txtMarca.Text = Vehiculo.Marca;
                txtModelo.Text = Vehiculo.Modelo;
                txtPlaca.Text = Vehiculo.Placa;
                numericAño.Text = Vehiculo.Año.ToString();
            }

            txtMarca.BackColor = Color.FromArgb(255, 255, 200);
            txtModelo.BackColor = Color.FromArgb(255, 255, 200);
            txtPlaca.BackColor = Color.FromArgb(255, 255, 200);
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

        private void ValidarCampoNumerico(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void RestablecerColoresTextBox()
        {
            txtMarca.BackColor = SystemColors.Window;
            txtModelo.BackColor = SystemColors.Window;
            txtPlaca.BackColor = SystemColors.Window;
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
                    txtNombreCompletoCliente.Text = nombreCompletoCliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        //Eventos
        private void btnAsignarCliente_Click(object sender, EventArgs e)
        {
            ConsultarConductor();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Crear_Actualizar();
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
            RestablecerColoresTextBox();
            lblTitutloFormulario.Text = "Crear vehiculo:";
            btnGuardar.Text = "Guardar";
            id = 0;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            GenerarReporte(new Reportes.Formularios.FrmReporteVehiculosActivos());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarRegistroTabla();
        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla.Rows.Count >= 1)
            {
                ObtenerRegistro();
                tabla.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarDataGridView(tabla, txtFiltro, btnBuscar);
        }
    }
}
