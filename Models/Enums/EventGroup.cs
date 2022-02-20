using System.Text.Json.Serialization;

namespace Dotnet_rpg3.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum EventGroup
    {
        Sprints,
        Hurdles,
        Throws,
        Multis,
        Distance,
        MidDistance

    }
}