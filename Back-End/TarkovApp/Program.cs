using TarkovApp.Controllers;
using TarkovApp.Services;
using TarkovApp.Services.Interfaces;

namespace TarkovApp;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.SetWindowSize(125, 25);
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(Constants.Constants.TarkovAppLogo + "\n");
        Console.WriteLine($"© Rick Huisman / Schwaaaa - {DateTime.Now.Year}");

        Console.ResetColor();

        await Start();
    }

    private static async Task Start()
    {
        var httpClient = new HttpClient();
        var connectorService = new ConnectorService(httpClient);
        var searchController = new SearchController(connectorService);
        var stopApp = false;

        while (!stopApp)
        {
            DisplayReadyForInput();

            var input = Console.ReadLine();

            if (input == "0")
            {
                stopApp = true;
            }

            var returnedItem = await searchController.GetItemAsync(input);

            try
            {
                returnedItem.DisplayBasicProperties();
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Couldn't find anything with that input.");
            }
        }

    }

    private static void DisplayReadyForInput()
    {
        Console.WriteLine("\nSearch for an item, using the Tarkov Api");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("[~] ");
        Console.ResetColor();
    }
}