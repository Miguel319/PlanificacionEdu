using System.Threading.Tasks;
using System.Web.Mvc;
using BLL;
using BOL;

namespace PlanificacionEdu.Controllers
{
    [AllowAnonymous]
    public class RegistroController : Controller
    {
        private UsuarioBs objBs;
        private NivelBs nivelObjBs;

        public RegistroController()
        {
            objBs = new UsuarioBs();
            nivelObjBs = new NivelBs();
        }

        // GET: Registro
        public async Task<ActionResult> Index()
        {
            ViewBag.NivelId = new SelectList(await nivelObjBs.Todos(), "Id", "Descripcion");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(Usuario usuario)
        {
            ViewBag.NivelId = new SelectList(await nivelObjBs.Todos(), "Id", "Descripcion");

            if (ModelState.IsValid)
            {
                await objBs.Agregar(usuario);
                return RedirectToAction("Index", "Planificacion");
            }
            return View();
        }

    }
}