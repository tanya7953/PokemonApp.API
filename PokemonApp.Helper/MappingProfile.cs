using AutoMapper;
using PokemonApp.Contracts;
using PokemonApp.Dto;

namespace PokemonApp.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDto>();

        }
    }
}
