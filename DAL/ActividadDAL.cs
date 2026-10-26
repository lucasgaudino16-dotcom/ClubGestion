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
    }
}
