using Dotnet_rpg3.Models.Enums;
namespace Dotnet_rpg3.Models
{
    public class Athlete
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LAstName { get; set; }
        public Year Year { get; set; }
        public string Bio { get; set; }
        public Event Event { get; set; }
    }
}