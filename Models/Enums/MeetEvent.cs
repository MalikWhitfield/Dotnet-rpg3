using System.Text.Json.Serialization;

namespace Dotnet_rpg3.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MeetEvent
    {
        OneHundredMeter,
        TwonHundredMeter,
        FourHunderedMeter,
        FourBy1Relay,
        FourBy4Relay,
        Javelin,
        Discuss,
        Hammer,
        Longjump,
        TripleJump,
        HighJump,
        FifteenHundred,
        FiveK,
        TenK


    }
}