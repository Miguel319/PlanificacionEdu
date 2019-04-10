using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class SistematizacionDb : DbBase
    {
        public async Task<IEnumerable<Sistematizacion>> Todos() => await db.Sistematizacion.ToListAsync();

        public async Task<Sistematizacion> ObtenerPorId(int id) => await db.Sistematizacion.FindAsync(id);

        public async Task Agregar(Sistematizacion Sistematizacion)
        {
            db.Sistematizacion.Add(Sistematizacion);
            await db.SaveChangesAsync();
        }

        public async Task Actualizar(Sistematizacion Sistematizacion)   
        {
            db.Entry(Sistematizacion).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var Sistematizacion = await db.Sistematizacion.FindAsync(id);
            db.Sistematizacion.Remove(Sistematizacion);
            await db.SaveChangesAsync();
        }
    }
}
