using System.Globalization;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;

namespace FileConverter.Converters.Json;

public class ConverterJsonService
{
    public static string ConverterJsonToCsv<T>(string jsonContent, string delimiter)
    {
        var readAllTextJsonFile = File.ReadAllText(jsonContent);
        var deserializeContent = JsonSerializer.Deserialize<List<T>>(readAllTextJsonFile);

        var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = delimiter
        };

        using var streamWriter = new StringWriter();
        using (var csvWriter = new CsvWriter(streamWriter, csvConfiguration))
        {
            csvWriter.WriteRecords(deserializeContent);
        }

        return streamWriter.ToString();
    }
}