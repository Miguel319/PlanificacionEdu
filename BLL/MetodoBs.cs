using System.Collections.Generic;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class MetodoBs
    {
        private MetodoDb objDb;

        public MetodoBs() => objDb = new MetodoDb();

        public async Task<IEnumerable<Metodo>> Todos() => await objDb.Todos();

        public async Task<Metodo> ObtenerPorId(int id) => await objDb.ObtenerPorId(id);

        public async Task Agregar(Metodo Metodo) => await objDb.Agregar(Metodo);

        public async Task Actualizar(Metodo Metodo) => await objDb.Actualizar(Metodo);

        public async Task Eliminar(int id) => await objDb.Eliminar(id);
    }
}
