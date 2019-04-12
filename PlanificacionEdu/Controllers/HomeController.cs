using System.Web.Mvc;

namespace PlanificacionEdu.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index() => View();
      

    }
}