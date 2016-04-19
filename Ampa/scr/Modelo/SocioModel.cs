using System.Collections.Generic;

namespace Ampa.Modelo
{
    public class SocioModel
    {
        public int SocioId { get; set; }
        public string Observaciones { get; set; }
        public bool PagoPorBanco { get; set; }
        public List<AlumnoModel> Alumnos { get; set; }
        public List<TutorModel> Tutores { get; set; }
    }
}