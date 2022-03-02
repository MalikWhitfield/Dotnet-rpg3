using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Track;
using Dotnet_rpg3.Models;

namespace Dotnet_rpg3.Services.Meet
{
    public interface IMeetResultService
    {
        Task<ServiceResponse<List<MeetResultDTO>>> GetAll();
        Task<ServiceResponse<MeetResultDTO>> GetById(Guid id);
        Task<ServiceResponse<List<MeetResultDTO>>> Create(AddMeetResultDTO newMeetResult);
        Task<ServiceResponse<List<MeetResultDTO>>> Delete(Guid id);
        Task<ServiceResponse<MeetResultDTO>> GetAllByAthleteId(Guid id);
    }
}