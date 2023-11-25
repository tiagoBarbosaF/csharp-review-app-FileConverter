using System.Text.Json;
using FileConverter.Converters.Csv;
using FileConverter.Converters.Json;
using FileConverter.Models;

var textCsv = """
           id;name;shortDescription;description;value
           1;Laptop;Powerful laptop;High-performance laptop with SSD;1200.00
           2;Smartphone;Latest smartphone;Feature-rich smartphone with dual cameras;699.99
           3;Headphones;Wireless headphones;Over-ear headphones with noise cancellation;199.95
           4;Camera;Digital camera;Professional DSLR camera with 4K video;1499.50
           5;Tablet;Portable tablet;Slim and lightweight tablet with a high-res display;449.00
           6;Fitness Tracker;Activity tracker;Water-resistant fitness tracker with heart rate monitor;79.99
           7;Smart Watch;Smartwatch;Smartwatch with GPS and fitness tracking;249.50
           8;Bluetooth Speaker;Portable speaker;Compact Bluetooth speaker with long battery life;49.99
           9;Gaming Console;Game console;Latest gaming console with 4K graphics;399.00
           10;Wireless Mouse;Computer accessory;Ergonomic wireless mouse for improved productivity;29.95
           """;

var textJson = """
                [
                 {
                   "Id": 1,
                   "Name": "Laptop",
                   "ShortDescription": "Powerful laptop",
                   "Description": "High-performance laptop with SSD",
                   "Value": 1200.00
                 },
                 {
                   "Id": 2,
                   "Name": "Smartphone",
                   "ShortDescription": "Latest smartphone",
                   "Description": "Feature-rich smartphone with dual cameras",
                   "Value": 699.99
                 },
                 {
                   "Id": 3,
                   "Name": "Headphones",
                   "ShortDescription": "Wireless headphones",
                   "Description": "Over-ear headphones with noise cancellation",
                   "Value": 199.95
                 },
                 {
                   "Id": 4,
                   "Name": "Camera",
                   "ShortDescription": "Digital camera",
                   "Description": "Professional DSLR camera with 4K video",
                   "Value": 1499.50
                 },
                 {
                   "Id": 5,
                   "Name": "Tablet",
                   "ShortDescription": "Portable tablet",
                   "Description": "Slim and lightweight tablet with a high-res display",
                   "Value": 449.00
                 },
                 {
                   "Id": 6,
                   "Name": "Fitness Tracker",
                   "ShortDescription": "Activity tracker",
                   "Description": "Water-resistant fitness tracker with heart rate monitor",
                   "Value": 79.99
                 },
                 {
                   "Id": 7,
                   "Name": "Smart Watch",
                   "ShortDescription": "Smartwatch",
                   "Description": "Smartwatch with GPS and fitness tracking",
                   "Value": 249.50
                 },
                 {
                   "Id": 8,
                   "Name": "Bluetooth Speaker",
                   "ShortDescription": "Portable speaker",
                   "Description": "Compact Bluetooth speaker with long battery life",
                   "Value": 49.99
                 },
                 {
                   "Id": 9,
                   "Name": "Gaming Console",
                   "ShortDescription": "Game console",
                   "Description": "Latest gaming console with 4K graphics",
                   "Value": 399.00
                 },
                 {
                   "Id": 10,
                   "Name": "Wireless Mouse",
                   "ShortDescription": "Computer accessory",
                   "Description": "Ergonomic wireless mouse for improved productivity",
                   "Value": 29.95
                 }
               ]
               """;
// var fileName = "test-csv.csv";

// File.WriteAllText("test-csv.csv", textCsv);
// Console.WriteLine($"File {fileName} created.");

// var allLines = File.ReadAllLines(fileName);

// allLines.Skip(1).Select(lines => lines.Split(";")).ToList().ForEach(line =>
// {
//     var productsDto = new ProductsDto(Convert.ToInt64(line[0]),line[1],line[2],line[3],Convert.ToDecimal(line[4]));
//     Console.WriteLine(productsDto);
// });

// var readAllText = File.ReadAllText(fileName);
// var converterCsvToJson = ConverterCsvService.ConverterCsvToJson<ProductsDto>(readAllText);
// Console.WriteLine($"{converterCsvToJson}");

var readAllLines = File.ReadAllText("test-json.json");

// using var jsonDocument = JsonDocument.Parse(readAllLines);
// var root = jsonDocument.RootElement;
//
// foreach (var jsonElement in root.EnumerateArray())
// {
//   var id = jsonElement.GetProperty("Id").GetInt32();
//   var name = jsonElement.GetProperty("Name");
//   Console.WriteLine($"{id} - {name}");
// }

// var readAllText = File.ReadAllText("jsonToCsv-test.csv");
// Console.WriteLine(readAllText);
var converterJsonToCsv = ConverterJsonService.ConverterJsonToCsv<ProductsDto>(readAllLines);
Console.WriteLine($"{converterJsonToCsv}");