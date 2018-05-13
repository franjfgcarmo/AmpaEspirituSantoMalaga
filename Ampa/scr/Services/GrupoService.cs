using System.Collections.Generic;
using System.Linq;
using Ampa.Modelo;
using Dapper;

namespace Ampa.Services
{
    public class GrupoService : Service
    {
        public static GrupoService GetInstance()
        {
            return new GrupoService();
        }

        public List<GrupoModel> ObtenerGrupos()
        {
            return Connection.DbConnection.Query<GrupoModel>("SELECT * FROM GRUPOS").ToList();
        }
    }
}