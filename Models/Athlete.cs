using System;
using Dotnet_rpg3.Models.Enums;
namespace Dotnet_rpg3.Models
{
    public class Athlete
    {
        public int AthleteId { get; set; }
        public string FirstName { get; set; }
        public string LAstName { get; set; }
        public Year Year { get; set; }
        public string Bio { get; set; }
        public EventGroup Event { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}