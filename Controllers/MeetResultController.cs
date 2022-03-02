using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Track;
using Dotnet_rpg3.Models;
using Dotnet_rpg3.Services.Meet;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_rpg3.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MeetResultController : ControllerBase
    {
        private readonly IMeetResultService _meetResultService;

        public MeetResultController(IMeetResultService meetResultService)
        {
            _meetResultService = meetResultService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<MeetResultDTO>>> GetAllPractices()
        {
            return Ok(await _meetResultService.GetAll());
        }

        [HttpGet("Athlete/{id}")]
        public async Task<ActionResult<ServiceResponse<MeetResultDTO>>> GetByAthleteId(Guid id)
        {
            return Ok(await _meetResultService.GetAllByAthleteId(id));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<MeetResultDTO>>> GetById(Guid id)
        {
            return Ok(await _meetResultService.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<MeetResultDTO>>>> Create(AddMeetResultDTO newPracticeResult)
        {
            return Ok(await _meetResultService.Create(newPracticeResult));
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<MeetResultDTO>>>> Delete(Guid id)
        {
            return Ok(await _meetResultService.Delete(id));
        }

    }
}