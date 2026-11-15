using System.Transactions;
using DAL;
using Entity;

namespace BLL
{
    public class InscripcionBLL
    {
        private readonly InscripcionDAL _dal = new InscripcionDAL();
        private readonly ActividadDAL _actividadDal = new ActividadDAL();
        private readonly SocioDAL _socioDal = new SocioDAL();

        public void Inscribir(Socio socio, List<Actividad> actividades)
        {
            try
            {
                if (socio == null || socio.Id <= 0)
                    throw new ReglaNegocioException("Elegí un socio.");
                if (!socio.Activo)
                    throw new ReglaNegocioException("El socio está dado de baja.");
                if (actividades == null || actividades.Count == 0)
                    throw new ReglaNegocioException("Elegí al menos una actividad.");

                foreach (var a in actividades)
                    if (_dal.Existe(socio.Id, a.Id))
                        throw new ReglaNegocioException(socio + " ya está inscripto en " + a.Nombre + ".");

                using (var scope = new TransactionScope())
                {
                    foreach (var a in actividades)
                    {
                        if (_actividadDal.ContarInscriptos(a.Id) >= a.Cupo)
                            throw new ReglaNegocioException("No quedan cupos en " + a.Nombre + ". No se registró ninguna inscripción.");

                        _dal.Insertar(socio.Id, a.Id, DateTime.Now, a.Arancel);
                    }

                    scope.Complete();
                }
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al inscribir al socio.", ex);
            }
        }

        public void Desinscribir(Socio socio, Actividad actividad)
        {
            try
            {
                if (socio == null || socio.Id <= 0)
                    throw new ReglaNegocioException("Elegí un socio.");
                if (actividad == null || actividad.Id <= 0)
                    throw new ReglaNegocioException("Elegí una actividad.");
                if (!_dal.Existe(socio.Id, actividad.Id))
                    throw new ReglaNegocioException(socio + " no está inscripto en " + actividad.Nombre + ".");

                using (var scope = new TransactionScope())
                {
                    _dal.Eliminar(socio.Id, actividad.Id);
                    scope.Complete();
                }
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al eliminar la inscripción.", ex);
            }
        }

        public void Desinscribir(int idSocio, int idActividad)
        {
            try
            {
                var socio = _socioDal.ObtenerPorId(idSocio);
                if (socio == null)
                    throw new ReglaNegocioException("El socio no existe.");

                var actividad = _actividadDal.ObtenerPorId(idActividad);
                if (actividad == null)
                    throw new ReglaNegocioException("La actividad no existe.");

                Desinscribir(socio, actividad);
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al eliminar la inscripción.", ex);
            }
        }

        public List<InscripcionDTO> ObtenerPorActividad(int idActividad)
        {
            try
            {
                return InscripcionDTOMapper.Map(_dal.ObtenerPorActividad(idActividad));
            }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al consultar los inscriptos.", ex);
            }
        }

        public List<InscripcionDTO> ObtenerPorSocio(int idSocio)
        {
            try
            {
                return InscripcionDTOMapper.Map(_dal.ObtenerPorSocio(idSocio));
            }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al consultar las inscripciones del socio.", ex);
            }
        }
    }
}
