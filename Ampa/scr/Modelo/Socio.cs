using System.Collections.Generic;

namespace Ampa.Modelo
{
    public class Socio
    {
        public int SocioId { get; set; }
        public string Observaciones { get; set; }
        public bool PagoPorBanco { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public List<Tutores> Tutores { get; set; }
    }
}