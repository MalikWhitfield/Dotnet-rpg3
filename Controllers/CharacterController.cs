using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnet_rpg3.Models;
using Dotnet_rpg3.Services.CharacterService;
using Dotnet_rpg3.DTOs.Character;
using AutoMapper;

namespace Dotnet_rpg3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        ICharacterService _characterService;
        private readonly IMapper _mapper;
        public CharacterController(ICharacterService characterService, IMapper mapper)
        {
            _characterService = characterService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<CharacterDTO>>> GetAllCharacters()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<CharacterDTO>>> GetById(int id)
        {
            return Ok(await _characterService.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<CharacterDTO>>>> CreateCharacter(AddCharacterDTO newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<CharacterDTO>>> UpdateCharacter(UpdateCharacterDTO updateCharacterDTO)
        {
            var response = await _characterService.Update(updateCharacterDTO);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(await _characterService.Update(updateCharacterDTO));
        }
    }
}