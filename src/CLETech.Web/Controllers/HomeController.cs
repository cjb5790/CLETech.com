using Microsoft.AspNet.Mvc;

namespace CLETech.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}