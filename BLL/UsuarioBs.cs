using System.Collections.Generic;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class UsuarioBs
    {
        private UsuarioDb objDb;

        public UsuarioBs() => objDb = new UsuarioDb();

        public async Task<IEnumerable<Usuario>> Todos() => await objDb.Todos();

        public async Task<Usuario> ObtenerPorId(int id) => await objDb.ObtenerPorId(id);

        public async Task Agregar(Usuario Usuario) => await objDb.Agregar(Usuario);

        public async Task Actualizar(Usuario Usuario) => await objDb.Actualizar(Usuario);

        public async Task Eliminar(int id) => await objDb.Eliminar(id);
    }
}
