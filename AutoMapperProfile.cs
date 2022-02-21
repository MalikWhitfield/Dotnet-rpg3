using AutoMapper;
using Dotnet_rpg3.DTOs.Character;
using Dotnet_rpg3.DTOs.Athlete;
using Dotnet_rpg3.DTOs.Track;
using Dotnet_rpg3.Models;
using Dotnet_rpg3.Models.Track;

namespace Dotnet_rpg3
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, CharacterDTO>().ReverseMap();
            CreateMap<AddCharacterDTO, CharacterDTO>().ReverseMap();

            CreateMap<Athlete, AthleteDTO>().ReverseMap();
            CreateMap<AthleteDTO, AddAthleteDTO>().ReverseMap();

            CreateMap<PracticeResult, PracticeResultDTO>().ReverseMap();
            CreateMap<PracticeResultDTO, AddPracticeResultDTO>().ReverseMap();

            CreateMap<MeetResultDTO, AddMeetResultDTO>().ReverseMap();
            CreateMap<MeetResult, MeetResultDTO>().ReverseMap();
        }
    }
}