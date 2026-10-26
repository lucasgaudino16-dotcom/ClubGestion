using System.Configuration;
using Entity;

namespace DAL
{
    public static class Conexion
    {
        public static string Cadena
        {
            get
            {
                var cs = ConfigurationManager.ConnectionStrings["MiConexion"];
                if (cs == null || string.IsNullOrWhiteSpace(cs.ConnectionString))
                    throw new AccesoDatosException("No se encontró la cadena de conexión MiConexion en App.config.");
                return cs.ConnectionString;
            }
        }
    }
}
