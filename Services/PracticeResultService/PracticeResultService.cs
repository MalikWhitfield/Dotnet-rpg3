using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dotnet_rpg3.DTOs.Track;
using Dotnet_rpg3.Models;

namespace Dotnet_rpg3.Services.PracticeResultService
{
    public class PracticeResultService : IPracticeResultService
    {
        private readonly IMapper _mapper;

        public PracticeResultService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<PracticeResultDTO> practices = new List<PracticeResultDTO> {
                new PracticeResultDTO{
                    PracticeId = Guid.NewGuid(),
                    AthleteId = Guid.NewGuid(),
                    RepNumber = 1
                },
                new PracticeResultDTO{
                    PracticeId = Guid.NewGuid(),
                    AthleteId = Guid.NewGuid(),
                    RepNumber = 2
                }

        };
        public async Task<ServiceResponse<List<PracticeResultDTO>>> Create(AddPracticeResultDTO newPractice)
        {
            var serviceResponse = new ServiceResponse<List<PracticeResultDTO>>();
            practices.Add(_mapper.Map<PracticeResultDTO>(newPractice));
            serviceResponse.Data = practices.Select(c => _mapper.Map<PracticeResultDTO>(c)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<PracticeResultDTO>>> Delete(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<PracticeResultDTO>>();
            var toDelete = practices.FindIndex(p => p.PracticeId == id);

            practices.RemoveAt(toDelete);

            serviceResponse.Data = practices;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<PracticeResultDTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<PracticeResultDTO>>();
            serviceResponse.Data = practices.Select(c => _mapper.Map<PracticeResultDTO>(c)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<PracticeResultDTO>> GetById(Guid id)
        {
            var serviceResponse = new ServiceResponse<PracticeResultDTO>();
            serviceResponse.Data = _mapper.Map<PracticeResultDTO>(practices.FirstOrDefault(c => c.PracticeId == id));

            return serviceResponse;
        }

        public async Task<ServiceResponse<PracticeResultDTO>> GetAllByAthleteId(Guid id)
        {
            var serviceResponse = new ServiceResponse<PracticeResultDTO>();
            serviceResponse.Data = _mapper.Map<PracticeResultDTO>(practices.Find(c => c.AthleteId == id));

            return serviceResponse;
        }
    }
}