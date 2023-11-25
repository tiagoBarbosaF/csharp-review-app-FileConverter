using System.Globalization;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;

namespace FileConverter.Converters.Csv;

public class ConverterCsvService
{
    public static string ConverterCsvToJson<T>(string csvContent)
    {
        var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using var stringReader = new StringReader(csvContent);
        using var csvReader = new CsvReader(stringReader, csvConfiguration);

        var records = csvReader.GetRecords<T>().ToList();
        return JsonSerializer.Serialize(records, new JsonSerializerOptions { WriteIndented = true });
    }
}