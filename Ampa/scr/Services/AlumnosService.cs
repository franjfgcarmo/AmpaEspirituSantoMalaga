using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ampa.Classes;
using Ampa.ConnectionProvider;
using Dapper;

namespace Ampa.Services
{
    public class AlumnosService:Service
    {
        public static AlumnosService GetInstance()
        {
            return new AlumnosService();
        }

        public List<Alumnos> ObtenerAlumnosPorSocioId(int socioId)
        {
            var query = @"SELECT * FROM Alumnos WHERE SocioId =" + socioId;
            return Connection.DbConnection.Query<Alumnos>(query).ToList();
        }
    }
}
