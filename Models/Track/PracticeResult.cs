using System;
using Dotnet_rpg3.Models.Enums;
namespace Dotnet_rpg3.Models.Track
{
    public class PracticeResult
    {
        public int PracticeId { get; set; }
        public int AthleteId { get; set; }
        public DateTime Date { get; set; }
        public string Drill { get; set; }
        public string Time { get; set; }
        public int RepNumber { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}