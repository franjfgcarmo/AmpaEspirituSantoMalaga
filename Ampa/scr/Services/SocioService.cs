using System;
using System.Linq;
using System.Windows.Forms;
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
            socio.Alumnos = alumnoService.ObtenerAlumnosPorSocioId(socioId,anyo);
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
            var socioId = GetMaximoSocio(cursoSocios.CursoId);

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

        public bool ImportarSocio(int actualSocioId,int actualCursoId, int anteriorSocioId, int anteriorCursoId)
        {
         
          //  var nuevoSocioId = GetMaximoSocio(actualCursoId);
            var querySocio = string.Format("Select {0} AS cursoId,{1} AS SocioId,Observaciones,PagoPorBanco FROM CursosSocios " +
                                           "WHERE SocioId = {2} AND cursoId = {3}", actualCursoId, actualSocioId, anteriorSocioId,
                anteriorCursoId);

            var socio = Connection.DbConnection.Query<CursosSociosModel>(querySocio).FirstOrDefault();
            
            var queryTutores = string.Format("INSERT INTO Tutores " +
                                           "SELECT Nombre, Apellidos, Telefono, Movil, Email, {0} AS SocioId,EsPrincipal,{1} AS CursoId FROM Tutores " +
                                           "WHERE  SocioId = {2} AND CursoId = {3}", actualSocioId, actualCursoId, anteriorSocioId,
                anteriorCursoId);
            var queryAlumnos = string.Format("INSERT INTO Alumnos " +
                                             "SELECT Nombre, Apellidos, Curso, {0} AS SocioId, {1} AS CursoId, GrupoId FROM Alumnos " +
                                             "WHERE  SocioId = {2} AND cursoId = {3}", actualSocioId, actualCursoId,
                anteriorSocioId,
                anteriorCursoId);
            try
            {
                UpdateSocioCurso(socio);
                try
                {
                    Connection.Execute(queryTutores);

                    try
                    {
                        Connection.Execute(queryAlumnos);
                    }
                    catch (Exception ex)
                    {
                        var queryBorradoTutor = string.Format("DELETE * FROM " +
                                                         "Tutores WHERE SocioId = {0} AND cursoId = {1}",
                       actualSocioId, actualCursoId);
                        Connection.Execute(queryBorradoTutor);
                        MessageBox.Show(ex.Message); 
                    }
                }
                catch (Exception ex)
                {
                    var queryBorradoSocios = string.Format("DELETE * FROM " +
                                                         "CursosSocios WHERE SocioId = {0} AND cursoId = {1}",
                       actualSocioId, actualCursoId);
                    Connection.Execute(queryBorradoSocios);
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private int GetMaximoSocio(int cursoId)
        {
            var querySocioId = string.Format(@"SELECT  IIf(IsNull(MAX(SocioId)), 0, Max(SocioId)) From CursosSocios Where CursoId={0}", cursoId);

            var socioId = Connection.DbConnection.Query<int>(querySocioId).FirstOrDefault() + 1;

            return socioId;
        }

        public bool EliminarSocio(int socioId, int cursoId)
        {
            try
            {
                var queryBorradoAlumno = string.Format("DELETE * FROM " +
                                                           "Alumnos WHERE SocioId = {0} AND cursoId = {1}",
                         socioId, cursoId);
                Connection.Execute(queryBorradoAlumno);

                var queryBorradoTutor = string.Format("DELETE * FROM " +
                                                               "Tutores WHERE SocioId = {0} AND cursoId = {1}",
                             socioId, cursoId);
                Connection.Execute(queryBorradoTutor);
                var queryBorradoSocio = string.Format("DELETE * FROM " +
                                                                "CursosSocios WHERE SocioId = {0} AND cursoId = {1}",
                              socioId, cursoId);
                Connection.Execute(queryBorradoSocio);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}