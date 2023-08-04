using HotelProject.BusinessLayer.Abstracts;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelServiceController : ControllerBase
    {
        private readonly IHotelServiceService _hotelServiceService;

        public HotelServiceController(IHotelServiceService hotelServiceService)
        {
            _hotelServiceService = hotelServiceService;
        }

        [HttpGet]
        public IActionResult HotelServiceList()
        {
            var values = _hotelServiceService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddHotelService(HotelService hotelService)
        {
            _hotelServiceService.TInsert(hotelService);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHotelService(int id)
        {
            var values = _hotelServiceService.TGetByID(id);
            _hotelServiceService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateHotelService(HotelService hotelService)
        {
            _hotelServiceService.TUpdate(hotelService);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetHotelService(int id)
        {
            var values = _hotelServiceService.TGetByID(id);

            return Ok(values);
        }



    }
}
