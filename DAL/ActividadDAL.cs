using Microsoft.Data.SqlClient;
using Entity;
using MAPPER;

namespace DAL
{
    public class ActividadDAL
    {
        private const string Select = "SELECT ID_ACTIVIDAD, NOMBRE AS ACTIVIDAD, ARANCEL, CUPO FROM ACTIVIDAD";

        public List<Actividad> ObtenerTodas()
        {
            try
            {
                var lista = new List<Actividad>();
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(Select + " ORDER BY NOMBRE", conn))
                {
                    conn.Open();
                    using (var dr = cmd.ExecuteReader())
                        while (dr.Read())
                            lista.Add(ActividadMapper.Map(dr));
                }
                return lista;
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al consultar las actividades.", ex);
            }
        }

        public Actividad? ObtenerPorId(int id)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(Select + " WHERE ID_ACTIVIDAD = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    using (var dr = cmd.ExecuteReader())
                        return dr.Read() ? ActividadMapper.Map(dr) : null;
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al consultar la actividad.", ex);
            }
        }

        public int ContarInscriptos(int idActividad)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM INSCRIPCION WHERE ID_ACTIVIDAD = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idActividad);
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al contar los inscriptos.", ex);
            }
        }
        public void Insertar(Actividad actividad)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    @"INSERT INTO ACTIVIDAD (NOMBRE, ARANCEL, CUPO)
              VALUES (@Nombre, @Arancel, @Cupo)", conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", actividad.Nombre);
                    cmd.Parameters.AddWithValue("@Arancel", actividad.Arancel);
                    cmd.Parameters.AddWithValue("@Cupo", actividad.Cupo);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException(
                    "Error al registrar la actividad.", ex);
            }
        }
        public void Modificar(Actividad actividad)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    @"UPDATE ACTIVIDAD
              SET NOMBRE = @Nombre,
                  ARANCEL = @Arancel,
                  CUPO = @Cupo
              WHERE ID_ACTIVIDAD = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", actividad.Nombre);
                    cmd.Parameters.AddWithValue("@Arancel", actividad.Arancel);
                    cmd.Parameters.AddWithValue("@Cupo", actividad.Cupo);
                    cmd.Parameters.AddWithValue("@Id", actividad.Id);

                    conn.Open();

                    int filas = cmd.ExecuteNonQuery();

                    if (filas == 0)
                        throw new AccesoDatosException(
                            "No se encontró la actividad que desea modificar.");
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException(
                    "Error al modificar la actividad.", ex);
            }
        }
        public void Eliminar(int idActividad)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "DELETE FROM ACTIVIDAD WHERE ID_ACTIVIDAD = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idActividad);

                    conn.Open();

                    int filas = cmd.ExecuteNonQuery();

                    if (filas == 0)
                        throw new AccesoDatosException(
                            "No se encontró la actividad que desea eliminar.");
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException(
                    "Error al eliminar la actividad.", ex);
            }
        }
    }
}
