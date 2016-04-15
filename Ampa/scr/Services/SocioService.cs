using System.Linq;
using Ampa.Modelo;
using Dapper;

namespace Ampa.Services
{
    public class SocioService : Service
    {
        public static SocioService GetInstance()
        {
            return new SocioService();
        }

        public Socio ObtenerSocioPorAnyoSocioId(int anyo, int socioId)
        {
            var query =string.Format(@"SELECT * FROM CursosSocios WHERE CursoId = {0} AND SocioId = {1}",anyo,socioId);
            var socio= Connection.DbConnection.Query<Socio>(query).FirstOrDefault();
            var tutorService = TutorService.GetInstance();
            if (socio == null) return null;
            var alumnoService = AlumnoService.GetInstance();
            socio.Tutores = tutorService.ObtenerTutoresPorSocioId(anyo, socioId);
            socio.Alumnos = alumnoService.ObtenerAlumnosPorSocioId(socioId);
            return socio;
        }
    }
}