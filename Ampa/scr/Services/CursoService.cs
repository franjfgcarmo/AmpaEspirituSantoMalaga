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
            var query = @"SELECT Max(Id) as Id,Descripcion FROM Cursos GROUP BY Id,Descripcion  HAVING MAX(id) = (SELECT MAX(id) FROM Cursos)";
            return Connection.DbConnection.Query<CursoModel>(query).FirstOrDefault();
        }

        public bool NuevoCurso()
        {
            var query = "SELECT Max(Id) as Id From Cursos";
            var result = Connection.DbConnection.Query<int>(query).FirstOrDefault();
            var anyo = result + 1;
            var descripción = string.Format("{0}/{1}", anyo, (anyo + 1));
            var queryInsert = string.Format("INSERT INTO Cursos (Id,Descripcion) VALUES ({0},'{1}')", anyo, descripción);
            return Connection.Execute(queryInsert)>0;
        }
    }
}