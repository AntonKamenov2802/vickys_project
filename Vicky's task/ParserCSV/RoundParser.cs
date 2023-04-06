
class RoundParser: ParserCSV{
    public RoundParser(string file_path) : base(file_path){}

    public override List<Round> parse()
    {
        List<Round> records = new List<Round>();
        if (csvReader != null){
            records.AddRange(csvReader.GetRecords<Round>());
        }
        return records;
    }

}