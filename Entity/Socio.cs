namespace Entity
{
    public class Socio
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; } = true;
        public Categoria Categoria { get; set; } = new Categoria();

        public override string ToString() => Apellido + ", " + Nombre;
    }
}
