using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Threading.Tasks;
namespace Dotnet_rpg3.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetById(int id);

        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}