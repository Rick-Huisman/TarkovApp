using System.Text.Json.Serialization;

namespace TarkovApp.Models;

public class Vendor
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("normalizedName")]
    public string? NormalizedName { get; set; }
}