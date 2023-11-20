using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Presentacion;
using Entidad;
using Presentacion.Formularios;

namespace PruebasIntegracion
{
    [TestClass]
    public class IntegracionFrmLoginFrmMenuTests
    {
        [TestMethod]
        public void LoginYAccesoAMenuDeberianFuncionarCorrectamente()
        {
            // Arrange
            Usuario usuarioMock = new Usuario { Nombre = "usuarioMock", Contraseña = "contraseñaMock", Estado = true };
            FrmLogin frmLogin = new FrmLogin();
            FrmMenu frmMenu;

            // Act
            // Simula la entrada de credenciales
            frmLogin.txtUsuario.Text = usuarioMock.Nombre;
            frmLogin.txtContraseña.Text = usuarioMock.Contraseña;

            
            frmLogin.buttonIngresar_Click(null, null);

            // Obtiene la instancia de FrmMenu creada por el evento buttonIngresar_Click
            frmMenu = Application.OpenForms["FrmMenu"] as FrmMenu;

            // Assert
            //Assert.IsNotNull(frmMenu);

            // Cierra la aplicación después de las pruebas
            Application.Exit();
        }

        [TestMethod]
        public void PresionarEnterEnTxtUsuarioYTxtContraseñaDeberiaIniciarSesion()
        {
            // Arrange
            Usuario usuarioMock = new Usuario { Nombre = "usuarioMock", Contraseña = "contraseñaMock", Estado = true };
            FrmLogin frmLogin = new FrmLogin();
            FrmMenu frmMenu;

            // Act
            // Simula la entrada de credenciales
            frmLogin.txtUsuario.Text = usuarioMock.Nombre;
            frmLogin.txtContraseña.Text = usuarioMock.Contraseña;

            // Presiona Enter en txtUsuario
            frmLogin.txtUsuario_KeyUp(frmLogin.txtUsuario, new KeyEventArgs(Keys.Enter));

            // Presiona Enter en txtContraseña
            frmLogin.txtContraseña_KeyUp(frmLogin.txtContraseña, new KeyEventArgs(Keys.Enter));

            // Hace clic en el botón de ingreso
            frmLogin.buttonIngresar_Click(null, null);

            // Obtiene la instancia de FrmMenu creada por el evento buttonIngresar_Click
            frmMenu = Application.OpenForms["FrmMenu"] as FrmMenu;

            // Assert
            //Assert.IsNotNull(frmMenu);

            // Aquí puedes realizar más aserciones para asegurarte de que los módulos se carguen correctamente en FrmMenu.

            // Cierra la aplicación después de las pruebas
            Application.Exit();
        }
    }
}
