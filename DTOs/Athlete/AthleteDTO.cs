using System;
using Dotnet_rpg3.Models.Enums;
namespace Dotnet_rpg3.DTOs.Athlete
{
    public class AthleteDTO
    {
        public Guid AthleteId { get; set; }
        public string FirstName { get; set; }
        public string LAstName { get; set; }
        public Year Year { get; set; }
        public string Bio { get; set; }
        public EventGroup Event { get; set; }
    }
}