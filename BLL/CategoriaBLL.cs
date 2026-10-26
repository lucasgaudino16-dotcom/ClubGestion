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
    }
}
