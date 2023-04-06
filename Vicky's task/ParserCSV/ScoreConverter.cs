

using CsvHelper;
using CsvHelper.Configuration;

public class ScoreConverter: CsvHelper.TypeConversion.DefaultTypeConverter {

    public override object? ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
    {
        (int Home, int Away) score = (0, 0);
        if (text != null){
            var data = text.Split("-");
            // Try/Catch exceptions here! 
            score.Home = Int32.Parse(data[0]);
            score.Away = Int32.Parse(data[1]);
            return score;
        }
        return score;

    }
}