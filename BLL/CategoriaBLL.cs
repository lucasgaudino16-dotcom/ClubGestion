using System.Transactions;
using DAL;
using Entity;

namespace BLL
{
    public class CategoriaBLL
    {
        private readonly CategoriaDAL _dal = new CategoriaDAL();

        public List<Categoria> ObtenerTodas()
        {
            try
            {
                return _dal.ObtenerTodas();
            }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al consultar las categorías.", ex);
            }
        }

        public Categoria ObtenerPorId(int id)
        {
            try
            {
                var c = _dal.ObtenerPorId(id);
                if (c == null)
                    throw new ReglaNegocioException("La categoría no existe.");
                return c;
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al consultar la categoría.", ex);
            }
        }

        public void Insertar(Categoria c)
        {
            try
            {
                Validar(c);
                if (_dal.ExisteDescripcion(c.Descripcion, 0))
                    throw new ReglaNegocioException("Ya existe una categoría llamada " + c.Descripcion + ".");

                using (var scope = new TransactionScope())
                {
                    c.Id = _dal.Insertar(c);
                    scope.Complete();
                }
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al registrar la categoría.", ex);
            }
        }

        public void Modificar(Categoria c)
        {
            try
            {
                ObtenerPorId(c.Id);
                Validar(c);
                if (_dal.ExisteDescripcion(c.Descripcion, c.Id))
                    throw new ReglaNegocioException("Ya existe otra categoría llamada " + c.Descripcion + ".");

                using (var scope = new TransactionScope())
                {
                    _dal.Modificar(c);
                    scope.Complete();
                }
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al modificar la categoría.", ex);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                var c = ObtenerPorId(id);
                var socios = _dal.ContarSocios(id);
                if (socios > 0)
                    throw new ReglaNegocioException("No se puede eliminar " + c.Descripcion + " porque tiene " + socios + " socio(s). Reasignalos a otra categoría primero.");

                using (var scope = new TransactionScope())
                {
                    _dal.Eliminar(id);
                    scope.Complete();
                }
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al eliminar la categoría.", ex);
            }
        }

        private void Validar(Categoria c)
        {
            if (c == null)
                throw new ReglaNegocioException("No hay datos de la categoría.");

            c.Descripcion = (c.Descripcion ?? string.Empty).Trim();

            if (c.Descripcion.Length < 3)
                throw new ReglaNegocioException("La descripción de la categoría debe tener al menos 3 caracteres.");
            if (c.Descripcion.Length > 50)
                throw new ReglaNegocioException("La descripción de la categoría no puede superar los 50 caracteres.");
            if (c.CuotaBase < 0)
                throw new ReglaNegocioException("La cuota base no puede ser negativa.");
        }
    }
}
