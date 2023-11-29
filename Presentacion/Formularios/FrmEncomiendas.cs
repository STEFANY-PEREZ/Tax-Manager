using Entidad;
using Logica.Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmEncomiendas : Form
    {
        private EncomiendaServicio ViajesServicio = new EncomiendaServicio();
        private TipoEncomiendaServicio TipoEncomiendaServicio = new TipoEncomiendaServicio();

        Encomienda Viajes = new Encomienda();
        Conductor condutorElegido = new Conductor();
        int id = 0;
        public FrmEncomiendas()
        {
            InitializeComponent();
        }
        
        private void FrmViajes_Load(object sender, EventArgs e)
        {
            ListarTipoEncomiendas();
            ListarViajes();
        }
        //Funciones

        private void ListarTipoEncomiendas()
        {
            try
            {
                List<TipoEncomiendas> tipoEncomiendas = TipoEncomiendaServicio.Listar();

                tipoEncomiendas.Insert(0, new TipoEncomiendas { IdEncomienda = 0, Nombre = "Seleccionar" });

                boxTipo.DataSource = tipoEncomiendas;
                boxTipo.DisplayMember = "Nombre"; 
                boxTipo.ValueMember = "IdEncomienda";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Crear ()
        {
            try
            {
                if (id == 0)
                {
                    DialogResult result = MessageBox.Show("¿Desea crear este viaje?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (!ValidarCamposVacios() || !ValidarFormatoValor())
                        {
                            return;
                        }

                        CapturarViaje();

                        string mensaje;

                        bool resultado = ViajesServicio.Crear(Viajes, out mensaje);

                        if (resultado)
                        {
                            MessageBox.Show($"Viaje con referencia creado exitosamente.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarFormulario();
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

        private bool ValidarFormatoValor()
        {
            if (!decimal.TryParse(txtValor.Text, out _))
            {
                MessageBox.Show("El campo 'Valor' debe ser un número decimal válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus();
                return false;
            }

            return true;
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

                int idUsuario = Convert.ToInt32(txtIdUsuario.Text);

                if (idUsuario != 0)
                {
                    DialogResult dialogo = MessageBox.Show($"¿Está seguro que desea eliminar Encomienda'?",
                        "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogo == DialogResult.Yes)
                    {
                        Encomienda encomiendaEliminar = new Encomienda()
                        {
                            IdViaje = idUsuario
                        };

                        string mensaje;
                        bool eliminado = ViajesServicio.Eliminar(encomiendaEliminar.IdViaje, out mensaje);

                        if (eliminado)
                        {
                            tabla.Enabled = true;
                            btnLimpiar.Enabled = true;
                            btnEliminar.Enabled = true;
                            RestablecerColoresTextBox();
                            LimpiarFormulario();
                            lblTitutloFormulario.Text = "Crear Encomienda:";
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
        private void ListarViajes()
        {
            try
            {
                tabla.Rows.Clear();

                List<Encomienda> viajes = ViajesServicio.Listar();

                foreach (Encomienda viaje in viajes)
                {
                    tabla.Rows.Add(new object[]
                    {
                        viaje.IdViaje,
                        viaje.Identificacion,
                        viaje.DireccionOrigen,
                        viaje.DireccionDestino,
                        viaje.Telefono,
                        viaje.Tipo,
                        viaje.Valor,
                        viaje.FechaCreacion
                    });
                }
                tabla.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CapturarViaje()
        {
            TipoEncomiendas tipoEncomiendas = (TipoEncomiendas)boxTipo.SelectedItem;

            Viajes.tipoEncomiendas = new TipoEncomiendas
            {
                IdEncomienda = tipoEncomiendas.IdEncomienda
            };
            Viajes.Identificacion = Convert.ToInt32(txtCedula.Text);
            Viajes.DireccionOrigen = txtDireccionOrigen.Text;
            Viajes.DireccionDestino = txtDireccionDestino.Text;
            Viajes.Tipo = boxTipo.Text;
            Viajes.Telefono = txtTelefono.Text;
            Viajes.Valor = Convert.ToDecimal(txtValor.Text); // Ajuste a Convert.ToDecimal
            Viajes.Contenido = txtContenido.Text;
        }

        private bool ValidarCamposVacios()
        {
            TextBox[] textBoxes = { txtCedula, txtDireccionOrigen, txtDireccionDestino, txtTelefono, txtValor, txtContenido };

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

        private void LimpiarFormulario()
        {
            txtDireccionOrigen.Clear();
            txtDireccionDestino.Clear();
            txtTelefono.Clear();
            txtValor.Clear();
            txtContenido.Clear();
            txtCedula.Clear();
        }

        private void RestablecerColoresTextBox()
        {
            txtDireccionOrigen.BackColor = SystemColors.Window;
            txtDireccionDestino.BackColor = SystemColors.Window;
            txtTelefono.BackColor = SystemColors.Window;
        }

        private void GenerarReporte(Form formulario)
        {
            if (tabla.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontraron registros de viajes para generar el reporte.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                formulario.ShowDialog();
            }
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Crear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            GenerarReporte(new Reportes.Formularios.FrmReporteViajesActivos());
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier entrada que no sea un número o tecla de control
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier entrada que no sea un número o tecla de control
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier entrada que no sea un número o tecla de control
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarDataGridView(tabla, txtFiltro, btnBuscar);
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            ListarViajes();
        }
    }
}
