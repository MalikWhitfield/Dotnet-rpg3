using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet_rpg3.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        public List<Character> characters = new List<Character> {
            new Character{
                Id = 1,
                Name = "Leek"
            },
              new Character{
                Id = 2,
                Name = "Ni"
            }
        };


        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);

            serviceResponse.Data = characters;

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;

            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = characters.FirstOrDefault(c => c.Id == id);

            return serviceResponse;
        }

    }
}