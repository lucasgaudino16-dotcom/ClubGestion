namespace Entity
{
    public class Actividad
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Arancel { get; set; }
        public int Cupo { get; set; }

        public override string ToString() => Nombre;
    }
}
