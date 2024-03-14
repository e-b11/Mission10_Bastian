namespace BowlerApp.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }

        IEnumerable<Bowler> GetBowlersWithTeams(string[] teamNames);
    }
}
