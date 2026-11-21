using System.ComponentModel;

namespace Entity;

public class ReporteActividadDTO
{
    [DisplayName("Actividad")]
    public string NombreActividad { get; set; } = string.Empty;

    [DisplayName("Cupo")]
    public int CupoMaximo { get; set; }

    [DisplayName("Inscriptos")]
    public int CantidadInscriptos { get; set; }

    [DisplayName("Cupos libres")]
    public int CuposLibres => CupoMaximo - CantidadInscriptos;

    [DisplayName("Arancel actual")]
    public decimal ValorCuota { get; set; }

    [DisplayName("Recaudación")]
    public decimal RecaudacionTotal { get; set; }
}
