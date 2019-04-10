using BLL;
using BOL;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PlanificacionEdu.Controllers
{
    public class PlanificacionController : Controller
    {
        private PlanificacionBs objBs;
        private MetodoBs metodoObjBs;
        private SistematizacionBs sistematizacionObjBs;
        private TrabajoBs trabajoObjBs;

        public PlanificacionController()
        {
            objBs = new PlanificacionBs();
            metodoObjBs = new MetodoBs();
            sistematizacionObjBs = new SistematizacionBs();
            trabajoObjBs = new TrabajoBs();
        }

        // GET: Planificacion
        public async Task<ActionResult> Index() => View( await objBs.Todos());

        [HttpGet]
        public async Task<ActionResult> Agregar()
        {
            ViewBag.MetodoId = new SelectList(await metodoObjBs.Todos(), "Id", "Descripcion");
            ViewBag.SistematizacionId = new SelectList(await sistematizacionObjBs.Todos(), "Id", "Descripcion");
            ViewBag.TrabajoId = new SelectList(await trabajoObjBs.Todos(), "Id", "Descripcion");

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Agregar(Planificacion planificacion)
        {
            if (ModelState.IsValid)
            {
                await objBs.Agregar(planificacion);
                return RedirectToAction("Index","Planificacion");
            }
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Editar(int id)
        {
            ViewBag.MetodoId = new SelectList(await metodoObjBs.Todos(), "Id", "Descripcion");
            ViewBag.SistematizacionId = new SelectList(await sistematizacionObjBs.Todos(), "Id", "Descripcion");
            ViewBag.TrabajoId = new SelectList(await trabajoObjBs.Todos(), "Id", "Descripcion");

            return View(await objBs.ObtenerPorId(id));
        }

        [HttpPost]
        public async Task<ActionResult> Editar(Planificacion planificacion)
        {
            if (ModelState.IsValid)
            {
                await objBs.Actualizar(planificacion);
                return RedirectToAction("Index", "Planificacion");
            }
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Eliminar(int id)
        {
            try
            {
                await objBs.Eliminar(id);
                TempData["Msg"] = "¡Planificación eliminada satisfactoriamente!";
                return RedirectToAction("Index", "Planificacion");
            }
            catch
            {
                TempData["Msg"] = "¡Error al eliminar planificación!";
                return RedirectToAction("Index", "Planificacion");
            }
        }
    }
}