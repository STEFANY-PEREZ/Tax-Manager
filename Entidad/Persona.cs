using System;

namespace Entidad
{
    public class Persona
    {
        public int Id { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
