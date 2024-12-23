using Microsoft.AspNetCore.Mvc;

namespace ToursProject.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
