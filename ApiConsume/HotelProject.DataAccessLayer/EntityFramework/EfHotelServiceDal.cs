using HotelProject.DataAccessLayer.Abstracts;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfHotelServiceDal : GenericRepository<HotelService>, IHotelServiceDal
    {
        public EfHotelServiceDal(Context context) : base(context)
        {
        }
    }
}
