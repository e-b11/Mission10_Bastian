using Microsoft.EntityFrameworkCore;

namespace BowlerApp.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options)
        {

        }
        //Set up two tables
        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
