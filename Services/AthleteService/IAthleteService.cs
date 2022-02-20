using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Athlete;

namespace Dotnet_rpg3.Services.AthleteService
{
    public interface IAthleteService
    {
        Task<ServiceResponse<List<AthleteDTO>>> GetAll();
        Task<ServiceResponse<AthleteDTO>> GetById(int id);
        Task<ServiceResponse<List<AthleteDTO>>> Create(AddAthleteDTO newAthlete);
        Task<ServiceResponse<List<AthleteDTO>>> Delete(int id);
    }
}
