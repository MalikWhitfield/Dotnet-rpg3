using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Character;
namespace Dotnet_rpg3.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDTO>> GetById(int id);

        Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);
    }
}