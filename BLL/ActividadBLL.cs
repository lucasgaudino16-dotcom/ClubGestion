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
        public void Insertar(Actividad actividad)
        {
            try
            {
                if (actividad == null)
                    throw new ReglaNegocioException("La actividad no puede ser nula.");

                if (string.IsNullOrWhiteSpace(actividad.Nombre))
                    throw new ReglaNegocioException("Debe ingresar el nombre de la actividad.");

                if (actividad.Arancel < 0)
                    throw new ReglaNegocioException("El arancel no puede ser negativo.");

                if (actividad.Cupo <= 0)
                    throw new ReglaNegocioException("El cupo debe ser mayor a cero.");

                actividad.Nombre = actividad.Nombre.Trim();

                _dal.Insertar(actividad);
            }
            catch (ReglaNegocioException)
            {
                throw;
            }
            catch (AccesoDatosException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al registrar la actividad.", ex);
            }
        }
        public void Modificar(Actividad actividad)
        {
            try
            {
                if (actividad == null)
                    throw new ReglaNegocioException("La actividad no puede ser nula.");

                if (actividad.Id <= 0)
                    throw new ReglaNegocioException("Debe seleccionar una actividad válida.");

                if (string.IsNullOrWhiteSpace(actividad.Nombre))
                    throw new ReglaNegocioException("Debe ingresar el nombre de la actividad.");

                if (actividad.Arancel < 0)
                    throw new ReglaNegocioException("El arancel no puede ser negativo.");

                if (actividad.Cupo <= 0)
                    throw new ReglaNegocioException("El cupo debe ser mayor a cero.");

                int inscriptos = _dal.ContarInscriptos(actividad.Id);

                if (actividad.Cupo < inscriptos)
                    throw new ReglaNegocioException(
                        $"El cupo no puede ser menor a los {inscriptos} socios inscriptos.");

                actividad.Nombre = actividad.Nombre.Trim();

                _dal.Modificar(actividad);
            }
            catch (ReglaNegocioException)
            {
                throw;
            }
            catch (AccesoDatosException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al modificar la actividad.", ex);
            }
        }
        public void Eliminar(int idActividad)
        {
            try
            {
                if (idActividad <= 0)
                    throw new ReglaNegocioException(
                        "Debe seleccionar una actividad válida.");

                var actividad = _dal.ObtenerPorId(idActividad);

                if (actividad == null)
                    throw new ReglaNegocioException(
                        "La actividad seleccionada no existe.");

                int inscriptos = _dal.ContarInscriptos(idActividad);

                if (inscriptos > 0)
                    throw new ReglaNegocioException(
                        $"No se puede eliminar la actividad '{actividad.Nombre}' " +
                        $"porque tiene {inscriptos} socio(s) inscripto(s).");

                _dal.Eliminar(idActividad);
            }
            catch (ReglaNegocioException)
            {
                throw;
            }
            catch (AccesoDatosException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error inesperado al eliminar la actividad.", ex);
            }
        }
    }
}
