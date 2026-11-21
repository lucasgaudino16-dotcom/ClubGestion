using Entity;
using MAPPER;
using Microsoft.Data.SqlClient;

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

        public bool ExisteNombre(string nombre, int idExcluido)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM ACTIVIDAD WHERE NOMBRE = @Nombre AND ID_ACTIVIDAD <> @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Id", idExcluido);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al verificar el nombre de la actividad.", ex);
            }
        }

        public int Insertar(Actividad a)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "INSERT INTO ACTIVIDAD (NOMBRE, ARANCEL, CUPO) " +
                    "OUTPUT INSERTED.ID_ACTIVIDAD " +
                    "VALUES (@Nombre, @Arancel, @Cupo)", conn))
                {
                    ActividadMapper.CargarParametros(cmd, a);
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al registrar la actividad.", ex);
            }
        }

        public void Modificar(Actividad a)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand(
                    "UPDATE ACTIVIDAD SET NOMBRE = @Nombre, ARANCEL = @Arancel, CUPO = @Cupo " +
                    "WHERE ID_ACTIVIDAD = @Id", conn))
                {
                    ActividadMapper.CargarParametros(cmd, a);
                    cmd.Parameters.AddWithValue("@Id", a.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al modificar la actividad.", ex);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (var conn = new SqlConnection(Conexion.Cadena))
                using (var cmd = new SqlCommand("DELETE FROM ACTIVIDAD WHERE ID_ACTIVIDAD = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al eliminar la actividad.", ex);
            }
        }

        public List<ReporteActividadDTO> ObtenerReporte(int? idActividad)
        {
            try
            {
                List<ReporteActividadDTO> lista = new List<ReporteActividadDTO>();

                string sql = @"
                    SELECT 
                        a.NOMBRE,
                        a.CUPO,
                        a.ARANCEL,
                        COUNT(i.ID_SOCIO) AS CANTIDAD_INSCRIPTOS,
                        ISNULL(SUM(i.ARANCEL_APLICADO), 0) AS RECAUDACION
                    FROM ACTIVIDAD a
                    LEFT JOIN INSCRIPCION i ON a.ID_ACTIVIDAD = i.ID_ACTIVIDAD
                    WHERE (@IdActividad IS NULL OR a.ID_ACTIVIDAD = @IdActividad)
                    GROUP BY a.ID_ACTIVIDAD, a.NOMBRE, a.CUPO, a.ARANCEL
                    ORDER BY a.NOMBRE;";

                    using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdActividad", (object?)idActividad ?? DBNull.Value);

                        conn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                                lista.Add(ReporteActividadDTOMapper.Map(dr));
                        }
                    }

                return lista;
            }
            catch (SqlException ex)
            {
                throw new AccesoDatosException("Error al consultar el reporte de inscriptos y recaudaciones.", ex);
            }
        }

    }
}
