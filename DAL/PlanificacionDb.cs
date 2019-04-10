using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class PlanificacionDb : DbBase
    {
        public async Task<IEnumerable<Planificacion>> Todos() => await db.Planificacion.ToListAsync();

        public async Task<Planificacion> ObtenerPorId(int id) => await db.Planificacion.FindAsync(id);

        public async Task Agregar(Planificacion Planificacion)
        {
            db.Planificacion.Add(Planificacion);
            await db.SaveChangesAsync();
        }

        public async Task Actualizar(Planificacion Planificacion)
        {
            db.Entry(Planificacion).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var Planificacion = await db.Planificacion.FindAsync(id);
            db.Planificacion.Remove(Planificacion);
            await db.SaveChangesAsync();
        }
    }
}
