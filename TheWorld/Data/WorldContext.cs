using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TheWorld.Models;

namespace TheWorld.Data
{
    public class WorldContext : DbContext
    {
        private IConfiguration _configuration { get; }

        public WorldContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Stop> Stops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration[""]);
        }
    }
}
