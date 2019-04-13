using System.Threading.Tasks;
using System.Web.Mvc;
using BLL;
using BOL;
using Rotativa;

namespace PlanificacionEdu.Controllers
{
    public class AsignaturaController : Controller
    {
        private AsignaturaBs objBs;

        public AsignaturaController() => objBs = new AsignaturaBs();

        // GET: Asignatura
        public async Task<ActionResult> Index() => View(await objBs.Todos());

        public ActionResult Agregar() => View();

        [HttpPost]
        public async Task<ActionResult> Agregar(Asignatura asignatura)
        {
            if (ModelState.IsValid)
            {
                await objBs.Agregar(asignatura);
                return RedirectToAction("Index", "Asignatura");
            }

            return View();
        }

        public async Task<ActionResult> Editar(int id) => View(await objBs.ObtenerPorId(id));

        [HttpPost]
        public async Task<ActionResult> Editar(Asignatura asignatura)
        {
            if (ModelState.IsValid)
            {
                await objBs.Actualizar(asignatura);
                return RedirectToAction("Index", "Asignatura");
            }
            return View(asignatura);
        }

        [HttpGet]
        public async Task<ActionResult> Detalles(int id) =>  View(await objBs.ObtenerPorId(id));

        public ActionResult ImprimirListado() => new ActionAsPdf("Index");

        [HttpGet]
        public async Task<ActionResult> Eliminar(int id)
        {
            try
            {
                await objBs.Eliminar(id);
                return RedirectToAction("Index", "Asignatura");
            }
            catch
            {
                TempData["ErrAsignatura"] = "Error: esta asignatura pertenece a una planificación. Desvincúlela para poder eliminarla.";
                return RedirectToAction("Index", "Asignatura");

            }
        }
    }
}