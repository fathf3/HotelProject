using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string link = "http://localhost:5000/api/DashboardWidget/";

        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMesage = await client.GetAsync(link + "StaffCount");
            var client2 = _httpClientFactory.CreateClient();
            var responseMesage2 = await client2.GetAsync(link + "BookingCount");
            var client3 = _httpClientFactory.CreateClient();
            var responseMesage3 = await client3.GetAsync(link + "RoomCount");

            var jsonData = await responseMesage.Content.ReadAsStringAsync();
            ViewBag.StaffCount = jsonData;
            var jsonData2 = await responseMesage2.Content.ReadAsStringAsync();
            ViewBag.BookingCount = jsonData2;
            var jsonData3 = await responseMesage3.Content.ReadAsStringAsync();
            ViewBag.roomCount = jsonData3;


            return View();
        }
    }
}
