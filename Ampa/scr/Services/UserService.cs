using System.Linq;
using Ampa.Classes;
using Dapper;

namespace Ampa.Services
{
    public class UserService : Service
    {
        public static UserService GetInstance()
        {
            return new UserService();
        }

        public bool ExisteUsuario(string nombre, string contrasena)
        {
            var query = string.Format("Select * From Usuarios WHERE Nombre = '{0}' And [Password] = '{1}'", nombre,
                contrasena);
            var usuario = Connection.DbConnection.Query<Usuarios>(query).FirstOrDefault();
            return usuario != null;
        }
    }
}