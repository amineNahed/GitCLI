using Microsoft.AspNetCore.Mvc;

namespace Atelier2.Controllers
{
    public class WebForm2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
