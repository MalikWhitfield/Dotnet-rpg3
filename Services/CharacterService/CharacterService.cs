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
        public List<CharacterDTO> characters = new List<CharacterDTO> {
            new CharacterDTO{
                CharacterId = 1,
                Name = "Leek"
            },
              new CharacterDTO{
                CharacterId = 2,
                Name = "Ni"
            }
        };

        private readonly IMapper _mapper;

        public CharacterService(IMapper mappper)
        {
            _mapper = mappper;
        }


        public async Task<ServiceResponse<List<CharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<CharacterDTO>>();
            characters.Add(_mapper.Map<CharacterDTO>(newCharacter));
            serviceResponse.Data = characters.Select(c => _mapper.Map<CharacterDTO>(c)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<CharacterDTO>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<CharacterDTO>>();
            serviceResponse.Data = characters.Select(c => _mapper.Map<CharacterDTO>(c)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<CharacterDTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<CharacterDTO>();
            serviceResponse.Data = _mapper.Map<CharacterDTO>(characters.FirstOrDefault(c => c.CharacterId == id));

            return serviceResponse;
        }

    }
}