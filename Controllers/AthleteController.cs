using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet_rpg3.Services.AthleteService;
using Dotnet_rpg3.DTOs.Athlete;
using Dotnet_rpg3.Models;

namespace Dotnet_rpg3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AthleteController : ControllerBase
    {
        IAthleteService _athleteService;
        public AthleteController(IAthleteService athleteService)
        {
            _athleteService = athleteService;

        }

        private static List<AthleteDTO> Athletes = new List<AthleteDTO>{
            new AthleteDTO(),
            new AthleteDTO()
            {
                Id = 1,
                FirstName = "Ni"
            }
        };

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<AthleteDTO>>> GetAllAthletes()
        {
            return Ok(await _athleteService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<AthleteDTO>>> GetById(int id)
        {
            return Ok(await _athleteService.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<AthleteDTO>>>> CreateAthlete(AddAthleteDTO newAthlete)
        {
            return Ok(await _athleteService.Create(newAthlete));
        }

    }
}