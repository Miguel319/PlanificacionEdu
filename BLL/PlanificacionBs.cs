using System.Collections.Generic;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class PlanificacionBs
    {
        private PlanificacionDb objDb;

        public PlanificacionBs() => objDb = new PlanificacionDb();

        public async Task<IEnumerable<Planificacion>> Todos() => await objDb.Todos();

        public async Task<Planificacion> ObtenerPorId(int id) => await objDb.ObtenerPorId(id);

        public async Task Agregar(Planificacion Planificacion) => await objDb.Agregar(Planificacion);

        public async Task Actualizar(Planificacion Planificacion) => await objDb.Actualizar(Planificacion);

        public async Task Eliminar(int id) => await objDb.Eliminar(id);
    }
}
