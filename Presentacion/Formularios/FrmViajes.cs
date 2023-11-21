using Entidad;
using Logica.Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Presentacion.Formularios
{
    public partial class FrmViajes : Form
    {
        private ViajesServicio ViajesServicio = new ViajesServicio();
        Viajes Viajes = new Viajes();
        int id = 0;
        public FrmViajes()
        {
            InitializeComponent();
        }

        //Funciones

        private void Crear ()
        {
            try
            {
                if (id == 0)
                {
                    DialogResult result = MessageBox.Show("¿Desea crear este viaje?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (!ValidarCamposVacios())
                        {
                            return;
                        }

                        Capturar();

                        string mensaje;

                        bool resultado = ViajesServicio.Crear(Viajes, out mensaje);

                        if (resultado)
                        {
                            MessageBox.Show($"Viaje con referencia '{Viajes.Id}' creado exitosamente.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    DialogResult dialogo = MessageBox.Show($"¿Está seguro que desea eliminar el viaje'?",
                        "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogo == DialogResult.Yes)
                    {
                        Vehiculo vehiculoEliminar = new Vehiculo()
                        {
                            Id = idUsuario
                        };

                        string mensaje;
                        bool eliminado = ViajesServicio.Eliminar(vehiculoEliminar.Id, out mensaje);

                        if (eliminado)
                        {
                            tabla.Enabled = true;
                            btnLimpiar.Enabled = true;
                            btnEliminar.Enabled = true;
                            RestablecerColoresTextBox();
                            LimpiarFormulario();
                            lblTitutloFormulario.Text = "Crear Viaje:";
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


        private bool ValidarCamposVacios()
        {
            TextBox[] textBoxes = { txtDireccionOrigen, txtDireccionDestino, txtTelefono };

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
            Viajes.Id = Convert.ToInt32(txtIdUsuario.Text);
            Viajes.DireccionDestino = txtDireccionDestino.Text;
            Viajes.DireccionOrigen = txtDireccionOrigen.Text;
            Viajes.Telefono = Convert.ToInt32(txtTelefono.Text);
        }

        private void LimpiarFormulario()
        {
            txtDireccionOrigen.Clear();
            txtDireccionDestino.Clear();
            txtTelefono.Clear();
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
    }
}
