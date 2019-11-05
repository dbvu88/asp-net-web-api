using AutoMapper;
using OnlineSociety.Model;
using OnlineSociety.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSociety.Model.MappingProfiles
{
    class UserMappingProfile: Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserModel>();
        }
    }
}