using System.Collections.Generic;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class TrabajoBs
    {
        private TrabajoDb objDb;

        public TrabajoBs() => objDb = new TrabajoDb();

        public async Task<IEnumerable<Trabajo>> Todos() => await objDb.Todos();

        public async Task<Trabajo> ObtenerPorId(int id) => await objDb.ObtenerPorId(id);

        public async Task Agregar(Trabajo Trabajo) => await objDb.Agregar(Trabajo);

        public async Task Actualizar(Trabajo Trabajo) => await objDb.Actualizar(Trabajo);

        public async Task Eliminar(int id) => await objDb.Eliminar(id);
    }
}
