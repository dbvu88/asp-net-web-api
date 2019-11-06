using AutoMapper;
using OnlineSociety.Models.DataModels;
using OnlineSociety.Models.ViewModels;

namespace OnlineSociety.App_Start
{
    internal class PetMappingProfile : Profile
    {
        public PetMappingProfile()
        {
            CreateMap<Pet, PetModel>();
        }
    }
}