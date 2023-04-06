
class TeamParser :  ParserCSV 
{
    public TeamParser(string file_path) : base(file_path){}
    public override List<Team> parse()
    {
        List<Team> records = new List<Team>();

        if (csvReader != null) {
            records.AddRange(csvReader.GetRecords<Team>());
        }
        return records;
    }
}