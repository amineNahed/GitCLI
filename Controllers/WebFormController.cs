using Microsoft.AspNetCore.Mvc;

namespace Atelier2.Controllers
{
    public class WebFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
