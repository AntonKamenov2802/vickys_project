
using CsvHelper.Configuration.Attributes;

public struct Round{
    public string? home { get; set; }
    public string? away { get; set; }
    [TypeConverter(typeof(ScoreConverter))]
    public (int Home, int Away)? score { get; set; }
    public string? comment { get; set; }
}