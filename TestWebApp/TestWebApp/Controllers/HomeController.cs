using System.Web.Mvc;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page test"

            return View();
        }
    }
}
