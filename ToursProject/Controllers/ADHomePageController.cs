using Microsoft.AspNetCore.Mvc;

namespace ToursProject.Controllers
{
    public class ADHomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
