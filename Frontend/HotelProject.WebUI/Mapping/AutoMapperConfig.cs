using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.AboutDTO;
using HotelProject.WebUI.DTOs.AppUserDTO;
using HotelProject.WebUI.DTOs.BookingDTO;
using HotelProject.WebUI.DTOs.HotelServiceDTO;
using HotelProject.WebUI.DTOs.LoginDTO;
using HotelProject.WebUI.DTOs.StaffDTO;
using HotelProject.WebUI.DTOs.SubscribeDTO;
using HotelProject.WebUI.DTOs.TestimonialDTO;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        protected AutoMapperConfig()
        {
            CreateMap<ResultHotelServiceDTO, HotelService>().ReverseMap();
            CreateMap<UpdateHotelServiceDTO, HotelService>().ReverseMap();
            CreateMap<CreateHotelServiceDTO, HotelService>().ReverseMap();
            
            CreateMap<ResultAboutDTO, About>().ReverseMap();
            CreateMap<UpdateAboutDTO, About>().ReverseMap();
            
            
            CreateMap<ResultTestimonialDTO, Testimonial>().ReverseMap();
            
            
            CreateMap<ResultStaffDTO, Staff>().ReverseMap();


            CreateMap<CreateSubscribeDTO, Subscribe>().ReverseMap();


            CreateMap<CreateBookingDTO, Booking>().ReverseMap();


            CreateMap<CreateNewUserDTO, AppUser>().ReverseMap();
            CreateMap<LoginUserDTO, AppUser>().ReverseMap();
        }
    }
}
