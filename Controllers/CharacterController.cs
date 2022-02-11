using Microsoft.AspNetCore.Mvc;
using Dotnet_rpg3.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Dotnet_rpg3.Services.CharacterService;
using System.Threading.Tasks;

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
        public async Task<ActionResult<ServiceResponse<Character>>> GetAllCharacters()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetById(int id)
        {
            return Ok(await _characterService.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> CreateCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}