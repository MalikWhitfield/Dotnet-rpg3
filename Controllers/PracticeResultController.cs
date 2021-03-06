using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Track;
using Dotnet_rpg3.Models;
using Dotnet_rpg3.Services.PracticeResultService;
using System.Collections.Generic;
using System;

namespace Dotnet_rpg3.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PracticeResultController : ControllerBase
    {
        private readonly IPracticeResultService _practiceResultSErvice;

        public PracticeResultController(IPracticeResultService practiceResultService)
        {
            _practiceResultSErvice = practiceResultService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<PracticeResultDTO>>> GetAllPractices()
        {
            return Ok(await _practiceResultSErvice.GetAll());
        }

        [HttpGet("Athlete/{id}")]
        public async Task<ActionResult<ServiceResponse<PracticeResultDTO>>> GetByAthleteId(Guid id)
        {
            return Ok(await _practiceResultSErvice.GetAllByAthleteId(id));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<PracticeResultDTO>>> GetById(Guid id)
        {
            return Ok(await _practiceResultSErvice.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<PracticeResultDTO>>>> Create(AddPracticeResultDTO newPracticeResult)
        {
            return Ok(await _practiceResultSErvice.Create(newPracticeResult));
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<PracticeResultDTO>>>> Delete(Guid id)
        {
            return Ok(await _practiceResultSErvice.Delete(id));
        }

    }
}