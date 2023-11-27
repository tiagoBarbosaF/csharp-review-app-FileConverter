using FileConverter.Converters.Csv;
using FileConverter.Converters.Json;
using FileConverter.Models;

namespace FileConverter.Main;

public class Main
{
    public static void Start()
    {
        while (true)
        {
            Menu();

            Console.Write($"\nEnter an option: ");
            var option = Console.ReadLine();

            if (option!.Equals("0"))
                break;

            switch (option)
            {
                case "1":
                    CsvToJsonMenu();
                    break;
                case "2":
                    Console.WriteLine($"\n-- Json to Csv (using files) --");
                    Console.Write($"Enter the path of file: ");
                    var pathJson = Console.ReadLine();

                    Console.Write("Enter the type of delimiter for your csv: ");
                    var delimiterJson = Console.ReadLine();

                    var converterJsonToCsv =
                        ConverterJsonService.ConverterJsonToCsv<ProductsDto>(pathJson!, delimiterJson!);

                    Console.WriteLine($"Json to Csv:\n" +
                                      $"{converterJsonToCsv}");
                    break;
                default:
                    Console.WriteLine("Invalid option...");
                    break;
            }
        }
    }

    private static void CsvToJsonMenu()
    {
        Console.WriteLine($"\n-- Csv to Json --");
        Console.WriteLine($"Enter the csv content (press Enter, Ctrl+Z, Enter to send content)");
        var csvContent = Console.In.ReadToEnd();

        var converterCsvToJsonWithFile =
            ConverterCsvService.ConverterCsvToJsonWithFile<ProductsDto>(csvContent);

        Console.WriteLine($"Csv to Json:\n" +
                          $"{converterCsvToJsonWithFile}");

        Console.WriteLine("Do you like to save the result in a file? (y/n)");
        var saveChoice = Console.ReadLine()!;

        if (saveChoice.ToLower().Equals("y"))
        {
            Console.Write("Enter the name file: ");
            var jsonNameFile = Console.ReadLine()!;
            var saveFileConverterCsvToJson = ConverterCsvService.SaveFileConverterCsvToJson<ProductsDto>(jsonNameFile,
                converterCsvToJsonWithFile);
            Console.WriteLine(saveFileConverterCsvToJson);
        }
    }

    private static void Menu()
    {
        var menuBar = new string('*', 40);

        Console.WriteLine($"\n{menuBar}");
        Console.WriteLine($"== Choice the type of converter ==\n" +
                          $"  1 - Csv to Json (using files)\n" +
                          $"  2 - Json to Csv (using files)\n" +
                          $"  0 - Exit\n" +
                          $"(obs.: always put header if using\n" +
                          $"csv converter.)\n" +
                          $"{menuBar}");
    }
}