using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Linq;

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


        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }

        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

    }
}