using System.Data;
using Entity;

namespace MAPPER
{
    public static class CategoriaMapper
    {
        public static Categoria Map(IDataRecord dr) => new Categoria
        {
            Id = (int)dr["ID_CATEGORIA"],
            Descripcion = (string)dr["CATEGORIA"],
            CuotaBase = (decimal)dr["CUOTA_BASE"]
        };

        public static List<Categoria> MapLista(DataTable tabla)
        {
            var lista = new List<Categoria>();
            using (var dr = tabla.CreateDataReader())
                while (dr.Read())
                    lista.Add(Map(dr));
            return lista;
        }
    }
}
