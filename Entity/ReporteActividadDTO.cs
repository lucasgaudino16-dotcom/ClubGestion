namespace Entity;

public class ReporteActividadDTO
{
    public string NombreActividad { get; set; } = string.Empty;
    public int CupoMaximo { get; set; }
    public int CantidadInscriptos { get; set; }
    public int CuposLibres => CupoMaximo - CantidadInscriptos;
    public decimal ValorCuota { get; set; }
    public decimal RecaudacionTotal => CantidadInscriptos * ValorCuota;
}
