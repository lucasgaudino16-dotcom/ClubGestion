using DAL;
using Entity;

namespace BLL
{
    public class ActividadBLL
    {
        private readonly ActividadDAL _dal = new ActividadDAL();

        public List<Actividad> ObtenerTodas()
        {
            try
            {
                return _dal.ObtenerTodas();
            }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al consultar las actividades.", ex);
            }
        }

        public Actividad ObtenerPorId(int id)
        {
            try
            {
                var a = _dal.ObtenerPorId(id);
                if (a == null)
                    throw new ReglaNegocioException("La actividad no existe.");
                return a;
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al consultar la actividad.", ex);
            }
        }

        public int CuposLibres(Actividad a)
        {
            try
            {
                return a.Cupo - _dal.ContarInscriptos(a.Id);
            }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al calcular los cupos.", ex);
            }
        }
    }
}
