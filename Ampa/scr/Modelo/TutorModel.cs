﻿namespace Ampa.Modelo
{
    public class TutorModel
    {
        public int SocioId { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }        
        public bool EsPrincipal { get; set; }
        public int CursoId { get; set; }
    }
}