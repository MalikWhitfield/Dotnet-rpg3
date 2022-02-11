using Microsoft.AspNetCore.Mvc;
using Dotnet_rpg3.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Dotnet_rpg3.Services.CharacterService;

namespace Dotnet_rpg3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character()
            {
                Id = 1,
                Name = "Ni"
            }
        };

        [HttpGet("GetAll")]
        public ActionResult<Character> GetAllCharacters()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetById(int id)
        {
            return Ok(_characterService.GetById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> CreateCharacter(Character newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}