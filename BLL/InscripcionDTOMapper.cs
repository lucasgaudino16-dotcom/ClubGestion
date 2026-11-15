using Entity;

namespace BLL
{
    public static class InscripcionDTOMapper
    {
        public static InscripcionDTO Map(Inscripcion i) => new InscripcionDTO
        {
            IdSocio = i.Socio.Id,
            IdActividad = i.Actividad.Id,
            Socio = i.Socio.ToString(),
            Dni = i.Socio.Dni,
            Categoria = i.Socio.Categoria.Descripcion,
            Actividad = i.Actividad.Nombre,
            Fecha = i.FechaInscripcion,
            Arancel = i.ArancelAplicado
        };

        public static List<InscripcionDTO> Map(List<Inscripcion> lista)
        {
            var salida = new List<InscripcionDTO>();
            foreach (var i in lista)
                salida.Add(Map(i));
            return salida;
        }
    }
}
