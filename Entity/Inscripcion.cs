namespace Entity
{
    public class Inscripcion
    {
        public Socio Socio { get; set; } = new Socio();
        public Actividad Actividad { get; set; } = new Actividad();
        public DateTime FechaInscripcion { get; set; }
        public decimal ArancelAplicado { get; set; }
    }

    public class InscripcionDTO
    {
        public string Socio { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Actividad { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public decimal Arancel { get; set; }
    }
}
