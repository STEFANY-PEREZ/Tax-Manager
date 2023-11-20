using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Presentacion;
using Presentacion.Formularios;
using System.Windows.Forms;

namespace PruebasUnitarias
{
    [TestClass]
    public class FrmUsuariosTests
    {
        [TestMethod]
        public void ValidarCamposVacios_DeberiaRetornarFalseSiHayCamposVacios()
        {
            // Arrange
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            TextBox textBox = new TextBox { Text = "" };  // Simula un campo vacío

            // Act
            bool resultado = frmUsuarios.ValidarCamposVacios(textBox);

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void ValidarCamposVacios_DeberiaRetornarTrueSiNoHayCamposVacios()
        {
            // Arrange
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            TextBox textBox = new TextBox { Text = "Valor no vacío" };  // Simula un campo no vacío

            // Act
            bool resultado = frmUsuarios.ValidarCamposVacios(textBox);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidarCampoNumerico_DeberiaPermitirSoloNumeros()
        {
            // Arrange
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            KeyPressEventArgs keyPressEvent = new KeyPressEventArgs('5');  // Simula la pulsación de la tecla '5'

            // Act
            frmUsuarios.PruebaValidarCampoNumerico(null, keyPressEvent);

            // Assert
            // Verifica que la tecla '5' se haya manejado correctamente y no haya sido manejada (Handled=false)
            Assert.IsFalse(keyPressEvent.Handled);
        }

        [TestMethod]
        public void ValidarCampoNumerico_DeberiaEvitarLetras()
        {
            // Arrange
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            KeyPressEventArgs keyPressEvent = new KeyPressEventArgs('a');  // Simula la pulsación de la tecla 'a'

            // Act
            frmUsuarios.PruebaValidarCampoNumerico(null, keyPressEvent);

            // Assert
            // Verifica que la tecla 'a' se haya manejado correctamente y haya sido manejada (Handled=true)
            Assert.IsTrue(keyPressEvent.Handled);
        }
    }
}
