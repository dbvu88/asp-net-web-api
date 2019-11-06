using AutoMapper;
using OnlineSociety.Models.DataModels;
using OnlineSociety.Models.ViewModels;

namespace OnlineSociety.Models.MappingProfiles
{
    class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserModel>()
                .ForMember(
                userModel => userModel.Clan,
                opt => opt.MapFrom(user => user.Clan.Name));
        }
    }
}
