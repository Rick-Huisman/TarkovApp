using System.Text.Json;
using TarkovApp.Models.Dtos;

namespace TarkovApp.Mappers;

public class AutoMapper
{
    public static RootDto MapFromJsonToDto(string jsonData)
    {
        return JsonSerializer.Deserialize<RootDto>(jsonData);
    }
}