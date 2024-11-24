using BusinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToursProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServicesService servicesService;
        public ServicesController(IServicesService servicesService)
        {
            this.servicesService = servicesService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllService() 
        {
            var values = await servicesService.TGetAll();
            return Ok(values);
        }
    }
}
