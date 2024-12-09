using Microsoft.AspNetCore.Mvc;

namespace ToursProject.Controllers
{
    public class DestinationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
