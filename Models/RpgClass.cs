using System.Text.Json.Serialization;

namespace DotNet6_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        // Basic Characters
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
}