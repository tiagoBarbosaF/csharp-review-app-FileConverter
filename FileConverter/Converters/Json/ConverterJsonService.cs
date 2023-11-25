using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using CsvHelper;
using CsvHelper.Configuration;

namespace FileConverter.Converters.Json;

public class ConverterJsonService
{
    public static string ConverterJsonToCsv<T>(string jsonContent)
    {
        var deserializeContent = JsonSerializer.Deserialize<List<T>>(jsonContent);
        var fileName = "C:\\dev\\csharp-projects\\FileConverter\\FileConverter\\bin\\Debug\\net8.0\\jsonToCsv-test.csv";

        var csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using (var streamWriter = new StreamWriter(fileName))
        {
            using (var csvWriter = new CsvWriter(streamWriter, csvConfiguration))
            {
                csvWriter.WriteRecords(deserializeContent);
            }
        }

        return ReaderJsonToCsv(fileName);
    }

    public static string ReaderJsonToCsv(string csvContent)
    {
        var readAllText = File.ReadAllText(csvContent);
        return readAllText;
    }
}