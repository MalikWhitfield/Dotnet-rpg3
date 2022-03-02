using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dotnet_rpg3.Models.Enums;
using Dotnet_rpg3.Models.Track;

namespace Dotnet_rpg3.Models
{
    public class Athlete
    {
        [Key]
        public Guid AthleteId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Year Year { get; set; }
        public string Bio { get; set; }
        public EventGroup Event { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<PracticeResult> PracticeResults { get; set; }
        public List<MeetResult> MeetResults { get; set; }


    }
}