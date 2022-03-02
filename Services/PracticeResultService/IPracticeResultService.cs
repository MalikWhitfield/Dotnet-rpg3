using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Track;
using Dotnet_rpg3.Models;

namespace Dotnet_rpg3.Services.PracticeResultService
{
    public interface IPracticeResultService
    {
        Task<ServiceResponse<List<PracticeResultDTO>>> GetAll();
        Task<ServiceResponse<PracticeResultDTO>> GetById(Guid id);
        Task<ServiceResponse<List<PracticeResultDTO>>> Create(AddPracticeResultDTO newAthlete);
        Task<ServiceResponse<List<PracticeResultDTO>>> Delete(Guid id);
        Task<ServiceResponse<PracticeResultDTO>> GetAllByAthleteId(Guid id);
    }
}