using System.Collections.Generic;
using System.Linq;
using Ampa.Modelo;
using Dapper;

namespace Ampa.Services
{
    public class TutorService : Service
    {
        public static TutorService GetInstance()
        {
            return new TutorService();
        }

        public List<Tutores> ObtenerTutoresPorSocioId(int anyo, int socioId)
        {
            var query = string.Format("SELECT t.* FROM " +
                                      "Tutores t INNER JOIN " +
                                      "CursosSocios cs on cs.SocioId = t.SocioId " +
                                      "WHERE cs.CursoId = {0} AND t.SocioId={1}", anyo, socioId);
            return Connection.DbConnection.Query<Tutores>(query).ToList();
        }

        public List<Tutores> ObtenerTutoresPrincipales(int anyo)
        {
            var query = "SELECT t.* " +
                        "FROM Tutores t INNER JOIN " +
                        "CursosSocios cs on cs.SocioId = t.SocioId " +
                        "WHERE t.EsPrincipal=True AND cs.CursoId =" + anyo;
            return Connection.DbConnection.Query<Tutores>(query).ToList();
        }

        public List<Tutores> BusquedaTutoresPorNombre(string busqueda, int anyo)
        {
            var query = string.Format(@"SELECT t.* 
                            FROM Tutores t INNER JOIN
                                CursosSocios cs on cs.SocioId = t.SocioId 
                            WHERE (instr(1,t.Nombre +"" ""+ t.Apellidos,'{0}')  or instr(1,t.Apellidos,'{0}') ) AND cs.CursoId ={1}",
                busqueda, anyo);
            return Connection.DbConnection.Query<Tutores>(query).ToList();
        }

        public bool Update(Tutores tutor)
        {
            var query = string.Format("Update Tutores Set " +
                                      "Nombre = '{0}'," +
                                      "Apellidos ='{1},'" +
                                      "Telefono = '{2}'" +
                                      "Movil = '{3}'" +
                                      "Email = '{4}'" +
                                      "EsPrincipal = '{5}'" +
                                      "WHERE Id = {6}", tutor.Nombre, tutor.Apellidos, tutor.Telefono, tutor.Movil,
                tutor.Email, tutor.EsPrincipal, tutor.Id);
            return Connection.Execute(query) > 0;
        }

        public bool Insert(Tutores tutor)
        {
            var query = string.Format("INSERT INTO Alumnos " +
                                      "(Nombre,Apellidos, Telefono, Movil, Email, EsPrincipal, SocioId)" +
                                      "VALUES ({0},{1},{2},{3},{4},{5},{6})",
                tutor.Nombre, tutor.Apellidos, tutor.Telefono, tutor.Movil, tutor.Email, tutor.EsPrincipal,
                tutor.SocioId);
            return Connection.Execute(query) > 0;
        }

        public bool Insert(List<Tutores> tutores)
        {
            foreach (var tutor in tutores)
            {
                Insert(tutor);
            }
            return true;
        }
    }
}