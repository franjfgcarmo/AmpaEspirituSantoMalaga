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

        public TutorModel ObtenerTutorById(int id)
        {
            var query = string.Format("SELECT t.* FROM " +
                                      "Tutores t INNER JOIN " +
                                      "CursosSocios cs on cs.SocioId = t.SocioId " +
                                      "WHERE t.Id = {0}", id);
            return Connection.DbConnection.Query<TutorModel>(query).FirstOrDefault();
        }

        public List<TutorModel> ObtenerTutoresPorSocioId(int anyo, int socioId)
        {
            var query = string.Format("SELECT t.* FROM " +
                                      "Tutores t INNER JOIN " +
                                      "CursosSocios cs on cs.SocioId = t.SocioId " +
                                      "WHERE cs.CursoId = {0} AND t.SocioId={1}", anyo, socioId);
            return Connection.DbConnection.Query<TutorModel>(query).ToList();
        }

        public List<TutorModel> ObtenerTutoresPrincipales(int anyo)
        {
            var query = "SELECT t.* " +
                        "FROM Tutores t INNER JOIN " +
                        "CursosSocios cs on cs.SocioId = t.SocioId " +
                        "WHERE t.EsPrincipal=True AND cs.CursoId =" + anyo;
            return Connection.DbConnection.Query<TutorModel>(query).ToList();
        }

        public List<TutorModel> BusquedaTutoresPorNombre(string busqueda, int anyo)
        {
            var query = string.Format(@"SELECT t.* 
                            FROM Tutores t INNER JOIN
                                CursosSocios cs on cs.SocioId = t.SocioId 
                            WHERE (instr(1,t.Nombre +"" ""+ t.Apellidos,'{0}')  or instr(1,t.Apellidos,'{0}') ) AND cs.CursoId ={1}",
                busqueda, anyo);
            return Connection.DbConnection.Query<TutorModel>(query).ToList();
        }

        public bool Update(TutorModel tutor)
        {
            if (tutor.EsPrincipal)
            {
                Connection.Execute(string.Format("Update Tutores Set EsPrincipal = false WHERE SocioId = {0}", tutor.SocioId));
            }

            var query = string.Format("Update Tutores Set " +
                                      "Nombre = '{0}'," +
                                      "Apellidos ='{1}'," +
                                      "Telefono = '{2}'," +
                                      "Movil = '{3}'," +
                                      "Email = '{4}'," +
                                      "EsPrincipal = {5} " +
                                      "WHERE Id = {6}", tutor.Nombre.Trim(), tutor.Apellidos.Trim(),
                tutor.Telefono.Trim(), tutor.Movil.Trim(),
                tutor.Email.Trim(), tutor.EsPrincipal, tutor.Id);
            return Connection.Execute(query) > 0;
        }

        public bool Insert(TutorModel tutor)
        {
            var query = string.Format("INSERT INTO Tutores " +
                                      "(Nombre,Apellidos, Telefono, Movil, Email, EsPrincipal, SocioId)" +
                                      "VALUES ('{0}','{1}','{2}','{3}','{4}',{5},{6})",
                tutor.Nombre, tutor.Apellidos, tutor.Telefono, tutor.Movil, tutor.Email, tutor.EsPrincipal,
                tutor.SocioId);
            return Connection.Execute(query) > 0;
        }

        public bool Insert(List<TutorModel> tutores)
        {
            foreach (var tutor in tutores)
            {
                Insert(tutor);
            }
            return true;
        }
    }
}