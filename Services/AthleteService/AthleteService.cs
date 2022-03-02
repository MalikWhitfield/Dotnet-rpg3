using System.Collections.Generic;
using Dotnet_rpg3.Models;
using System.Threading.Tasks;
using System.Linq;
using Dotnet_rpg3.DTOs.Athlete;
using System;

namespace Dotnet_rpg3.Services.AthleteService
{
    public class AthleteService : IAthleteService
    {
        public List<AthleteDTO> Athletes = new List<AthleteDTO> {
            new AthleteDTO{
                Id = Guid.NewGuid(),
                FirstName = "Leek"
            },
              new AthleteDTO{
                Id = Guid.NewGuid(),
                FirstName = "Ni"
            }
        };

        public async Task<ServiceResponse<List<AthleteDTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<AthleteDTO>>();
            serviceResponse.Data = Athletes;

            return serviceResponse;
        }

        public async Task<ServiceResponse<AthleteDTO>> GetById(Guid id)
        {
            var serviceResponse = new ServiceResponse<AthleteDTO>();
            serviceResponse.Data = Athletes.FirstOrDefault(c => c.Id == id);

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<AthleteDTO>>> Create(AddAthleteDTO newAthlete)
        {
            var serviceResponse = new ServiceResponse<List<AthleteDTO>>();
            // Athletes.Add(newAthlete);

            serviceResponse.Data = Athletes;

            return serviceResponse;
        }


        public async Task<ServiceResponse<List<AthleteDTO>>> Delete(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<AthleteDTO>>();
            serviceResponse.Data = Athletes;

            return serviceResponse;
        }
    }
}