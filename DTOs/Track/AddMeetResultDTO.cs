using System;
using Dotnet_rpg3.Models.Enums;

namespace Dotnet_rpg3.DTOs.Track
{
    public class AddMeetResultDTO
    {
        public Guid AthleteId { get; set; }
        public DateTime Date { get; set; }
        public MeetEvent Event { get; set; }
        public string Time { get; set; }
        public int? HeatType { get; set; }
        public int? AttemptNumber { get; set; }
        public string Comment { get; set; }
    }
}