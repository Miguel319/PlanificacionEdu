using BLL;
using System.Threading.Tasks;
using System.Web.Mvc;
using BOL;

namespace PlanificacionEdu.Controllers
{
    public class IndicadorController : Controller
    {
        private PlanificacionBs planificacionObjBs;
        private IndicadorBs indicadorObjBs;

        public IndicadorController()
        {
            planificacionObjBs = new PlanificacionBs();
            indicadorObjBs = new IndicadorBs();
        }

        // GET: Indicador
        public async Task<ActionResult> Index() => View(await indicadorObjBs.Todos());

        public async Task<ActionResult> Agregar()
        {
            ViewBag.PlanificacionId = new SelectList(await planificacionObjBs.Todos(), "Id", "Descripcion");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Agregar(Indicador indicador)
        {
            if (ModelState.IsValid)
            {
                await indicadorObjBs.Agregar(indicador);
                return RedirectToAction("Index", "Indicador");
            }

            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Editar(int id)
        {
            ViewBag.PlanificacionId = new SelectList(await planificacionObjBs.Todos(), "Id", "Descripcion");
            return View(await indicadorObjBs.ObtenerPorId(id));
        }

        public async Task<ActionResult> Editar(Indicador indicador)
        {
            if (ModelState.IsValid)
            {
                await indicadorObjBs.Actualizar(indicador);
                return RedirectToAction("Index", "Indicador");
            }

            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Detalles(int id) => View(await indicadorObjBs.ObtenerPorId(id));

        [HttpGet]
        public async Task<ActionResult> Eliminar(int id)
        {
            try
            {
                await indicadorObjBs.Eliminar(id);
                return RedirectToAction("Index", "Indicador");
            }
            catch
            {
                return RedirectToAction("Index", "Indicador");
            }
        }
    }
}