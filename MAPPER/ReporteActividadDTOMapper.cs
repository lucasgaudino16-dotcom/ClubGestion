using Entity;
using System.Data;

namespace MAPPER
{
    public static class ReporteActividadDTOMapper
    {
        public static ReporteActividadDTO Map(IDataRecord dr) => new ReporteActividadDTO
        {
            NombreActividad = (string)dr["NOMBRE"],
            CupoMaximo = (int)dr["CUPO"],
            CantidadInscriptos = (int)dr["CANTIDAD_INSCRIPTOS"],
            ValorCuota = (decimal)dr["ARANCEL"],
            RecaudacionTotal = (decimal)dr["RECAUDACION"]
        };
    }
}
