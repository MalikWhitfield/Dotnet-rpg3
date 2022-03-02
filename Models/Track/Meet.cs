using System;
using System.ComponentModel.DataAnnotations;

namespace Dotnet_rpg3.Models.Track
{
    public class Meet
    {
        [Key]
        public Guid MeetId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}