using BusinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToursProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService socialMediaService;
        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            this.socialMediaService = socialMediaService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSocialMedia()
        {
            var values = await socialMediaService.TGetAll();
            return Ok(values);
        }
    }
}
