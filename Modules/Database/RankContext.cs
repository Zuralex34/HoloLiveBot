using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HoloLiveBot.Modules.Database
{
    public class RankContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Server> Servers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=RankDatabase.db");
        }
    }
}
