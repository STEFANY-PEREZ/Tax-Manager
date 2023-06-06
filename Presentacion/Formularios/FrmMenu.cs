using Entidad;
using Logica.Servicios;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmMenu : Form
    {
        public static Usuario UsuarioLogueado;
        public ModuloAccesoServicio ModuloAccesoServicio = new ModuloAccesoServicio();
        public FrmMenu(Usuario usuario)
        {
            UsuarioLogueado = usuario;
            InitializeComponent();
        }

        private void ValidadControles()
        {
            List<ModuloAcceso> modulosAcceso = ModuloAccesoServicio.ListarModulosActivosPorIdUsuario(UsuarioLogueado.Id);

            //Recorremos los elementos del menú lateral
            foreach (var elemento in panelLateral.Controls)
            {
                //Si el elemento del menú lateral es un botón entonces ejecuta el bloque de codigo
                if (elemento is Button boton)
                {
                    bool encontrado = modulosAcceso.Any(m => m.Nombre == boton.Name);
                    if (encontrado) { boton.Visible = true; }
                    else { boton.Visible = false; }
                }
            }
        }

        private void FrmMenu_Load(object sender, System.EventArgs e)
        {
            ValidadControles();
        }

        private void CambiarEstadoBotonesPrincipales(bool state, Button button)
        {
            List<Button> buttons = new List<Button> {  servicios, conductores, vehiculos, clientes, usuarios };

            if (buttons.Contains(button))
            {
                button.Enabled = !state;

                foreach (Button btn in buttons)
                {
                    if (btn != button)
                    {
                        btn.Enabled = state;
                    }
                }
            }
        }

        private void AbrirNuevoFormulario(Form modulo)
        {
            panelBase.Controls.Clear();
            modulo.TopLevel = false;
            modulo.Dock = DockStyle.Fill;
            panelBase.Controls.Add(modulo);
            panelBase.Tag = modulo;
            modulo.Show();
            panelBase.BringToFront();
        }

        private void AbrirModulo(Form panel, Button botonModulo)
        {
            CambiarEstadoBotonesPrincipales(true, botonModulo);
            AbrirNuevoFormulario(panel);
        }

        private void servicios_Click(object sender, System.EventArgs e)
        {
            AbrirModulo(new FrmServicios(), servicios);
        }

        private void conductores_Click(object sender, System.EventArgs e)
        {
            AbrirModulo(new FrmConductores(), conductores);
        }

        private void vehiculos_Click(object sender, System.EventArgs e)
        {
            AbrirModulo(new FrmVehiculos(), vehiculos);
        }

        private void clientes_Click(object sender, System.EventArgs e)
        {
            AbrirModulo(new FrmClientes(), clientes);
        }

        private void usuarios_Click(object sender, System.EventArgs e)
        {
            AbrirModulo(new FrmUsuarios(), usuarios);
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall) { return; }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea salir del sistema?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = (dialogResult == DialogResult.No);

            if (!e.Cancel) { Application.Exit(); }
        }
    }
}
