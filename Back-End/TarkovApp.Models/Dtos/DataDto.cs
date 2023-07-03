using System.Text.Json.Serialization;

namespace TarkovApp.Models.Dtos;

public class DataDto
{
    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
}