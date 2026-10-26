using System.Data;
using Microsoft.Data.SqlClient;
using Entity;
using MAPPER;

namespace DAL
{
    public class CategoriaDAL
    {
        public List<Categoria> ObtenerTodas()
        {
            try
            {
                var tabla = new DataTable();
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var da = new SqlDataAdapter(
                    "SELECT ID_CATEGORIA, DESCRIPCION AS CATEGORIA, CUOTA_BASE FROM CATEGORIA ORDER BY DESCRIPCION", conn))
                {
                    da.Fill(tabla);
                }
                return CategoriaMapper.MapLista(tabla);
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al consultar las categorías.", ex);
            }
        }
    }
}
