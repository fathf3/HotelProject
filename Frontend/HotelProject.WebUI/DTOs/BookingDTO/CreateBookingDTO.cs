using System;

namespace HotelProject.WebUI.DTOs.BookingDTO
{
    public class CreateBookingDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string AdultCount { get; set; }
        public string ChildCount { get; set; }
        public string SpecialRequest { get; set; }
        public int Description { get; set; }
        public string Status { get; set; }
    }
}
