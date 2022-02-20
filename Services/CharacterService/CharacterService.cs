using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Linq;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Character;
using AutoMapper;
namespace Dotnet_rpg3.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        public List<GetCharacterDTO> characters = new List<GetCharacterDTO> {
            new GetCharacterDTO{
                CharacterId = 1,
                Name = "Leek"
            },
              new GetCharacterDTO{
                CharacterId = 2,
                Name = "Ni"
            }
        };

        private readonly IMapper _mapper;

        public CharacterService(IMapper mappper)
        {
            _mapper = mappper;
        }


        public async Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
            characters.Add(_mapper.Map<GetCharacterDTO>(newCharacter));
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterDTO>();
            serviceResponse.Data = _mapper.Map<GetCharacterDTO>(characters.FirstOrDefault(c => c.CharacterId == id));

            return serviceResponse;
        }

    }
}