namespace Entity
{
    public class AccesoDatosException : Exception
    {
        public AccesoDatosException(string mensaje) : base(mensaje) { }
        public AccesoDatosException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }

    public class ReglaNegocioException : Exception
    {
        public ReglaNegocioException(string mensaje) : base(mensaje) { }
        public ReglaNegocioException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}
