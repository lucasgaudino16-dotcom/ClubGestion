using System.Text.RegularExpressions;
using DAL;
using Entity;

namespace BLL
{
    public class SocioBLL
    {
        private readonly SocioDAL _dal = new SocioDAL();
        private readonly InscripcionDAL _inscripcionDal = new InscripcionDAL();

        public List<Socio> ObtenerTodos()
        {
            try
            {
                return _dal.ObtenerTodos();
            }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al consultar los socios.", ex);
            }
        }

        public List<Socio> Buscar(string texto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(texto))
                    return _dal.ObtenerTodos();

                return _dal.Buscar(texto.Trim());
            }
            catch (AccesoDatosException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al buscar socios.", ex);
            }
        }

        public Socio ObtenerPorId(int id)
        {
            try
            {
                var s = _dal.ObtenerPorId(id);
                if (s == null)
                    throw new ReglaNegocioException("El socio no existe.");
                return s;
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al consultar el socio.", ex);
            }
        }

        public void Insertar(Socio s)
        {
            try
            {
                Validar(s);
                if (_dal.ExisteDni(s.Dni, 0))
                    throw new ReglaNegocioException("Ya existe un socio con el DNI " + s.Dni + ".");
                s.FechaAlta = DateTime.Now;
                s.Id = _dal.Insertar(s);
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al registrar el socio.", ex);
            }
        }

        public void Modificar(Socio s)
        {
            try
            {
                ObtenerPorId(s.Id);
                Validar(s);
                if (_dal.ExisteDni(s.Dni, s.Id))
                    throw new ReglaNegocioException("Ya existe otro socio con el DNI " + s.Dni + ".");
                _dal.Modificar(s);
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al modificar el socio.", ex);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                ObtenerPorId(id);
                if (_inscripcionDal.ObtenerPorSocio(id).Count > 0)
                    throw new ReglaNegocioException("El socio tiene inscripciones. Dalo de baja en lugar de eliminarlo.");
                _dal.Eliminar(id);
            }
            catch (ReglaNegocioException) { throw; }
            catch (AccesoDatosException) { throw; }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al eliminar el socio.", ex);
            }
        }

        private void Validar(Socio s)
        {
            s.Nombre = s.Nombre.Trim();
            s.Apellido = s.Apellido.Trim();
            s.Dni = s.Dni.Trim();
            s.Email = s.Email.Trim();
            s.Telefono = string.IsNullOrWhiteSpace(s.Telefono) ? null : s.Telefono.Trim();

            if (s.Nombre.Length < 2)
                throw new ReglaNegocioException("El nombre debe tener al menos 2 caracteres.");
            if (s.Apellido.Length < 2)
                throw new ReglaNegocioException("El apellido debe tener al menos 2 caracteres.");
            if (!Regex.IsMatch(s.Dni, @"^\d{7,8}$"))
                throw new ReglaNegocioException("El DNI debe tener 7 u 8 dígitos, sin puntos.");
            if (!Regex.IsMatch(s.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ReglaNegocioException("El email no tiene un formato válido.");
            if (s.Telefono != null && !Regex.IsMatch(s.Telefono, @"^[\d\s\-\+\(\)]{6,20}$"))
                throw new ReglaNegocioException("El teléfono solo admite dígitos, espacios, guiones y paréntesis.");
            if (s.Categoria == null || s.Categoria.Id <= 0)
                throw new ReglaNegocioException("Elegí una categoría.");
        }
    }
}
