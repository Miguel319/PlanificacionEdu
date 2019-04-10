using System.Collections.Generic;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class SistematizacionBs
    {
        private SistematizacionDb objDb;

        public SistematizacionBs() => objDb = new SistematizacionDb();

        public async Task<IEnumerable<Sistematizacion>> Todos() => await objDb.Todos();

        public async Task<Sistematizacion> ObtenerPorId(int id) => await objDb.ObtenerPorId(id);

        public async Task Agregar(Sistematizacion Sistematizacion) => await objDb.Agregar(Sistematizacion);

        public async Task Actualizar(Sistematizacion Sistematizacion) => await objDb.Actualizar(Sistematizacion);

        public async Task Eliminar(int id) => await objDb.Eliminar(id);
    }
}
