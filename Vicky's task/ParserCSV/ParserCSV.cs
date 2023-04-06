
using CsvHelper;
using System.Globalization;

// Used 3rd party lib https://www.nuget.org/packages/CsvHelper/

public abstract class ParserCSV
{
    // Creates the basic parser to read a file
    // Which will be used for future classes
    private StreamReader? streamReader;
    protected CsvReader? csvReader;

    public ParserCSV(string file_path){
        streamReader = new StreamReader(file_path);
        csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
    }

    // Requires to override this method when we derrive from this class
    public abstract object parse();
}