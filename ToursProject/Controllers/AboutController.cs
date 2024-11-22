using Microsoft.AspNetCore.Mvc;

namespace ToursProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
