using Dotnet_rpg3.Models.Enums;
namespace Dotnet_rpg3.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "malik";

        public int Strength { get; set; }
        public int HitPoints { get; set; }
        public int Defense { get; set; }
        public int Intelligence { get; set; }
        public RpgClass Class { get; set; } = RpgClass.Coward;

    }
}