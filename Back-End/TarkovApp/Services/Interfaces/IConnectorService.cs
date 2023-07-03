namespace TarkovApp.Services.Interfaces;

public interface IConnectorService
{
    public Task<string> GetItemRequestAsync(string query);
}