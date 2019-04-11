using System.Threading.Tasks;
using System.Web.Mvc;
using BLL;
using BOL;

namespace PlanificacionEdu.Controllers
{
    public class RegistroController : Controller
    {
        private UsuarioBs objBs;
        private IndicadorBs indicadorObjBs;

        public RegistroController()
        {
            objBs = new UsuarioBs();
            indicadorObjBs = new IndicadorBs();
        }

        // GET: Registro
        public async Task<ActionResult> Index()
        {
            ViewBag.NivelId = new SelectList(await indicadorObjBs.Todos(), "Id", "Descripcion");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                await objBs.Agregar(usuario);
                return RedirectToAction("Index", "Planificacion");
            }

            TempData["Msg"] = "Error al registrar usuario. Inténtelo de nuevo.";
            return View();
        }

    }
}