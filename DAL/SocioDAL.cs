using Microsoft.Data.SqlClient;
using Entity;
using MAPPER;

namespace DAL
{
    public class SocioDAL
    {
        private const string Select =
            "SELECT S.ID_SOCIO, S.NOMBRE, S.APELLIDO, S.DNI, S.EMAIL, S.TELEFONO, S.FECHA_ALTA, S.ACTIVO, " +
            "C.ID_CATEGORIA, C.DESCRIPCION AS CATEGORIA, C.CUOTA_BASE " +
            "FROM SOCIO S INNER JOIN CATEGORIA C ON C.ID_CATEGORIA = S.ID_CATEGORIA";

        public List<Socio> ObtenerTodos()
        {
            try
            {
                var lista = new List<Socio>();
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(Select + " ORDER BY S.APELLIDO, S.NOMBRE", conn))
                {
                    conn.Open();
                    using (var dr = cmd.ExecuteReader())
                        while (dr.Read())
                            lista.Add(SocioMapper.Map(dr));
                }
                return lista;
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al consultar los socios.", ex);
            }
        }

        public List<Socio> Buscar(string texto)
        {
            try
            {
                var lista = new List<Socio>();

                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    Select + " WHERE S.APELLIDO LIKE @Busqueda OR S.DNI LIKE @Busqueda " +
                    "ORDER BY S.APELLIDO, S.NOMBRE", conn))
                {
                    cmd.Parameters.AddWithValue("@Busqueda", "%" + texto + "%");

                    conn.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(SocioMapper.Map(dr));
                        }
                    }
                }

                return lista;
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException(
                    "Error al buscar socios.", ex);
            }
        }

        public Socio? ObtenerPorId(int id)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(Select + " WHERE S.ID_SOCIO = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (var dr = cmd.ExecuteReader())
                        return dr.Read() ? SocioMapper.Map(dr) : null;
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al consultar el socio.", ex);
            }
        }

        public bool ExisteDni(string dni, int idExcluido)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM SOCIO WHERE DNI = @Dni AND ID_SOCIO <> @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Dni", dni);
                    cmd.Parameters.AddWithValue("@Id", idExcluido);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al verificar el DNI.", ex);
            }
        }

        public int Insertar(Socio s)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "INSERT INTO SOCIO (NOMBRE, APELLIDO, DNI, EMAIL, TELEFONO, FECHA_ALTA, ACTIVO, ID_CATEGORIA) " +
                    "OUTPUT INSERTED.ID_SOCIO " +
                    "VALUES (@Nombre, @Apellido, @Dni, @Email, @Telefono, @FechaAlta, @Activo, @IdCategoria)", conn))
                {
                    SocioMapper.CargarParametros(cmd, s);
                    cmd.Parameters.AddWithValue("@FechaAlta", s.FechaAlta);
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al registrar el socio.", ex);
            }
        }

        public void Modificar(Socio s)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "UPDATE SOCIO SET NOMBRE = @Nombre, APELLIDO = @Apellido, DNI = @Dni, EMAIL = @Email, " +
                    "TELEFONO = @Telefono, ACTIVO = @Activo, ID_CATEGORIA = @IdCategoria WHERE ID_SOCIO = @Id", conn))
                {
                    SocioMapper.CargarParametros(cmd, s);
                    cmd.Parameters.AddWithValue("@Id", s.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al modificar el socio.", ex);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand("DELETE FROM SOCIO WHERE ID_SOCIO = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al eliminar el socio.", ex);
            }
        }
    }
}
