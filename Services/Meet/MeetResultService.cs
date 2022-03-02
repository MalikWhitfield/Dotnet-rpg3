using System;
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
                    MeetResultId = Guid.NewGuid(),
                    AthleteId = Guid.NewGuid(),
                    HeatType = Models.Enums.HeatType.Prelims
                },
                new MeetResultDTO{
                    MeetResultId = Guid.NewGuid(),
                    AthleteId = Guid.NewGuid(),
                    HeatType = Models.Enums.HeatType.Finals
                }

        };

        public async Task<ServiceResponse<List<MeetResultDTO>>> Create(AddMeetResultDTO newMeetResult)
        {
            var serviceResponse = new ServiceResponse<List<MeetResultDTO>>();
            try
            {
                meets.Add(_mapper.Map<MeetResultDTO>(newMeetResult));
                serviceResponse.Data = meets.Select(c => _mapper.Map<MeetResultDTO>(c)).ToList();

            }
            catch (Exception ex)
            {
                serviceResponse.Data = null;
                serviceResponse.Message = "Error creating meet result";
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<MeetResultDTO>>> Delete(Guid id)
        {
            var serviceResponse = new ServiceResponse<List<MeetResultDTO>>();
            try
            {
                var meetResult = meets.First(m => m.MeetResultId == id);
                meets.Remove(meetResult);
                serviceResponse.Data = meets;

            }
            catch (Exception ex)
            {
                serviceResponse.Data = null;
                serviceResponse.Message = "Error deleting meet result";
            }


            return serviceResponse;
        }

        public async Task<ServiceResponse<List<MeetResultDTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<MeetResultDTO>>();
            serviceResponse.Data = meets.Select(c => _mapper.Map<MeetResultDTO>(c)).ToList();

            return serviceResponse;
        }

        public async Task<ServiceResponse<MeetResultDTO>> GetById(Guid id)
        {
            var serviceResponse = new ServiceResponse<MeetResultDTO>();
            try
            {
                serviceResponse.Data = _mapper.Map<MeetResultDTO>(meets.FirstOrDefault(c => c.MeetResultId == id));
            }

            catch (Exception ex)
            {
                serviceResponse.Data = null;
                serviceResponse.Message = "Meet Result not found";
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<MeetResultDTO>> GetAllByAthleteId(Guid id)
        {
            var serviceResponse = new ServiceResponse<MeetResultDTO>();
            try
            {
                serviceResponse.Data = _mapper.Map<MeetResultDTO>(meets.Find(c => c.AthleteId == id));

            }
            catch (Exception ex)
            {
                serviceResponse.Data = null;
                serviceResponse.Message = $"Meets not found by Athlete Id {id}";
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<MeetResultDTO>> Update(UpdateMeetResultDTO updateMeetResultDTO)
        {
            var serviceResponse = new ServiceResponse<MeetResultDTO>();
            try
            {
                MeetResultDTO meetResult = meets.Find(m => m.MeetResultId == updateMeetResultDTO.MeetResultId);
                serviceResponse.Data = _mapper.Map<MeetResultDTO>(meets);

            }
            catch (Exception ex)
            {
                serviceResponse.Data = null;
                serviceResponse.Message = "Meet Result not found";
            }

            return serviceResponse;

        }
    }
}