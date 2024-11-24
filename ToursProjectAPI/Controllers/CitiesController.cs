using BusinesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ToursProjectAPI.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICitiesService citiesService;

        public CitiesController(ICitiesService citiesService)
        {
            this.citiesService = citiesService;
        }
        [HttpGet]
        public async Task<IActionResult> GetCities() {
            var values = await citiesService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCities(Cities cities)
        {
            citiesService.TInsert(cities);
            return Ok();
        }
    }
}
