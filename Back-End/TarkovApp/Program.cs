using System.Runtime.InteropServices.ComTypes;
using TarkovApp.Controllers;
using TarkovApp.Models;
using TarkovApp.Services;
using TarkovApp.Models.Constants;

namespace TarkovApp;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WindowWidth = 125;
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(Constants.TarkovAppLogo + "\n");
        Console.WriteLine($"© Rick Huisman / Schwaaaa - {DateTime.Now.Year}");

        Console.ResetColor();

        await Start();
    }

    private static async Task Start()
    {
        var httpClient = new HttpClient();
        var connectorService = new ConnectorService(httpClient);
        var searchController = new SearchController(connectorService);
        var returnedItem = new Item();

        while (true)
        {
            DisplayReadyForInput();

            var input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                returnedItem = await searchController.GetItemAsync(input ?? "");

                try
                {
                    returnedItem.DisplayBasicProperties();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Couldn't find anything with that input.");
                }
            }
            else
            {
                Console.WriteLine("Error: Input cannot be empty.");
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