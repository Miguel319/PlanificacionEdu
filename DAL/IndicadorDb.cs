using BOL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DAL
{
    public class IndicadorDb : DbBase
    {
        public async Task<IEnumerable<Indicador>> Todos() => await db.Indicador.ToListAsync();

        public async Task<Indicador> ObtenerPorId(int id) => await db.Indicador.FindAsync(id);

        public async Task Agregar(Indicador Indicador)
        {
            db.Indicador.Add(Indicador);
            await db.SaveChangesAsync();
        }

        public async Task Actualizar(Indicador Indicador)
        {
            db.Entry(Indicador).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var Indicador = await db.Indicador.FindAsync(id);
            db.Indicador.Remove(Indicador);
            await db.SaveChangesAsync();
        }
    }
}
