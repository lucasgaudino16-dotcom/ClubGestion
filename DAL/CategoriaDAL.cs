using System.Data;
using Microsoft.Data.SqlClient;
using Entity;
using MAPPER;

namespace DAL
{
    public class CategoriaDAL
    {
        private const string Select = "SELECT ID_CATEGORIA, DESCRIPCION AS CATEGORIA, CUOTA_BASE FROM CATEGORIA";

        public List<Categoria> ObtenerTodas()
        {
            try
            {
                var tabla = new DataTable();
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var da = new SqlDataAdapter(Select + " ORDER BY DESCRIPCION", conn))
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

        public Categoria? ObtenerPorId(int id)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(Select + " WHERE ID_CATEGORIA = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (var dr = cmd.ExecuteReader())
                        return dr.Read() ? CategoriaMapper.Map(dr) : null;
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al consultar la categoría.", ex);
            }
        }

        public bool ExisteDescripcion(string descripcion, int idExcluido)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM CATEGORIA WHERE DESCRIPCION = @Descripcion AND ID_CATEGORIA <> @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@Id", idExcluido);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al verificar la descripción de la categoría.", ex);
            }
        }

        public int ContarSocios(int idCategoria)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM SOCIO WHERE ID_CATEGORIA = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idCategoria);
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al contar los socios de la categoría.", ex);
            }
        }

        public int Insertar(Categoria c)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "INSERT INTO CATEGORIA (DESCRIPCION, CUOTA_BASE) OUTPUT INSERTED.ID_CATEGORIA VALUES (@Descripcion, @CuotaBase)", conn))
                {
                    cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion);
                    cmd.Parameters.AddWithValue("@CuotaBase", c.CuotaBase);
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al registrar la categoría.", ex);
            }
        }

        public void Modificar(Categoria c)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "UPDATE CATEGORIA SET DESCRIPCION = @Descripcion, CUOTA_BASE = @CuotaBase WHERE ID_CATEGORIA = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion);
                    cmd.Parameters.AddWithValue("@CuotaBase", c.CuotaBase);
                    cmd.Parameters.AddWithValue("@Id", c.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al modificar la categoría.", ex);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand("DELETE FROM CATEGORIA WHERE ID_CATEGORIA = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al eliminar la categoría.", ex);
            }
        }
    }
}
