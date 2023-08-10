using HotelProject.BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApiConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IRoomService _roomService;

        public DashboardWidgetController(IStaffService staffService, IBookingService bookingService, IRoomService roomService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _roomService = roomService;
        }

        [HttpGet("StaffCount")]
        public IActionResult StaffCount()
        {
            return Ok(_staffService.TGetStaffCount());
        }
        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            return Ok(_bookingService.GetBookingCount());
        }
        [HttpGet("RoomCount")]
        public IActionResult RoomCount()
        {
            return Ok(_roomService.GetRoomCount());
        }
        [HttpGet("Last6Bookinng")]
        public IActionResult Last6Bookinng()
        {
            var values = _bookingService.Last6Bookinng();

            return Ok(values);
        }


    }
}
