using System.Transactions;
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

        public void Insertar(Actividad a)
        {
            try
            {
                Validar(a);
                if (_dal.ExisteNombre(a.Nombre, 0))
                    throw new ReglaNegocioException("Ya existe una actividad llamada " + a.Nombre + ".");

                using (var scope = new TransactionScope())
                {
                    a.Id = _dal.Insertar(a);
                    scope.Complete();
                }
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al registrar la actividad.", ex);
            }
        }

        public void Modificar(Actividad a)
        {
            try
            {
                ObtenerPorId(a.Id);
                Validar(a);
                if (_dal.ExisteNombre(a.Nombre, a.Id))
                    throw new ReglaNegocioException("Ya existe otra actividad llamada " + a.Nombre + ".");

                var inscriptos = _dal.ContarInscriptos(a.Id);
                if (a.Cupo < inscriptos)
                    throw new ReglaNegocioException("La actividad ya tiene " + inscriptos + " inscriptos: el cupo no puede ser menor.");

                using (var scope = new TransactionScope())
                {
                    _dal.Modificar(a);
                    scope.Complete();
                }
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al modificar la actividad.", ex);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                var a = ObtenerPorId(id);
                if (_dal.ContarInscriptos(id) > 0)
                    throw new ReglaNegocioException("No se puede eliminar " + a.Nombre + " porque tiene socios inscriptos.");

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
                throw new Exception("Error inesperado al eliminar la actividad.", ex);
            }
        }

        private void Validar(Actividad a)
        {
            a.Nombre = a.Nombre.Trim();

            if (a.Nombre.Length < 3)
                throw new ReglaNegocioException("El nombre de la actividad debe tener al menos 3 caracteres.");
            if (a.Nombre.Length > 80)
                throw new ReglaNegocioException("El nombre de la actividad no puede superar los 80 caracteres.");
            if (a.Arancel < 0)
                throw new ReglaNegocioException("El arancel no puede ser negativo.");
            if (a.Cupo <= 0)
                throw new ReglaNegocioException("El cupo debe ser mayor que cero.");
        }
    }
}
