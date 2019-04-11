using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;
using BLL;
using BOL;

namespace PlanificacionEdu.Controllers
{
    public class IniciarSesionController : Controller
    {
        public UsuarioBs objBs;

        public IniciarSesionController() => objBs = new UsuarioBs();

        // GET: IniciarSesion
        public ActionResult Index() => View();

        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            try
            {
                if (Membership.ValidateUser(usuario.Email, usuario.Contra))
                {
                    FormsAuthentication.SetAuthCookie(usuario.Email, false);
                    return RedirectToAction("Index", "Planificacion");
                }
                else
                {
                    TempData["Msg"] = "Error al iniciar sesión. Verifique sus credenciales y vuelva a intentarlo";
                    return View();
                }
            }
            catch
            {
                TempData["Msg"] = "Error al iniciar sesión. Verifique sus credenciales y vuelva a intentarlo";
                return View();
            }
            
        }

    }
}