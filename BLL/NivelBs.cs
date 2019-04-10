using System.Collections.Generic;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class NivelBs
    {
        private NivelDb objDb;

        public NivelBs() => objDb = new NivelDb();

        public async Task<IEnumerable<Nivel>> Todos() => await objDb.Todos();

        public async Task<Nivel> ObtenerPorId(int id) => await objDb.ObtenerPorId(id);

        public async Task Agregar(Nivel Nivel) => await objDb.Agregar(Nivel);

        public async Task Actualizar(Nivel Nivel) => await objDb.Actualizar(Nivel);

        public async Task Eliminar(int id) => await objDb.Eliminar(id);
    }
}
