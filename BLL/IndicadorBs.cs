using System.Collections.Generic;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class IndicadorBs
    {
        private IndicadorDb objDb;

        public IndicadorBs() => objDb = new IndicadorDb();

        public async Task<IEnumerable<Indicador>> Todos() => await objDb.Todos();

        public async Task<Indicador> ObtenerPorId(int id) => await objDb.ObtenerPorId(id);

        public async Task Agregar(Indicador indicador) => await objDb.Agregar(indicador);

        public async Task Actualizar(Indicador indicador) => await objDb.Actualizar(indicador);

        public async Task Eliminar(int id) => await objDb.Eliminar(id);
    }
}
