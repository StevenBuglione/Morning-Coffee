using System;
using System.Linq;
using AutoMapper;
using Morning_Coffee_Backend.Dtos;
using Morning_Coffee_Backend.Models;

namespace Morning_Coffee_Backend.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt =>
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.HasProfilePic).Url))
                .ForMember(dest => dest.Age, opt =>
                    opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailedDto>()
                .ForMember(dest => dest.PhotoUrl, opt =>
                        opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.HasProfilePic).Url))
                .ForMember(dest => dest.Age, opt =>
                        opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
           
            CreateMap<UserForRegisterDto, User>();

        }
    }
}
