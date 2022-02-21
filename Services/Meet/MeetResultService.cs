using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dotnet_rpg3.DTOs.Track;
using Dotnet_rpg3.Models;

namespace Dotnet_rpg3.Services.Meet
{
    public class MeetResultService : IMeetResultService
    {
        private readonly IMapper _mapper;

        public MeetResultService(IMapper mapper)
        {
            _mapper = mapper;
        }


        public List<MeetResultDTO> meets = new List<MeetResultDTO> {
                new MeetResultDTO{
                    MeetResultId = 1,
                    AthleteId = 11,
                    HeatType = Models.Enums.HeatType.Prelims
                },
                new MeetResultDTO{
                    MeetResultId = 2,
                    AthleteId = 22,
                    HeatType = Models.Enums.HeatType.Finals
                }

        };

        public async Task<ServiceResponse<List<MeetResultDTO>>> Create(AddMeetResultDTO newMeetResult)
        {
            var serviceResponse = new ServiceResponse<List<MeetResultDTO>>();
            meets.Add(_mapper.Map<MeetResultDTO>(newMeetResult));
            serviceResponse.Data = meets.Select(c => _mapper.Map<MeetResultDTO>(c)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<MeetResultDTO>>> Delete(int id)
        {
            var serviceResponse = new ServiceResponse<List<MeetResultDTO>>();
            var toDelete = meets.FindIndex(p => p.MeetResultId == id);

            meets.RemoveAt(toDelete);

            serviceResponse.Data = meets;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<MeetResultDTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<MeetResultDTO>>();
            serviceResponse.Data = meets.Select(c => _mapper.Map<MeetResultDTO>(c)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<MeetResultDTO>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<MeetResultDTO>();
            serviceResponse.Data = _mapper.Map<MeetResultDTO>(meets.FirstOrDefault(c => c.MeetResultId == id));

            return serviceResponse;
        }

        public async Task<ServiceResponse<MeetResultDTO>> GetAllByAthleteId(int id)
        {
            var serviceResponse = new ServiceResponse<MeetResultDTO>();
            serviceResponse.Data = _mapper.Map<MeetResultDTO>(meets.Find(c => c.AthleteId == id));

            return serviceResponse;
        }
    }
}