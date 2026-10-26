namespace Entity
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal CuotaBase { get; set; }

        public override string ToString() => Descripcion;
    }
}
