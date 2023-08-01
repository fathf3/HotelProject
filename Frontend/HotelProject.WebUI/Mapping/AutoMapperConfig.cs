using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.HotelServiceDTO;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        protected AutoMapperConfig()
        {
            CreateMap<ResultHotelServiceDTO, HotelService>().ReverseMap();
            CreateMap<UpdateHotelServiceDTO, HotelService>().ReverseMap();
            CreateMap<CreateHotelServiceDTO, HotelService>().ReverseMap();
        }
    }
}
