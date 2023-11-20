using NUnit.Framework;

[TestFixture]
public class PruebasDeLogin
{
    [Test]
    public void LoginYAccesoAMenuDeberianFuncionarCorrectamente()
    {
        // Arrange
        Usuario usuarioMock = new Usuario { Nombre = "usuarioMock", Contrase�a = "contrase�aMock", Estado = true };
        FrmLogin frmLogin = new FrmLogin();
        FrmMenu frmMenu;

        // Act
        // Simula la entrada de credenciales y hace clic en el bot�n de ingreso
        frmLogin.UsuarioText = usuarioMock.Nombre;
        frmLogin.Contrase�aText = usuarioMock.Contrase�a;
        frmLogin.buttonIngresar_Click(null, null);

        // Obtiene la instancia de FrmMenu creada por el evento buttonIngresar_Click
        frmMenu = Application.OpenForms["FrmMenu"] as FrmMenu;

        // Assert
        Assert.IsNotNull(frmMenu);
    }

    [Test]
    public void PresionarEnterEnTxtUsuarioYTxtContrase�aDeberiaIniciarSesion()
    {
        // Arrange
        Usuario usuarioMock = new Usuario { Nombre = "usuarioMock", Contrase�a = "contrase�aMock", Estado = true };
        FrmLogin frmLogin = new FrmLogin();
        FrmMenu frmMenu;

        // Act
        // Simula la entrada de credenciales y presiona Enter en txtUsuario y txtContrase�a
        frmLogin.UsuarioText = usuarioMock.Nombre;
        frmLogin.Contrase�aText = usuarioMock.Contrase�a;
        frmLogin.txtUsuario_KeyUp(frmLogin.UsuarioText, new KeyEventArgs(Keys.Enter));
        frmLogin.txtContrase�a_KeyUp(frmLogin.Contrase�aText, new KeyEventArgs(Keys.Enter));

        // Obtiene la instancia de FrmMenu creada por el evento buttonIngresar_Click
        frmMenu = Application.OpenForms["FrmMenu"] as FrmMenu;

        // Assert
        Assert.IsNotNull(frmMenu);
    }
}