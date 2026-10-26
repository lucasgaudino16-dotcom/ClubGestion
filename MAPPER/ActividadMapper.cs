using System.Data;
using Entity;

namespace MAPPER
{
    public static class ActividadMapper
    {
        public static Actividad Map(IDataRecord dr) => new Actividad
        {
            Id = (int)dr["ID_ACTIVIDAD"],
            Nombre = (string)dr["ACTIVIDAD"],
            Arancel = (decimal)dr["ARANCEL"],
            Cupo = (int)dr["CUPO"]
        };
    }
}
