using System.Net.Http.Json;
using TarkovApp.Services.Interfaces;

namespace TarkovApp.Services;

public class ConnectorService : IConnectorService
{
    private readonly HttpClient _httpClient;
    private readonly Dictionary<string, string> _request = new();

    public ConnectorService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    private void AddQueryToRequest(string query)
    {
        _request.Add(Constants.Constants.TarkovApiQueryString, query);
    }

    private void RemoveQueriesFromRequest()
    {
        _request.Clear();
    }

    private async Task<string> GetDataFromTarkovApi()
    {
        var response = await _httpClient.PostAsJsonAsync(Constants.Constants.TarkovApiEndpoint, _request);

        RemoveQueriesFromRequest();

        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> GetItemRequestAsync(string query)
    {
        AddQueryToRequest(query);

        return await GetDataFromTarkovApi();
    }
}