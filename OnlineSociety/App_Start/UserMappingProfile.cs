﻿using AutoMapper;
using OnlineSociety.Models.DataModels;
using OnlineSociety.Models.ViewModels;

namespace OnlineSociety.App_Start
{
    internal class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserModel>();
        }
    }
}