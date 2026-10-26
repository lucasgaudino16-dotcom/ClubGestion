using Microsoft.Data.SqlClient;
using Entity;
using MAPPER;

namespace DAL
{
    public class InscripcionDAL
    {
        private const string Select =
            "SELECT I.FECHA_INSCRIPCION, I.ARANCEL_APLICADO, " +
            "S.ID_SOCIO, S.NOMBRE, S.APELLIDO, S.DNI, S.EMAIL, S.TELEFONO, S.FECHA_ALTA, S.ACTIVO, " +
            "C.ID_CATEGORIA, C.DESCRIPCION AS CATEGORIA, C.CUOTA_BASE, " +
            "A.ID_ACTIVIDAD, A.NOMBRE AS ACTIVIDAD, A.ARANCEL, A.CUPO " +
            "FROM INSCRIPCION I " +
            "INNER JOIN SOCIO S ON S.ID_SOCIO = I.ID_SOCIO " +
            "INNER JOIN CATEGORIA C ON C.ID_CATEGORIA = S.ID_CATEGORIA " +
            "INNER JOIN ACTIVIDAD A ON A.ID_ACTIVIDAD = I.ID_ACTIVIDAD";

        public List<Inscripcion> ObtenerPorActividad(int idActividad)
        {
            try
            {
                return Listar(Select + " WHERE I.ID_ACTIVIDAD = @Id ORDER BY S.APELLIDO, S.NOMBRE", idActividad);
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al consultar los inscriptos de la actividad.", ex);
            }
        }

        public List<Inscripcion> ObtenerPorSocio(int idSocio)
        {
            try
            {
                return Listar(Select + " WHERE I.ID_SOCIO = @Id ORDER BY A.NOMBRE", idSocio);
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al consultar las inscripciones del socio.", ex);
            }
        }

        public bool Existe(int idSocio, int idActividad)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM INSCRIPCION WHERE ID_SOCIO = @Socio AND ID_ACTIVIDAD = @Actividad", conn))
                {
                    cmd.Parameters.AddWithValue("@Socio", idSocio);
                    cmd.Parameters.AddWithValue("@Actividad", idActividad);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al verificar la inscripción.", ex);
            }
        }

        public void Insertar(int idSocio, int idActividad, DateTime fecha, decimal arancel)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "INSERT INTO INSCRIPCION (ID_SOCIO, ID_ACTIVIDAD, FECHA_INSCRIPCION, ARANCEL_APLICADO) " +
                    "VALUES (@Socio, @Actividad, @Fecha, @Arancel)", conn))
                {
                    cmd.Parameters.AddWithValue("@Socio", idSocio);
                    cmd.Parameters.AddWithValue("@Actividad", idActividad);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Arancel", arancel);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al registrar la inscripción.", ex);
            }
        }

        public void Eliminar(int idSocio, int idActividad)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "DELETE FROM INSCRIPCION WHERE ID_SOCIO = @Socio AND ID_ACTIVIDAD = @Actividad", conn))
                {
                    cmd.Parameters.AddWithValue("@Socio", idSocio);
                    cmd.Parameters.AddWithValue("@Actividad", idActividad);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al eliminar la inscripción.", ex);
            }
        }

        private List<Inscripcion> Listar(string sql, int id)
        {
            var lista = new List<Inscripcion>();
            using (var conn = new SqlConnection(Conexion.Cadena))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                using (var dr = cmd.ExecuteReader())
                    while (dr.Read())
                        lista.Add(InscripcionMapper.Map(dr));
            }
            return lista;
        }
    }
}
