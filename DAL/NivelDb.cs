using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class NivelDb : DbBase
    {
        public async Task<IEnumerable<Nivel>> Todos() => await db.Nivel.ToListAsync();

        public async Task<Nivel> ObtenerPorId(int id) => await db.Nivel.FindAsync(id);

        public async Task Agregar(Nivel Nivel)
        {
            db.Nivel.Add(Nivel);
            await db.SaveChangesAsync();
        }

        public async Task Actualizar(Nivel Nivel)
        {
            db.Entry(Nivel).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var Nivel = await db.Nivel.FindAsync(id);
            db.Nivel.Remove(Nivel);
            await db.SaveChangesAsync();
        }
    }
}
