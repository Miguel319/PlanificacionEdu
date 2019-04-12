using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class AsignaturaDb : DbBase
    {
        public async Task<IEnumerable<Asignatura>> Todos() => await db.Asignatura.ToListAsync();

        public async Task<Asignatura> ObtenerPorId(int id) => await db.Asignatura.FindAsync(id);

        public async Task Agregar(Asignatura Asignatura)
        {
            db.Asignatura.Add(Asignatura);
            await db.SaveChangesAsync();
        }

        public async Task Actualizar(Asignatura Asignatura)
        {
            db.Entry(Asignatura).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var Asignatura = await db.Asignatura.FindAsync(id);
            db.Asignatura.Remove(Asignatura);
            await db.SaveChangesAsync();
        }
    }
}