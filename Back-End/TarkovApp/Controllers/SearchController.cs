using System.Text.Json;
using TarkovApp.Mappers;
using TarkovApp.Models;
using TarkovApp.Models.Dtos;
using TarkovApp.Services.Interfaces;

namespace TarkovApp.Controllers;

public class SearchController
{
    private readonly IConnectorService _connectorService;

    public SearchController(IConnectorService connectorService)
    {
        _connectorService = connectorService;
    }

    public async Task<Item> GetItemAsync(string searchTerm)
    {
        var returnData = await _connectorService.GetItemRequestAsync("{items(name: \"" + searchTerm + "\") { " + Constants.Constants.BasicItemProperties + " }}");

        return AutoMapper.MapFromJsonToDto(returnData).Data.Items.FirstOrDefault();
    }
}