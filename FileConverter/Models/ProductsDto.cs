using CsvHelper.Configuration.Attributes;

namespace FileConverter.Models;

public record ProductsDto
{
    [Name("id")] public long Id { get; init; }
    [Name("name")] public string Name { get; init; }
    [Name("shortDescription")] public string ShortDescription { get; init; }
    [Name("description")] public string Description { get; init; }
    [Name("value")] public decimal Value { get; init; }
};