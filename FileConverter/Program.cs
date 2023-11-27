using FileConverter.Converters.Csv;
using FileConverter.Main;
using FileConverter.Models;

Main.Start();

// var csvText = @"id;name;shortDescription;description;value
// 1;Laptop;Powerful laptop;High-performance laptop with SSD;1200.00
// 2;Smartphone;Latest smartphone;Feature-rich smartphone with dual cameras;699.99
// 3;Headphones;Wireless headphones;Over-ear headphones with noise cancellation;199.95";

// File.WriteAllText("csv-test.csv",csvText);
// Console.WriteLine("File created");
// var converterCsvToJsonWithFile = ConverterCsvService.ConverterCsvToJsonWithFile<ProductsDto>("csv-test.csv");
// Console.WriteLine(converterCsvToJsonWithFile);

// Console.WriteLine("Digite o bloco: press Ctrl+Z e enter para continuar");
// var readToEnd = Console.In.ReadToEnd();
// Console.WriteLine($"Texto inserido:\n{readToEnd}");

// var converterCsvToJsonWithFile = ConverterCsvService.ConverterCsvToJsonWithFile<ProductsDto>(readToEnd);
// Console.WriteLine(converterCsvToJsonWithFile);


// var currentDirectory = Directory.GetCurrentDirectory();
// Console.WriteLine(currentDirectory);