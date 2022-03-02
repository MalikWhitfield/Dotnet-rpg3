using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Linq;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Character;
using AutoMapper;
using System;

namespace Dotnet_rpg3.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        public List<Character> characters = new List<Character> {
            new Character{
                CharacterId = 1,
                Name = "Leek"
            },
              new Character{
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
            characters.Add(_mapper.Map<Character>(newCharacter));
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
            try
            {
                serviceResponse.Data = _mapper.Map<CharacterDTO>(characters.FirstOrDefault(c => c.CharacterId == id));

            }
            catch (Exception ex)
            {
                serviceResponse.Message = "Character not found.";

            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<CharacterDTO>> Update(UpdateCharacterDTO updateCharacterDTO)
        {
            var serviceResponse = new ServiceResponse<CharacterDTO>();
            try
            {

                Character character = characters.FirstOrDefault(c => c.CharacterId == updateCharacterDTO.CharacterId);

                character.Class = updateCharacterDTO.Class;
                character.Defense = updateCharacterDTO.Defense;
                character.Intelligence = updateCharacterDTO.Intelligence;
                character.Name = updateCharacterDTO.Name;
                character.HitPoints = updateCharacterDTO.HitPoints;
                character.Strength = updateCharacterDTO.Strength;

                serviceResponse.Data = _mapper.Map<CharacterDTO>(character);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Character not found.";
            }
            return serviceResponse;

        }


    }
}