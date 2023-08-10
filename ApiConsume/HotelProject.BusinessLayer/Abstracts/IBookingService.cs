using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstracts
{
    public interface IBookingService : IGenericService<Booking>
    {
        int GetBookingCount();
        List<Booking> Last6Bookinng();
    }
}
