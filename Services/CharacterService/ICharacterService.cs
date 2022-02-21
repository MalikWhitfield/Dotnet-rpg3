using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Character;
namespace Dotnet_rpg3.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<CharacterDTO>>> GetAllCharacters();
        Task<ServiceResponse<CharacterDTO>> GetById(int id);

        Task<ServiceResponse<List<CharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);
        Task<ServiceResponse<CharacterDTO>> Update(UpdateCharacterDTO updateCharacterDTO);
    }
}