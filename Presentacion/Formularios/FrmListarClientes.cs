using Entidad;
using Logica.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmListarClientes : Form
    {
        private ClienteServicio ClienteServicio = new ClienteServicio();
        private TipoDocumentoServicio TipoDocumentoServicio = new TipoDocumentoServicio();
        public Persona Persona = new Persona();
        public Cliente Cliente = new Cliente();
        TipoDocumento TipoDocumento = new TipoDocumento();
        int id = 0;

        public FrmListarClientes()
        {
            InitializeComponent();
        }

        private void FrmListarClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarRegistroTabla();
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

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
