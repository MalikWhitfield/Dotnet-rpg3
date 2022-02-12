using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Athlete;

namespace Dotnet_rpg3.Services.AthleteService
{
    public interface IAthleteService
    {
        Task<ServiceResponse<List<GetAthleteDTO>>> GetAll();
        Task<ServiceResponse<GetAthleteDTO>> GetById(int id);
        Task<ServiceResponse<List<GetAthleteDTO>>> Create(AddAthleteDTO newAthlete);
        Task<ServiceResponse<List<GetAthleteDTO>>> Delete(int id);
    }
}
