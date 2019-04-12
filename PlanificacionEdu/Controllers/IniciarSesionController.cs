using BLL;
using BOL;
using System.Web.Mvc;
using System.Web.Security;

namespace PlanificacionEdu.Controllers
{
    [AllowAnonymous]
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
                    TempData["ErrLog"] = "Error al iniciar sesión. Verifique sus credenciales y vuelva a intentarlo";
                    return View();
                }
            }
            catch
            {
                TempData["ErrLog"] = "Error al iniciar sesión. Verifique sus credenciales y vuelva a intentarlo";
                return View();
            }
        }

        public ActionResult CerrarSesion(Usuario usuario)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}