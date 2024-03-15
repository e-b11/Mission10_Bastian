namespace BowlerApp.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }

        //Set up method to get joined bowler data
        IEnumerable<Bowler> GetBowlersWithTeams(string[] teamNames);
    }
}
