using Entidad;
using Logica.Servicios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void ValidarCredenciales()
        {
            try
            {
                Usuario usuario = new UsuarioServicio().Listar().Where(u => u.Nombre == txtUsuario.Text 
                        && u.Contraseña == txtContraseña.Text).FirstOrDefault();

                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("El campo del documento está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                }
                else if (txtContraseña.Text == "")
                {
                    MessageBox.Show("El campo de contraseña está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Focus();
                }
                else
                {
                    if (usuario != null)
                    {
                        if (usuario.Estado == false)
                        {
                            MessageBox.Show("Este usuario se encuentra Inactivo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            this.Hide();
                            FrmMenu menu = new FrmMenu(usuario);
                            menu.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas, verifique e intentelo nuevamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            ValidarCredenciales();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall) { return; }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea salir del sistema?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = (dialogResult == DialogResult.No);

            if (!e.Cancel) { Application.Exit(); }
        }
    }
}
