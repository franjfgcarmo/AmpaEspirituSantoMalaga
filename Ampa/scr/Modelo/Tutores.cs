namespace Ampa.Modelo
{
    public class Tutores
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }
        public int SocioId { get; set; }
        public bool EsPrincipal { get; set; }

    }
}
