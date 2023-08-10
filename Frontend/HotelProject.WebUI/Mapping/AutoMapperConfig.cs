using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.AboutDTO;
using HotelProject.WebUI.DTOs.AppUserDTO;
using HotelProject.WebUI.DTOs.BookingDTO;
using HotelProject.WebUI.DTOs.ContactDTO;
using HotelProject.WebUI.DTOs.GuestDTO;
using HotelProject.WebUI.DTOs.HotelServiceDTO;
using HotelProject.WebUI.DTOs.LoginDTO;
using HotelProject.WebUI.DTOs.RoomDTO;
using HotelProject.WebUI.DTOs.StaffDTO;
using HotelProject.WebUI.DTOs.SubscribeDTO;
using HotelProject.WebUI.DTOs.TestimonialDTO;
using HotelProject.WebUI.DTOs.WorkLocationDTO;

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
            CreateMap<CreateAboutDTO, About>().ReverseMap();

            CreateMap<ResultRoomDTO, Room>().ReverseMap();
            CreateMap<UpdateRoomDTO, Room>().ReverseMap();
            CreateMap<CreateRoomDTO, Room>().ReverseMap();

            CreateMap<ResultGuestDTO, Guest>().ReverseMap();
            CreateMap<UpdateGuestDTO, Guest>().ReverseMap();
            CreateMap<CreateGuestDTO, Guest>().ReverseMap();

            CreateMap<CreateWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<ResultWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<UpdateWorkLocationDto, WorkLocation>().ReverseMap();

            CreateMap<ResultTestimonialDTO, Testimonial>().ReverseMap();
            
            
            CreateMap<ResultStaffDTO, Staff>().ReverseMap();


            CreateMap<CreateSubscribeDTO, Subscribe>().ReverseMap();
            CreateMap<CreateContactDTO, Contact>().ReverseMap();
            CreateMap<CreateSendMessageDTO, SendMessage>().ReverseMap();
            CreateMap<ResultSendMessageDTO, SendMessage>().ReverseMap();
            CreateMap<GetMessageByIDDto, SendMessage>().ReverseMap();
            CreateMap<InboxContactDto, Contact>().ReverseMap();
            

            CreateMap<CreateBookingDTO, Booking>().ReverseMap();
            CreateMap<ResultBookingDTO, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDTO, Booking>().ReverseMap();


            CreateMap<CreateNewUserDTO, AppUser>().ReverseMap();
            CreateMap<LoginUserDTO, AppUser>().ReverseMap();
        }
    }
}
