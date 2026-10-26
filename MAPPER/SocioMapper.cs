using System.Data;
using Entity;

namespace MAPPER
{
    public static class SocioMapper
    {
        public static Socio Map(IDataRecord dr) => new Socio
        {
            Id = (int)dr["ID_SOCIO"],
            Nombre = (string)dr["NOMBRE"],
            Apellido = (string)dr["APELLIDO"],
            Dni = (string)dr["DNI"],
            Email = (string)dr["EMAIL"],
            Telefono = dr["TELEFONO"] == DBNull.Value ? null : (string)dr["TELEFONO"],
            FechaAlta = (DateTime)dr["FECHA_ALTA"],
            Activo = (bool)dr["ACTIVO"],
            Categoria = CategoriaMapper.Map(dr)
        };

        public static void CargarParametros(Microsoft.Data.SqlClient.SqlCommand cmd, Socio s)
        {
            cmd.Parameters.AddWithValue("@Nombre", s.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", s.Apellido);
            cmd.Parameters.AddWithValue("@Dni", s.Dni);
            cmd.Parameters.AddWithValue("@Email", s.Email);
            cmd.Parameters.AddWithValue("@Telefono", (object?)s.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Activo", s.Activo);
            cmd.Parameters.AddWithValue("@IdCategoria", s.Categoria.Id);
        }
    }
}
