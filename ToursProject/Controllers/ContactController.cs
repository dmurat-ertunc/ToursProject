using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using ToursProject.Models;
using ToursProject.Models.Contact;

namespace ToursProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AddContactViewModel addContactViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(addContactViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:9091/api/contact/sendContact", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                // Yanıtı al ve deserialize et
                var responseContent = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<NoDataResult>(responseContent);

                // API'den gelen mesajı ViewBag'e at
                if (result != null && result.Status)
                {
                    ViewBag.Ok = result.Message;
                }
                else
                {
                    ViewBag.Err = "Bir hata oluştu.";
                }
            }
            return View();
        }
    }
}
