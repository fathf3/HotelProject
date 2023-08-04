using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Booking
    {
        public int BookingID { get; set; }
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
