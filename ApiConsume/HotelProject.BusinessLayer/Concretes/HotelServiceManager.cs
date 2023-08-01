using HotelProject.BusinessLayer.Abstracts;
using HotelProject.DataAccessLayer.Abstracts;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concretes
{
    public class HotelServiceManager : IHotelServiceService
    {
        private readonly IHotelServiceDal _hotelserviceDal;

        public HotelServiceManager(IHotelServiceDal hotelserviceDal)
        {
            _hotelserviceDal = hotelserviceDal;
        }

        public void TDelete(HotelService t)
        {
            _hotelserviceDal.Delete(t);
        }

        public HotelService TGetByID(int id)
        {
            return _hotelserviceDal.GetByID(id);
        }

        public List<HotelService> TGetList()
        {
            return _hotelserviceDal.GetList();
        }

        public void TInsert(HotelService t)
        {
            _hotelserviceDal.Insert(t);
        }

        public void TUpdate(HotelService t)
        {
            _hotelserviceDal.Update(t);
        }
    }
}
