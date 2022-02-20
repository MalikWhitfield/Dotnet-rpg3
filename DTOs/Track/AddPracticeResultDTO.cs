using System;

namespace Dotnet_rpg3.DTOs.Track
{
    public class AddPracticeResultDTO
    {
        public int AthleteId { get; set; }
        public DateTime Date { get; set; }
        public string Drill { get; set; }
        public string Time { get; set; }
        public int? RepNumber { get; set; }
        public string Comment { get; set; }
    }
}