using HotelProject.WebUI.DTOs.BookingDTO;
using HotelProject.WebUI.DTOs.HotelServiceDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private string link = "http://localhost:5000/api/Booking/";

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async  Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(link);
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDTO>>(jsonData);
                return View(values);
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ApprovedReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var bookingResponseMessage = await client.GetAsync(link+ id);
            
            if (bookingResponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await bookingResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ApprovedReservationDTO>(jsonData);
                values.Status = "Onaylandı";
                jsonData = JsonConvert.SerializeObject(values);
                StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync(link, stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
                
            }
            else {
                return View();
            }
            
        }



    }
}
