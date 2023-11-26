using System.Globalization;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;

namespace FileConverter.Converters.Csv;

public class ConverterCsvService
{
    public static string ConverterCsvToJsonWithFile<T>(string csvContent, string delimiter)
    {
        var readAllTextCsvFile = File.ReadAllText(csvContent);
        var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = delimiter
        };
        using var stringReader = new StringReader(readAllTextCsvFile);
        using var csvReader = new CsvReader(stringReader, csvConfiguration);

        var records = csvReader.GetRecords<T>().ToList();
        return JsonSerializer.Serialize(records, new JsonSerializerOptions { WriteIndented = true });
    }
}