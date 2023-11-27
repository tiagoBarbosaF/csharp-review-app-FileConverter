using System.Globalization;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;

namespace FileConverter.Converters.Csv;

public class ConverterCsvService
{
    public static string ConverterCsvToJsonWithFile<T>(string csvContent, string delimiter = ";")
    {
        // var readAllTextCsvFile = File.ReadAllText(csvContent);
        var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = delimiter
        };
        using var stringReader = new StringReader(csvContent);
        using var csvReader = new CsvReader(stringReader, csvConfiguration);

        var records = csvReader.GetRecords<T>().ToList();
        return JsonSerializer.Serialize(records, new JsonSerializerOptions { WriteIndented = true });
    }

    public static string SaveFileConverterCsvToJson<T>(string jsonFileName, string jsonContent)
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        File.WriteAllText($"{jsonFileName}.json",jsonContent);
        return $"\nFile {jsonFileName}.json created with success, you encounter in the path \n{currentDirectory}";
    }
}