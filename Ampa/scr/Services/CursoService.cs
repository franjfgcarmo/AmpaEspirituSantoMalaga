using System.Linq;
using Ampa.Modelo;
using Dapper;

namespace Ampa.Services
{
    public class CursoService : Service
    {
        public static CursoService GetInstance()
        {
            return new CursoService();
        }

        public CursoModel ObtenerCursoAcademico()
        {
            var query = @"SELECT Max(Id) as Id,Descripcion FROM Cursos GROUP BY Id,Descripcion";
            return Connection.DbConnection.Query<CursoModel>(query).FirstOrDefault();
        }
    }
}