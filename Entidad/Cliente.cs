using System;

namespace Entidad
{
    public class Cliente 
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
