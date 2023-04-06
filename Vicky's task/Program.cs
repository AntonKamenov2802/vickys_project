

namespace FootballLegues
{
    class Program
    {
        static void Main(string[] args)
        {
            var leagueParser = new LeagueParser("test_files\\setup.csv");
            var leagues = leagueParser.parse();

            var teamsParser = new TeamParser("test_files\\teams.csv");
            var teams = teamsParser.parse();
            
            var roundParser = new RoundParser("test_files\\round-1.csv");
            var rounds = roundParser.parse();

            if (leagues != null)
            {
                var fistLeague = rounds.ElementAt(0);
                Console.WriteLine(fistLeague.score.Value.Home);
                Console.WriteLine(leagues.ElementAt(0).leagueName);

            }
        }
    }
}
