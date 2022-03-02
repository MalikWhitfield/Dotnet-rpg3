using System;
using Dotnet_rpg3.Models.Enums;

namespace Dotnet_rpg3.Models.Track
{
    public class MeetResult
    {
        public Guid MeetResultId { get; set; }
        public Guid AthleteId { get; set; }
        public DateTime Date { get; set; }
        public MeetEvent Event { get; set; }
        public string Time { get; set; }
        public HeatType? HeatType { get; set; }
        public int? AttemptNumber { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}