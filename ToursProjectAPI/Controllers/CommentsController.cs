using BusinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToursProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentsService commentsService;
        public CommentsController(ICommentsService commentsService)
        {
            this.commentsService = commentsService;
        }
        [HttpGet]
        public IActionResult GetAllComment()
        {
            var values = commentsService.TGetAll();
            return Ok(values);
        }
    }
}
