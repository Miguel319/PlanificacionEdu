using System.Collections.Generic;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class AsignaturaBs
    {
        private AsignaturaDb objDb;

        public AsignaturaBs() => objDb = new AsignaturaDb();

        public async Task<IEnumerable<Asignatura>> Todos() => await objDb.Todos();

        public async Task<Asignatura> ObtenerPorId(int id) => await objDb.ObtenerPorId(id);

        public async Task Agregar(Asignatura Asignatura) => await objDb.Agregar(Asignatura);

        public async Task Actualizar(Asignatura Asignatura) => await objDb.Actualizar(Asignatura);

        public async Task Eliminar(int id) => await objDb.Eliminar(id);
    }
}
