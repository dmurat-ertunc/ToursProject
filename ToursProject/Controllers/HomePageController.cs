using Microsoft.AspNetCore.Mvc;

namespace ToursProject.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
