
class LeagueParser :  ParserCSV 
{
    public LeagueParser(string file_path) : base(file_path){}

    // Here we make our own Parser to parse the setup.csv file
    public override List<League> parse() {
        List<League> records = new List<League>();

        if (csvReader != null){
            records.AddRange(csvReader.GetRecords<League>());
        }
        return records;
    }   
}