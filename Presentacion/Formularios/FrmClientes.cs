﻿using Entidad;
using Logica.Servicios;
using Presentacion.Reportes.Formularios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmClientes : Form
    {
        //Variables
        private ClienteServicio ClienteServicio = new ClienteServicio();
        private TipoDocumentoServicio TipoDocumentoServicio = new TipoDocumentoServicio();

        Cliente Cliente = new Cliente();
        Persona Persona = new Persona();
        TipoDocumento TipoDocumento = new TipoDocumento();
        Rol Rol = new Rol();


        int id = 0;
        string nombreCliente = string.Empty;

        public FrmClientes()
        {
            InitializeComponent();
        }

        //Funciones

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ListarTiposDocumento();
            ListarClientes();
        }

        private void ListarTiposDocumento()
        {
            try
            {
                List<TipoDocumento> tiposDocumento = TipoDocumentoServicio.Listar();

                tiposDocumento.Insert(0, new TipoDocumento { Id = 0, Nombre = "Seleccionar" });

                boxTipoDocumento.DataSource = tiposDocumento;
                boxTipoDocumento.DisplayMember = "Nombre";
                boxTipoDocumento.ValueMember = "Id";
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
                    DialogResult result = MessageBox.Show("¿Desea crear este nuevo cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (!ValidarCamposVacios())
                        {
                            return;
                        }

                        Capturar();

                        string mensaje;
                        bool resultado = ClienteServicio.Crear(Cliente, out mensaje);

                        if (resultado)
                        {
                            MessageBox.Show($"Cliente '{Cliente.Persona.Nombre} {Cliente.Persona.Apellido}' creado exitosamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarFormulario();
                            ListarClientes();
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
                        bool resultado = ClienteServicio.Actualizar(Cliente, out mensaje);

                        if (resultado)
                        {
                            MessageBox.Show($"Ciente '{Cliente.Persona.Nombre} {Cliente.Persona.Apellido}' actualizado exitosamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimpiarFormulario();
                            RestablecerColoresTextBox();
                            ListarClientes();
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
            TextBox[] textBoxes = { txtNombre, txtApellido, txtNumeroDocumento, txtTelefono, txtDireccion };
            ComboBox[] comboBoxes = { boxTipoDocumento };

            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"El campo '{textBox.Name.Substring(3)}' está vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Focus();
                    return false;
                }
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.SelectedIndex == 0)
                {
                    MessageBox.Show($"Debe seleccionar un valor para el campo '{comboBox.Name.Substring(3)}'.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox.Focus();
                    return false;
                }
            }

            return true;
        }

        private void Capturar()
        {
            TipoDocumento tipoDocumentoSeleccionado = (TipoDocumento)boxTipoDocumento.SelectedItem;

            Persona.TipoDocumento = new TipoDocumento
            {
                Id = tipoDocumentoSeleccionado.Id
            };

            // Asigno los valores a los atributos del usuario
            Cliente.Id = Convert.ToInt32(txtIdCliente.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Apellido = txtApellido.Text;
            Persona.Telefono = txtTelefono.Text;
            Persona.Direccion = txtDireccion.Text;
            Persona.NumeroDocumento = txtNumeroDocumento.Text;
            Cliente.Persona = Persona;
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

                int idCliente = Convert.ToInt32(txtIdCliente.Text);

                if (idCliente != 0)
                {
                    DialogResult dialogo = MessageBox.Show($"¿Está seguro que desea eliminar el ciente '{nombreCliente}'?",
                        "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogo == DialogResult.Yes)
                    {
                        Usuario usuarioEliminar = new Usuario()
                        {
                            Id = idCliente
                        };

                        string mensaje;
                        bool eliminado = ClienteServicio.Eliminar(usuarioEliminar.Id, out mensaje);

                        if (eliminado)
                        {
                            tabla.Enabled = true;
                            btnLimpiar.Enabled = true;
                            btnEliminar.Enabled = true;
                            LimpiarFormulario();
                            ListarTiposDocumento();
                            RestablecerColoresTextBox();
                            ListarClientes();
                            lblTitutloFormulario.Text = "Crear cliente:";
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

        private void ListarClientes()
        {
            try
            {
                tabla.Rows.Clear();

                List<Cliente> clientes = ClienteServicio.Listar();

                foreach (Cliente cliente in clientes)
                {

                    tabla.Rows.Add(new object[]
                    {
                        cliente.Id,
                        cliente.Persona.Id,
                        cliente.Persona.Nombre,
                        cliente.Persona.Apellido,
                        cliente.Persona.NumeroDocumento,
                        cliente.Persona.TipoDocumento.Id,
                        cliente.Persona.TipoDocumento.Nombre,
                        cliente.Persona.Telefono,
                        cliente.Persona.Direccion,
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
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumeroDocumento.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            boxTipoDocumento.SelectedIndex = 0;
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

                if (tabla.CurrentRow.Cells["col_id_cliente"].Value == null)
                {
                    MessageBox.Show("El registro seleccionado no contiene un ID de usuario válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                id = Convert.ToInt32(tabla.CurrentRow.Cells["col_id_cliente"].Value);

                TipoDocumento = new TipoDocumento
                {
                    Id = Convert.ToInt32(tabla.CurrentRow.Cells["col_id_tipo_documento"].Value),
                    Nombre = tabla.CurrentRow.Cells["col_tipo_documento"].Value?.ToString(),
                };

                Cliente = new Cliente
                {
                    Id = this.id,

                    Persona = new Persona
                    {
                        Id = Convert.ToInt32(tabla.CurrentRow.Cells["col_id_persona"].Value),
                        Nombre = tabla.CurrentRow.Cells["col_nombres"].Value?.ToString(),
                        Apellido = tabla.CurrentRow.Cells["col_apellidos"].Value?.ToString(),
                        NumeroDocumento = tabla.CurrentRow.Cells["col_numero_documento"].Value?.ToString(),

                        TipoDocumento = this.TipoDocumento,

                        Telefono = tabla.CurrentRow.Cells["col_telefono"].Value?.ToString(),
                        Direccion = tabla.CurrentRow.Cells["col_direccion"].Value?.ToString(),
                    },
                };

                nombreCliente = $"{Cliente.Persona.Nombre} {Cliente.Persona.Apellido}";

                txtIdCliente.Text = id.ToString();
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

            if (Cliente.Persona != null)
            {
                txtNombre.Text = Cliente.Persona.Nombre;
                txtApellido.Text = Cliente.Persona.Apellido;
                txtNumeroDocumento.Text = Cliente.Persona.NumeroDocumento;
            }

            boxTipoDocumento.DataSource = TipoDocumentoServicio.Listar();
            boxTipoDocumento.DisplayMember = "Nombre";
            boxTipoDocumento.ValueMember = "Id";
            boxTipoDocumento.SelectedValue = TipoDocumento.Id;


            txtTelefono.Text = Cliente.Persona.Telefono;
            txtDireccion.Text = Cliente.Persona.Direccion;

            // Cambiar el color de fondo de los TextBox al dar clic en el botón
            Color colorAmarilloClaro = Color.FromArgb(255, 255, 200);
            txtNombre.BackColor = colorAmarilloClaro;
            txtApellido.BackColor = colorAmarilloClaro;
            txtNumeroDocumento.BackColor = colorAmarilloClaro;
            txtTelefono.BackColor = colorAmarilloClaro;
            txtDireccion.BackColor = colorAmarilloClaro;
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
            txtNombre.BackColor = SystemColors.Window;
            txtApellido.BackColor = SystemColors.Window;
            txtNumeroDocumento.BackColor = SystemColors.Window;
            txtTelefono.BackColor = SystemColors.Window;
            txtDireccion.BackColor = SystemColors.Window;
        }

        private void GenerarReporte(Form formulario)
        {
            if (tabla.Rows.Count <= 0)
            {
                MessageBox.Show("No se encontraron registros de clientes para generar el reporte.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                formulario.ShowDialog();
            }
        }

        //Eventos

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Formularios.FrmReporteClientesActivos frmReporteClientesActivos = new Reportes.Formularios.FrmReporteClientesActivos();
            frmReporteClientesActivos.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabla.Enabled = true;
            btnLimpiar.Enabled = true;
            btnReporte.Enabled = true;
            LimpiarFormulario();
            ListarTiposDocumento();
            RestablecerColoresTextBox();
            lblTitutloFormulario.Text = "Crear cliente:";
            btnGuardar.Text = "Guardar";
            id = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Crear_Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            GenerarReporte(new FrmReporteClientesActivos());
        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla.Rows.Count >= 1)
            {
                ObtenerRegistro();
                tabla.Enabled = false;
            }
        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarRegistroTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarDataGridView(tabla, txtFiltro, btnBuscar);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            ListarClientes();
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
