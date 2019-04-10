using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class TrabajoDb : DbBase
    {
        public async Task<IEnumerable<Trabajo>> Todos() => await db.Trabajo.ToListAsync();

        public async Task<Trabajo> ObtenerPorId(int id) => await db.Trabajo.FindAsync(id);

        public async Task Agregar(Trabajo Trabajo)
        {
            db.Trabajo.Add(Trabajo);
            await db.SaveChangesAsync();
        }

        public async Task Actualizar(Trabajo Trabajo)
        {
            db.Entry(Trabajo).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var Trabajo = await db.Trabajo.FindAsync(id);
            db.Trabajo.Remove(Trabajo);
            await db.SaveChangesAsync();
        }
    }
}
