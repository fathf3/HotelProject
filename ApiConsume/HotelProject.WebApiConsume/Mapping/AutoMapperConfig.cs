﻿using AutoMapper;
using HotelProject.DTOLayer.DTOs.RoomDTO;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApiConsume.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddRoomDTO, Room>();
            CreateMap<Room, AddRoomDTO>();

            CreateMap<UpdateRoomDTO, Room>().ReverseMap();
        }
    }
}
