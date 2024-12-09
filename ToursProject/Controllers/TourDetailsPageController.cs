using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ToursProject.Models;
using ToursProject.Models.ToursModel;

namespace ToursProject.Controllers
{
    public class TourDetailsPageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public TourDetailsPageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index(long id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync($"http://localhost:9091/api/tours/getById/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                // JSON'u ApiResponse<ToursListViewModel> olarak deserialize et
                var response = JsonConvert.DeserializeObject<ApiResponseSingle<ToursListViewModel>>(jsonData);

                //// Gelen data içeriğini al
                var tour = response?.Data;

                // View'e "tour" modelini gönder
                return View(tour);
            }

            // Eğer hata varsa boş bir view dön
            return View();
        }
    }
}
