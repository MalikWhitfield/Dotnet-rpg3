using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Athlete;
using System;

namespace Dotnet_rpg3.Services.AthleteService
{
    public interface IAthleteService
    {
        Task<ServiceResponse<List<AthleteDTO>>> GetAll();
        Task<ServiceResponse<AthleteDTO>> GetById(Guid id);
        Task<ServiceResponse<List<AthleteDTO>>> Create(AddAthleteDTO newAthlete);
        Task<ServiceResponse<List<AthleteDTO>>> Delete(Guid id);
        Task<ServiceResponse<AthleteDTO>> Update(UpdateAthleteDTO updateAthlete);

    }
}
