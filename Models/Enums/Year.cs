using System.Text.Json.Serialization;

namespace Dotnet_rpg3.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum Year
    {
        Freshman,
        RedshirtFreshman,
        Sophomore,
        RedshirtSophomore,
        Junior,
        RedshirtJunior,
        Senior,
        RedshirtSenior
    }
}