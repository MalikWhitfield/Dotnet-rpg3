using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Threading.Tasks;
using System.Linq;
using Dotnet_rpg3.DTOs.Athlete;

namespace Dotnet_rpg3.Services.AthleteService
{
    public class AthleteService : IAthleteService
    {
        public List<GetAthleteDTO> Athletes = new List<GetAthleteDTO> {
            new GetAthleteDTO{
                Id = 1,
                FirstName = "Leek"
            },
              new GetAthleteDTO{
                Id = 2,
                FirstName = "Ni"
            }
        };

        public async Task<ServiceResponse<List<GetAthleteDTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<GetAthleteDTO>>();
            serviceResponse.Data = Athletes;

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetAthleteDTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<GetAthleteDTO>();
            serviceResponse.Data = Athletes.FirstOrDefault(c => c.Id == id);

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetAthleteDTO>>> Create(AddAthleteDTO newAthlete)
        {
            var serviceResponse = new ServiceResponse<List<GetAthleteDTO>>();
            // Athletes.Add(newAthlete);

            serviceResponse.Data = Athletes;

            return serviceResponse;
        }


        public async Task<ServiceResponse<List<GetAthleteDTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetAthleteDTO>>();
            serviceResponse.Data = Athletes;

            return serviceResponse;
        }
    }
}