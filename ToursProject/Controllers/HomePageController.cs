using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using ToursProject.Models;
using ToursProject.Models.ToursModel;

namespace ToursProject.Controllers
{
    public class HomePageController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;
        public HomePageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
   
            var responseMessage = await client.GetAsync("http://localhost:9091/api/tours/getAll");


            if (responseMessage.IsSuccessStatusCode)  // eğer doğru ise değer 200-299 arası bir değer döner
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<ApiResponse<ToursListViewModel>>(jsonData);
                var values = response?.Data; // Eğer JSON doğru parse edildiyse, "Data" kısmını alır.
                return View(values);
            }
            return View();
        }
    }
}
