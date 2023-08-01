using HotelProject.WebUI.DTOs.HotelServiceDTO;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class HotelServiceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private string link = "http://localhost:5000/api/HotelService/";
        public HotelServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(link);
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultHotelServiceDTO>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> AddHotelService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddStaff(CreateHotelServiceDTO createHotelService)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createHotelService);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync(link, stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }






    }
}
