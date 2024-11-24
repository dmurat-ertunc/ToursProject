
using BusinesLayer.Abstract;
using DTOLayer.DTO;
using EntityLayer.Concrete;
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
        public async Task<IActionResult> GetAllTours()
        {
            var tour = await toursService.TGetAll();
            return Ok(tour);
        }
    }
}
