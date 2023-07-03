using System.Text.Json.Serialization;

namespace TarkovApp.Models.Dtos;

public class RootDto
{
    [JsonPropertyName("data")]
    public DataDto Data { get; set; }
}