using AutoMapper;
using PokemonApp.Contracts;
using PokemonApp.Dto;

namespace PokemonApp.API.Helper 
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();

        }
    }
}
