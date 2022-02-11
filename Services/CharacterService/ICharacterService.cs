using System.Collections.Generic;
using Dotnet_rpg3.Models;

namespace Dotnet_rpg3.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetById(int id);

        List<Character> AddCharacter(Character newCharacter);
    }
}