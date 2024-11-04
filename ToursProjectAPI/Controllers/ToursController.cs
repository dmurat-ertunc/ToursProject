using BusinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToursProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToursController : ControllerBase
    {
        private readonly IToursService toursService;
        public ToursController(IToursService toursService)
        {
            this.toursService = toursService;
        }
        [HttpGet]
        public IActionResult GetAllTours()
        {
            var values = toursService.TGetAll();
            return Ok(values);
        }
    }
}
