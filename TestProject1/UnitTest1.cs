using NUnit.Framework;

[TestFixture]
public class PruebasDeLogin
{
    [Test]
    public void LoginYAccesoAMenuDeberianFuncionarCorrectamente()
    {
        // Arrange
        Usuario usuarioMock = new Usuario { Nombre = "usuarioMock", Contraseña = "contraseñaMock", Estado = true };
        FrmLogin frmLogin = new FrmLogin();
        FrmMenu frmMenu;

        // Act
        // Simula la entrada de credenciales y hace clic en el botón de ingreso
        frmLogin.UsuarioText = usuarioMock.Nombre;
        frmLogin.ContraseñaText = usuarioMock.Contraseña;
        frmLogin.buttonIngresar_Click(null, null);

        // Obtiene la instancia de FrmMenu creada por el evento buttonIngresar_Click
        frmMenu = Application.OpenForms["FrmMenu"] as FrmMenu;

        // Assert
        Assert.IsNotNull(frmMenu);
    }

    [Test]
    public void PresionarEnterEnTxtUsuarioYTxtContraseñaDeberiaIniciarSesion()
    {
        // Arrange
        Usuario usuarioMock = new Usuario { Nombre = "usuarioMock", Contraseña = "contraseñaMock", Estado = true };
        FrmLogin frmLogin = new FrmLogin();
        FrmMenu frmMenu;

        // Act
        // Simula la entrada de credenciales y presiona Enter en txtUsuario y txtContraseña
        frmLogin.UsuarioText = usuarioMock.Nombre;
        frmLogin.ContraseñaText = usuarioMock.Contraseña;
        frmLogin.txtUsuario_KeyUp(frmLogin.UsuarioText, new KeyEventArgs(Keys.Enter));
        frmLogin.txtContraseña_KeyUp(frmLogin.ContraseñaText, new KeyEventArgs(Keys.Enter));

        // Obtiene la instancia de FrmMenu creada por el evento buttonIngresar_Click
        frmMenu = Application.OpenForms["FrmMenu"] as FrmMenu;

        // Assert
        Assert.IsNotNull(frmMenu);
    }
}