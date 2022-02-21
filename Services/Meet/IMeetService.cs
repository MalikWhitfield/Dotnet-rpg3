using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnet_rpg3.DTOs.Track;
using Dotnet_rpg3.Models;

namespace Dotnet_rpg3.Services.Meet
{
    public interface IMeetService
    {
        Task<ServiceResponse<List<MeetResultDTO>>> GetAll();
        Task<ServiceResponse<MeetResultDTO>> GetById(int id);
        Task<ServiceResponse<List<MeetResultDTO>>> Create(AddMeetResultDTO newMeetResult);
        Task<ServiceResponse<List<MeetResultDTO>>> Delete(int id);
        Task<ServiceResponse<MeetResultDTO>> GetAllByAthleteId(int id);
    }
}