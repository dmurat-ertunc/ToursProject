using BusinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToursProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketSoldController : ControllerBase
    {
        private readonly ITicketSoldService ticketSoldService;
        public TicketSoldController(ITicketSoldService ticketSoldService)
        {
            this.ticketSoldService = ticketSoldService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTicketSolds()
        {
            var values = await ticketSoldService.TGetAll();
            return Ok(values);
        }
    }
}
