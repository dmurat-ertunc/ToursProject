using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using ToursProject.Models.Contact;
using ToursProject.Models;
using ToursProject.Models.Session;

namespace ToursProject.Controllers
{
    public class SessionController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;
        public SessionController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel signUpViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(signUpViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:9091/api/session/register", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                // Yanıtı al ve deserialize et
                var responseContent = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<NoDataResult>(responseContent);

                // API'den gelen mesajı ViewBag'e at
                //localstorage yapılacak
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel signInViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(signInViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:9091/api/session/login", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                // Yanıtı al ve deserialize et
                var responseContent = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResponseSingle<LoginResponse>>(responseContent);

                if (result?.Data?.Token != null)
                {
                    return RedirectToAction("Index","HomePage",new {token= result.Data.Token});
                }
            }
            return View();
        }
    }
}
