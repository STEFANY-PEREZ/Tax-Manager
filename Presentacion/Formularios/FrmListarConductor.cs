using Entidad;
using Logica.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmListarConductores : Form
    {
        private ServicioServicio ConductorServicio = new ServicioServicio();
        public Conductor Conductor = new Conductor();
        public Persona Persona = new Persona();
        public TipoDocumento TipoDocumento = new TipoDocumento();
        int id = 0;


        public FrmListarConductores()
        {
            InitializeComponent();
        }

        private void ListarConductores()
        {
            try
            {
                tabla.Rows.Clear();

                List<Conductor> conductores = ConductorServicio.Listar();

                foreach (Conductor conductor in conductores)
                {

                    tabla.Rows.Add(new object[]
                    {
                        conductor.Id,
                        conductor.Persona.Id,
                        conductor.Persona.Nombre,
                        conductor.Persona.Apellido,
                        conductor.Persona.NumeroDocumento,
                        conductor.Persona.TipoDocumento.Id,
                        conductor.Persona.TipoDocumento.Nombre,
                        conductor.Persona.Telefono,
                        conductor.Persona.Direccion,
                    });
                }

                tabla.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                if (tabla.CurrentRow.Cells["col_id_conductor"].Value == null)
                {
                    MessageBox.Show("El registro seleccionado no contiene un ID de usuario válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                id = Convert.ToInt32(tabla.CurrentRow.Cells["col_id_conductor"].Value);

                TipoDocumento = new TipoDocumento
                {
                    Id = Convert.ToInt32(tabla.CurrentRow.Cells["col_id_tipo_documento"].Value),
                    Nombre = tabla.CurrentRow.Cells["col_tipo_documento"].Value?.ToString(),
                };

                Conductor = new Conductor
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

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarRegistroTabla();
        }

        private void FrmListarConductor_Load(object sender, EventArgs e)
        {
            ListarConductores();
        }
    }
}
