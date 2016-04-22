using System;
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

        public SocioModel ObtenerSocioPorAnyoSocioId(int anyo, int socioId)
        {
            var query = string.Format(@"SELECT * FROM CursosSocios WHERE CursoId = {0} AND SocioId = {1}", anyo, socioId);
            var socio = Connection.DbConnection.Query<SocioModel>(query).FirstOrDefault();
            var tutorService = TutorService.GetInstance();
            if (socio == null) return null;
            var alumnoService = AlumnoService.GetInstance();
            socio.Tutores = tutorService.ObtenerTutoresPorSocioId(anyo, socioId);
            socio.Alumnos = alumnoService.ObtenerAlumnosPorSocioId(socioId);
            return socio;
        }

        public bool UpdateSocioCurso(CursosSociosModel cursoSocios)
        {
            var query = string.Format("Update CursosSocios Set " +
                                      "Observaciones = '{0}'," +
                                      "PagoPorBanco = {1} " +
                                      "WHERE SocioId = {2} AND CursoId = {3}", cursoSocios.Observaciones,
                cursoSocios.PagoPorBanco, cursoSocios.SocioId, cursoSocios.CursoId
                );
            return Connection.Execute(query) > 0;
        }

        public int InsertSocioCurso(CursosSociosModel cursoSocios)
        {
            var querySocioId = string.Format(@"SELECT  IIf(IsNull(MAX(SocioId)), 0, Max(SocioId)) From CursosSocios Where CursoId={0}", cursoSocios.CursoId);

            var socioId = Connection.DbConnection.Query<int>(querySocioId).FirstOrDefault()+1;

            var query = string.Format("INSERT INTO CursosSocios (Observaciones, PagoPorBanco,SocioId,CursoId) " +
                                      "VALUES('{0}',{1},{2},{3})", cursoSocios.Observaciones,
                cursoSocios.PagoPorBanco, socioId, cursoSocios.CursoId
                );
            if (Connection.Execute(query) > 0)
            {
                return socioId;
            }
            
            throw new Exception("Ha ocurrido un error al intentar obtener el socioId");
        }
    }
}