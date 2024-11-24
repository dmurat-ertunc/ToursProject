using BusinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToursProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourTimeController : ControllerBase
    {
        private readonly ITourTimeService tourTimeService;
        public TourTimeController(ITourTimeService tourTimeService)
        {
            this.tourTimeService = tourTimeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTourTimes()
        {
            var values = await tourTimeService.TGetAll();
            return Ok(values);
        }
    }
}
