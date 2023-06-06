using System;

namespace Entidad
{
    public class Conductor
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
