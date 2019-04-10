using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using BOL;

namespace DAL
{
    public class MetodoDb : DbBase
    {
        public async Task<IEnumerable<Metodo>> Todos() =>  await db.Metodo.ToListAsync();

        public async Task<Metodo> ObtenerPorId(int id) => await db.Metodo.FindAsync(id);
        
        public async Task Agregar(Metodo Metodo)
        {
            db.Metodo.Add(Metodo);
            await db.SaveChangesAsync();
        }

        public async Task Actualizar(Metodo Metodo)
        {
            db.Entry(Metodo).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var Metodo = await db.Metodo.FindAsync(id);
            db.Metodo.Remove(Metodo);
            await db.SaveChangesAsync();
        }
    }
}
