using Microsoft.AspNetCore.Mvc;

namespace ToursProject.Controllers
{
    public class ToursController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
