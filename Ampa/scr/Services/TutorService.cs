using System.Collections.Generic;
using System.Linq;
using Ampa.Classes;
using Dapper;

namespace Ampa.Services
{
    public class TutorService:Service
    {
        public static TutorService GetInstance()
        {
            return new TutorService();
        }

        public List<Tutores>ObtenerTutoresPrincipales(int anyo)
        {
            var query = @"SELECT t.* FROM Tutores t INNER JOIN CursosSocios cs on cs.SocioId = t.SocioId WHERE t.EsPrincipal=True AND cs.CursoId =" + anyo;
            return Connection.DbConnection.Query<Tutores>(query).ToList();
        }

        public List<Tutores> BusquedaTutoresPorNombre(string busqueda, int anyo)
        {
            var query =string.Format(@"SELECT t.* 
                            FROM Tutores t INNER JOIN
                                CursosSocios cs on cs.SocioId = t.SocioId 
                            WHERE (instr(1,t.Nombre +"" ""+ t.Apellidos,'{0}')  or instr(1,t.Apellidos,'{0}') ) AND cs.CursoId ={1}", busqueda, anyo);
            return Connection.DbConnection.Query<Tutores>(query).ToList();
        }
    }
}