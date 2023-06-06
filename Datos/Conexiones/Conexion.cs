using System.Configuration;

namespace Datos.Conexiones
{
    public class Conexion
    {
        public static string CadenaConexionMaestra = ConfigurationManager.ConnectionStrings["Conexion_TAX_MANAGER"].ToString();
    }
}
