using System.Text.Json.Serialization;

namespace Dotnet_rpg3.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Dragon,
        Beast,
        Coward
    }
}