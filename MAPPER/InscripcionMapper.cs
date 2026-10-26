using System.Data;
using Entity;

namespace MAPPER
{
    public static class InscripcionMapper
    {
        public static Inscripcion Map(IDataRecord dr) => new Inscripcion
        {
            Socio = SocioMapper.Map(dr),
            Actividad = ActividadMapper.Map(dr),
            FechaInscripcion = (DateTime)dr["FECHA_INSCRIPCION"],
            ArancelAplicado = (decimal)dr["ARANCEL_APLICADO"]
        };
    }
}
